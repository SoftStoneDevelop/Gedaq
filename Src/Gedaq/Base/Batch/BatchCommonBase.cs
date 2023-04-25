using Gedaq.Base.Model;
using Gedaq.DbConnection.GeneratorsBatch;
using Gedaq.Enums;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;

namespace Gedaq.Base.Batch
{
    internal static class BatchCommonBase
    {
        public static void ThrowExceptionIfOutCannotExist(QueryBatch batch)
        {
            if (batch.HaveParametrs &&
                batch.QueryBases().Any(any => any.query.HaveParametrs() && any.query.BaseParametrs().Any(anyIn => anyIn.HaveDirection))
                )
            {
                throw new Exception("Iterator and Async methods cannot have out parameter");
            }
        }

        public static void SetOutAndReturnParametrs(
            QueryBatch batch, 
            StringBuilder builder,
            ProviderInfo providerInfo
            )
        {
            var indexBatch = -1;
            foreach (var item in batch.QueryBases())
            {
                ++indexBatch;
                if (!item.query.HaveParametrs())
                {
                    continue;
                }

                int index = -1;
                foreach (var parametr in item.query.BaseParametrs())
                {
                    ++index;
                    if (parametr.Direction == System.Data.ParameterDirection.ReturnValue ||
                    parametr.Direction == System.Data.ParameterDirection.Output ||
                    parametr.Direction == System.Data.ParameterDirection.InputOutput
                    )
                    {
                        builder.Append($@"
                    {parametr.VariableName(BaseParametr.VariablePostfix(parametr.Direction))}Batch{item.number} = ({parametr.Type.GetFullTypeName(true)}){providerInfo.GetParametrValue(parametr, index, $"batch.BatchCommands[{indexBatch}]")};
");
                    }
                }
            }
        }

        public static void WriteSetParametrs(QueryBatch batch, StringBuilder builder, ProviderInfo providerInfo)
        {
            builder.Append($@"
                batch.Set{batch.MethodName}Parametrs(
");
            var haveSuccessIteration = false;
            if(batch.HaveParametrs)
            {
                foreach (var item in batch.QueryBases())
                {
                    if (!item.query.HaveParametrs())
                    {
                        continue;
                    }

                    if (haveSuccessIteration)
                    {
                        builder.Append($@",");
                    }

                    int index = -1;
                    var afterFirst = false;
                    foreach (var parametr in item.query.BaseParametrs())
                    {
                        ++index;
                        if (parametr.Direction != System.Data.ParameterDirection.Input && parametr.Direction != System.Data.ParameterDirection.InputOutput)
                        {
                            continue;
                        }

                        if (afterFirst)
                        {
                            builder.Append($@",");
                        }

                        builder.Append($@"
                    in {parametr.VariableName()}Batch{item.number}
");

                        afterFirst |= true;
                    }

                    haveSuccessIteration |= true;
                }
            }

            builder.Append($@"{(haveSuccessIteration ? "," : "")}
                    timeout
");
            if(providerInfo.CanSetTransaction)
            {
                builder.Append($@",
                    transaction
");
            }

            builder.Append($@"
                    );");
        }

        public static void CreateCommand(
            QueryBatch source,
            string sourceParametrName,
            MethodType methodType,
            StringBuilder builder
            )
        {
            if (methodType == MethodType.Async)
            {
                builder.Append($@"
                await Create{source.MethodName}BatchAsync({sourceParametrName}
");
            }
            else
            {
                builder.Append($@"
                Create{source.MethodName}Batch({sourceParametrName}
");
            }

            AddFormatParametrs(source, builder);

            if (methodType == MethodType.Async)
            {
                builder.Append($@"
                , false, cancellationToken)
");
            }
            else
            {
                builder.Append($@"
                , false)
");
            }
        }

        private static void AddFormatParametrs(
            QueryBatch source,
            StringBuilder builder
            )
        {
            if (!source.HaveFormatParametrs)
            {
                return;
            }

            foreach (var item in source.QueryBases())
            {
                if (!item.query.HaveFromatParametrs())
                {
                    continue;
                }

                int index = 0;
                foreach (var format in item.query.FormatParametrs)
                {
                    builder.Append($@",
                {(format.HaveName ? $"{format.Name}Batch{item.number.ToString()}" : $"format{index++.ToString()}Batch{item.number.ToString()}")}
");
                }
            }
        }

        public static void WriteMethodParametrs(
            QueryBatch source,
            StringBuilder builder
            )
        {
            if (!source.HaveParametrs && !source.HaveFormatParametrs)
            {
                return;
            }

            foreach (var item in source.QueryBases())
            {
                WriteParametrs(item, builder);
                WriteFormatParametrs(item, builder);
            }
        }

        private static void WriteParametrs(
            (int number, QueryBase query) item,
            StringBuilder builder
            )
        {
            if (!item.query.HaveParametrs())
            {
                return;
            }

            foreach (var parametr in item.query.BaseParametrs())
            {
                if (parametr.Direction == System.Data.ParameterDirection.Input || parametr.Direction == System.Data.ParameterDirection.InputOutput)
                {
                    builder.Append($@",
            {parametr.Type.GetFullTypeName(true)} {parametr.VariableName(BaseParametr.VariablePostfix(System.Data.ParameterDirection.Input))}Batch{item.number}

                            
                        ");
                }

                CommandParametrsHelper.WriteOutParametrs(parametr, builder, $"Batch{item.number}");
            }
        }

        private static void WriteFormatParametrs(
            (int number, QueryBase query) item,
            StringBuilder builder
            )
        {
            if (!item.query.HaveFromatParametrs())
            {
                return;
            }

            int index = 0;
            foreach (var format in item.query.FormatParametrs)
            {
                builder.Append($@",
        System.String {(format.HaveName ? $"{format.Name}Batch{item.number.ToString()}" : $"format{index++.ToString()}Batch{item.number.ToString()}")}
");
            }
        }

        public static string GetScalarTypeName(QueryBatch source, ProviderInfo providerInfo)
        {
            var first = source.QueryBases().First().query;
            if (first.Aliases.IsRowsAffected)
            {
                if (source.QueryType != Enums.QueryType.NonQuery)
                {
                    throw new Exception("Use NonQuery for update/delete/inser command");
                }

                return "System.Int32";
            }

            if (providerInfo.IsKnownProviderType(first.MapTypeName) || providerInfo.IsSpecialHandlerType(first.MapTypeName))
            {
                return first.MapTypeName.GetFullTypeName();
            }

            var firstField = first.Aliases.AllFieldsOrderByPosition().First();
            first.MapTypeName.GetPropertyOrFieldName(firstField.Name, out _, out var type);
            return type.GetFullTypeName(true);
        }
    }
}