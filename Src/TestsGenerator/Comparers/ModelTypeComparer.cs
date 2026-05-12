using System.Collections.Generic;

namespace TestsGenerator.Comparers
{
    internal class ModelTypeComparer : IEqualityComparer<Model.ModelType>
    {
        public bool Equals(Model.ModelType? x, Model.ModelType? y)
        {
            if (object.ReferenceEquals(x, y))
            {
                return true;
            }

            if (x == null || y == null)
            {
                return false;
            }

            return
                x.TypeInfo.ItemTypeFullName == y.TypeInfo.ItemTypeFullName
                && x.TypeInfo.ItemTypeNamePostfix == y.TypeInfo.ItemTypeNamePostfix
                && x.TypeInfo.DbSqlType == y.TypeInfo.DbSqlType
                && x.TypeInfo.EnumerableType == y.TypeInfo.EnumerableType;
        }

        public int GetHashCode(Model.ModelType obj)
        {
            return 0;
        }
    }
}