using System;
using System.Data;
using TestsGenerator.Enums;
using TestsGenerator.TypeInfos;
using TestsGenerator.TypeValueHelpers;

namespace TestsGenerator.Model
{
    internal class MSSQLModel : ModelType
    {
        public MSSQLModel(
            SqlDbType sqlDbType,
            string typeName,
            string typeFullName,
            Func<ValueHelper> valueStorageFactory,
            EnumerableType enumerableType = EnumerableType.SingleType,
            int size = -1,
            bool mustHaveSize = false,
            bool isReferenceType = false
            )
            : base(
                  new MSSQLTypeInfo(SqlDbType.Int, "Int32", "System.Int32", enumerableType, 0, false, false), 
                  new MSSQLTypeInfo(sqlDbType, typeName, typeFullName, enumerableType, size, mustHaveSize, isReferenceType), 
                  valueStorageFactory
                  )
        {

        }
    }
}