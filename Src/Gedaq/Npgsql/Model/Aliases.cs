using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.Npgsql.Model
{
    internal class Aliases
    {
        public Aliases(bool isRowsAffected = false)
        {
            IsRowsAffected = isRowsAffected;
        }

        public bool IsRowsAffected { get; private set; }
        public List<string> FieldNames = new List<string>();
    }
}
