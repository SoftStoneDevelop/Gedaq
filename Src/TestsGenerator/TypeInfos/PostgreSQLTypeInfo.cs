using NpgsqlTypes;
using TestsGenerator.Helpers;

namespace TestsGenerator.TypeInfos
{
    internal class PostgreSQLTypeInfo : TypeInfo
    {
        public PostgreSQLTypeInfo(
            NpgsqlDbType npgsqlDbType,
            string typeName,
            string typeFullName,
            int size = -1,
            bool mustHaveSize = false,
            bool isReferenceType = false
            ) : base(npgsqlDbType.ToDbType(), npgsqlDbType.ToDbSqlTableType(), typeName, typeFullName, size, mustHaveSize, isReferenceType)
        {
            NpgsqlDbType = npgsqlDbType;
        }

        public readonly NpgsqlDbType NpgsqlDbType;

        public override string DefaultMapType => NpgsqlDbType.ToDefaultMapType();

        public override string SpecialDbTypeStr()
        {
            return $"NpgsqlTypes.NpgsqlDbType.{NpgsqlDbType.ToString()}";
        }

        public override string DbTypeStr()
        {
            return $"System.Data.DbType.{DbType.ToString()}";
        }

        public override string DbSqlAfterType()
        {
            return string.Empty;
        }
    }
}