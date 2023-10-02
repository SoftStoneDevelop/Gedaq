using Gedaq.Base.Model;
using Gedaq.DbConnection.Model;
using System.Collections.Generic;

namespace Gedaq.Base
{
    internal class BatchPair<QB>
        where QB : QueryBatchCommand
    {
        public QB Batch { get; set; }
        public List<BatchPart> Parts { get; } = new List<BatchPart>();

        public bool IsEmpty()
        {
            return Batch == null && Parts.Count == 0;
        }
    }
}