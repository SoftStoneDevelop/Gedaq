using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.Npgsql.Model
{
    internal class Field
    {
        public string Name { get; set; }
        public int Position { get; set; }
    }

    internal class Aliases
    {
        public Aliases(bool isRowsAffected = false)
        {
            IsRowsAffected = isRowsAffected;
        }

        public Aliases(string entityName)
        {
            IsRowsAffected = false;
            EntityName = entityName;
        }

        public bool IsRowsAffected { get; private set; }
        public List<Field> Fields = new List<Field>();

        public string EntityName { get; private set; }
        public bool IsRoot => EntityName == null;
        public List<Aliases> InnerEntities = new List<Aliases>();
    }
}