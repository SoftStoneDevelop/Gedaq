using Gedaq.Helpers;
using Microsoft.CodeAnalysis;

namespace Gedaq.MySqlConnector.Helpers
{
    internal static class MySqlConnectorMapTypeHelper
    {
        internal static bool IsKnownProviderType(
            this ITypeSymbol typeSymbol
            )
        {
            if (typeSymbol.IsKnownArrayType())
            {
                return true;
            }

            return typeSymbol.IsKnownProviderBaseType();
        }

        internal static bool IsKnownProviderBaseType(
            this ITypeSymbol namedTypeSymbol
            )
        {
            switch (namedTypeSymbol.GetFullTypeName(replaceNullable: true))
            {
                case "System.Int32":
                {
                    return true;
                }

                case "System.UInt32":
                {
                    return true;
                }

                case "System.Int64":
                {
                    return true;
                }

                case "System.UInt64":
                {
                    return true;
                }

                case "System.SByte":
                {
                    return true;
                }

                case "System.Byte":
                {
                    return true;
                }

                case "System.Int16":
                {
                    return true;
                }

                case "System.UInt16":
                {
                    return true;
                }

                case "System.Char":
                {
                    return true;
                }

                case "System.Decimal":
                {
                    return true;
                }

                case "System.Double":
                {
                    return true;
                }

                case "System.Boolean":
                {
                    return true;
                }

                case "System.Single":
                {
                    return true;
                }

                case "System.DateTime":
                {
                    return true;
                }

                case "System.TimeSpan":
                {
                    return true;
                }

                case "System.Guid":
                {
                    return true;
                }

                case "System.DateTimeOffset":
                {
                    return true;
                }

                case "System.String":
                {
                    return true;
                }

                case "System.Numerics.BigInteger":
                {
                    return true;
                }

                case "System.DateOnly":
                {
                    return true;
                }

                case "System.TimeOnly":
                {
                    return true;
                }

                case "System.Text.StringBuilder":
                {
                    return true;
                }

                case "MySqlConnector.MySqlDateTime":
                {
                    return true;
                }

                case "MySqlConnector.MySqlDecimal":
                {
                    return true;
                }

                case "MySqlConnector.MySqlGeometry":
                {
                    return true;
                }
            }

            return false;
        }

        private static bool IsKnownArrayType(this ITypeSymbol type)
        {
            if (type.IsArrayType(out var elementType))
            {
                return elementType.IsKnownProviderBaseType();
            }

            return false;
        }

        public static bool IsSpecialHandlerType(this ITypeSymbol type)
        {
            return false;
        }
    }
}