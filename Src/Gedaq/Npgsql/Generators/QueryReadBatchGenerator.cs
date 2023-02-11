using Gedaq.Helpers;
using Gedaq.Npgsql.Helpers;
using Gedaq.Npgsql.Model;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gedaq.Npgsql.Generators
{
    internal class QueryReadBatchGenerator
    {
        private ref struct AdditionalMethodInfo
        {
            public bool AllIsSameType;
        }

        private StringBuilder _methodCode = new StringBuilder();

        public string GetCode()
        {
            var code = _methodCode.ToString();
            return code;
        }

        public void Reset()
        {
            _methodCode.Clear();
        }

        public void GenerateMethod(QueryReadBatchNpgsql source)
        {
            Reset();
            var addInfo = CalculateResultType(source);
            Start(source);
            MethodParametrs(source);
            GenerateBody(source);
            End();
        }

        private AdditionalMethodInfo CalculateResultType(QueryReadBatchNpgsql source)
        {
            var typeReturn = source.Queries.First();
            var allSameType = source.Queries.All(x => x == typeReturn);

            return
                new AdditionalMethodInfo
                {
                    AllIsSameType = allSameType
                };
        }

        private void Start(
            QueryReadBatchNpgsql source
            )
        {
            _methodCode.Append($@"
using Npgsql;
using System.Data;
using System.Collections;
using System.Collections.Generic;

namespace {source.ContainTypeName.ContainingNamespace}
{{
    public static class {source.MethodName}Class
    {{
        
        public static I{(source.MethodType == Enums.MethodType.Sync ? "" : "Async")}Enumerable<{(source.Queries.Length == 1 ? source.Queries[0].MapTypeName.GetFullTypeName() : nameof(Object))}> {source.MethodName}(
");
        }

        private void End(
            )
        {
            _methodCode.Append($@"
        }}
    }}
}}
");
        }

        private void MethodParametrs(
            QueryReadBatchNpgsql source
            )
        {
            _methodCode.Append($@"
            this {source.SourceType.ToTypeName()} {source.SourceType.ToParametrName()}
");
            //foreach parametrs - add parametrs
            _methodCode.Append($@"
        )
        {{
");
        }

        private void GenerateBody(
            QueryReadBatchNpgsql source
            )
        {
            if (source.MethodType == Enums.MethodType.Sync)
            {
                SyncBody(source);
            }
            else
            {
                AsyncBody(source);
            }
        }

        #region Sync

        private void SyncBody(
            QueryReadBatchNpgsql source
            )
        {
            throw new NotImplementedException();
        }

        private void SyncYieldItem(
            QueryMap query
            )
        {
            if (query.MapTypeName.IsPrimitive())
            {
                _methodCode.Append($@"
                    yield return reader.GetFieldValue<{query.MapTypeName.GetFullTypeName()}>(0);
");
            }
            else if (query.MapTypeName.Name == nameof(Object))
            {
                _methodCode.Append($@"
                    yield return reader.GetValue(0);
");
            }
            else if (query.MapTypeName is IArrayTypeSymbol typeArray && typeArray.ElementType.Name == nameof(Object))
            {
                _methodCode.Append($@"
                    var item = new object[reader.FieldCount];
                    reader.GetValues(item);
                    yield return item;
");
            }
            else
            {
                _methodCode.Append($@"
                    var item = new {query.MapTypeName.GetFullTypeName()}
                    {{
");
                for (int i = 0; i < query.Aliases.Fields.Count; i++)
                {
                    var field = query.Aliases.Fields[i];
                    query.MapTypeName.GetPropertyOrFieldName(field.Name, out var propertyName, out var propertyType);
                    _methodCode.Append($@"
                        {propertyName} = reader.GetFieldValue<{propertyType.GetFullTypeName()}>({i}),
");
                }

                _methodCode.Append($@" 
                    }};
                
                    yield return item;
");
            }
        }

        #endregion

        #region Async

        private void AsyncBody(
            QueryReadBatchNpgsql source
            )
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}