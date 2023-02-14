using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.Npgsql.Enums
{
    [Flags]
    internal enum NpgsqlSourceType
    {
        NpgsqlConnection = 1,
        NpgsqlDataSource = 2
    }
}