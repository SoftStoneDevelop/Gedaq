using Gedaq.Constants;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using System.Linq;

namespace Gedaq.Base.Model
{
    internal class Aliases
    {
        private List<Field> _fields = new List<Field>();

        public Aliases()
        {
        }

        public Aliases(string entityName, string linkKey = null)
        {
            EntityName = entityName;
            LinkKey = linkKey;
        }

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
            return Fields().First(f => f.Name.ToLowerInvariant() == LinkKey.ToLowerInvariant());
        }

        public bool IsRoot => EntityName == null;
        public List<Aliases> InnerEntities = new List<Aliases>();
        private Field[] _allFieldsByOrder = null;
        private Field[] _fieldsByOrder = null;

        public void AddField(Field field)
        {
            _fields.Add(field);
        }

        public void FreezeFields(SourceProductionContext context)
        {
            FreezeFieldsWithoutCheck();

            var positionedFields = AllFields().Where(wh => wh.Position.HasValue).ToArray();
            var uniquePositions = positionedFields.Select(s => s.Position.Value).Distinct().Count();
            if (uniquePositions != positionedFields.Length)
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.ColumnPositionNotUnique,
                    DiagnosticConstants.ColumnPositionNotUniqueDescr,
                    DiagnosticSeverity.Error,
                    new string[] { positionedFields.Length.ToString(), uniquePositions.ToString() });
            }
        }

        public void FreezeFieldsWithoutCheck()
        {
            _ = Fields();
            _ = AllFields();

            _fields = null;
        }

        public Field[] Fields()
        {
            if (_fieldsByOrder != null)
            {
                return _fieldsByOrder;
            }

            _fieldsByOrder = _fields.OrderBy(o => o.Position).ToArray();
            return _fieldsByOrder;
        }

        public Field[] AllFields()
        {
            if(_allFieldsByOrder != null)
            {
                return _allFieldsByOrder;
            }

            var tempFields = new List<Field>();

            var entities = new Stack<Aliases>();
            entities.Push(this);
            while (entities.Count != 0)
            {
                var current = entities.Pop();
                tempFields.AddRange(current.Fields());
                foreach (var inner in current.InnerEntities)
                {
                    entities.Push(inner);
                }
            }

            _allFieldsByOrder = tempFields.OrderBy(f => f.Position).ToArray();

            return _allFieldsByOrder;
        }
    }
}