using Gedaq.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.MySqlConnector
{
    internal class MySqlConnectorProviderInfo : ProviderInfo
    {
        public override bool CanSetTransaction => true;

        public override string TransactionType()
        {
            return "MySqlTransaction";
        }

        public override string BatchType()
        {
            return "MySqlBatch";
        }

        public override string CommandType()
        {
            return "MySqlCommand";
        }

        public override string ReaderType()
        {
            return "MySqlDataReader";
        }

        public override string DefaultSourceType()
        {
            throw new System.NotImplementedException();
        }

        public override string DefaultSourceTypeParametr()
        {
            throw new System.NotImplementedException();
        }
    }
}