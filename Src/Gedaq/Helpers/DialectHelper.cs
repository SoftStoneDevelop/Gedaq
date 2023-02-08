using Gedaq.Enums;
using Microsoft.CodeAnalysis;

namespace Gedaq.Helpers
{
    internal static class DialectHelper
    {
        internal static NpgsqlDbType ToNpgsqlDbType(this ITypeSymbol typeSymbol)
        {
            switch (typeSymbol.Name)
            {
                case nameof(System.String):
                {
                    return NpgsqlDbType.Text;
                }

                case nameof(System.UInt16):
                case nameof(System.Int16):
                {
                    return NpgsqlDbType.Smallint;
                }

                case nameof(System.UInt32):
                case nameof(System.Int32):
                {
                    return NpgsqlDbType.Integer;
                }

                case nameof(System.UInt64):
                case nameof(System.Int64):
                {
                    return NpgsqlDbType.Bigint;
                }

                case nameof(System.Boolean):
                {
                    return NpgsqlDbType.Boolean;
                }

                case nameof(System.Double):
                {
                    return NpgsqlDbType.Double;
                }

                case nameof(System.Char):
                {
                    return NpgsqlDbType.InternalChar;
                }

                case nameof(System.Single):
                {
                    return NpgsqlDbType.Real;
                }

                case nameof(System.Decimal):
                {
                    return NpgsqlDbType.Money;
                }

                default:
                {
                    throw new System.Exception($"No match found in database for type '{typeSymbol.Name}'");
                }
            }
        }
    }
}