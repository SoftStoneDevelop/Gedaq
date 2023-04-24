using Gedaq.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.DbConnection
{
    internal class DbProviderInfo : ProviderInfo
    {
        public override bool CanSetTransaction => true;

        public override string TransactionType()
        {
            return "DbTransaction";
        }

        public override string BatchType()
        {
            return "DbBatch";
        }

        public override string CommandType()
        {
            return "DbCommand";
        }

        public override string ReaderType()
        {
            return "DbDataReader";
        }

        public override string DefaultSourceType()
        {
            return "DbConnection";
        }

        public override string DefaultSourceTypeParametr()
        {
            return "connection";
        }
    }
}