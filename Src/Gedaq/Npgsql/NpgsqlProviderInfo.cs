using Gedaq.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.Npgsql
{
    internal class NpgsqlProviderInfo : ProviderInfo
    {
        public override bool CanSetTransaction => false;

        public override string TransactionType()
        {
            throw new NotImplementedException();
        }

        public override string BatchType()
        {
            return "NpgsqlBatch";
        }

        public override string CommandType()
        {
            return "NpgsqlCommand";
        }

        public override string ReaderType()
        {
            return "NpgsqlDataReader";
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