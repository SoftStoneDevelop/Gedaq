using System;
using TestsGenerator.Enums;
using TestsGenerator.TypeInfos;
using TestsGenerator.TypeValueHelpers;

namespace TestsGenerator.Model
{
    internal class ClickhouseModel : ModelType
    {
        public ClickhouseModel(
            string clickHouseType,
            string typeName,
            string typeFullName,
            Func<ValueHelper> valueStorageFactory,
            EnumerableType enumerableType = EnumerableType.SingleType,
            int size = -1,
            bool mustHaveSize = false,
            bool isReferenceType = false)
            : base(
                  new ClickhouseTypeInfo("Int32", "Int32", "System.Int32", enumerableType, 0, false, false), 
                  new ClickhouseTypeInfo(clickHouseType, typeName, typeFullName, enumerableType, size, mustHaveSize, isReferenceType), 
                  valueStorageFactory)
        {

        }
    }
}