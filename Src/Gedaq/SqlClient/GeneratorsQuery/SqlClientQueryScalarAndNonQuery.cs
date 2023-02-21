using Gedaq.Base.Query;

namespace Gedaq.SqlClient.GeneratorsQuery
{
    internal class SqlClientQueryScalarAndNonQuery : QueryScalarNonQueryBase
    {
        private readonly SqlClientQueryCommon _queryCommon = new SqlClientQueryCommon();
        protected override QueryCommonBase QueryCommon => _queryCommon;
    }
}