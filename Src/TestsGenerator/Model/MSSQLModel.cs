using System;
using System.Data;
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
            int size = -1,
            bool mustHaveSize = false,
            bool isReferenceType = false
            )
            : base(
                  new MSSQLTypeInfo(SqlDbType.Int, "Int32", "System.Int32", 0, false, false), 
                  new MSSQLTypeInfo(sqlDbType, typeName, typeFullName, size, mustHaveSize, isReferenceType), 
                  valueStorageFactory
                  )
        {

        }
    }
}