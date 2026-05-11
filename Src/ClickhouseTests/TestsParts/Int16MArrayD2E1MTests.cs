

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
    Id = 4,
    Value = 
new System.Int16[,] { { 22018, 16194, }, { 3780, 13367, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 7,
    Value = 
new System.Int16[,] { { 4502, 1020, }, { 32030, 6391, }, },
    NullableValue = 
new System.Int16[,] { { 1203, 24323, }, { 26318, 4010, }, },
},
    NullableValue = 
new System.Int16[,] { { 9731, 31269, }, { 32394, 13422, }, },
},
            new Int16MArrayD2E1M
{
    Id = 8,
    Value = 
new System.Int16[,] { { 21348, 32432, }, { 11235, 5071, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 9,
    Value = 
new System.Int16[,] { { 16788, 1665, }, { 6889, 23378, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 10,
    Value = 
new System.Int16[,] { { 18498, 5995, }, { 30730, 11945, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 18,
    Value = 
new System.Int16[,] { { 29236, 17878, }, { 17615, 22614, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 19,
    Value = 
new System.Int16[,] { { 6236, 26311, }, { 15132, 22635, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 20,
    Value = 
new System.Int16[,] { { 25533, 32536, }, { 23781, 9816, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 11777, 24222, }, { 20322, 14239, }, },
},
            new Int16MArrayD2E1M
{
    Id = 28,
    Value = 
new System.Int16[,] { { 15709, 21193, }, { 26956, 9482, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 24,
    Value = 
new System.Int16[,] { { 8862, 11752, }, { 31556, 28438, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 37,
    Value = 
new System.Int16[,] { { 29986, 6157, }, { 13508, 8830, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 28,
    Value = 
new System.Int16[,] { { 31288, 15257, }, { 6175, 20049, }, },
    NullableValue = 
new System.Int16[,] { { 22143, 20805, }, { 3254, 16219, }, },
},
    NullableValue = 
new System.Int16[,] { { 23883, 13595, }, { 17803, 8880, }, },
},
            new Int16MArrayD2E1M
{
    Id = 38,
    Value = 
new System.Int16[,] { { 2064, 4266, }, { 24925, 12892, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 32,
    Value = 
new System.Int16[,] { { 20654, 27496, }, { 15869, 9548, }, },
    NullableValue = 
new System.Int16[,] { { 25020, 11181, }, { 14157, 7503, }, },
},
    NullableValue = 
new System.Int16[,] { { 30612, 8781, }, { 28358, 31421, }, },
},
            new Int16MArrayD2E1M
{
    Id = 43,
    Value = 
new System.Int16[,] { { 12941, 1540, }, { 693, 23371, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 34,
    Value = 
new System.Int16[,] { { 5413, 28320, }, { 23616, 12843, }, },
    NullableValue = 
new System.Int16[,] { { 5179, 31088, }, { 30040, 4545, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 52,
    Value = 
new System.Int16[,] { { 6237, 12178, }, { 9583, 20547, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 41,
    Value = 
new System.Int16[,] { { 28232, 23616, }, { 28548, 15297, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 55,
    Value = 
new System.Int16[,] { { 3820, 15747, }, { 8427, 18463, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 49,
    Value = 
new System.Int16[,] { { 7323, 27187, }, { 21293, 32350, }, },
    NullableValue = 
new System.Int16[,] { { 22788, 13359, }, { 12939, 15025, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 59,
    Value = 
new System.Int16[,] { { 23914, 1953, }, { 15400, 22953, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 51,
    Value = 
new System.Int16[,] { { 3717, 15012, }, { 30629, 16035, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 28383, 4600, }, { 19232, 16724, }, },
},
            new Int16MArrayD2E1M
{
    Id = 61,
    Value = 
new System.Int16[,] { { 22673, 24580, }, { 7833, 15961, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 56,
    Value = 
new System.Int16[,] { { 9389, 28066, }, { 11777, 15768, }, },
    NullableValue = 
new System.Int16[,] { { 26620, 25821, }, { 30492, 4414, }, },
},
    NullableValue = 
new System.Int16[,] { { 15038, 20097, }, { 27024, 8808, }, },
},
            new Int16MArrayD2E1M
{
    Id = 68,
    Value = 
new System.Int16[,] { { 14554, 8863, }, { 3635, 12046, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 57,
    Value = 
new System.Int16[,] { { 15383, 18459, }, { 13249, 18579, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 75,
    Value = 
new System.Int16[,] { { 13476, 1410, }, { 17226, 27743, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 58,
    Value = 
new System.Int16[,] { { 5862, 5730, }, { 22079, 8241, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 76,
    Value = 
new System.Int16[,] { { 13408, 27225, }, { 5745, 8008, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 64,
    Value = 
new System.Int16[,] { { 8168, 24548, }, { 17763, 26535, }, },
    NullableValue = 
new System.Int16[,] { { 29438, 19606, }, { 26350, 16342, }, },
},
    NullableValue = 
new System.Int16[,] { { 29018, 26781, }, { 7126, 7921, }, },
},
            new Int16MArrayD2E1M
{
    Id = 79,
    Value = 
new System.Int16[,] { { 22097, 811, }, { 9070, 4835, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 70,
    Value = 
new System.Int16[,] { { 26646, 2918, }, { 20731, 16428, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 82,
    Value = 
new System.Int16[,] { { 31263, 24317, }, { 15637, 26106, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 77,
    Value = 
new System.Int16[,] { { 1564, 19447, }, { 6591, 4150, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 15091, 24615, }, { 2962, 7244, }, },
},
            new Int16MArrayD2E1M
{
    Id = 90,
    Value = 
new System.Int16[,] { { 4930, 6377, }, { 4286, 25830, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 78,
    Value = 
new System.Int16[,] { { 536, 1617, }, { 4596, 26049, }, },
    NullableValue = 
new System.Int16[,] { { 16926, 25223, }, { 23298, 20618, }, },
},
    NullableValue = 
new System.Int16[,] { { 10717, 25333, }, { 5586, 20219, }, },
},
            new Int16MArrayD2E1M
{
    Id = 98,
    Value = 
new System.Int16[,] { { 1689, 15471, }, { 3067, 29804, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 85,
    Value = 
new System.Int16[,] { { 28118, 6759, }, { 9550, 28518, }, },
    NullableValue = 
new System.Int16[,] { { 26375, 21998, }, { 8693, 28568, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 99,
    Value = 
new System.Int16[,] { { 12023, 12106, }, { 573, 6988, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 93,
    Value = 
new System.Int16[,] { { 27309, 28203, }, { 15995, 3886, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 28110, 2636, }, { 4477, 29466, }, },
},
            new Int16MArrayD2E1M
{
    Id = 101,
    Value = 
new System.Int16[,] { { 2060, 5433, }, { 5256, 1196, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 99,
    Value = 
new System.Int16[,] { { 3349, 2469, }, { 15713, 3614, }, },
    NullableValue = 
new System.Int16[,] { { 8420, 12114, }, { 32515, 2110, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 102,
    Value = 
new System.Int16[,] { { 31546, 5513, }, { 32193, 30807, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 107,
    Value = 
new System.Int16[,] { { 17131, 30204, }, { 11896, 18111, }, },
    NullableValue = 
new System.Int16[,] { { 9554, 17645, }, { 12244, 19718, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 109,
    Value = 
new System.Int16[,] { { 3404, 17007, }, { 14096, 279, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 112,
    Value = 
new System.Int16[,] { { 5792, 24154, }, { 11751, 21840, }, },
    NullableValue = 
new System.Int16[,] { { 22531, 9626, }, { 24148, 18594, }, },
},
    NullableValue = 
new System.Int16[,] { { 9872, 16768, }, { 11360, 29841, }, },
},
            new Int16MArrayD2E1M
{
    Id = 115,
    Value = 
new System.Int16[,] { { 28769, 6682, }, { 5658, 22113, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 115,
    Value = 
new System.Int16[,] { { 11819, 27329, }, { 10939, 2050, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 14573, 1595, }, { 16845, 21650, }, },
},
            new Int16MArrayD2E1M
{
    Id = 121,
    Value = 
new System.Int16[,] { { 173, 23643, }, { 29392, 17289, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 119,
    Value = 
new System.Int16[,] { { 4137, 9809, }, { 12422, 25059, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 27392, 26946, }, { 20603, 29972, }, },
},
            new Int16MArrayD2E1M
{
    Id = 124,
    Value = 
new System.Int16[,] { { 32505, 27176, }, { 1347, 18354, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 128,
    Value = 
new System.Int16[,] { { 21083, 8099, }, { 18461, 19615, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 126,
    Value = 
new System.Int16[,] { { 24288, 24254, }, { 2988, 13218, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 136,
    Value = 
new System.Int16[,] { { 543, 13041, }, { 10690, 16819, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 10543, 560, }, { 13711, 4571, }, },
},
            new Int16MArrayD2E1M
{
    Id = 129,
    Value = 
new System.Int16[,] { { 9066, 25052, }, { 12091, 6447, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 143,
    Value = 
new System.Int16[,] { { 11250, 1282, }, { 18123, 1952, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 3411, 8216, }, { 3024, 8804, }, },
},
            new Int16MArrayD2E1M
{
    Id = 133,
    Value = 
new System.Int16[,] { { 3565, 25181, }, { 15120, 30996, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 145,
    Value = 
new System.Int16[,] { { 31208, 14564, }, { 11893, 30385, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 5571, 25863, }, { 23163, 30168, }, },
},
            new Int16MArrayD2E1M
{
    Id = 138,
    Value = 
new System.Int16[,] { { 11494, 3386, }, { 5539, 10083, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 146,
    Value = 
new System.Int16[,] { { 365, 4616, }, { 20393, 12518, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 145,
    Value = 
new System.Int16[,] { { 1772, 17604, }, { 1114, 26353, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 155,
    Value = 
new System.Int16[,] { { 28956, 10656, }, { 27301, 5112, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 18524, 14609, }, { 9841, 14249, }, },
},
            new Int16MArrayD2E1M
{
    Id = 150,
    Value = 
new System.Int16[,] { { 16870, 18704, }, { 16167, 7985, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 159,
    Value = 
new System.Int16[,] { { 31690, 23311, }, { 23876, 3513, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 24220, 18783, }, { 13968, 15326, }, },
},
            new Int16MArrayD2E1M
{
    Id = 158,
    Value = 
new System.Int16[,] { { 11869, 13183, }, { 7202, 18344, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 162,
    Value = 
new System.Int16[,] { { 12813, 481, }, { 9582, 17468, }, },
    NullableValue = 
new System.Int16[,] { { 3957, 16208, }, { 10766, 19224, }, },
},
    NullableValue = 
new System.Int16[,] { { 8267, 12483, }, { 21193, 6689, }, },
},
            new Int16MArrayD2E1M
{
    Id = 159,
    Value = 
new System.Int16[,] { { 21368, 4528, }, { 26781, 19068, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 168,
    Value = 
new System.Int16[,] { { 8584, 24966, }, { 24843, 28084, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 168,
    Value = 
new System.Int16[,] { { 26491, 19590, }, { 22029, 26715, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 170,
    Value = 
new System.Int16[,] { { 11380, 18799, }, { 9444, 19902, }, },
    NullableValue = 
new System.Int16[,] { { 11246, 29466, }, { 1314, 24040, }, },
},
    NullableValue = 
new System.Int16[,] { { 8181, 6387, }, { 1316, 6012, }, },
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

