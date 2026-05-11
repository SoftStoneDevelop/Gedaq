using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using TestsGenerator.Constants;
using TestsGenerator.Enums;
using TestsGenerator.TypeInfos;

namespace TestsGenerator.Generators
{
    internal class ModelGenerator
    {
        private readonly StringBuilderArray.StringBuilderArray _stringBuilder = new();

        public const string AssertMethodName = "AssertModel";

        public async Task Generate(
            List<Model.ModelType> models,
            string destinationFolder,
            Database database)
        {
            var directory = Directory.CreateDirectory($"{destinationFolder}/Model/");
            foreach (var file in directory.GetFiles())
            {
                File.Delete(file.FullName);
            }

            foreach (var model in models)
            {
                switch (database)
                {
                    case Database.PostgreSQL:
                    {
                        await Model(model, destinationFolder, isFlat: false, withDbTypes: false, checkNullValue: true);
                        await Model(model, destinationFolder, isFlat: true, withDbTypes: false, checkNullValue: true);
                        await ModelInner(model.ModelInner, destinationFolder, withDbTypes: false, checkNullValue: true);
                        await ModelInner(model.ModelInner, destinationFolder, withDbTypes: true, checkNullValue: true);

                        break;
                    }

                    case Database.MySQL:
                    case Database.MsSQL:
                    default:
                    {
                        await Model(model, destinationFolder, isFlat: false, withDbTypes: false, checkNullValue: true);
                        await Model(model, destinationFolder, isFlat: true, withDbTypes: false, checkNullValue: true);
                        await ModelInner(model.ModelInner, destinationFolder, withDbTypes: false, checkNullValue: true);

                        break;
                    }

                    case Database.Clickhouse:
                    {
                        await Model(model, destinationFolder, isFlat: false, withDbTypes: false, checkNullValue: false);
                        await ModelInner(model.ModelInner, destinationFolder, withDbTypes: false, checkNullValue: false);
                        break;
                    }
                }
            }
        }

        private static string DbTypeAttribute(TypeInfo typeInfo, bool withDbTypes)
        {
            if (!withDbTypes)
            {
                return string.Empty;
            }

            return $"[Gedaq.Npgsql.Attributes.DbType({typeInfo.SpecialDbTypeStr()})]";
        }

        private static string AliasAttribute(
            bool useAlias,
            int? position = null,
            string? alias = null)
        {
            if (!useAlias)
            {
                return string.Empty;
            }

            var builder = new DefaultInterpolatedStringHandler();
            builder.AppendLiteral("[Gedaq.Common.Attributes.Alias(");
            var added = false;
            if (alias != null)
            {
                builder.AppendLiteral($"alias: {alias}");
                added = true;
            }

            if (position.HasValue)
            {
                if (added)
                {
                    builder.AppendLiteral(", ");
                }

                builder.AppendLiteral($"order: {position.Value}");
            }

            builder.AppendLiteral(")]");

            return builder.ToStringAndClear();
        }

        private async Task Model(
            Model.ModelType model,
            string destinationFolder,
            bool isFlat,
            bool withDbTypes,
            bool checkNullValue)
        {
            _stringBuilder.Clear();
            _stringBuilder.Append($@"
using NUnit.Framework;
using System.Linq;

namespace Tests
{{
    public class {model.ClassName(isFlat, withDbTypes)}
    {{
        {DbTypeAttribute(model.IdTypeInfo, withDbTypes)}
        public {model.IdType} {model.IdName} {{ get; set; }}

        {DbTypeAttribute(model.TypeInfo, withDbTypes)}
        public {model.ValueType} {model.ValueName} {{ get; set; }}

{(isFlat ? string.Empty : $"        public {model.ModelInnerType} {model.ModelInnerName} {{ get; set; }}")}

        {DbTypeAttribute(model.TypeInfo, withDbTypes)}
        public {model.NullableValueType} {model.NullableValueName} {{ get; set; }}

        public static void {AssertMethodName}({model.ClassName(isFlat, withDbTypes)} actual, {model.ClassName(false)} expect, bool checkInInnerOnlyId)
        {{");

            if (model.TypeInfo.EnumerableType == Enums.EnumerableType.SingleType)
            {
                AssertSingle("actual", "expect", model, isFlat: isFlat, checkNullValue: checkNullValue);
            }
            else
            {
                AssertEnumerable("actual", "expect", model, isFlat: isFlat, checkNullValue: checkNullValue);
            }

            _stringBuilder.Append($@"
        }}
    }}
}}

");
            await File.WriteAllTextAsync($"{destinationFolder}/Model/{model.ClassName(isFlat, withDbTypes)}.cs", _stringBuilder.ToString());
            _stringBuilder.Clear();
        }

        private void AssertSingle(
            string modelVariable,
            string expectVariable,
            Model.ModelType model,
            bool isFlat,
            bool checkNullValue)
        {
            _stringBuilder.Append($@"
                Assert.That({modelVariable}, Is.Not.Null);
                Assert.That({modelVariable}.{model.IdName}, Is.EqualTo({expectVariable}.{model.IdName}));
                Assert.That({modelVariable}.{model.ValueName}, Is.EqualTo({expectVariable}.{model.ValueName}));");

            if (checkNullValue)
            {
                _stringBuilder.Append($@"
                if({expectVariable}.{model.NullableValueName} == {ValueConstants.NullValue})
                {{
                    Assert.That({modelVariable}.{model.NullableValueName}, Is.Null);
                }}
                else
                {{
                    Assert.That({modelVariable}.{model.NullableValueName}, Is.Not.Null);
                    Assert.That({modelVariable}.{model.NullableValueName}, Is.EqualTo({expectVariable}.{model.NullableValueName}));
                }}");
            }

            if (!isFlat)
            {
                _stringBuilder.Append($@"
                if({expectVariable}.{model.ModelInnerName} == {ValueConstants.NullValue})
                {{
                    Assert.That({modelVariable}.{model.ModelInnerName}, Is.Null);
                }}
                else
                {{
                    Assert.That({modelVariable}.{model.ModelInnerName}, Is.Not.Null);
                    Assert.That({modelVariable}.{model.ModelInnerName}.{model.ModelInner.IdName}, Is.EqualTo({expectVariable}.{model.ModelInnerName}.{model.ModelInner.IdName}));
                    if (checkInInnerOnlyId)
                    {{
                        Assert.That({modelVariable}.{model.ModelInnerName}.{model.ModelInner.ValueName}, Is.EqualTo(({model.ModelInner.ValueType})default));
");
                if (checkNullValue)
                {
                    _stringBuilder.Append($@"
                        Assert.That({modelVariable}.{model.ModelInnerName}.{model.ModelInner.NullableValueName}, Is.Null);");
                }
                _stringBuilder.Append($@"
                    }}
                    else
                    {{
                        Assert.That({modelVariable}.{model.ModelInnerName}.{model.ModelInner.ValueName}, Is.EqualTo({expectVariable}.{model.ModelInnerName}.{model.ModelInner.ValueName}));");

                if (checkNullValue)
                {
                    _stringBuilder.Append($@"
                        if({expectVariable}.{model.ModelInnerName}.{model.ModelInner.NullableValueName} == {ValueConstants.NullValue})
                        {{
                            Assert.That({modelVariable}.{model.ModelInnerName}.{model.ModelInner.NullableValueName}, Is.Null);
                        }}
                        else
                        {{
                            Assert.That({modelVariable}.{model.ModelInnerName}.{model.ModelInner.NullableValueName}, Is.Not.Null);
                            Assert.That({modelVariable}.{model.ModelInnerName}.{model.ModelInner.NullableValueName}, Is.EqualTo({expectVariable}.{model.ModelInnerName}.{model.ModelInner.NullableValueName}));
                        }}");
                }

                _stringBuilder.Append($@"
                    }}
                }}
");
            }
        }

        private string GetCollectionsCount(TypeInfo typeInfo)
        {
            switch (typeInfo.EnumerableType)
            {
                case EnumerableType.JArray:
                case EnumerableType.MArray:
                {
                    return "Length";
                }

                case EnumerableType.List:
                {
                    return "Count";
                }

                case EnumerableType.Dictionary:
                case EnumerableType.SingleType:
                default:
                {
                    throw new NotImplementedException();
                }
            }
        }

        private string IndexInMArray(int dimensions)
        {
            var builder = new DefaultInterpolatedStringHandler();
            for (int i = 0; i < dimensions; i++)
            {
                builder.AppendLiteral("i");
                builder.AppendFormatted(i);
                if (i != dimensions - 1)
                {
                    builder.AppendLiteral(",");
                }
            }

            return builder.ToStringAndClear();
        }

        private void CompareCollections(
            string actualCollectionVar,
            string expectCollectionVar,
            TypeInfo typeInfo)
        {
            if (typeInfo.EnumerableType == EnumerableType.MArray)
            {
                _stringBuilder.Append($@"
                {{
                    var expectCollection = {expectCollectionVar};
                    var actualCollection = {actualCollectionVar};
                    Assert.That(actualCollection.{GetCollectionsCount(typeInfo)}, Is.EqualTo(expectCollection.{GetCollectionsCount(typeInfo)}));
                    Assert.That(actualCollection.Rank, Is.EqualTo(expectCollection.Rank)); // and must be {typeInfo.ArrayDimensions}");
                for (int i = 0; i < typeInfo.ArrayDimensions; i++)
                {
                    _stringBuilder.Append($@"
                    Assert.That(actualCollection.GetLength({i}), Is.EqualTo(expectCollection.GetLength({i})));");
                }

                for (int i = 0; i < typeInfo.ArrayDimensions; i++)
                {
                    _stringBuilder.Append($@"
                    for(int i{i} = 0; i{i} < expectCollection.GetLength({i}); i{i}++)
                    {{");
                }

                _stringBuilder.Append($@"
                        var expectItem = expectCollection[{IndexInMArray(typeInfo.ArrayDimensions)}];
                        var actualItem = actualCollection[{IndexInMArray(typeInfo.ArrayDimensions)}];
                        Assert.That(expectItem, Is.EqualTo(actualItem));");

                for (int i = 0; i < typeInfo.ArrayDimensions; i++)
                {
                    _stringBuilder.Append($@"
                    }}");
                }

                _stringBuilder.Append($@"
                }}");
            }

            if (typeInfo.EnumerableType == EnumerableType.JArray)
            {
                _stringBuilder.Append($@"
                {{
                    var expectCollection = {expectCollectionVar};
                    Assert.That({actualCollectionVar}.{GetCollectionsCount(typeInfo)}, Is.EqualTo(expectCollection.{GetCollectionsCount(typeInfo)}));");

                for (int i = 0; i < typeInfo.ArrayDimensions; i++)
                {
                    _stringBuilder.Append($@"
                    for(int i{i} = 0; i{i} < expectCollection.{GetCollectionsCount(typeInfo)}; i{i}++)
                    {{");

                    if (i == 0)
                    {
                        _stringBuilder.Append($@"
                        var expectCollection{i} = expectCollection[i{i}];
                        var actualCollection{i} = {actualCollectionVar}[i{i}];
                        Assert.That(actualCollection{i}.{GetCollectionsCount(typeInfo)}, Is.EqualTo(expectCollection{i}.{GetCollectionsCount(typeInfo)}));");
                    }
                    else
                    {
                        _stringBuilder.Append($@"
                        var expectCollection{i} = expectCollection{i - 1}[i{i}];
                        var actualCollection{i} = actualCollection{i - 1}[i{i}];
                        Assert.That(actualCollection{i}.{GetCollectionsCount(typeInfo)}, Is.EqualTo(expectCollection{i}.{GetCollectionsCount(typeInfo)}));");
                    }
                }

                for (int i = 0; i < typeInfo.ArrayDimensions; i++)
                {
                    if (i == typeInfo.ArrayDimensions - 1)
                    {
                        _stringBuilder.Append($@"
                        var expectItem = expectCollection{i}[i{i}];
                        var actualItem = actualCollection{i}[i{i}];
                        Assert.That(expectItem, Is.EqualTo(actualItem));");
                    }

                    _stringBuilder.Append($@"
                    }}");
                }
            }
        }

        private void AssertEnumerable(
            string modelVariable,
            string expectVariable,
            Model.ModelType model,
            bool isFlat,
            bool checkNullValue)
        {
            _stringBuilder.Append($@"
                Assert.That({modelVariable}, Is.Not.Null);
                Assert.That({modelVariable}.{model.IdName}, Is.EqualTo({expectVariable}.{model.IdName}));");
            CompareCollections(
                actualCollectionVar: $"{modelVariable}.{model.ValueName}",
                expectCollectionVar: $"{expectVariable}.{model.ValueName}",
                model.TypeInfo);

            if (checkNullValue)
            {
                _stringBuilder.Append($@"

                if({expectVariable}.{model.NullableValueName} == {ValueConstants.NullValue})
                {{
                    Assert.That({modelVariable}.{model.NullableValueName}, Is.Null);
                }}
                else
                {{
                    Assert.That({modelVariable}.{model.NullableValueName}, Is.Not.Null);");
                CompareCollections(
                    actualCollectionVar: $"{modelVariable}.{model.NullableValueName}",
                    expectCollectionVar: $"{expectVariable}.{model.NullableValueName}",
                    model.TypeInfo);
                _stringBuilder.Append($@"
                }}");
            }

            if (!isFlat)
            {
                _stringBuilder.Append($@"

                if({expectVariable}.{model.ModelInnerName} == {ValueConstants.NullValue})
                {{
                    Assert.That({modelVariable}.{model.ModelInnerName}, Is.Null);
                }}
                else
                {{
                    Assert.That({modelVariable}.{model.ModelInnerName}, Is.Not.Null);
                    Assert.That({modelVariable}.{model.ModelInnerName}.{model.ModelInner.IdName}, Is.EqualTo({expectVariable}.{model.ModelInnerName}.{model.ModelInner.IdName}));
                    if (checkInInnerOnlyId)
                    {{
                        Assert.That({modelVariable}.{model.ModelInnerName}.{model.ModelInner.ValueName}, Is.EqualTo(({model.ModelInner.ValueType})default));");

                if (checkNullValue)
                {
                    _stringBuilder.Append($@"
                        Assert.That({modelVariable}.{model.ModelInnerName}.{model.ModelInner.NullableValueName}, Is.Null);");
                }

                _stringBuilder.Append($@"
                    }}
                    else
                    {{");
                CompareCollections(
                    actualCollectionVar: $"{expectVariable}.{model.ModelInnerName}.{model.ValueName}",
                    expectCollectionVar: $"{modelVariable}.{model.ModelInnerName}.{model.ValueName}",
                    model.TypeInfo);

                if (checkNullValue)
                {
                    _stringBuilder.Append($@"

                        if({expectVariable}.{model.ModelInnerName}.{model.ModelInner.NullableValueName} == {ValueConstants.NullValue})
                        {{
                            Assert.That({modelVariable}.{model.ModelInnerName}.{model.ModelInner.NullableValueName}, Is.Null);
                        }}
                        else
                        {{
                            Assert.That({modelVariable}.{model.ModelInnerName}.{model.ModelInner.NullableValueName}, Is.Not.Null);");
                    CompareCollections(
                        actualCollectionVar: $"{expectVariable}.{model.ModelInnerName}.{model.ModelInner.NullableValueName}",
                        expectCollectionVar: $"{modelVariable}.{model.ModelInnerName}.{model.ModelInner.NullableValueName}",
                        model.TypeInfo);
                    _stringBuilder.Append($@"
                        }}");
                }

                _stringBuilder.Append($@"

                    }}
                }}
");
            }
        }

        private async Task ModelInner(
            Model.ModelInnerType model,
            string destinationFolder,
            bool withDbTypes,
            bool checkNullValue)
        {
            _stringBuilder.Clear();
            _stringBuilder.Append($@"
using NUnit.Framework;
using System.Linq;

namespace Tests
{{
    public class {model.ClassName(withDbTypes, withDbTypes)}
    {{
        {DbTypeAttribute(model.IdTypeInfo, withDbTypes)}
        {AliasAttribute(withDbTypes, 0)}
        public {model.IdType} {model.IdName} {{ get; set; }}

        {DbTypeAttribute(model.TypeInfo, withDbTypes)}
        {AliasAttribute(withDbTypes, 1)}
        public {model.ValueType} {model.ValueName} {{ get; set; }}

        {DbTypeAttribute(model.TypeInfo, withDbTypes)}
        {AliasAttribute(withDbTypes, 2)}
        public {model.NullableValueType} {model.NullableValueName} {{ get; set; }}

        public static void {AssertMethodName}({model.ClassName(withDbTypes, withDbTypes)} actual, {model.ClassName(false)} expect, bool checkInInnerOnlyId)
        {{");

            if (model.TypeInfo.EnumerableType == Enums.EnumerableType.SingleType)
            {
                AssertInnerSingle("actual", "expect", model, checkNullValue);
            }
            else
            {
                AssertInnerEnumerable("actual", "expect", model, checkNullValue);
            }

            _stringBuilder.Append($@"
        }}
    }}
}}");
            await File.WriteAllTextAsync($"{destinationFolder}/Model/{model.ClassName(withDbTypes, withDbTypes)}.cs", _stringBuilder.ToString());
            _stringBuilder.Clear();
        }

        private void AssertInnerSingle(
            string modelVariable,
            string expectVariable,
            Model.ModelInnerType model,
            bool checkNullValue)
        {
            _stringBuilder.Append($@"
                Assert.That({modelVariable}, Is.Not.Null);
                Assert.That({modelVariable}.{model.IdName}, Is.EqualTo({expectVariable}.{model.IdName}));
                Assert.That({modelVariable}.{model.ValueName}, Is.EqualTo({expectVariable}.{model.ValueName}));");
            if (checkNullValue)
            {
                _stringBuilder.Append($@"
                if ({expectVariable}.{model.NullableValueName} == null)
                {{
                    Assert.That({modelVariable}.{model.NullableValueName}, Is.Null);
                }}
                else
                {{
                    Assert.That({modelVariable}.{model.NullableValueName}, Is.Not.Null);
                    Assert.That({modelVariable}.{model.NullableValueName}, Is.EqualTo({expectVariable}.{model.NullableValueName}));
                }}");
            }
        }

        private void AssertInnerEnumerable(
            string modelVariable,
            string expectVariable,
            Model.ModelInnerType model,
            bool checkNullValue)
        {
            _stringBuilder.Append($@"
                Assert.That({modelVariable}, Is.Not.Null);
                Assert.That({modelVariable}.{model.IdName}, Is.EqualTo({expectVariable}.{model.IdName}));");
            CompareCollections(
                actualCollectionVar: $"{expectVariable}.{model.ValueName}",
                expectCollectionVar: $"{modelVariable}.{model.ValueName}",
                model.TypeInfo);

            if (checkNullValue)
            {
                _stringBuilder.Append($@"

                if ({expectVariable}.{model.NullableValueName} == null)
                {{
                    Assert.That({modelVariable}.{model.NullableValueName}, Is.Null);
                }}
                else
                {{
                    Assert.That({modelVariable}.{model.NullableValueName}, Is.Not.Null);");
                CompareCollections(
                    actualCollectionVar: $"{expectVariable}.{model.NullableValueName}",
                    expectCollectionVar: $"{modelVariable}.{model.NullableValueName}",
                    model.TypeInfo);
                _stringBuilder.Append($@"
                }}");
            }
        }

        public static string CreateNewModelInstance(Model.ModelType model, Model.ModelValue value)
        {
            return $@"new {model.ClassName(false)}
{{
    {model.IdName} = {value.Id},
    {model.ValueName} = {value.Value},
    {model.ModelInnerName} = {CreateNewModelInnerInstance(model.ModelInner, value.InnerModel)},
    {model.NullableValueName} = {value.NullableValue},
}}";
        }

        private static string CreateNewModelInnerInstance(Model.ModelInnerType model, Model.InnerModelValue value, bool withDbTypes = false)
        {
            if (value == null)
            {
                return ValueConstants.NullValue;
            }

            return $@"new {model.ClassName(false, withDbTypes)}
{{
    {model.IdName} = {value.Id},
    {model.ValueName} = {value.Value},
    {model.NullableValueName} = {value.NullableValue},
}}";
        }

        public static string ConvertToWAOrSelf(Model.ModelInnerType model, string valueName, bool withDbTypes = false)
        {
            if (!withDbTypes)
            {
                return valueName;
            }

            return $@"
new {model.ClassName(false, withDbTypes)}
{{
    {model.IdName} = {valueName}.{model.IdName},
    {model.ValueName} = {valueName}.{model.ValueName},
    {model.NullableValueName} = {valueName}.{model.NullableValueName},
}}";
        }
    }
}