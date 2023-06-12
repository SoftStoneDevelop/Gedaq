using MySqlConnector;
using System;
using TestsGenerator.TypeInfos;
using TestsGenerator.TypeValueHelpers;

namespace TestsGenerator.Model
{
    internal class MySqlModel : ModelType
    {
        public MySqlModel(
            MySqlDbType mySqlDbType,
            string typeName,
            string typeFullName,
            Func<ValueHelper> valueStorageFactory,
            int size = -1,
            bool mustHaveSize = false,
            bool isReferenceType = false
            )
            : base(
                  new MySQLTypeInfo(MySqlDbType.Int32, "Int32", "System.Int32", 0, false, false), 
                  new MySQLTypeInfo(mySqlDbType, typeName, typeFullName, size, mustHaveSize, isReferenceType), 
                  valueStorageFactory
                  )
        {

        }
    }
}