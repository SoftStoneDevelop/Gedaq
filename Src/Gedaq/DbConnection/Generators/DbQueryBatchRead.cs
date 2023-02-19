using Gedaq.Base;

namespace Gedaq.DbConnection.Generators
{
    internal class DbQueryBatchRead : QueryBatchReadBase
    {
        DbBatchCommon _batchCommon = new DbBatchCommon();
        protected override BatchCommonGenerator BatchCommon => _batchCommon;
    }
}
