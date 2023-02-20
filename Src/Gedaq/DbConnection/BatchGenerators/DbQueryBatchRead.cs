using Gedaq.Base.Batch;

namespace Gedaq.DbConnection.BatchGenerators
{
    internal class DbQueryBatchRead : QueryBatchReadBase
    {
        DbBatchCommon _batchCommon = new DbBatchCommon();
        protected override BatchCommonGenerator BatchCommon => _batchCommon;
    }
}
