

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
    Id = 3,
    Value = 
new System.Int16[,] { { 11895, 26048, }, { 25889, 5524, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 3,
    Value = 
new System.Int16[,] { { 640, 2383, }, { 87, 28013, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 7166, 15180, }, { 7211, 12852, }, },
},
            new Int16MArrayD2E1M
{
    Id = 10,
    Value = 
new System.Int16[,] { { 543, 1853, }, { 2424, 8207, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 4,
    Value = 
new System.Int16[,] { { 28752, 23704, }, { 2816, 15723, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 19,
    Value = 
new System.Int16[,] { { 5647, 22205, }, { 2090, 18580, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 9,
    Value = 
new System.Int16[,] { { 12562, 10167, }, { 15767, 26004, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 21,
    Value = 
new System.Int16[,] { { 21843, 22162, }, { 11611, 27019, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 10,
    Value = 
new System.Int16[,] { { 31372, 14088, }, { 28709, 15048, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 30322, 14615, }, { 2016, 2224, }, },
},
            new Int16MArrayD2E1M
{
    Id = 30,
    Value = 
new System.Int16[,] { { 28101, 7390, }, { 2202, 11234, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 13,
    Value = 
new System.Int16[,] { { 28157, 17242, }, { 2768, 900, }, },
    NullableValue = 
new System.Int16[,] { { 14882, 26756, }, { 5274, 3261, }, },
},
    NullableValue = 
new System.Int16[,] { { 11461, 7124, }, { 23369, 23501, }, },
},
            new Int16MArrayD2E1M
{
    Id = 32,
    Value = 
new System.Int16[,] { { 19156, 12559, }, { 20975, 7279, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 19,
    Value = 
new System.Int16[,] { { 8412, 23693, }, { 18331, 15412, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 33,
    Value = 
new System.Int16[,] { { 24304, 21822, }, { 1866, 15583, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 24,
    Value = 
new System.Int16[,] { { 11938, 29622, }, { 20122, 17268, }, },
    NullableValue = 
new System.Int16[,] { { 16400, 12172, }, { 1045, 25740, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 41,
    Value = 
new System.Int16[,] { { 29663, 16218, }, { 16399, 23844, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 29,
    Value = 
new System.Int16[,] { { 1683, 6939, }, { 15840, 22085, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 11547, 31446, }, { 12937, 5603, }, },
},
            new Int16MArrayD2E1M
{
    Id = 42,
    Value = 
new System.Int16[,] { { 15576, 13025, }, { 14111, 7574, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 34,
    Value = 
new System.Int16[,] { { 28380, 5521, }, { 31348, 5355, }, },
    NullableValue = 
new System.Int16[,] { { 9753, 9708, }, { 6453, 9400, }, },
},
    NullableValue = 
new System.Int16[,] { { 16259, 621, }, { 31029, 19679, }, },
},
            new Int16MArrayD2E1M
{
    Id = 45,
    Value = 
new System.Int16[,] { { 15974, 22435, }, { 21296, 26953, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 37,
    Value = 
new System.Int16[,] { { 18886, 5461, }, { 26922, 22855, }, },
    NullableValue = 
new System.Int16[,] { { 27067, 29870, }, { 8831, 11691, }, },
},
    NullableValue = 
new System.Int16[,] { { 14566, 7012, }, { 6766, 17107, }, },
},
            new Int16MArrayD2E1M
{
    Id = 53,
    Value = 
new System.Int16[,] { { 13578, 3531, }, { 25579, 827, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 41,
    Value = 
new System.Int16[,] { { 16817, 24340, }, { 8594, 1109, }, },
    NullableValue = 
new System.Int16[,] { { 31430, 25417, }, { 30829, 25951, }, },
},
    NullableValue = 
new System.Int16[,] { { 24688, 29137, }, { 20014, 26037, }, },
},
            new Int16MArrayD2E1M
{
    Id = 55,
    Value = 
new System.Int16[,] { { 17357, 8222, }, { 31243, 11946, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 44,
    Value = 
new System.Int16[,] { { 24315, 27230, }, { 27710, 6593, }, },
    NullableValue = 
new System.Int16[,] { { 12333, 19089, }, { 3357, 24597, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 60,
    Value = 
new System.Int16[,] { { 30351, 3468, }, { 12388, 25388, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 53,
    Value = 
new System.Int16[,] { { 19179, 9867, }, { 2459, 22172, }, },
    NullableValue = 
new System.Int16[,] { { 31253, 5795, }, { 16131, 22671, }, },
},
    NullableValue = 
new System.Int16[,] { { 27437, 21345, }, { 18636, 19837, }, },
},
            new Int16MArrayD2E1M
{
    Id = 63,
    Value = 
new System.Int16[,] { { 23003, 19036, }, { 20533, 29096, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 59,
    Value = 
new System.Int16[,] { { 606, 10993, }, { 4561, 30707, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 30107, 2407, }, { 15270, 27531, }, },
},
            new Int16MArrayD2E1M
{
    Id = 72,
    Value = 
new System.Int16[,] { { 32239, 1673, }, { 3450, 19165, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 64,
    Value = 
new System.Int16[,] { { 8925, 20999, }, { 25529, 8284, }, },
    NullableValue = 
new System.Int16[,] { { 23844, 19006, }, { 17439, 27863, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 81,
    Value = 
new System.Int16[,] { { 11928, 7358, }, { 26058, 30188, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 70,
    Value = 
new System.Int16[,] { { 22929, 2077, }, { 11347, 31181, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 85,
    Value = 
new System.Int16[,] { { 10237, 1754, }, { 10865, 12019, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 77,
    Value = 
new System.Int16[,] { { 2136, 7557, }, { 12202, 23158, }, },
    NullableValue = 
new System.Int16[,] { { 31543, 15612, }, { 2121, 17626, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 92,
    Value = 
new System.Int16[,] { { 469, 31679, }, { 19645, 30732, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 86,
    Value = 
new System.Int16[,] { { 21745, 23534, }, { 29116, 15606, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 32692, 364, }, { 1783, 618, }, },
},
            new Int16MArrayD2E1M
{
    Id = 99,
    Value = 
new System.Int16[,] { { 17354, 30747, }, { 84, 3763, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 87,
    Value = 
new System.Int16[,] { { 15217, 23, }, { 9506, 26104, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 102,
    Value = 
new System.Int16[,] { { 4577, 20955, }, { 32362, 395, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 92,
    Value = 
new System.Int16[,] { { 16947, 8206, }, { 27162, 16987, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 11544, 7470, }, { 18, 8170, }, },
},
            new Int16MArrayD2E1M
{
    Id = 110,
    Value = 
new System.Int16[,] { { 30287, 15431, }, { 6126, 8791, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 95,
    Value = 
new System.Int16[,] { { 14752, 11521, }, { 11412, 2372, }, },
    NullableValue = 
new System.Int16[,] { { 2406, 25077, }, { 5585, 25716, }, },
},
    NullableValue = 
new System.Int16[,] { { 19569, 25766, }, { 11170, 3338, }, },
},
            new Int16MArrayD2E1M
{
    Id = 118,
    Value = 
new System.Int16[,] { { 14527, 10220, }, { 27155, 28717, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 98,
    Value = 
new System.Int16[,] { { 24992, 18098, }, { 31904, 28403, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 120,
    Value = 
new System.Int16[,] { { 7543, 2970, }, { 26636, 19428, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 99,
    Value = 
new System.Int16[,] { { 8224, 24002, }, { 27716, 11512, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 124,
    Value = 
new System.Int16[,] { { 29956, 27392, }, { 28978, 18264, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 106,
    Value = 
new System.Int16[,] { { 17466, 22459, }, { 10128, 21537, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 130,
    Value = 
new System.Int16[,] { { 6517, 10610, }, { 18008, 20422, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 114,
    Value = 
new System.Int16[,] { { 2193, 14602, }, { 5607, 28062, }, },
    NullableValue = 
new System.Int16[,] { { 18002, 7238, }, { 30351, 27153, }, },
},
    NullableValue = 
new System.Int16[,] { { 18842, 2977, }, { 12315, 2577, }, },
},
            new Int16MArrayD2E1M
{
    Id = 133,
    Value = 
new System.Int16[,] { { 31969, 27182, }, { 18969, 7812, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 116,
    Value = 
new System.Int16[,] { { 21754, 25514, }, { 4688, 31115, }, },
    NullableValue = 
new System.Int16[,] { { 5339, 12114, }, { 28188, 15515, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 141,
    Value = 
new System.Int16[,] { { 2944, 25421, }, { 3935, 18825, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 123,
    Value = 
new System.Int16[,] { { 23967, 7069, }, { 26257, 27771, }, },
    NullableValue = 
new System.Int16[,] { { 17467, 30739, }, { 11209, 17811, }, },
},
    NullableValue = 
new System.Int16[,] { { 8567, 21006, }, { 5622, 23502, }, },
},
            new Int16MArrayD2E1M
{
    Id = 146,
    Value = 
new System.Int16[,] { { 1838, 31459, }, { 20042, 2330, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 128,
    Value = 
new System.Int16[,] { { 12293, 6936, }, { 7771, 5202, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 12204, 22148, }, { 29376, 6574, }, },
},
            new Int16MArrayD2E1M
{
    Id = 155,
    Value = 
new System.Int16[,] { { 30850, 27171, }, { 17800, 744, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 136,
    Value = 
new System.Int16[,] { { 26232, 15780, }, { 29031, 30168, }, },
    NullableValue = 
new System.Int16[,] { { 19901, 7484, }, { 2120, 26348, }, },
},
    NullableValue = 
new System.Int16[,] { { 5540, 10834, }, { 31244, 12939, }, },
},
            new Int16MArrayD2E1M
{
    Id = 160,
    Value = 
new System.Int16[,] { { 6650, 30495, }, { 17489, 24313, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 139,
    Value = 
new System.Int16[,] { { 5049, 21731, }, { 2021, 898, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 13778, 6097, }, { 26657, 27790, }, },
},
            new Int16MArrayD2E1M
{
    Id = 169,
    Value = 
new System.Int16[,] { { 11338, 5041, }, { 32211, 30363, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 144,
    Value = 
new System.Int16[,] { { 3850, 9832, }, { 11454, 7334, }, },
    NullableValue = 
new System.Int16[,] { { 5809, 3997, }, { 28379, 7320, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 173,
    Value = 
new System.Int16[,] { { 20953, 29012, }, { 11008, 30800, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 153,
    Value = 
new System.Int16[,] { { 23166, 22766, }, { 20068, 5443, }, },
    NullableValue = 
new System.Int16[,] { { 28660, 21082, }, { 5531, 21206, }, },
},
    NullableValue = 
new System.Int16[,] { { 4741, 6116, }, { 11151, 14575, }, },
},
            new Int16MArrayD2E1M
{
    Id = 181,
    Value = 
new System.Int16[,] { { 13696, 30033, }, { 24480, 27327, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 160,
    Value = 
new System.Int16[,] { { 8183, 22435, }, { 14370, 16003, }, },
    NullableValue = 
new System.Int16[,] { { 4972, 10437, }, { 993, 23237, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 188,
    Value = 
new System.Int16[,] { { 6470, 25318, }, { 27324, 30005, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 161,
    Value = 
new System.Int16[,] { { 9752, 13465, }, { 1657, 2374, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 193,
    Value = 
new System.Int16[,] { { 6597, 11316, }, { 11671, 11376, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 162,
    Value = 
new System.Int16[,] { { 1302, 4022, }, { 13463, 17891, }, },
    NullableValue = 
new System.Int16[,] { { 14076, 21113, }, { 22674, 16022, }, },
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

