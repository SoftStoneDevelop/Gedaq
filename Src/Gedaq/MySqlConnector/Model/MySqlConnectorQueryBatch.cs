﻿using Gedaq.Base.Model;
using Gedaq.MySqlConnector.Enums;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Gedaq.MySqlConnector.Model
{
    internal class MySqlConnectorQueryBatch : QueryBatchCommand
    {
        public MySqlConnectorSourceType SourceType;
        public List<(int number, MySqlConnectorQuery query)> Queries = new List<(int number, MySqlConnectorQuery query)>();

        internal static bool CreateNew(ImmutableArray<TypedConstant> namedArguments, INamedTypeSymbol containsType, out MySqlConnectorQueryBatch queryBatch)
        {
            queryBatch = null;
            if (namedArguments.Length != 6)
            {
                return false;
            }

            var result = new MySqlConnectorQueryBatch();
            if (!result.FillQueryType(namedArguments[1]))
            {
                return false;
            }
            
            result.MethodInfo =
                new BaseMethodInfo(
                    namedArguments[0],
                    namedArguments[2],
                    namedArguments[3],
                    namedArguments[4],
                    containsType
                    );

            result.ContainTypeName = containsType;
            queryBatch = result;

            if (!result.SetPartInterfaceType(namedArguments[5]))
            {
                return false;
            }

            return true;
        }

        public override IEnumerable<(int, QueryBaseCommand)> QueryBases()
        {
            return Queries.Select(sel => (sel.number, (QueryBaseCommand)sel.query));
        }
    }
}