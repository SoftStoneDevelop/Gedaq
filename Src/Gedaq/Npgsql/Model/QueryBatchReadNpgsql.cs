using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using System.Linq;

namespace Gedaq.Npgsql.Model
{
    internal class QueryBatchReadNpgsql : BaseNpgsql
    {
        public QueryBatchReadNpgsql(List<QueryReadNpgsql> queries)
        {
            var first = Queries.First();
            AllSameTypes = true;
            HaveParametrs = false;
            MethodName = first.BatchMethodName;

            Queries = queries
                .OrderBy(or => or.BatchNumber)
                .Select(sel =>
                {
                    AllSameTypes &= SymbolEqualityComparer.Default.Equals(sel.MapTypeName, first.MapTypeName);
                    HaveParametrs |= sel.HaveParametrs();
                    SourceType |= sel.SourceType;
                    MethodType |= sel.MethodType;

                    return sel;
                })
                .ToList();
        }

        public List<QueryReadNpgsql> Queries { get; private set; }
        public bool AllSameTypes { get; private set; }
        public bool HaveParametrs { get; private set; }
    }
}