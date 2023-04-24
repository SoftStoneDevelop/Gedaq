using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.Base.Model
{
    internal abstract class QueryBatch : BaseGenerateItem
    {
        public bool AllSameTypes = true;
        public bool HaveParametrs;
        public bool HaveFormatParametrs;

        public abstract IEnumerable<(int number, QueryBase query)> QueryBases();
    }
}