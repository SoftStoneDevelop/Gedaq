using Gedaq.Base.Model;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gedaq.Base
{
    internal class ItemPair
    {
        public ItemPair(
            Aliases aliases,
            ITypeSymbol mapTypeName,
            string itemName,
            int tabs
            )
        {
            Aliases = aliases;
            MapTypeName = mapTypeName;
            ItemName = itemName;
            Tabs = tabs;
        }

        public ItemPair(
            Aliases aliases,
            ITypeSymbol mapTypeName,
            string itemName,
            ItemPair parent,
            string propertyName,
            int tabs
            )
            : this(aliases, mapTypeName, itemName, tabs)
        {
            Parent = parent;
            PropertyName = propertyName;
        }

        public Aliases Aliases { get; private set; }
        public ITypeSymbol MapTypeName { get; private set; }
        public string PropertyName { get; private set; }
        public string PathInItem(string property = "")
        {
            if (Parent != null)
            {
                var parentProperty = Parent?.PathInItem();
                var postfix = string.IsNullOrEmpty(property) ? string.Empty : $".{property}";
                if(!string.IsNullOrEmpty(parentProperty))
                {
                    return $"{parentProperty}.{PropertyName}{postfix}";
                }
                else
                {
                    return $"{PropertyName}{postfix}";
                }
            }
            else
            {
                return property;
            }
        }
        public string ItemName { get; private set; }

        public ItemPair Parent { get; private set; }
        public int Tabs { get; private set; }

        public bool HaveUnprocess => 
            (Aliases.Fields.Count != 0 && (_lastProcessedField == -1 || _lastProcessedField != Aliases.Fields.Count - 1)) ||
            (Aliases.InnerEntities.Count != 0 && (_lastProcessedInner == -1 || _lastProcessedInner != Aliases.InnerEntities.Count - 1))
            ;

        private int _lastProcessedField = -1;
        private int _lastProcessedInner = -1;

        public bool GetUnprocessFieldOrInnerAlias(out Field field, out Aliases inner)
        {
            field = null;
            inner = null;

            var nextField = (Aliases.Fields.Count != 0 && Aliases.Fields.Count - 1 != _lastProcessedField) ? Aliases.Fields[_lastProcessedField + 1] : null;
            var nextInner = (Aliases.InnerEntities.Count != 0 && Aliases.InnerEntities.Count - 1 != _lastProcessedInner) ? Aliases.InnerEntities[_lastProcessedInner + 1] : null;

            if(nextField == null && nextInner == null)
            {
                return false;
            }

            if(nextField == null)
            {
                _lastProcessedInner++;
                inner = nextInner;
                return true;
            }

            if(nextInner == null)
            {
                _lastProcessedField++;
                field = nextField;
                return true;
            }

            if(nextField.Position < nextInner.AllFieldsOrderByPosition().First().Position)
            {
                _lastProcessedField++;
                field = nextField;
                return true;
            }

            _lastProcessedInner++;
            inner = nextInner;
            return true;
        }
    }
}