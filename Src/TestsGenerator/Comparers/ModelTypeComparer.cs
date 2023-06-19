using System.Collections.Generic;

namespace TestsGenerator.Comparers
{
    internal class ModelTypeComparer : IEqualityComparer<Model.ModelType>
    {
        public bool Equals(Model.ModelType x, Model.ModelType y)
        {
            return x.TypeInfo.ItemTypeFullName == y.TypeInfo.ItemTypeFullName && x.TypeInfo.DbSqlType == y.TypeInfo.DbSqlType && x.TypeInfo.EnumerableType == y.TypeInfo.EnumerableType;
        }

        public int GetHashCode(Model.ModelType obj)
        {
            return 0;
        }
    }
}