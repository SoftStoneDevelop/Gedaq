using System.Collections.Generic;
using System.Linq;

namespace Gedaq.Base.Model
{
    internal class Aliases
    {
        public Aliases()
        {
        }

        public Aliases(string entityName, string linkKey = null)
        {
            EntityName = entityName;
            LinkKey = linkKey;
        }

        public List<Field> Fields = new List<Field>();

        /// <summary>
        /// Name of this Entity in root entity
        /// </summary>
        public string EntityName { get; private set; }

        public string LinkKey { get; private set; }

        public bool HaveLinkKey => LinkKey != null;

        /// <summary>
        /// Prefix all fields in entity
        /// </summary>
        public string Prefix { get; set; } = "";

        public Field GetLinkField()
        {
            return Fields.First(f => f.Name.ToLowerInvariant() == LinkKey.ToLowerInvariant());
        }

        public bool IsRoot => EntityName == null;
        public List<Aliases> InnerEntities = new List<Aliases>();
        private List<Field> _allFields = null;

        public List<Field> AllFieldsOrderByPosition()
        {
            if(_allFields == null)
            {
                _allFields = new List<Field>();
            }
            else
            {
                return _allFields;
            }

            var entities = new Stack<Aliases>();
            entities.Push(this);
            while (entities.Count != 0)
            {
                var current = entities.Pop();
                _allFields.AddRange(current.Fields);
                foreach (var inner in current.InnerEntities)
                {
                    entities.Push(inner);
                }
            }

            _allFields = _allFields.OrderBy(f => f.Position).ToList();

            return _allFields;
        }
    }
}