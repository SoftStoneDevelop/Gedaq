using System;
using System.Collections.Generic;
using System.Linq;
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

        public Aliases(string entityName, string linkKey = null)
        {
            IsRowsAffected = false;
            EntityName = entityName;
            LinkKey = linkKey;
        }

        public bool IsRowsAffected { get; private set; }
        public List<Field> Fields = new List<Field>();

        public string EntityName { get; private set; }
        public string LinkKey { get; private set; }

        public Field GetLinkField()
        {
            return Fields.First(f => f.Name.ToLowerInvariant() == LinkKey.ToLowerInvariant());
        }


        public bool IsRoot => EntityName == null;
        public List<Aliases> InnerEntities = new List<Aliases>();
    }
}