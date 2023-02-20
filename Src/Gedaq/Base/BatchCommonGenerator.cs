using Gedaq.Base.Model;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gedaq.Base
{
    internal abstract class BatchCommonGenerator : DbCommonBase
    {
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

            if (IsKnownProviderType(first.MapTypeName))
            {
                return first.MapTypeName.GetFullTypeName();
            }

            var firstField = first.Aliases.GetFirstFieldInQuery();
            first.MapTypeName.GetPropertyOrFieldName(firstField.Name, out _, out var type);
            return type.GetFullTypeName(true);
        }
    }
}