using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.DbConnection.Model
{
    internal abstract class QueryBatch : BaseGenerateItem
    {
        public bool AllSameTypes = true;
        public bool HaveParametrs;

        public abstract IEnumerable<(int number, QueryBase query)> QueryBases();
    }
}