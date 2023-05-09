using Gedaq.Base.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Enums;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Gedaq.Npgsql.Model
{
    internal class BinaryExport : BaseGenerateItem
    {
        public NpgsqlSourceType SourceType { get; private set; }
        public string Query;
        public ITypeSymbol MapTypeName { get; private set; }
        public Aliases Aliases;

        private BinaryExport()
        {
        }

        internal static bool CreateNew(ImmutableArray<TypedConstant> namedArguments, INamedTypeSymbol containsType, out BinaryExport method)
        {
            method = null;
            if (namedArguments.Length != 6)
            {
                return false;
            }

            var methodSource = new BinaryExport();
            if (!methodSource.FillQuery(namedArguments[0]))
            {
                return false;
            }

            if (!methodSource.MethodInfo.FillMethodName(namedArguments[1]))
            {
                return false;
            }

            if (!methodSource.FillMapType(namedArguments[2]))
            {
                return false;
            }

            if (!methodSource.MethodInfo.FillMethodType(namedArguments[3]))
            {
                return false;
            }

            if (!methodSource.FillSourceType(namedArguments[4]))
            {
                return false;
            }

            if (!methodSource.MethodInfo.FillAccessModifier(namedArguments[5]))
            {
                return false;
            }

            if (methodSource.MapTypeName == null)
            {
                throw new Exception("The mapping type must be specified");
            }

            methodSource.ContainTypeName = containsType;
            method = methodSource;
            return true;
        }

        protected bool FillQuery(TypedConstant argument)
        {
            if (!(argument.Type is INamedTypeSymbol strParam) ||
                strParam.Name != nameof(String)
                )
            {
                return false;
            }

            Query = (string)argument.Value;
            return true;
        }

        protected bool FillMapType(TypedConstant argument)
        {
            if (argument.IsNull)
            {
                return true;
            }

            if (!(argument.Value is ITypeSymbol typeParam))
            {
                return false;
            }

            MapTypeName = typeParam;
            return true;
        }

        private bool FillSourceType(TypedConstant argument)
        {
            if (argument.Kind != TypedConstantKind.Enum ||
                !(argument.Type is INamedTypeSymbol namedTypeSymbol4) ||
                !namedTypeSymbol4.IsAssignableFrom("Gedaq.Npgsql.Enums", "SourceType")
                )
            {
                return false;
            }

            SourceType = (NpgsqlSourceType)argument.Value;
            return true;
        }
    }
}