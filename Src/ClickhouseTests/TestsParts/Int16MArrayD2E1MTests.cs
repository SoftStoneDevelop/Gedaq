

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
    Id = 8,
    Value = 
new System.Int16[,] { { 8494, 14326, }, { 9656, 18022, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 8,
    Value = 
new System.Int16[,] { { 311, 7029, }, { 1322, 32053, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 11,
    Value = 
new System.Int16[,] { { 29580, 676, }, { 19051, 10378, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 17,
    Value = 
new System.Int16[,] { { 15842, 12133, }, { 8897, 1643, }, },
    NullableValue = 
new System.Int16[,] { { 25465, 21947, }, { 27953, 31923, }, },
},
    NullableValue = 
new System.Int16[,] { { 1610, 7547, }, { 9718, 30197, }, },
},
            new Int16MArrayD2E1M
{
    Id = 19,
    Value = 
new System.Int16[,] { { 9900, 27147, }, { 9648, 12310, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 25,
    Value = 
new System.Int16[,] { { 29408, 11126, }, { 28867, 13416, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 28,
    Value = 
new System.Int16[,] { { 7329, 1133, }, { 31211, 18483, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 31,
    Value = 
new System.Int16[,] { { 13669, 9890, }, { 6829, 7432, }, },
    NullableValue = 
new System.Int16[,] { { 21595, 7228, }, { 24309, 27904, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 32,
    Value = 
new System.Int16[,] { { 16008, 24853, }, { 4146, 29324, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 39,
    Value = 
new System.Int16[,] { { 24417, 31253, }, { 17649, 22820, }, },
    NullableValue = 
new System.Int16[,] { { 10925, 5131, }, { 7327, 2757, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 40,
    Value = 
new System.Int16[,] { { 310, 3849, }, { 11792, 1762, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 48,
    Value = 
new System.Int16[,] { { 8739, 31685, }, { 6659, 7896, }, },
    NullableValue = 
new System.Int16[,] { { 5547, 18914, }, { 22863, 12403, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 42,
    Value = 
new System.Int16[,] { { 21123, 11227, }, { 21871, 23017, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 49,
    Value = 
new System.Int16[,] { { 22949, 21736, }, { 17669, 20051, }, },
    NullableValue = 
new System.Int16[,] { { 1422, 20358, }, { 28538, 18825, }, },
},
    NullableValue = 
new System.Int16[,] { { 26068, 24273, }, { 876, 25994, }, },
},
            new Int16MArrayD2E1M
{
    Id = 49,
    Value = 
new System.Int16[,] { { 27819, 18449, }, { 20326, 8514, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 58,
    Value = 
new System.Int16[,] { { 17505, 19742, }, { 3443, 12389, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 18156, 28961, }, { 18976, 23312, }, },
},
            new Int16MArrayD2E1M
{
    Id = 53,
    Value = 
new System.Int16[,] { { 15743, 6519, }, { 2242, 23346, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 67,
    Value = 
new System.Int16[,] { { 3010, 17219, }, { 14417, 5416, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 12447, 4235, }, { 5428, 21726, }, },
},
            new Int16MArrayD2E1M
{
    Id = 56,
    Value = 
new System.Int16[,] { { 29693, 18685, }, { 15566, 7564, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 71,
    Value = 
new System.Int16[,] { { 11070, 19114, }, { 2335, 21546, }, },
    NullableValue = 
new System.Int16[,] { { 26134, 20500, }, { 6129, 29507, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 58,
    Value = 
new System.Int16[,] { { 19874, 18788, }, { 7748, 24818, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 76,
    Value = 
new System.Int16[,] { { 23729, 20094, }, { 20771, 4399, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 7839, 2417, }, { 4104, 31554, }, },
},
            new Int16MArrayD2E1M
{
    Id = 63,
    Value = 
new System.Int16[,] { { 18159, 31936, }, { 9063, 11165, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 80,
    Value = 
new System.Int16[,] { { 403, 5532, }, { 18968, 4739, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 29622, 30769, }, { 3255, 24956, }, },
},
            new Int16MArrayD2E1M
{
    Id = 71,
    Value = 
new System.Int16[,] { { 29327, 1942, }, { 28448, 29995, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 83,
    Value = 
new System.Int16[,] { { 3988, 23103, }, { 8129, 30594, }, },
    NullableValue = 
new System.Int16[,] { { 9115, 427, }, { 6003, 5100, }, },
},
    NullableValue = 
new System.Int16[,] { { 10180, 12089, }, { 29073, 9744, }, },
},
            new Int16MArrayD2E1M
{
    Id = 79,
    Value = 
new System.Int16[,] { { 19496, 7863, }, { 10408, 14917, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 90,
    Value = 
new System.Int16[,] { { 5149, 8364, }, { 22598, 10386, }, },
    NullableValue = 
new System.Int16[,] { { 16691, 4396, }, { 10137, 16355, }, },
},
    NullableValue = 
new System.Int16[,] { { 15389, 24959, }, { 19268, 21712, }, },
},
            new Int16MArrayD2E1M
{
    Id = 88,
    Value = 
new System.Int16[,] { { 9408, 15715, }, { 28895, 12065, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 92,
    Value = 
new System.Int16[,] { { 431, 3966, }, { 21199, 9529, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 14462, 30820, }, { 31551, 27955, }, },
},
            new Int16MArrayD2E1M
{
    Id = 96,
    Value = 
new System.Int16[,] { { 25459, 27260, }, { 3211, 25675, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 99,
    Value = 
new System.Int16[,] { { 9651, 101, }, { 14887, 22118, }, },
    NullableValue = 
new System.Int16[,] { { 6184, 22484, }, { 14437, 24611, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 103,
    Value = 
new System.Int16[,] { { 24421, 6170, }, { 12028, 19559, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 105,
    Value = 
new System.Int16[,] { { 19879, 19261, }, { 28355, 1027, }, },
    NullableValue = 
new System.Int16[,] { { 22335, 17737, }, { 23786, 31788, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 112,
    Value = 
new System.Int16[,] { { 28203, 21871, }, { 20688, 29218, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 110,
    Value = 
new System.Int16[,] { { 30431, 10000, }, { 30530, 7062, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 10011, 19665, }, { 14043, 5976, }, },
},
            new Int16MArrayD2E1M
{
    Id = 120,
    Value = 
new System.Int16[,] { { 806, 31311, }, { 30265, 25097, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 117,
    Value = 
new System.Int16[,] { { 22689, 26554, }, { 19268, 30834, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 126,
    Value = 
new System.Int16[,] { { 19866, 13811, }, { 24831, 8601, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 123,
    Value = 
new System.Int16[,] { { 18999, 29324, }, { 8071, 17806, }, },
    NullableValue = 
new System.Int16[,] { { 5307, 24476, }, { 24443, 20403, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 130,
    Value = 
new System.Int16[,] { { 27572, 2621, }, { 2258, 2447, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 126,
    Value = 
new System.Int16[,] { { 25103, 6900, }, { 15643, 10645, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 134,
    Value = 
new System.Int16[,] { { 17755, 11223, }, { 10221, 7417, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 132,
    Value = 
new System.Int16[,] { { 7421, 3444, }, { 24324, 20059, }, },
    NullableValue = 
new System.Int16[,] { { 19942, 4674, }, { 30113, 27435, }, },
},
    NullableValue = 
new System.Int16[,] { { 9519, 31591, }, { 12730, 4591, }, },
},
            new Int16MArrayD2E1M
{
    Id = 139,
    Value = 
new System.Int16[,] { { 9230, 11241, }, { 11872, 5830, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 140,
    Value = 
new System.Int16[,] { { 4552, 11325, }, { 31422, 10768, }, },
    NullableValue = 
new System.Int16[,] { { 4890, 18490, }, { 30134, 15199, }, },
},
    NullableValue = 
new System.Int16[,] { { 28654, 21960, }, { 25971, 5965, }, },
},
            new Int16MArrayD2E1M
{
    Id = 143,
    Value = 
new System.Int16[,] { { 14882, 27570, }, { 4825, 25545, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 143,
    Value = 
new System.Int16[,] { { 8323, 24110, }, { 24422, 14436, }, },
    NullableValue = 
new System.Int16[,] { { 15643, 14304, }, { 5133, 4581, }, },
},
    NullableValue = 
new System.Int16[,] { { 1475, 10424, }, { 10577, 12971, }, },
},
            new Int16MArrayD2E1M
{
    Id = 150,
    Value = 
new System.Int16[,] { { 1436, 26045, }, { 21221, 10041, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 149,
    Value = 
new System.Int16[,] { { 29457, 19339, }, { 12584, 29494, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 155,
    Value = 
new System.Int16[,] { { 23824, 13236, }, { 1113, 2072, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 155,
    Value = 
new System.Int16[,] { { 25602, 5248, }, { 30586, 26071, }, },
    NullableValue = 
new System.Int16[,] { { 20232, 5481, }, { 4226, 20158, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 163,
    Value = 
new System.Int16[,] { { 25693, 25070, }, { 21112, 22851, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 164,
    Value = 
new System.Int16[,] { { 16627, 17515, }, { 27598, 19475, }, },
    NullableValue = 
new System.Int16[,] { { 11191, 27321, }, { 27241, 29724, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 170,
    Value = 
new System.Int16[,] { { 14918, 13143, }, { 2142, 14263, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 167,
    Value = 
new System.Int16[,] { { 21442, 26020, }, { 18394, 7321, }, },
    NullableValue = 
new System.Int16[,] { { 14965, 27005, }, { 11169, 28565, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 177,
    Value = 
new System.Int16[,] { { 8462, 6470, }, { 26668, 20217, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 171,
    Value = 
new System.Int16[,] { { 10296, 5960, }, { 14491, 10804, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 16487, 16924, }, { 7750, 18743, }, },
},
            new Int16MArrayD2E1M
{
    Id = 178,
    Value = 
new System.Int16[,] { { 15464, 19613, }, { 19358, 11223, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 178,
    Value = 
new System.Int16[,] { { 13283, 24530, }, { 2843, 12957, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 26754, 29185, }, { 30828, 4425, }, },
},
            new Int16MArrayD2E1M
{
    Id = 186,
    Value = 
new System.Int16[,] { { 1762, 25643, }, { 28933, 32192, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 182,
    Value = 
new System.Int16[,] { { 1182, 3437, }, { 28632, 5434, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 192,
    Value = 
new System.Int16[,] { { 8073, 9267, }, { 30083, 19314, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 185,
    Value = 
new System.Int16[,] { { 16222, 23389, }, { 6329, 24243, }, },
    NullableValue = 
new System.Int16[,] { { 10826, 29127, }, { 7254, 25213, }, },
},
    NullableValue = 
new System.Int16[,] { { 9539, 15597, }, { 14324, 9717, }, },
},
            new Int16MArrayD2E1M
{
    Id = 194,
    Value = 
new System.Int16[,] { { 30694, 22965, }, { 16693, 26136, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 191,
    Value = 
new System.Int16[,] { { 2554, 6188, }, { 15483, 7397, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 201,
    Value = 
new System.Int16[,] { { 10496, 22571, }, { 21770, 3144, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 198,
    Value = 
new System.Int16[,] { { 6098, 25950, }, { 869, 25410, }, },
    NullableValue = 
new System.Int16[,] { { 20638, 17937, }, { 12732, 26357, }, },
},
    NullableValue = 
new System.Int16[,] { { 19481, 29124, }, { 16200, 23312, }, },
},
            new Int16MArrayD2E1M
{
    Id = 210,
    Value = 
new System.Int16[,] { { 28501, 5666, }, { 20005, 32149, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 206,
    Value = 
new System.Int16[,] { { 6532, 15194, }, { 15859, 21316, }, },
    NullableValue = null,
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

