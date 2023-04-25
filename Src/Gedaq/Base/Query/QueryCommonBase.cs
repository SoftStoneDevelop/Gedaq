using Gedaq.Base.Model;
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
    internal abstract class QueryCommonBase : DbCommonBase
    {

        public virtual void SetOutAndReturnParametrs(QueryBase source, StringBuilder builder)
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
                    {parametr.VariableName(BaseParametr.VariablePostfix(parametr.Direction))} = ({parametr.Type.GetFullTypeName(true)}){GetParametrValue(parametr, index, "command")};
");
                }
            }
        }

        public string GetScalarTypeName(QueryBase source)
        {
            if (source.Aliases.IsRowsAffected)
            {
                if (source.QueryType != Enums.QueryType.NonQuery)
                {
                    throw new Exception("Use NonQuery for update/delete/inser command");
                }

                return "System.Int32";
            }

            if (IsKnownProviderType(source.MapTypeName) || IsSpecialHandlerType(source.MapTypeName))
            {
                return source.MapTypeName.GetFullTypeName();
            }

            var firstField = source.Aliases.AllFieldsOrderByPosition().First();
            source.MapTypeName.GetPropertyOrFieldName(firstField.Name, out _, out var type);
            return type.GetFullTypeName(true);
        }

        public void ThrowExceptionIfOutCannotExist(QueryBase source)
        {
            if (source.HaveParametrs() &&  source.BaseParametrs().Any(an => an.Direction != System.Data.ParameterDirection.Input))
            {
                throw new Exception("Iterator and Async methods cannot have out parameter");
            }
        }

        public void CreateCommand(
            QueryBase source,
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

        private void SetFormatParametrs(
            QueryBase source,
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

        public void AddFormatParametrs(
            QueryBase source,
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

        public void AddParametrs(
            QueryBase source,
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
                    WriteOutParametrs(parametr, builder);
                }
            }
        }

        public void WriteSetParametrs(QueryBase source, StringBuilder builder, ProviderInfo providerInfo)
        {
            var afterFirst = false;
            if (source.HaveParametrs())
            {
                foreach (var parametr in source.BaseParametrs())
                {
                    if (parametr.Direction != System.Data.ParameterDirection.Input && parametr.Direction != System.Data.ParameterDirection.InputOutput)
                    {
                        continue;
                    }

                    if (afterFirst)
                    {
                        builder.Append($@",");
                    }

                    builder.Append($@"
                    {parametr.VariableName(BaseParametr.VariablePostfix(System.Data.ParameterDirection.Input))}
");

                    afterFirst |= true;
                }
            }

            builder.Append($@"{(afterFirst ? "," : "")}
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