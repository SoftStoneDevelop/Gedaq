using Gedaq.Base.Batch;

namespace Gedaq.DbConnection.BatchGenerators
{
    internal class DbQueryBatchScalarNoQuery : QueryBatchScalarNoQueryBase
    {
        DbBatchCommon _batchCommon = new DbBatchCommon();
        protected override BatchCommonGenerator BatchCommon => _batchCommon;
    }
}