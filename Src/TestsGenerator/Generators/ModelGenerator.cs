using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using TestsGenerator.Constants;

namespace TestsGenerator.Generators
{
    internal class ModelGenerator
    {
        private readonly StringBuilderArray.StringBuilderArray _stringBuilder = new();

        public const string AssertMethodName = "AssertModel";

        public async Task Generate(List<Model.ModelType> models, string destinationFolder)
        {
            var directory = Directory.CreateDirectory($"{destinationFolder}/Model/");
            foreach (var file in directory.GetFiles())
            {
                File.Delete(file.FullName);
            }

            foreach (var model in models)
            {
                foreach (var isFlat in ValueConstants.BoolValues)
                {
                    await Model(model, destinationFolder, isFlat: isFlat);
                }

                await ModelInner(model.ModelInner, destinationFolder);
            }
        }

        private async Task Model(
            Model.ModelType model,
            string destinationFolder,
            bool isFlat)
        {
            _stringBuilder.Clear();
            _stringBuilder.Append($@"
using NUnit.Framework;
using System.Linq;

namespace Tests
{{
    public class {model.ClassName(isFlat)}
    {{
        public {model.IdType} {model.IdName} {{ get; set; }}

        public {model.ValueType} {model.ValueName} {{ get; set; }}

{(isFlat ? string.Empty : $"        public {model.ModelInnerType} {model.ModelInnerName} {{ get; set; }}")}

        public {model.NullableValueType} {model.NullableValueName} {{ get; set; }}

        public static void {AssertMethodName}({model.ClassName(isFlat)} actual, {model.ClassName(false)} expect, bool checkInInnerOnlyId)
        {{");

            if (model.TypeInfo.EnumerableType == Enums.EnumerableType.SingleType)
            {
                AssertSingle("actual", "expect", model, isFlat: isFlat);
            }
            else
            {
                AssertEnumerable("actual", "expect", model, isFlat: isFlat);
            }

            _stringBuilder.Append($@"
        }}
    }}
}}

");
            await File.WriteAllTextAsync($"{destinationFolder}/Model/{model.ClassName(isFlat)}.cs", _stringBuilder.ToString());
            _stringBuilder.Clear();
        }

        private void AssertSingle(
            string modelVariable,
            string expectVariable,
            Model.ModelType model,
            bool isFlat)
        {
            _stringBuilder.Append($@"
                Assert.That({modelVariable}, Is.Not.Null);
                Assert.That({modelVariable}.{model.IdName}, Is.EqualTo({expectVariable}.{model.IdName}));
                Assert.That({modelVariable}.{model.ValueName}, Is.EqualTo({expectVariable}.{model.ValueName}));
                if({expectVariable}.{model.NullableValueName} == {ValueConstants.NullValue})
                {{
                    Assert.That({modelVariable}.{model.NullableValueName}, Is.Null);
                }}
                else
                {{
                    Assert.That({modelVariable}.{model.NullableValueName}, Is.Not.Null);
                    Assert.That({modelVariable}.{model.NullableValueName}, Is.EqualTo({expectVariable}.{model.NullableValueName}));
                }}
");
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
                        Assert.That({modelVariable}.{model.ModelInnerName}.{model.ModelInner.NullableValueName}, Is.Null);
                    }}
                    else
                    {{
                        Assert.That({modelVariable}.{model.ModelInnerName}.{model.ModelInner.ValueName}, Is.EqualTo({expectVariable}.{model.ModelInnerName}.{model.ModelInner.ValueName}));
                        if({expectVariable}.{model.ModelInnerName}.{model.ModelInner.NullableValueName} == {ValueConstants.NullValue})
                        {{
                            Assert.That({modelVariable}.{model.ModelInnerName}.{model.ModelInner.NullableValueName}, Is.Null);
                        }}
                        else
                        {{
                            Assert.That({modelVariable}.{model.ModelInnerName}.{model.ModelInner.NullableValueName}, Is.Not.Null);
                            Assert.That({modelVariable}.{model.ModelInnerName}.{model.ModelInner.NullableValueName}, Is.EqualTo({expectVariable}.{model.ModelInnerName}.{model.ModelInner.NullableValueName}));
                        }}
                    }}
                }}
");
            }
        }

        private void AssertEnumerable(
            string modelVariable,
            string expectVariable,
            Model.ModelType model,
            bool isFlat)
        {
            _stringBuilder.Append($@"
                Assert.That({modelVariable}, Is.Not.Null);
                Assert.That({modelVariable}.{model.IdName}, Is.EqualTo({expectVariable}.{model.IdName}));
                {{
                    var expectEnumerValue = {expectVariable}.{model.ValueName};
                    Assert.That({modelVariable}.{model.ValueName}.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {{
                        var expectItem = expectEnumerValue[i];
                        var haveItem = {modelVariable}.{model.ValueName}[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }}
                }}
                if({expectVariable}.{model.NullableValueName} == {ValueConstants.NullValue})
                {{
                    Assert.That({modelVariable}.{model.NullableValueName}, Is.Null);
                }}
                else
                {{
                    Assert.That({modelVariable}.{model.NullableValueName}, Is.Not.Null);
                    {{
                        var expectEnumerValue = {expectVariable}.{model.NullableValueName};
                        Assert.That({modelVariable}.{model.NullableValueName}.Count(), Is.EqualTo(expectEnumerValue.Count()));
                        for(int i = 0; i < expectEnumerValue.Count(); i++)
                        {{
                            var expectItem = expectEnumerValue[i];
                            var haveItem = {modelVariable}.{model.NullableValueName}[i];
                            Assert.That(expectItem, Is.EqualTo(haveItem));
                        }}
                    }}
                }}
");
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
                        Assert.That({modelVariable}.{model.ModelInnerName}.{model.ModelInner.NullableValueName}, Is.Null);
                    }}
                    else
                    {{  
                        {{
                            var expectEnumerValue = {expectVariable}.{model.ModelInnerName}.{model.ValueName};
                            Assert.That({modelVariable}.{model.ModelInnerName}.{model.ValueName}.Count(), Is.EqualTo(expectEnumerValue.Count()));
                            for(int i = 0; i < expectEnumerValue.Count(); i++)
                            {{
                                var expectItem = expectEnumerValue[i];
                                var haveItem = {modelVariable}.{model.ModelInnerName}.{model.ValueName}[i];
                                Assert.That(expectItem, Is.EqualTo(haveItem));
                            }}
                        }}
                        if({expectVariable}.{model.ModelInnerName}.{model.ModelInner.NullableValueName} == {ValueConstants.NullValue})
                        {{
                            Assert.That({modelVariable}.{model.ModelInnerName}.{model.ModelInner.NullableValueName}, Is.Null);
                        }}
                        else
                        {{
                            Assert.That({modelVariable}.{model.ModelInnerName}.{model.ModelInner.NullableValueName}, Is.Not.Null);
                            {{
                                var expectEnumerValue = {expectVariable}.{model.ModelInnerName}.{model.ModelInner.NullableValueName};
                                Assert.That({modelVariable}.{model.ModelInnerName}.{model.ModelInner.NullableValueName}.Count(), Is.EqualTo(expectEnumerValue.Count()));
                                for(int i = 0; i < expectEnumerValue.Count(); i++)
                                {{
                                    var expectItem = expectEnumerValue[i];
                                    var haveItem = {modelVariable}.{model.ModelInnerName}.{model.ModelInner.NullableValueName}[i];
                                    Assert.That(expectItem, Is.EqualTo(haveItem));
                                }}
                            }}
                        }}
                    }}
                }}
");
            }
        }

        private async Task ModelInner(Model.ModelInnerType model, string destinationFolder)
        {
            _stringBuilder.Clear();
            _stringBuilder.Append($@"
using NUnit.Framework;
using System.Linq;

namespace Tests
{{
    public class {model.ClassName(false)}
    {{
        public {model.IdType} {model.IdName} {{ get; set; }}

        public {model.ValueType} {model.ValueName} {{ get; set; }}

        public {model.NullableValueType} {model.NullableValueName} {{ get; set; }}

        public static void {AssertMethodName}({model.ClassName(false)} actual, {model.ClassName(false)} expect, bool checkInInnerOnlyId)
        {{");

            if (model.TypeInfo.EnumerableType == Enums.EnumerableType.SingleType)
            {
                AssertInnerSingle("actual", "expect", model);
            }
            else
            {
                AssertInnerEnumerable("actual", "expect", model);
            }

            _stringBuilder.Append($@"
        }}
    }}
}}

");
            await File.WriteAllTextAsync($"{destinationFolder}/Model/{model.ClassName(false)}.cs", _stringBuilder.ToString());
            _stringBuilder.Clear();
        }

        private void AssertInnerSingle(
            string modelVariable,
            string expectVariable,
            Model.ModelInnerType model)
        {
            _stringBuilder.Append($@"
                Assert.That({modelVariable}, Is.Not.Null);
                Assert.That({modelVariable}.{model.IdName}, Is.EqualTo({expectVariable}.{model.IdName}));
                Assert.That({modelVariable}.{model.ValueName}, Is.EqualTo({expectVariable}.{model.ValueName}));
                if ({expectVariable}.{model.NullableValueName} == null)
                {{
                    Assert.That({modelVariable}.{model.NullableValueName}, Is.Null);
                }}
                else
                {{
                    Assert.That({modelVariable}.{model.NullableValueName}, Is.Not.Null);
                    Assert.That({modelVariable}.{model.NullableValueName}, Is.EqualTo({expectVariable}.{model.NullableValueName}));
                }}
");
        }

        private void AssertInnerEnumerable(
            string modelVariable,
            string expectVariable,
            Model.ModelInnerType model)
        {
            _stringBuilder.Append($@"
                Assert.That({modelVariable}, Is.Not.Null);
                Assert.That({modelVariable}.{model.IdName}, Is.EqualTo({expectVariable}.{model.IdName}));
                {{
                    var expectEnumerValue = {expectVariable}.{model.ValueName};
                    Assert.That({modelVariable}.{model.ValueName}.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {{
                        var expectItem = expectEnumerValue[i];
                        var haveItem = {modelVariable}.{model.ValueName}[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }}
                }}

                if ({expectVariable}.{model.NullableValueName} == null)
                {{
                    Assert.That({modelVariable}.{model.NullableValueName}, Is.Null);
                }}
                else
                {{
                    Assert.That({modelVariable}.{model.NullableValueName}, Is.Not.Null);
                    {{
                        var expectEnumerValue = {expectVariable}.{model.NullableValueName};
                        Assert.That({modelVariable}.{model.NullableValueName}.Count(), Is.EqualTo(expectEnumerValue.Count()));
                        for(int i = 0; i < expectEnumerValue.Count(); i++)
                        {{
                            var expectItem = expectEnumerValue[i];
                            var haveItem = {modelVariable}.{model.NullableValueName}[i];
                            Assert.That(expectItem, Is.EqualTo(haveItem));
                        }}
                    }}
                }}
");
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

        private static string CreateNewModelInnerInstance(Model.ModelInnerType model, Model.InnerModelValue value)
        {
            if (value == null)
            {
                return ValueConstants.NullValue;
            }

            return $@"new {model.ClassName(false)}
{{
    {model.IdName} = {value.Id},
    {model.ValueName} = {value.Value},
    {model.NullableValueName} = {value.NullableValue},
}}";
        }
    }
}