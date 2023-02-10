using Gedaq.Enums;
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

        public string GetFileName()
        {
            return $"{MethodName}{SourceType.ToString()}.g.cs";
        }
    }
}