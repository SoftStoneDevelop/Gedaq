using Gedaq.Base.Model;
using Microsoft.CodeAnalysis;
using System;
using System.Linq;

namespace Gedaq.Base.Query
{
    internal static class QueryCommonBase
    {
        public static void ThrowExceptionIfOutCannotExist(QueryBaseCommand source)
        {
            if (source.HaveParametrs() &&  source.BaseParametrs().Any(an => an.Direction != System.Data.ParameterDirection.Input))
            {
                throw new Exception("Iterator and Async methods cannot have out parameter");
            }
        }
    }
}