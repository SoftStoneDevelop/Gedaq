using Gedaq.Enums;
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

            throw new NotImplementedException();
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
    }
}