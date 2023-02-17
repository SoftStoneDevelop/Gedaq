using Npgsql;

namespace DbConnectionTests.Helpers
{
    internal static class DatabaseHelper
    {
        public static bool ExistTable(
            this NpgsqlConnection connection,
            string tableName
        )
        {
            using var command = connection.CreateCommand();
            command.CommandText = $@"
SELECT
    t.table_name
FROM information_schema.tables t
WHERE
	t.table_name = '{tableName}'
;
";
            return
                command.ExecuteScalar() != null;
        }

        public static void DropTable(
            this NpgsqlConnection connection,
            string tableName
        )
        {
            if(ExistTable(connection, tableName))
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