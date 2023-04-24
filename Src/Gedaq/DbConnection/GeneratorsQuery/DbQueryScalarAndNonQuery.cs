﻿using Gedaq.Base;
using Gedaq.Base.Query;
using Gedaq.SqlClient;

namespace Gedaq.DbConnection.GeneratorsQuery
{
    internal class DbQueryScalarAndNonQuery : QueryScalarNonQueryBase
    {
        private readonly DbQueryCommon _queryCommon = new DbQueryCommon();
        protected override QueryCommonBase QueryCommon => _queryCommon;

        private readonly DbProviderInfo _providerInfo = new DbProviderInfo();
        protected override ProviderInfo ProviderInfo => _providerInfo;
    }
}