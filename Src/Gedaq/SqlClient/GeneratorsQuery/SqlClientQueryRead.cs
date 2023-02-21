using Gedaq.Base.Query;
using Gedaq.SqlClient.GeneratorsQuery;

namespace Gedaq.SqlClient.GeneratorsQuery
{
    internal class SqlClientQueryRead : QueryReadBase
    {
        private readonly SqlClientQueryCommon _queryCommon = new SqlClientQueryCommon();
        protected override QueryCommonBase QueryCommon => _queryCommon;
    }
}