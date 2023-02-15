using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gedaq.Npgsql.Model
{
    internal class QueryBatchReadNpgsql : BaseNpgsql
    {
        public QueryBatchReadNpgsql(List<QueryReadNpgsql> queries)
        {
            var first = queries.First();
            AllSameTypes = true;
            HaveParametrs = false;
            MethodName = first.BatchMethodName;
            ContainTypeName= first.ContainTypeName;
            var set = new HashSet<int>();

            Queries = queries
                .OrderBy(or => or.BatchNumber)
                .Select(sel =>
                {
                    AllSameTypes &= SymbolEqualityComparer.Default.Equals(sel.MapTypeName, first.MapTypeName);
                    HaveParametrs |= sel.HaveParametrs();
                    SourceType |= sel.SourceType;
                    MethodType |= sel.MethodType;
                    Timeout += sel.Timeout;
                    if(!set.Add(sel.BatchNumber))
                    {
                        throw new Exception($"Batch number must be unique in batch:'{MethodName}'");
                    }

                    return sel;
                })
                .ToList();
        }

        public List<QueryReadNpgsql> Queries { get; private set; }
        public bool AllSameTypes { get; private set; }
        public bool HaveParametrs { get; private set; }
    }
}