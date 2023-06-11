using System.Collections.Generic;

namespace TestsGenerator.Comparers
{
    internal class ModelTypeComparer : IEqualityComparer<Model.ModelType>
    {
        public bool Equals(Model.ModelType x, Model.ModelType y)
        {
            return x.TypeInfo.TypeFullName == y.TypeInfo.TypeFullName && x.TypeInfo.DbSqlType == y.TypeInfo.DbSqlType;
        }

        public int GetHashCode(Model.ModelType obj)
        {
            return 0;
        }
    }
}