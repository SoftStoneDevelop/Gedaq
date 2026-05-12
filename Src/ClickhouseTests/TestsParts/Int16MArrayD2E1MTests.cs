

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
    Id = 7,
    Value = 
new System.Int16[,] { { 4555, 29512, }, { 16541, 21948, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 2,
    Value = 
new System.Int16[,] { { 19730, 21937, }, { 122, 2960, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 16,
    Value = 
new System.Int16[,] { { 10270, 20303, }, { 16218, 30899, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 6,
    Value = 
new System.Int16[,] { { 28761, 19112, }, { 28010, 12310, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 9656, 32608, }, { 23324, 415, }, },
},
            new Int16MArrayD2E1M
{
    Id = 20,
    Value = 
new System.Int16[,] { { 26403, 7320, }, { 26460, 26216, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 11,
    Value = 
new System.Int16[,] { { 24752, 30776, }, { 27074, 4666, }, },
    NullableValue = 
new System.Int16[,] { { 31648, 31397, }, { 6205, 15944, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 28,
    Value = 
new System.Int16[,] { { 32714, 11587, }, { 26645, 23749, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 16,
    Value = 
new System.Int16[,] { { 8337, 20365, }, { 30490, 13203, }, },
    NullableValue = 
new System.Int16[,] { { 5695, 18049, }, { 1615, 5732, }, },
},
    NullableValue = 
new System.Int16[,] { { 26364, 12805, }, { 16463, 6155, }, },
},
            new Int16MArrayD2E1M
{
    Id = 36,
    Value = 
new System.Int16[,] { { 6113, 7545, }, { 25062, 23303, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 17,
    Value = 
new System.Int16[,] { { 9006, 10271, }, { 9395, 23401, }, },
    NullableValue = 
new System.Int16[,] { { 6039, 32176, }, { 32755, 16210, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 40,
    Value = 
new System.Int16[,] { { 5422, 30872, }, { 22101, 16215, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 21,
    Value = 
new System.Int16[,] { { 6378, 3521, }, { 23220, 29894, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 14318, 20768, }, { 21036, 29011, }, },
},
            new Int16MArrayD2E1M
{
    Id = 49,
    Value = 
new System.Int16[,] { { 2417, 18217, }, { 16214, 24164, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 25,
    Value = 
new System.Int16[,] { { 25593, 2614, }, { 18781, 10420, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 32401, 994, }, { 5486, 23939, }, },
},
            new Int16MArrayD2E1M
{
    Id = 52,
    Value = 
new System.Int16[,] { { 17217, 7740, }, { 12964, 7599, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 33,
    Value = 
new System.Int16[,] { { 13686, 26037, }, { 18687, 3743, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 57,
    Value = 
new System.Int16[,] { { 24583, 20677, }, { 11709, 14427, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 35,
    Value = 
new System.Int16[,] { { 19602, 21222, }, { 7645, 20711, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 64,
    Value = 
new System.Int16[,] { { 29549, 15494, }, { 8851, 9560, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 40,
    Value = 
new System.Int16[,] { { 15830, 7368, }, { 7284, 204, }, },
    NullableValue = 
new System.Int16[,] { { 16354, 15875, }, { 11818, 13794, }, },
},
    NullableValue = 
new System.Int16[,] { { 15198, 10348, }, { 396, 22868, }, },
},
            new Int16MArrayD2E1M
{
    Id = 67,
    Value = 
new System.Int16[,] { { 6269, 25360, }, { 9460, 3755, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 49,
    Value = 
new System.Int16[,] { { 19202, 23016, }, { 1573, 25560, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 74,
    Value = 
new System.Int16[,] { { 28499, 24466, }, { 30257, 7336, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 57,
    Value = 
new System.Int16[,] { { 13900, 12724, }, { 18182, 18439, }, },
    NullableValue = 
new System.Int16[,] { { 1060, 31532, }, { 4927, 6577, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 80,
    Value = 
new System.Int16[,] { { 18676, 9202, }, { 32266, 817, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 66,
    Value = 
new System.Int16[,] { { 4574, 8410, }, { 12972, 26331, }, },
    NullableValue = 
new System.Int16[,] { { 185, 22628, }, { 13699, 10516, }, },
},
    NullableValue = 
new System.Int16[,] { { 18317, 11855, }, { 8726, 3905, }, },
},
            new Int16MArrayD2E1M
{
    Id = 88,
    Value = 
new System.Int16[,] { { 17400, 8834, }, { 6727, 28530, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 74,
    Value = 
new System.Int16[,] { { 6894, 8972, }, { 12068, 12069, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 25718, 940, }, { 3139, 15191, }, },
},
            new Int16MArrayD2E1M
{
    Id = 89,
    Value = 
new System.Int16[,] { { 5844, 4569, }, { 8078, 8513, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 79,
    Value = 
new System.Int16[,] { { 18226, 22651, }, { 4782, 17843, }, },
    NullableValue = 
new System.Int16[,] { { 27249, 7698, }, { 26499, 16032, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 92,
    Value = 
new System.Int16[,] { { 28071, 15145, }, { 26973, 1566, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 84,
    Value = 
new System.Int16[,] { { 28372, 20617, }, { 15734, 20181, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 31068, 24843, }, { 20889, 2006, }, },
},
            new Int16MArrayD2E1M
{
    Id = 99,
    Value = 
new System.Int16[,] { { 30253, 24003, }, { 9288, 1558, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 91,
    Value = 
new System.Int16[,] { { 30585, 5522, }, { 12288, 18348, }, },
    NullableValue = 
new System.Int16[,] { { 17750, 24921, }, { 18012, 7362, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 104,
    Value = 
new System.Int16[,] { { 15640, 24580, }, { 30418, 1533, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 94,
    Value = 
new System.Int16[,] { { 27229, 13341, }, { 15520, 22619, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 111,
    Value = 
new System.Int16[,] { { 26019, 18248, }, { 20050, 32422, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 100,
    Value = 
new System.Int16[,] { { 2685, 7973, }, { 9972, 24429, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 119,
    Value = 
new System.Int16[,] { { 15775, 8422, }, { 24863, 13735, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 104,
    Value = 
new System.Int16[,] { { 9577, 24586, }, { 5177, 18649, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 10474, 3039, }, { 9902, 16322, }, },
},
            new Int16MArrayD2E1M
{
    Id = 127,
    Value = 
new System.Int16[,] { { 24895, 16978, }, { 14339, 13459, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 110,
    Value = 
new System.Int16[,] { { 23545, 7826, }, { 4302, 21621, }, },
    NullableValue = 
new System.Int16[,] { { 20223, 20044, }, { 1719, 28489, }, },
},
    NullableValue = 
new System.Int16[,] { { 23394, 7911, }, { 15376, 23912, }, },
},
            new Int16MArrayD2E1M
{
    Id = 129,
    Value = 
new System.Int16[,] { { 3726, 14512, }, { 17371, 7991, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 119,
    Value = 
new System.Int16[,] { { 31077, 15523, }, { 30636, 26894, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 130,
    Value = 
new System.Int16[,] { { 11868, 25660, }, { 12741, 13869, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 126,
    Value = 
new System.Int16[,] { { 22292, 25493, }, { 2652, 31232, }, },
    NullableValue = 
new System.Int16[,] { { 20232, 28257, }, { 27771, 3251, }, },
},
    NullableValue = 
new System.Int16[,] { { 741, 19104, }, { 24457, 3493, }, },
},
            new Int16MArrayD2E1M
{
    Id = 139,
    Value = 
new System.Int16[,] { { 27209, 22440, }, { 30805, 507, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 128,
    Value = 
new System.Int16[,] { { 18978, 26087, }, { 27517, 18620, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 148,
    Value = 
new System.Int16[,] { { 17820, 24423, }, { 14338, 26792, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 136,
    Value = 
new System.Int16[,] { { 12551, 5685, }, { 14352, 4814, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 28596, 1043, }, { 27118, 17961, }, },
},
            new Int16MArrayD2E1M
{
    Id = 152,
    Value = 
new System.Int16[,] { { 5154, 19959, }, { 4574, 919, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 137,
    Value = 
new System.Int16[,] { { 7412, 17004, }, { 21759, 12573, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 32200, 23456, }, { 14497, 24879, }, },
},
            new Int16MArrayD2E1M
{
    Id = 156,
    Value = 
new System.Int16[,] { { 412, 18972, }, { 23729, 14767, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 145,
    Value = 
new System.Int16[,] { { 8709, 16391, }, { 16009, 30345, }, },
    NullableValue = 
new System.Int16[,] { { 29594, 28814, }, { 30053, 9638, }, },
},
    NullableValue = 
new System.Int16[,] { { 23273, 31286, }, { 28507, 11668, }, },
},
            new Int16MArrayD2E1M
{
    Id = 164,
    Value = 
new System.Int16[,] { { 10560, 12971, }, { 12862, 4776, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 151,
    Value = 
new System.Int16[,] { { 28988, 6289, }, { 3602, 4144, }, },
    NullableValue = 
new System.Int16[,] { { 9797, 4873, }, { 25526, 23993, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 166,
    Value = 
new System.Int16[,] { { 9593, 5769, }, { 16463, 10457, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 157,
    Value = 
new System.Int16[,] { { 13446, 20617, }, { 2936, 25302, }, },
    NullableValue = 
new System.Int16[,] { { 1936, 7621, }, { 2172, 9559, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 168,
    Value = 
new System.Int16[,] { { 745, 15443, }, { 6490, 18754, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 166,
    Value = 
new System.Int16[,] { { 3496, 11813, }, { 31109, 17000, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 20011, 6091, }, { 21293, 17818, }, },
},
            new Int16MArrayD2E1M
{
    Id = 177,
    Value = 
new System.Int16[,] { { 24155, 22826, }, { 7932, 16791, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 167,
    Value = 
new System.Int16[,] { { 18424, 2182, }, { 19974, 23207, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 21452, 4460, }, { 3358, 30507, }, },
},
            new Int16MArrayD2E1M
{
    Id = 180,
    Value = 
new System.Int16[,] { { 17716, 480, }, { 27236, 885, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 171,
    Value = 
new System.Int16[,] { { 5829, 14527, }, { 12316, 3034, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 182,
    Value = 
new System.Int16[,] { { 758, 16510, }, { 15706, 18305, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 180,
    Value = 
new System.Int16[,] { { 7672, 25369, }, { 32247, 2945, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 1799, 28556, }, { 19019, 9335, }, },
},
            new Int16MArrayD2E1M
{
    Id = 190,
    Value = 
new System.Int16[,] { { 16242, 27810, }, { 12499, 30080, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 181,
    Value = 
new System.Int16[,] { { 14924, 7286, }, { 3716, 13331, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 196,
    Value = 
new System.Int16[,] { { 15367, 25350, }, { 21852, 7556, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 183,
    Value = 
new System.Int16[,] { { 31355, 16127, }, { 2602, 31558, }, },
    NullableValue = 
new System.Int16[,] { { 12063, 20932, }, { 15790, 23331, }, },
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

