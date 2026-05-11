using NpgsqlTypes;
using System;
using TestsGenerator.Enums;
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
            EnumerableType enumerableType = EnumerableType.SingleType,
            int size = -1,
            bool mustHaveSize = false,
            bool isReferenceType = false,
            int arrayDimensions = 1)
            : base(
                  new PostgreSQLTypeInfo(NpgsqlDbType.Integer, "Int32", "System.Int32", EnumerableType.SingleType, 0, false, false), 
                  new PostgreSQLTypeInfo(npgsqlDbType, typeName, typeFullName, enumerableType, size, mustHaveSize, isReferenceType, arrayDimensions: arrayDimensions), 
                  valueStorageFactory)
        {

        }
    }
}