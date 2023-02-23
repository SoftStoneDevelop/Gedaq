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
            string itemName
            )
        {
            Aliases = aliases;
            MapTypeName = mapTypeName;
            ItemName = itemName;
        }

        public ItemPair(
            Aliases aliases,
            ITypeSymbol mapTypeName,
            string itemName,
            string propertyName
            )
            : this(aliases, mapTypeName, itemName)
        {
            PropertyName = propertyName;
        }

        public Aliases Aliases { get; private set; }
        public ITypeSymbol MapTypeName { get; private set; }
        public string PropertyName { get; private set; }
        public string ItemName { get; private set; }

        public ItemPair Parent { get; set; }
        public int Tabs { get; set; }
    }
}