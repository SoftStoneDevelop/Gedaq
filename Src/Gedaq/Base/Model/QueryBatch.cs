using System.Collections.Generic;
using System.Linq;

namespace Gedaq.Base.Model
{
    internal abstract class QueryBatchCommand : QueryBase
    {
        public bool AllSameTypes = true;
        public bool HaveParametrs;
        public bool HaveFormatParametrs;
        public bool HaveDynamicParametrs;

        public override bool IsCollectionDelegateMap => BatchPartBases().Any(a => a.QueryBase.IsCollectionDelegateMap);

        public abstract IEnumerable<BatchPartBase> BatchPartBases();
    }
}