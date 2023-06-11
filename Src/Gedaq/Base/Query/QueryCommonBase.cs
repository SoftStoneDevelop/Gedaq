﻿using Gedaq.Base.Model;
using Gedaq.DbConnection.GeneratorsQuery;
using Gedaq.Enums;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Gedaq.Base.Query
{
    internal static class QueryCommonBase
    {

        public static void SetOutAndReturnParametrs(QueryBaseCommand source, StringBuilder builder, ProviderInfo providerInfo)
        {
            var index = -1;
            foreach (var parametr in source.BaseParametrs())
            {
                ++index;
                if (parametr.Direction == System.Data.ParameterDirection.ReturnValue ||
                    parametr.Direction == System.Data.ParameterDirection.Output ||
                    parametr.Direction == System.Data.ParameterDirection.InputOutput
                    )
                {
                    builder.Append($@"
                    {parametr.VariableName(BaseParametr.VariablePostfix(parametr.Direction))} = ({parametr.Type.GetFullTypeName(true)}){providerInfo.GetParametrValue(parametr, index, "command")};
");
                }
            }
        }

        public static void GetScalarType(QueryBaseCommand source, ProviderInfo providerInfo, out ITypeSymbol type, out bool isRowsAffected, out string typeName)
        {
            if (source.Aliases.IsRowsAffected)
            {
                if (source.QueryType != Enums.QueryType.NonQuery)
                {
                    throw new Exception("Use NonQuery for update/delete/inser command");
                }

                isRowsAffected = true;
                type = null;
                typeName = "System.Int32";
                return;
            }

            isRowsAffected = false;
            if (providerInfo.IsKnownProviderType(source.MapTypeName) || providerInfo.IsSpecialHandlerType(source.MapTypeName))
            {
                type = source.MapTypeName;
                typeName = type.GetFullTypeName(replaceNullable: true);
                return;
            }

            var firstField = source.Aliases.AllFieldsOrderByPosition().First();
            source.MapTypeName.GetPropertyOrFieldName(firstField.Name, out _, out var typeProp);
            type = typeProp;
            typeName = type.GetFullTypeName(replaceNullable: true);
            return;
        }

        public static void ThrowExceptionIfOutCannotExist(QueryBaseCommand source)
        {
            if (source.HaveParametrs() &&  source.BaseParametrs().Any(an => an.Direction != System.Data.ParameterDirection.Input))
            {
                throw new Exception("Iterator and Async methods cannot have out parameter");
            }
        }

        public static void CreateCommand(
            QueryBaseCommand source,
            string sourceParametrName,
            MethodType methodType,
            StringBuilder builder
            )
        {
            if (methodType == MethodType.Async)
            {
                builder.Append($@"
                await Create{source.MethodName}CommandAsync({sourceParametrName}
");
            }
            else
            {
                builder.Append($@"
                Create{source.MethodName}Command({sourceParametrName}
");
            }

            SetFormatParametrs(source, builder);

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

        private static void SetFormatParametrs(
            QueryBaseCommand source,
            StringBuilder builder
            )
        {
            if (!source.HaveFromatParametrs())
            {
                return;
            }

            int index = 0;
            foreach (var format in source.FormatParametrs)
            {
                builder.Append($@",
                {(format.HaveName ? format.Name : $"format{index++.ToString()}")}
");
            }
        }

        public static void AddFormatParametrs(
            QueryBaseCommand source,
            StringBuilder builder
            )
        {
            if (!source.HaveFromatParametrs())
            {
                return;
            }

            int index = 0;
            foreach (var format in source.FormatParametrs)
            {
                builder.Append($@",
        System.String {(format.HaveName ? format.Name : $"format{index++.ToString()}")}
");
            }
        }

        public static void AddParametrs(
            QueryBaseCommand source,
            StringBuilder builder,
            bool writeOutParametrs
            )
        {
            if (!source.HaveParametrs())
            {
                return;
            }

            foreach (var parametr in source.BaseParametrs())
            {
                if (parametr.Direction == System.Data.ParameterDirection.Input || parametr.Direction == System.Data.ParameterDirection.InputOutput)
                {
                    builder.Append($@",
            {parametr.Type.GetFullTypeName(true)} {parametr.VariableName(BaseParametr.VariablePostfix(System.Data.ParameterDirection.Input))}
                        ");
                }

                if(writeOutParametrs)
                {
                    CommandParametrsHelper.WriteOutParametrs(parametr, builder);
                }
            }
        }

        public static void WriteSetParametrs(QueryBaseCommand source, StringBuilder builder, ProviderInfo providerInfo)
        {
            var isStatic = source.ContainTypeName.GCIsStatic();
            var afterFirst = false;
            if (source.HaveParametrs())
            {
                foreach (var parametr in source.BaseParametrs())
                {
                    if (parametr.Direction != System.Data.ParameterDirection.Input && parametr.Direction != System.Data.ParameterDirection.InputOutput)
                    {
                        continue;
                    }

                    if (!isStatic || afterFirst)
                    {
                        builder.Append($@",");
                    }

                    builder.Append($@"
                    {parametr.VariableName(BaseParametr.VariablePostfix(System.Data.ParameterDirection.Input))}
");
                    afterFirst |= true;
                }
            }

            builder.Append($@"{(!isStatic || afterFirst ? "," : "")}
                    timeout
");
            if (providerInfo.CanSetTransaction)
            {
                builder.Append($@",
                    transaction
");
            }
        }
    }
}