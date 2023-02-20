using Gedaq.Base.Batch;

namespace Gedaq.DbConnection.GeneratorsBatch
{
    internal class DbQueryBatchScalarNoQuery : QueryBatchScalarNoQueryBase
    {
        DbBatchCommon _batchCommon = new DbBatchCommon();
        protected override BatchCommonGenerator BatchCommon => _batchCommon;
    }
}