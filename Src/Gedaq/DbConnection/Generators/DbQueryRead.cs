using Gedaq.Base;

namespace Gedaq.DbConnection.Generators
{
    internal class DbQueryRead : QueryReadBase
    {
        private readonly DbQueryCommon _queryCommon = new DbQueryCommon();
        protected override QueryCommonBase QueryCommon => _queryCommon;
    }
}