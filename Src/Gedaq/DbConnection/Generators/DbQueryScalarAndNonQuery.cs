﻿using Gedaq.Base;

namespace Gedaq.DbConnection.Generators
{
    internal class DbQueryScalarAndNonQuery : QueryScalarNonQueryBase
    {
        private readonly DbQueryCommon _queryCommon = new DbQueryCommon();
        protected override QueryCommonBase QueryCommon => _queryCommon;
    }
}