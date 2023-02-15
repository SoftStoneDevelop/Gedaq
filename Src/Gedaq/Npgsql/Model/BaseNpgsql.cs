﻿using Gedaq.Common.Enums;
using Gedaq.Enums;
using Gedaq.Npgsql.Enums;
using Gedaq.Provider.Enums;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.Npgsql.Model
{
    internal class BaseNpgsql
    {
        public string MethodName;
        public NpgsqlSourceType SourceType;
        public MethodType MethodType;
        public INamedTypeSymbol ContainTypeName;
        public int? Timeout;
    }
}