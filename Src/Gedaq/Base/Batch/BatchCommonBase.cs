using Gedaq.Base.Model;
using Microsoft.CodeAnalysis;
using System;
using System.Linq;

namespace Gedaq.Base.Batch
{
    internal static class BatchCommonBase
    {
        public static void ThrowExceptionIfOutCannotExist(QueryBatchCommand batch)
        {
            if (batch.HaveParametrs &&
                batch.QueryBases().Any(any => any.QueryBase.HaveParametrs() && any.QueryBase.BaseParametrs().Any(anyIn => anyIn.HaveDirection))
                )
            {
                throw new Exception("Iterator and Async methods cannot have out parameter");
            }
        }
    }
}