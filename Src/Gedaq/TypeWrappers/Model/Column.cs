using Gedaq.Enums;
using System;
using System.Collections.Generic;

namespace Gedaq.TypeWrappers.Model
{
    internal class Column
    {
        public Dictionary<ProviderDialect, string> ColumnName { get; } = new Dictionary<ProviderDialect, string>();

        public string PropertyName { get; set; }

        public Dictionary<ProviderDialect, Enum> ColumnType { get; } = new Dictionary<ProviderDialect, Enum>();

        public Dictionary<ProviderDialect, string> DefaultValues { get; } = new Dictionary<ProviderDialect, string>();

        public List<Constrain> Constrains { get; } = new List<Constrain>();
    }
}