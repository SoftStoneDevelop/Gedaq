﻿using Gedaq.Base.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.MySqlConnector.Enums;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Gedaq.MySqlConnector.Model
{
    internal class MySqlConnectorQuery : QueryBase
    {
        public MySqlConnectorSourceType SourceType { get; private set; }
        public MySqlConnectorParametr[] Parametrs;

        private MySqlConnectorQuery()
        {
        }

        public override bool HaveParametrs()
        {
            return Parametrs != null;
        }

        internal static bool CreateNew(ImmutableArray<TypedConstant> namedArguments, INamedTypeSymbol containsType, out MySqlConnectorQuery method)
        {
            method = null;
            if (namedArguments.Length != 7)
            {
                return false;
            }

            var methodSource = new MySqlConnectorQuery();
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

            if (!methodSource.FillQueryType(namedArguments[5]))
            {
                return false;
            }

            if (!methodSource.FillGenerate(namedArguments[6]))
            {
                return false;
            }

            if(methodSource.MapTypeName == null && methodSource.QueryType.HasFlag(QueryType.Read))
            {
                throw new Exception("For the 'Read' type, the mapping type must be specified");
            }

            methodSource.ContainTypeName = containsType;
            method = methodSource;
            return true;
        }

        public override IEnumerable<BaseParametr> BaseParametrs()
        {
            return Parametrs.Cast<BaseParametr>();
        }

        private bool FillSourceType(TypedConstant argument)
        {
            if (argument.Kind != TypedConstantKind.Enum ||
                !(argument.Type is INamedTypeSymbol namedTypeSymbol4) ||
                !namedTypeSymbol4.IsAssignableFrom("Gedaq.MySqlConnector.Enums", "SourceType")
                )
            {
                return false;
            }

            SourceType = (MySqlConnectorSourceType)argument.Value;
            return true;
        }
    }
}