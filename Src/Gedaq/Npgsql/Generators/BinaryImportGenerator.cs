using Gedaq.Base;
using Gedaq.Base.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Enums;
using Gedaq.Npgsql.Helpers;
using Gedaq.Npgsql.Model;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Gedaq.Npgsql.Generators
{
    internal class BinaryImportGenerator : BaseGenerator
    {
        public void Generate(BinaryImport binaryImport)
        {
            Reset();
            Start(binaryImport);
            GenerateMethod(binaryImport);
            EndClass();
            EndNameSpace();
        }

        private void Start(
            BinaryImport binaryImport
            )
        {
            _methodCode.Append($@"
using Npgsql;
using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace {binaryImport.ContainTypeName.ContainingNamespace.GetFullNamespace()}
{{
    {GeneratedClassDeclarationHelper.GCDeclarationName(binaryImport.ContainTypeName, binaryImport.MethodInfo, "Npgsql")}
    {{
");
        }

        private void GenerateMethod(BinaryImport binaryImport)
        {
            if (binaryImport.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                if(binaryImport.MethodType.HasFlag(MethodType.Sync))
                {
                    GenerateMethod(binaryImport, NpgsqlSourceType.NpgsqlConnection, MethodType.Sync, false);
                }

                if (binaryImport.MethodType.HasFlag(MethodType.Async))
                {
                    GenerateMethod(binaryImport, NpgsqlSourceType.NpgsqlConnection, MethodType.Async, false);
                    GenerateMethod(binaryImport, NpgsqlSourceType.NpgsqlConnection, MethodType.Async, true);
                }
            }

            if (binaryImport.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                if (binaryImport.MethodType.HasFlag(MethodType.Sync))
                {
                    GenerateMethod(binaryImport, NpgsqlSourceType.NpgsqlDataSource, MethodType.Sync, false);
                }

                if (binaryImport.MethodType.HasFlag(MethodType.Async))
                {
                    GenerateMethod(binaryImport, NpgsqlSourceType.NpgsqlDataSource, MethodType.Async, false);
                    GenerateMethod(binaryImport, NpgsqlSourceType.NpgsqlConnection, MethodType.Async, true);
                }
            }
        }

        private void GenerateMethod(
            BinaryImport binaryImport,
            NpgsqlSourceType sourceType,
            MethodType methodType,
            bool isAsyncCollection
            )
        {
            StartMethod(binaryImport, sourceType, methodType, isAsyncCollection);
            MethodBody(binaryImport, sourceType, methodType, isAsyncCollection);
            EndMethod();
        }

        private void StartMethod(
            BinaryImport binaryImport,
            NpgsqlSourceType sourceType,
            MethodType methodType,
            bool isAsyncCollection
            )
        {
            var collectionType = $"I{(isAsyncCollection ? "Async" : "")}Enumerable<{binaryImport.MapTypeName.GetFullTypeName(true, true)}>";

            if (methodType == MethodType.Async)
            {
                _methodCode.Append($@"
        {binaryImport.AccessModifier.ToLowerInvariant()} {binaryImport.MethodStaticModifier} async {binaryImport.MethodInfo.AsyncResultType.ToResultType()} {binaryImport.MethodName}Async(
            {binaryImport.ContainTypeName.GCThisWordOrEmpty()}{sourceType.ToTypeName()} {sourceType.ToParametrName()},
            {collectionType} collection,
            TimeSpan? timeout = null,
            CancellationToken cancellationToken = default
            )
        {{
");
            }
            else
            {
                _methodCode.Append($@"
        {binaryImport.AccessModifier.ToLowerInvariant()} {binaryImport.MethodStaticModifier} void {binaryImport.MethodName}(
            {binaryImport.ContainTypeName.GCThisWordOrEmpty()}{sourceType.ToTypeName()} {sourceType.ToParametrName()},
            {collectionType} collection,
            TimeSpan? timeout = null
            )
        {{
");
            }
        }

        private void MethodBody(
            BinaryImport binaryImport,
            NpgsqlSourceType sourceType,
            MethodType methodType,
            bool isAsyncCollection
            )
        {
            var isAsync = methodType == MethodType.Async;
            var cancellation = isAsync ? "cancellationToken" : "";
            var async = isAsync ? "Async" : "";
            var await = isAsync ? "await " : "";

            if (sourceType == NpgsqlSourceType.NpgsqlDataSource)
            {
                _methodCode.Append($@"
            {NpgsqlSourceType.NpgsqlConnection.ToTypeName()} {NpgsqlSourceType.NpgsqlConnection.ToParametrName()} = {await} {sourceType.ToParametrName()}.OpenConnection{async}({cancellation});
");
            }

            _methodCode.Append($@"
            NpgsqlBinaryImporter import = null;
            try
            {{
                import = {await}{NpgsqlSourceType.NpgsqlConnection.ToParametrName()}.BeginBinaryImport{async}(@""
{binaryImport.Query}
""{(isAsync ? ", cancellationToken" : "")});

                if(timeout.HasValue)
                {{
                    import.Timeout = timeout.Value;
                }}

                {(isAsyncCollection ? await : "")}foreach (var item in collection{(isAsyncCollection ? ".WithCancellation(cancellationToken)" : "")})
                {{
                    {await}import.StartRow{async}({cancellation});
");
            WriteItem(binaryImport, methodType);
            _methodCode.Append($@"
                }}
                {await}import.Complete{async}({cancellation});
                {await}import.Dispose{async}();
                import = null;
            }}
            finally
            {{
                if(import != null)
                {{
                    try
                    {{
                        {await}import.Close{async}();
                    }}
                    catch {{ /* ignore */ }}

                    {await}import.Dispose{async}();
                }}
            }}
");
        }

        public void WriteItem(
            BinaryImport binaryImport,
            MethodType methodType
            )
        {
            var isAsync = methodType == MethodType.Async;
            var async = isAsync ? "Async" : "";
            var await = isAsync ? "await " : "";
            var cancellation = isAsync ? "(cancellationToken)" : "()";

            if (NpgsqlMapTypeHelper.IsKnownProviderType(binaryImport.MapTypeName))
            {
                var field = binaryImport.Aliases.AllFieldsOrderByPosition().First();
                var dbType = field.HaveAdditionalInfo ? $",(NpgsqlTypes.NpgsqlDbType)({((NpgsqlFieldInfo)field.AdditionalInfo).NpgsqlDbType})" : "";
                _methodCode.Append($@"
                    {await}import.Write{async}(item{dbType}{(isAsync ? $",cancellationToken" : "")});
");
            }
            else if (binaryImport.MapTypeName.IsNullableType())
            {
                var field = binaryImport.Aliases.AllFieldsOrderByPosition().First();
                var dbType = field.HaveAdditionalInfo ? $",(NpgsqlTypes.NpgsqlDbType)({((NpgsqlFieldInfo)field.AdditionalInfo).NpgsqlDbType})" : "";
                _methodCode.Append($@"
                    if (!item.HasValue)
                    {{
                        {await}import.WriteNull{async}{cancellation};
                    }}
                    else
                    {{
                        {await}import.Write{async}(item.Value{dbType}{(isAsync ? $",cancellationToken" : "")});
                    }}
");
            }
            else if (binaryImport.MapTypeName.TypeKind == TypeKind.Class || binaryImport.MapTypeName.TypeKind == TypeKind.Struct)
            {
                ComplicateItem(binaryImport.Aliases, binaryImport.MapTypeName, methodType);
            }
            else
            {
                var field = binaryImport.Aliases.AllFieldsOrderByPosition().First();
                var dbType = field.HaveAdditionalInfo ? $",(NpgsqlTypes.NpgsqlDbType)({((NpgsqlFieldInfo)field.AdditionalInfo).NpgsqlDbType})" : "";
                _methodCode.Append($@"
                    {await}import.Write{async}(item{dbType}{(isAsync ? $",cancellationToken" : "")});
");
            }
        }

        private void ComplicateItem(
            Aliases rootAliase,
            ITypeSymbol rootMapTypeName,
            MethodType methodType
            )
        {
            var isAsync = methodType == MethodType.Async;
            var async = isAsync ? "Async" : "";
            var cancellation = isAsync ? "(cancellationToken)" : "()"; ;
            var await = isAsync ? "await " : "";

            var aliases = new Stack<ItemPair>();
            {
                var root = new ItemPair(rootAliase, rootMapTypeName, "item", 0);
                aliases.Push(root);
                var needSkip = root.Aliases.AllFieldsOrderByPosition().Count;
                if (rootMapTypeName.IsNullableType())
                {
                    _methodCode.Append($@"
                    if(!item.HasValue)
                    {{
");
                }
                else if(rootMapTypeName.TypeKind == TypeKind.Class)
                {
                    _methodCode.Append($@"
                    if(item == null)
                    {{
");
                }

                for (var i = 0; i < needSkip; i++)
                {
                    _methodCode.Append($@"
                        {await}import.WriteNull{async}{cancellation};
");
                }

                _methodCode.Append($@"
                    }}
");
            }

            var itemId = 0;
            while (aliases.Count != 0)
            {
                var pair = aliases.Pop();
                if (!pair.HaveUnprocess)
                {
                    //close brackets and set
                    EndInnerEntity(methodType, pair, await, async, cancellation);
                    continue;
                }

                if (!pair.GetUnprocessFieldOrInnerAlias(out var field, out var inner))
                {
                    throw new InvalidOperationException();
                }

                aliases.Push(pair);

                if (field != null)
                {
                    WriteFields(field, pair, methodType);
                    continue;
                }

                if (inner != null)
                {
                    pair.MapTypeName.GetPropertyOrFieldName(inner.EntityName, out var propertyName, out var pairType);
                    var newPair = 
                        new ItemPair(
                            inner, 
                            pairType, 
                            $"item{++itemId}",
                            pair,
                            propertyName,
                            0
                            );
                    aliases.Push(newPair);

                    _methodCode.Append($@"
                    {Tabs(newPair.Tabs)}if(item.{newPair.PathInItem()} != null)
                    {Tabs(newPair.Tabs)}{{
");
                    continue;
                }
            }
        }

        private void EndInnerEntity(
            MethodType methodType,
            ItemPair pair,
            string await,
            string async,
            string cancellation
            )
        {
            if(pair.HaveUnprocess || pair.Parent == null)
            {
                return;
            }

            _methodCode.Append($@"
                    {Tabs(pair.Tabs)}}}
                    {Tabs(pair.Tabs)}else
                    {Tabs(pair.Tabs)}{{
");
            var needSkip = pair.Aliases.AllFieldsOrderByPosition().Count;
            for (var i = 0; i < needSkip; i++)
            {
                _methodCode.Append($@"
                    {Tabs(pair.Tabs)}    {await}import.WriteNull{async}{cancellation};
");
            }

            _methodCode.Append($@"
                    {Tabs(pair.Tabs)}}}
");
        }

        private void WriteFields(Field field, ItemPair pair, MethodType methodType)
        {
            var isAsync = methodType == MethodType.Async;
            var async = isAsync ? "Async" : "";
            var cancellation = isAsync ? "(cancellationToken)" : "()"; ;
            var await = isAsync ? "await " : "";

            var dbType = field.HaveAdditionalInfo ? $",(NpgsqlTypes.NpgsqlDbType)({((NpgsqlFieldInfo)field.AdditionalInfo).NpgsqlDbType})" : "";
            var tabs = pair.Parent != null ? pair.Tabs + 1 : pair.Tabs;
            pair.MapTypeName.GetPropertyOrFieldName(field.Name, out var propertyName, out var propertyType);
            var pathInItem = pair.PathInItem(propertyName);
            if (propertyType.IsReferenceType)
            {
                _methodCode.Append($@"
                    {Tabs(tabs)}if (item.{pathInItem} == null)
                    {Tabs(tabs)}{{
                    {Tabs(tabs)}    {await}import.WriteNull{async}{cancellation};
                    {Tabs(tabs)}}}
                    {Tabs(tabs)}else
                    {Tabs(tabs)}{{
                    {Tabs(tabs)}    {await}import.Write{async}(item.{pathInItem}{dbType}{(isAsync ? $",cancellationToken" : "")});
                    {Tabs(tabs)}}}
");
            }
            else
            if (propertyType.IsNullableType())
            {
                _methodCode.Append($@"
                    {Tabs(tabs)}if (!item.{pathInItem}.HasValue)
                    {Tabs(tabs)}{{
                    {Tabs(tabs)}    {await}import.WriteNull{async}{cancellation};
                    {Tabs(tabs)}}}
                    {Tabs(tabs)}else
                    {Tabs(tabs)}{{
                    {Tabs(tabs)}    {await}import.Write{async}(item.{pathInItem}.Value{dbType}{(isAsync ? $",cancellationToken" : "")});
                    {Tabs(tabs)}}}
");
            }
            else
            {
                if (propertyType.IsReferenceType)
                {
                    _methodCode.Append($@"
                    {Tabs(tabs)}if(item.{pathInItem} == null)
                    {Tabs(tabs)}{{
                    {Tabs(tabs)}    {await}import.WriteNull{async}{cancellation};
                    {Tabs(tabs)}}}
                    {Tabs(tabs)}else
                    {Tabs(tabs)}{{
                    {Tabs(tabs)}    {await}import.Write{async}(item.{pathInItem}{dbType}{(isAsync ? $",cancellationToken" : "")});
                    {Tabs(tabs)}}}
");
                }
                else
                {
                    _methodCode.Append($@"
                    {Tabs(tabs)}{await}import.Write{async}(item.{pathInItem}{dbType}{(isAsync ? $",cancellationToken" : "")});
");
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private string Tabs(int tabs)
        {
            return new string(' ', tabs * 4);
        }

        private void EndMethod()
        {
            _methodCode.Append($@"
        }}
");
        }

        private void EndClass()
        {
            _methodCode.Append($@"
    }}");
        }

        private void EndNameSpace()
        {
            _methodCode.Append($@"
}}");
        }
    }
}