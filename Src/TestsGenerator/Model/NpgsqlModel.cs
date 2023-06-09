using NpgsqlTypes;
using System;
using TestsGenerator.TypeInfos;
using TestsGenerator.TypeValueHelpers;

namespace TestsGenerator.Model
{
    internal class NpgsqlModel : ModelType
    {
        public NpgsqlModel(
            NpgsqlDbType npgsqlDbType,
            string typeName,
            string typeFullName,
            Func<ValueHelper> valueStorageFactory,
            int size = -1,
            bool mustHaveSize = false,
            bool isReferenceType = false
            )
            : base(
                  new PostgreSQLTypeInfo(NpgsqlDbType.Integer, "Int32", "System.Int32", 0, false, false), 
                  new PostgreSQLTypeInfo(npgsqlDbType, typeName, typeFullName, size, mustHaveSize, isReferenceType), 
                  valueStorageFactory
                  )
        {

        }
    }
}