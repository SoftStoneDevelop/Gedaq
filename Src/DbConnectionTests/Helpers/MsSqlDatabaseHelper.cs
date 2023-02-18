using Microsoft.Data.SqlClient;
namespace DbConnectionTests.Helpers
{
    internal static class MsSqlDatabaseHelper
    {
        public static bool ExistTable(
            this SqlConnection connection,
            string tableName
        )
        {
            using var command = connection.CreateCommand();
            command.CommandText = $@"
SELECT
	t.name
FROM sys.tables t
WHERE
	t.name ='{tableName}'
;
";
            return
                command.ExecuteScalar() != null;
        }

        public static void DropTable(
            this SqlConnection connection,
            string tableName
        )
        {
            if (ExistTable(connection, tableName))
            {
                using var command = connection.CreateCommand();
                command.CommandText = $@"
DROP TABLE {tableName};
;
";
                command.ExecuteNonQuery();
            }
        }
    }
}