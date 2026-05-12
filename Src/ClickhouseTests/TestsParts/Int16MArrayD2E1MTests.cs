

using ClickHouse.Driver.ADO;
using System;
using Gedaq.Common.Enums;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IInt16MArrayMArrayD2
    {
    }
    
    internal partial class Int16MArrayMArrayD2 : IInt16MArrayMArrayD2
    {


#region TestData

        private readonly Int16MArrayD2E1M[] _testData = new Int16MArrayD2E1M[]
        {
            new Int16MArrayD2E1M
{
    Id = 2,
    Value = 
new System.Int16[,] { { 19232, 27770, }, { 18821, 32011, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 1,
    Value = 
new System.Int16[,] { { 8249, 23745, }, { 25480, 12938, }, },
    NullableValue = 
new System.Int16[,] { { 24664, 16534, }, { 10173, 6306, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 10,
    Value = 
new System.Int16[,] { { 30012, 11402, }, { 29349, 3402, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 5,
    Value = 
new System.Int16[,] { { 3797, 12102, }, { 28168, 6807, }, },
    NullableValue = 
new System.Int16[,] { { 17434, 23870, }, { 28742, 1719, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 17,
    Value = 
new System.Int16[,] { { 2408, 5516, }, { 1854, 25616, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 8,
    Value = 
new System.Int16[,] { { 22151, 7609, }, { 24406, 17604, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 26,
    Value = 
new System.Int16[,] { { 25445, 21398, }, { 14876, 26559, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 9,
    Value = 
new System.Int16[,] { { 1224, 30488, }, { 23716, 923, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 6642, 30122, }, { 11774, 27308, }, },
},
            new Int16MArrayD2E1M
{
    Id = 28,
    Value = 
new System.Int16[,] { { 11404, 13504, }, { 15861, 17052, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 11,
    Value = 
new System.Int16[,] { { 16354, 12075, }, { 16107, 21000, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 35,
    Value = 
new System.Int16[,] { { 22779, 15029, }, { 25098, 226, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 12,
    Value = 
new System.Int16[,] { { 21568, 24561, }, { 7763, 15269, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 9076, 4370, }, { 5489, 25855, }, },
},
            new Int16MArrayD2E1M
{
    Id = 39,
    Value = 
new System.Int16[,] { { 26706, 16970, }, { 29691, 22537, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 18,
    Value = 
new System.Int16[,] { { 23479, 13158, }, { 19575, 9834, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 44,
    Value = 
new System.Int16[,] { { 32309, 2575, }, { 5789, 10598, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 21,
    Value = 
new System.Int16[,] { { 17891, 15976, }, { 7075, 1573, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 15671, 2785, }, { 32051, 17892, }, },
},
            new Int16MArrayD2E1M
{
    Id = 46,
    Value = 
new System.Int16[,] { { 5711, 4654, }, { 13915, 8201, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 24,
    Value = 
new System.Int16[,] { { 4129, 12623, }, { 11253, 29678, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 55,
    Value = 
new System.Int16[,] { { 27149, 22374, }, { 21471, 18725, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 25,
    Value = 
new System.Int16[,] { { 22364, 2189, }, { 18131, 17306, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 7775, 21609, }, { 2995, 5153, }, },
},
            new Int16MArrayD2E1M
{
    Id = 59,
    Value = 
new System.Int16[,] { { 19302, 14560, }, { 16697, 1343, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 33,
    Value = 
new System.Int16[,] { { 7942, 864, }, { 19700, 1946, }, },
    NullableValue = 
new System.Int16[,] { { 20103, 5242, }, { 26570, 31621, }, },
},
    NullableValue = 
new System.Int16[,] { { 28655, 32719, }, { 27198, 19667, }, },
},
            new Int16MArrayD2E1M
{
    Id = 61,
    Value = 
new System.Int16[,] { { 17969, 696, }, { 11554, 9999, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 37,
    Value = 
new System.Int16[,] { { 27875, 15755, }, { 14116, 7782, }, },
    NullableValue = 
new System.Int16[,] { { 15844, 22836, }, { 27616, 11517, }, },
},
    NullableValue = 
new System.Int16[,] { { 19236, 18181, }, { 30132, 22614, }, },
},
            new Int16MArrayD2E1M
{
    Id = 65,
    Value = 
new System.Int16[,] { { 12427, 26137, }, { 12166, 17469, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 43,
    Value = 
new System.Int16[,] { { 7029, 8382, }, { 4948, 4578, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 25997, 3947, }, { 25104, 6811, }, },
},
            new Int16MArrayD2E1M
{
    Id = 72,
    Value = 
new System.Int16[,] { { 13117, 2479, }, { 3829, 31789, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 50,
    Value = 
new System.Int16[,] { { 2351, 27972, }, { 28589, 13873, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 80,
    Value = 
new System.Int16[,] { { 7428, 4723, }, { 16548, 29805, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 54,
    Value = 
new System.Int16[,] { { 1908, 19068, }, { 28203, 32105, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 86,
    Value = 
new System.Int16[,] { { 30827, 23932, }, { 30938, 19601, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 60,
    Value = 
new System.Int16[,] { { 28532, 23601, }, { 13853, 12958, }, },
    NullableValue = 
new System.Int16[,] { { 18755, 29352, }, { 31482, 28419, }, },
},
    NullableValue = 
new System.Int16[,] { { 17432, 20736, }, { 23369, 13284, }, },
},
            new Int16MArrayD2E1M
{
    Id = 88,
    Value = 
new System.Int16[,] { { 24015, 32371, }, { 1678, 23082, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 69,
    Value = 
new System.Int16[,] { { 26502, 21539, }, { 29233, 25493, }, },
    NullableValue = 
new System.Int16[,] { { 18512, 24653, }, { 29015, 400, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 97,
    Value = 
new System.Int16[,] { { 5292, 28868, }, { 13370, 21651, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 78,
    Value = 
new System.Int16[,] { { 3946, 727, }, { 8404, 24818, }, },
    NullableValue = 
new System.Int16[,] { { 18734, 12163, }, { 24148, 25552, }, },
},
    NullableValue = 
new System.Int16[,] { { 820, 20009, }, { 15246, 3876, }, },
},
            new Int16MArrayD2E1M
{
    Id = 101,
    Value = 
new System.Int16[,] { { 16669, 22467, }, { 20954, 16833, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 81,
    Value = 
new System.Int16[,] { { 3611, 4660, }, { 9489, 21463, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 108,
    Value = 
new System.Int16[,] { { 32452, 13437, }, { 6777, 32733, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 86,
    Value = 
new System.Int16[,] { { 20331, 20917, }, { 15630, 22952, }, },
    NullableValue = 
new System.Int16[,] { { 27318, 21301, }, { 32600, 7140, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 113,
    Value = 
new System.Int16[,] { { 10677, 91, }, { 10773, 20116, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 91,
    Value = 
new System.Int16[,] { { 19597, 28626, }, { 12366, 9381, }, },
    NullableValue = 
new System.Int16[,] { { 32237, 2221, }, { 26188, 2358, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 118,
    Value = 
new System.Int16[,] { { 14600, 5503, }, { 15619, 7751, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 96,
    Value = 
new System.Int16[,] { { 27546, 30494, }, { 30524, 8963, }, },
    NullableValue = 
new System.Int16[,] { { 10115, 28818, }, { 26960, 31592, }, },
},
    NullableValue = 
new System.Int16[,] { { 10910, 23440, }, { 28469, 8941, }, },
},
            new Int16MArrayD2E1M
{
    Id = 125,
    Value = 
new System.Int16[,] { { 10525, 615, }, { 17151, 18315, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 103,
    Value = 
new System.Int16[,] { { 24263, 14366, }, { 3968, 25020, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 128,
    Value = 
new System.Int16[,] { { 6443, 20580, }, { 8104, 19176, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 109,
    Value = 
new System.Int16[,] { { 23314, 8114, }, { 29883, 12644, }, },
    NullableValue = 
new System.Int16[,] { { 1239, 9948, }, { 29895, 31342, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 130,
    Value = 
new System.Int16[,] { { 13707, 25419, }, { 2145, 27624, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 110,
    Value = 
new System.Int16[,] { { 30145, 24752, }, { 4430, 6082, }, },
    NullableValue = 
new System.Int16[,] { { 19723, 24147, }, { 22383, 19876, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 138,
    Value = 
new System.Int16[,] { { 7590, 6628, }, { 12813, 24676, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 112,
    Value = 
new System.Int16[,] { { 5103, 12798, }, { 9823, 533, }, },
    NullableValue = 
new System.Int16[,] { { 17182, 15666, }, { 30698, 18268, }, },
},
    NullableValue = 
new System.Int16[,] { { 12577, 24829, }, { 4138, 30044, }, },
},
            new Int16MArrayD2E1M
{
    Id = 146,
    Value = 
new System.Int16[,] { { 9180, 3290, }, { 16458, 20422, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 120,
    Value = 
new System.Int16[,] { { 11039, 25423, }, { 19405, 1801, }, },
    NullableValue = 
new System.Int16[,] { { 13031, 24497, }, { 31276, 21389, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 155,
    Value = 
new System.Int16[,] { { 21362, 20083, }, { 20059, 7568, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 126,
    Value = 
new System.Int16[,] { { 31389, 10201, }, { 12892, 14762, }, },
    NullableValue = 
new System.Int16[,] { { 24427, 22643, }, { 11900, 1426, }, },
},
    NullableValue = 
new System.Int16[,] { { 10492, 9544, }, { 14734, 20355, }, },
},
            new Int16MArrayD2E1M
{
    Id = 156,
    Value = 
new System.Int16[,] { { 12631, 24643, }, { 26807, 2642, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 135,
    Value = 
new System.Int16[,] { { 19262, 5893, }, { 11023, 19987, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 164,
    Value = 
new System.Int16[,] { { 216, 20502, }, { 21334, 2806, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 136,
    Value = 
new System.Int16[,] { { 10893, 24987, }, { 21422, 1503, }, },
    NullableValue = 
new System.Int16[,] { { 30771, 27628, }, { 6446, 12757, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 167,
    Value = 
new System.Int16[,] { { 6161, 3285, }, { 29445, 14024, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 145,
    Value = 
new System.Int16[,] { { 13254, 19806, }, { 14381, 20755, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 21718, 17669, }, { 11790, 16223, }, },
},
            new Int16MArrayD2E1M
{
    Id = 170,
    Value = 
new System.Int16[,] { { 10903, 27428, }, { 18719, 16826, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 151,
    Value = 
new System.Int16[,] { { 9288, 22821, }, { 9104, 24827, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 11741, 7155, }, { 12013, 14292, }, },
},
            new Int16MArrayD2E1M
{
    Id = 173,
    Value = 
new System.Int16[,] { { 31758, 28037, }, { 31213, 23520, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 159,
    Value = 
new System.Int16[,] { { 2722, 11190, }, { 2079, 23985, }, },
    NullableValue = 
new System.Int16[,] { { 27291, 6870, }, { 25160, 26036, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 182,
    Value = 
new System.Int16[,] { { 9736, 25163, }, { 27129, 31047, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 164,
    Value = 
new System.Int16[,] { { 23455, 19470, }, { 20106, 8782, }, },
    NullableValue = 
new System.Int16[,] { { 24157, 24211, }, { 9381, 12692, }, },
},
    NullableValue = 
new System.Int16[,] { { 4270, 4525, }, { 6281, 10559, }, },
},
            new Int16MArrayD2E1M
{
    Id = 190,
    Value = 
new System.Int16[,] { { 21114, 12590, }, { 17141, 1814, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 172,
    Value = 
new System.Int16[,] { { 16672, 29352, }, { 6568, 21816, }, },
    NullableValue = 
new System.Int16[,] { { 21938, 32105, }, { 11480, 17484, }, },
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int16marrayd2e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Array(Int16))}, 
    {mi_id:Int32},
    {mi_value:Array(Array(Int16))}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArrayMArrayD2)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16[,]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16[,]), 
                parametrName: "mi_value", 
                methodParametrName: "mi_Value")]
        public void InsertModelDbConnectionConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < 2; i++)
                {
                    await ((IInt16MArrayMArrayD2)this).InsertModelDbConnectionAsync(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 2; i < 35; i++)
                {
                     ((IInt16MArrayMArrayD2)this).InsertModelDbConnection(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

#endregion

#region Select Models

[Gedaq.DbConnection.Attributes.Query(
            query: @"
SELECT
	m_id AS id,
    m_value AS value,
~StartInner::ModelInner:id~
~Reinterpret::id~
    mi_id,
~Reinterpret::value~
    mi_value
~EndInner::ModelInner~
FROM gedaqtests.int16marrayd2e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int16MArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArrayMArrayD2)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_id")]
        public void SelectModelDbConnectionConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models = await ((IInt16MArrayMArrayD2)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int16MArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models =  ((IInt16MArrayMArrayD2)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int16MArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

