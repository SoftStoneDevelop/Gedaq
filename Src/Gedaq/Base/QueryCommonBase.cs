using Gedaq.Base.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Gedaq.Base
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

        public void WriteSetParametrs(QueryBase source, StringBuilder builder)
        {
            builder.Append($@"
                command.Set{source.MethodName}Parametrs(
");
            var afterFirst = false;
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
                    in {parametr.VariableName(BaseParametr.VariablePostfix(System.Data.ParameterDirection.Input))}
");

                afterFirst |= true;
            }

            builder.Append($@"
                    );
");
        }

        public string GetScalarTypeName(QueryBase source)
        {
            if (source.Aliases.IsRowsAffected)
            {
                return "System.Int32";
            }

            if (IsKnownProviderType(source.MapTypeName))
            {
                return source.MapTypeName.GetFullTypeName();
            }

            var firstField = source.Aliases.GetFirstFieldInQuery();
            source.MapTypeName.GetPropertyOrFieldName(firstField.Name, out _, out var type);
            return type.GetFullTypeName(true);
        }

        public void WriteOutParametrs(BaseParametr parametr, StringBuilder builder)
        {
            if (parametr.Direction == System.Data.ParameterDirection.InputOutput || parametr.Direction == System.Data.ParameterDirection.Output)
            {
                builder.Append($@",
            out {parametr.Type.GetFullTypeName(true)} {parametr.VariableName(BaseParametr.VariablePostfix(System.Data.ParameterDirection.Output))}
");
                return;
            }

            if (parametr.Direction == System.Data.ParameterDirection.ReturnValue)
            {
                builder.Append($@",
            out {parametr.Type.GetFullTypeName(true)} {parametr.VariableName(BaseParametr.VariablePostfix(System.Data.ParameterDirection.ReturnValue))}
");
                return;
            }
        }

        public void ThrowExceptionIfOutCannotExist(QueryBase source)
        {
            if (source.BaseParametrs().Any(an => an.Direction != System.Data.ParameterDirection.Input))
            {
                throw new Exception("Iterator and Async methods cannot have out parameter");
            }
        }
    }
}