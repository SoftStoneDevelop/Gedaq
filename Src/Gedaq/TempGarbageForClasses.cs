﻿using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq
{
    internal enum MethodType
    {
        Sync = 0,
        Async = 1
    }

    internal enum NpgsqlSourceType
    {
        NpgsqlConnection = 0,
        NpgsqlDataSource = 1
    }

    internal class QueryMap
    {
        public string Query;
        public INamedTypeSymbol MapTypeName;
    }

    internal class QueryReadNpgsql
    {
        public QueryMap[] Queries;
        public MethodType MethodType;
        public NpgsqlSourceType SourceType;
        public string NameSpace;
    }
}
