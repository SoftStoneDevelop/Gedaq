using Gedaq.Base;
using Gedaq.Npgsql.Helpers;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;

namespace Gedaq.Npgsql.Generators
{
    internal class NpgsqlBatchCommon : BatchCommonGenerator
    {
        public override string BatchType()
        {
            return "NpgsqlBatch";
        }

        public override string CommandType()
        {
            return "NpgsqlCommand";
        }

        public override bool IsKnownProviderType(ITypeSymbol type)
        {
            return MapTypeHelper.IsKnownProviderType(type);
        }

        public override string ReaderType()
        {
            return "NpgsqlDataReader";
        }
    }
}