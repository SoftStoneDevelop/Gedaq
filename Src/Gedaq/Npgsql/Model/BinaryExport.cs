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
    internal class BinaryExport
    {
        public NpgsqlSourceType SourceType { get; private set; }
        public string Query;
        public ITypeSymbol MapTypeName { get; private set; }
        public string MethodName { get; protected set; }
        public MethodType MethodType { get; protected set; }
        public INamedTypeSymbol ContainTypeName;
        public Aliases Aliases;

        public BinaryExport()
        {
        }

        internal static bool CreateNew(ImmutableArray<TypedConstant> namedArguments, INamedTypeSymbol containsType, out BinaryExport method)
        {
            method = null;
            if (namedArguments.Length != 5)
            {
                return false;
            }

            var methodSource = new BinaryExport();
            if (!methodSource.FillQuery(namedArguments[0]))
            {
                return false;
            }

            if (!methodSource.FillMethodName(namedArguments[1]))
            {
                return false;
            }

            if (!methodSource.FillMapType(namedArguments[2]))
            {
                return false;
            }

            if (!methodSource.FillMethodType(namedArguments[3]))
            {
                return false;
            }

            if (!methodSource.FillSourceType(namedArguments[4]))
            {
                return false;
            }

            if(methodSource.MapTypeName == null)
            {
                throw new Exception("The mapping type must be specified");
            }

            methodSource.ContainTypeName = containsType;
            method = methodSource;
            return true;
        }

        protected bool FillMethodName(TypedConstant argument)
        {
            if (!(argument.Type is INamedTypeSymbol namedTypeSymbol) ||
                namedTypeSymbol.Name != nameof(String)
                )
            {
                return false;
            }

            MethodName = (string)argument.Value;
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

        protected bool FillMethodType(TypedConstant argument)
        {
            if (argument.Kind != TypedConstantKind.Enum ||
                !(argument.Type is INamedTypeSymbol namedTypeSymbol3) ||
                !namedTypeSymbol3.IsAssignableFrom("Gedaq.Common.Enums", "MethodType")
                )
            {
                return false;
            }

            MethodType = (MethodType)argument.Value;
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