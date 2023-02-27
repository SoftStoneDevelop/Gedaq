using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.MySqlConnector.Enums
{
    [Flags]
    internal enum MySqlConnectorSourceType
    {
        MySqlConnection = 1,
        MySqlDataSource = 2
    }
}