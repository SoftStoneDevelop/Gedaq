using System;
using System.Collections.Generic;
using System.Text;

namespace TestsGenegator.Model
{
    internal class TypeInfo
    {
        public TypeInfo(
            string dbType,
            string typeName,
            string typeFullName,
            bool isReferenceType = false
            )
        {
            DbType = dbType;
            TypeName = typeName;
            TypeFullName = typeFullName;
            IsReferenceType = isReferenceType;
        }

        public readonly string DbType;

        public readonly string TypeName;

        public readonly string TypeFullName;

        public readonly bool IsReferenceType;
    }
}