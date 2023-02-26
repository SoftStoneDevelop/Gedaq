using Gedaq.Base.Model;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
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
        public string ItemName { get; private set; }

        public ItemPair Parent { get; private set; }
        public int Tabs { get; private set; }


        private int _lastProcessField = -1;
        public bool GetNextField(out Field field)
        {
            if(Aliases.Fields.Count == 0)
            {
                field = null;
                return false;
            }

            field = Aliases.Fields[++_lastProcessField];
            return true;
        }

        public void StepBackField()
        {
            --_lastProcessField;
        }
    }
}