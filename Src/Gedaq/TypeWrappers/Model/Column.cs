using Gedaq.Enums;
using System;
using System.Collections.Generic;

namespace Gedaq.TypeWrappers.Model
{
    internal class Column
    {
        public string ColumnName { get; set; }

        public Dictionary<ProviderDialect, Enum> ColumnType { get; } = new Dictionary<ProviderDialect, Enum>();

        public List<Constrain> Constrains { get; } = new List<Constrain>();
    }
}