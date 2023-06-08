using System;
using System.Collections.Generic;
using System.Text;

namespace TestsGenegator.Comparers
{
    internal class ModelTypeComparer : IEqualityComparer<Model.Model>
    {
        public bool Equals(Model.Model x, Model.Model y)
        {
            return x.TypeInfo.TypeFullName == y.TypeInfo.TypeFullName;
        }

        public int GetHashCode(Model.Model obj)
        {
            return 0;
        }
    }
}