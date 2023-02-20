using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.Npgsql.Helpers
{
    internal static class NpgsqlMapTypeHelper
    {
        public static readonly string NpgsqlDbTypeName = "NpgsqlTypes.NpgsqlDbType";

        internal static bool IsKnownProviderType(
            this ITypeSymbol typeSymbol
            )
        {
            if(typeSymbol.IsKnownArrayType())
            {
                return true;
            }

            return typeSymbol.IsKnownProviderBaseType();
        }

        internal static bool IsKnownProviderBaseType(
            this ITypeSymbol namedTypeSymbol
            )
        {
            switch (namedTypeSymbol.GetFullTypeName())
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

                case "System.TimeSpan":
                {
                    return true;
                }

                case "System.DateTime":
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

                case "System.Net.IPAddress":
                {
                    return true;
                }

                case "System.Net.NetworkInformation.PhysicalAddress":
                {
                    return true;
                }

                case "System.Guid":
                {
                    return true;
                }

                case "System.Numerics.BigInteger":
                {
                    return true;
                }

                case "System.Collections.BitArray":
                {
                    return true;
                }

                case "NpgsqlTypes.NpgsqlTsQuery":
                {
                    return true;
                }

                case "NpgsqlTypes.NpgsqlTsVector":
                {
                    return true;
                }

                case "NpgsqlTypes.NpgsqlPoint":
                {
                    return true;
                }

                case "NpgsqlTypes.NpgsqlLSeg":
                {
                    return true;
                }

                case "NpgsqlTypes.NpgsqlPath":
                {
                    return true;
                }

                case "NpgsqlTypes.NpgsqlPolygon":
                {
                    return true;
                }

                case "NpgsqlTypes.NpgsqlLine":
                {
                    return true;
                }

                case "NpgsqlTypes.NpgsqlCircle":
                {
                    return true;
                }

                case "NpgsqlTypes.NpgsqlBox":
                {
                    return true;
                }
            }

            return false;
        }

        private static bool IsKnownArrayType(this ITypeSymbol type)
        {
            if(type.IsArrayType(out var elementType))
            {
                return elementType.IsKnownProviderBaseType();
            }

            return false;
        }
    }
}