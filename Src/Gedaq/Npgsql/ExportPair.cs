using Gedaq.Npgsql.Model;
using System.Collections.Generic;

namespace Gedaq.Npgsql
{
    internal class ExportPair
    {
        public BinaryExport Export { get; set; }

        public List<DbTypesOverride> DbTypeOverrides { get; } = new List<DbTypesOverride>();

        public bool IsEmpty()
        {
            return Export == null && DbTypeOverrides.Count == 0;
        }
    }
}
