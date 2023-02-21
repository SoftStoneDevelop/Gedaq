using Gedaq.Base.Model;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gedaq.Base.Batch
{
    internal abstract class BatchCommonGenerator : DbCommonBase
    {
        public void ThrowExceptionIfOutCannotExist(QueryBatch batch)
        {
            if (batch.HaveParametrs &&
                batch.QueryBases().Any(any => any.query.HaveParametrs() && any.query.BaseParametrs().Any(anyIn => anyIn.HaveDirection))
                )
            {
                throw new Exception("Iterator and Async methods cannot have out parameter");
            }
        }

        public virtual void SetOutAndReturnParametrs(QueryBatch batch, StringBuilder builder)
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
                    {parametr.VariableName(BaseParametr.VariablePostfix(parametr.Direction))}Batch{item.number} = ({parametr.Type.GetFullTypeName(true)}){GetParametrValue(parametr, index, $"batch.BatchCommands[{indexBatch}]")};
");
                    }
                }
            }
        }

        public void WriteSetParametrs(QueryBatch batch, StringBuilder builder)
        {
            builder.Append($@"
                batch.Set{batch.MethodName}Parametrs(
");
            var haveSuccessIteration = false;
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
                    if(parametr.Direction != System.Data.ParameterDirection.Input && parametr.Direction != System.Data.ParameterDirection.InputOutput)
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

            builder.Append($@"
                    );");
        }

        public string GetScalarTypeName(QueryBatch source)
        {
            var first = source.QueryBases().First().query;
            if (first.Aliases.IsRowsAffected)
            {
                return "System.Int32";
            }

            if (IsKnownProviderType(first.MapTypeName) || IsSpecialHandlerType(first.MapTypeName))
            {
                return first.MapTypeName.GetFullTypeName();
            }

            var firstField = first.Aliases.GetFirstFieldInQuery();
            first.MapTypeName.GetPropertyOrFieldName(firstField.Name, out _, out var type);
            return type.GetFullTypeName(true);
        }
    }
}