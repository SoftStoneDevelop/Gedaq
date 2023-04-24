﻿using Gedaq.Base;
using Gedaq.Base.Query;

namespace Gedaq.DbConnection.GeneratorsQuery
{
    internal class DbQueryRead : QueryReadBase
    {
        private readonly DbQueryCommon _queryCommon = new DbQueryCommon();
        protected override QueryCommonBase QueryCommon => _queryCommon;

        private readonly DbProviderInfo _dbProviderInfo = new DbProviderInfo();
        protected override ProviderInfo ProviderInfo => _dbProviderInfo;
    }
}