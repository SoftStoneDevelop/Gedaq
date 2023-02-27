using Gedaq.MySqlConnector.Enums;
using System;

namespace Gedaq.MySqlConnector.Helpers
{
    internal static class MySqlConnectorSourceTypeHelper
    {
        public static string ToTypeName(this MySqlConnectorSourceType sourceType)
        {
            switch (sourceType)
            {
                case MySqlConnectorSourceType.MySqlConnection:
                {
                    return "MySqlConnector.MySqlConnection";
                }

                case MySqlConnectorSourceType.MySqlDataSource:
                {
                    return "MySqlConnector.MySqlDataSource";
                }

                default:
                {
                    throw new NotImplementedException();
                }
            }
        }

        public static string ToParametrName(this MySqlConnectorSourceType sourceType)
        {
            switch (sourceType)
            {
                case MySqlConnectorSourceType.MySqlConnection:
                {
                    return "connection";
                }

                case MySqlConnectorSourceType.MySqlDataSource:
                {
                    return "dataSource";
                }

                default:
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}