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
        public static void ThrowExceptionIfOutCannotExist(QueryBatchCommand batch)
        {
            if (batch.HaveParametrs &&
                batch.QueryBases().Any(any => any.query.HaveParametrs() && any.query.BaseParametrs().Any(anyIn => anyIn.HaveDirection))
                )
            {
                throw new Exception("Iterator and Async methods cannot have out parameter");
            }
        }
    }
}