

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
    Id = 1,
    Value = 
new System.Int16[,] { {
20870,
15551, } },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 6,
    Value = 
new System.Int16[,] { {
11189,
12665, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { {
152,
4665, } },
},
            new Int16MArrayD2E1M
{
    Id = 2,
    Value = 
new System.Int16[,] { {
31798,
28837, } },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 7,
    Value = 
new System.Int16[,] { {
19585,
24905, } },
    NullableValue = 
new System.Int16[,] { {
15758,
29480, } },
},
    NullableValue = 
new System.Int16[,] { {
2209,
277, } },
},
            new Int16MArrayD2E1M
{
    Id = 10,
    Value = 
new System.Int16[,] { {
27579,
17779, } },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 11,
    Value = 
new System.Int16[,] { {
12598,
32684, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 11,
    Value = 
new System.Int16[,] { {
14211,
1008, } },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 20,
    Value = 
new System.Int16[,] { {
19163,
27716, } },
    NullableValue = 
new System.Int16[,] { {
2199,
7267, } },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 18,
    Value = 
new System.Int16[,] { {
31534,
27811, } },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 27,
    Value = 
new System.Int16[,] { {
26466,
13418, } },
    NullableValue = 
new System.Int16[,] { {
20767,
14425, } },
},
    NullableValue = 
new System.Int16[,] { {
24244,
30962, } },
},
            new Int16MArrayD2E1M
{
    Id = 23,
    Value = 
new System.Int16[,] { {
21862,
12067, } },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 29,
    Value = 
new System.Int16[,] { {
29601,
12448, } },
    NullableValue = 
new System.Int16[,] { {
32505,
27235, } },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 28,
    Value = 
new System.Int16[,] { {
19796,
6924, } },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 35,
    Value = 
new System.Int16[,] { {
8199,
19746, } },
    NullableValue = 
new System.Int16[,] { {
18131,
25638, } },
},
    NullableValue = 
new System.Int16[,] { {
21433,
29467, } },
},
            new Int16MArrayD2E1M
{
    Id = 37,
    Value = 
new System.Int16[,] { {
20373,
17245, } },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 41,
    Value = 
new System.Int16[,] { {
25243,
3719, } },
    NullableValue = 
new System.Int16[,] { {
15382,
8243, } },
},
    NullableValue = 
new System.Int16[,] { {
8594,
16012, } },
},
            new Int16MArrayD2E1M
{
    Id = 44,
    Value = 
new System.Int16[,] { {
32376,
19702, } },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 49,
    Value = 
new System.Int16[,] { {
28875,
16093, } },
    NullableValue = 
new System.Int16[,] { {
25125,
29513, } },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 46,
    Value = 
new System.Int16[,] { {
21738,
13913, } },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 55,
    Value = 
new System.Int16[,] { {
27608,
7610, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 53,
    Value = 
new System.Int16[,] { {
27419,
1339, } },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 60,
    Value = 
new System.Int16[,] { {
27170,
16344, } },
    NullableValue = 
new System.Int16[,] { {
29915,
15253, } },
},
    NullableValue = 
new System.Int16[,] { {
26250,
4052, } },
},
            new Int16MArrayD2E1M
{
    Id = 58,
    Value = 
new System.Int16[,] { {
30723,
32427, } },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 69,
    Value = 
new System.Int16[,] { {
15605,
31226, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 60,
    Value = 
new System.Int16[,] { {
9970,
22214, } },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 73,
    Value = 
new System.Int16[,] { {
14576,
15893, } },
    NullableValue = 
new System.Int16[,] { {
29935,
24218, } },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 69,
    Value = 
new System.Int16[,] { {
312,
10383, } },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 77,
    Value = 
new System.Int16[,] { {
28227,
12416, } },
    NullableValue = 
new System.Int16[,] { {
17983,
22998, } },
},
    NullableValue = 
new System.Int16[,] { {
21133,
31318, } },
},
            new Int16MArrayD2E1M
{
    Id = 77,
    Value = 
new System.Int16[,] { {
13131,
30473, } },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 81,
    Value = 
new System.Int16[,] { {
1364,
15488, } },
    NullableValue = 
new System.Int16[,] { {
27128,
19853, } },
},
    NullableValue = 
new System.Int16[,] { {
3214,
17255, } },
},
            new Int16MArrayD2E1M
{
    Id = 78,
    Value = 
new System.Int16[,] { {
15447,
17154, } },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 90,
    Value = 
new System.Int16[,] { {
27802,
13041, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { {
9069,
28855, } },
},
            new Int16MArrayD2E1M
{
    Id = 82,
    Value = 
new System.Int16[,] { {
12288,
32253, } },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 99,
    Value = 
new System.Int16[,] { {
10095,
1555, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 90,
    Value = 
new System.Int16[,] { {
7742,
18044, } },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 100,
    Value = 
new System.Int16[,] { {
3333,
8259, } },
    NullableValue = 
new System.Int16[,] { {
28193,
10350, } },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 94,
    Value = 
new System.Int16[,] { {
6953,
12208, } },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 109,
    Value = 
new System.Int16[,] { {
7676,
7842, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 99,
    Value = 
new System.Int16[,] { {
22174,
6851, } },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 118,
    Value = 
new System.Int16[,] { {
26010,
20042, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 102,
    Value = 
new System.Int16[,] { {
23069,
3995, } },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 126,
    Value = 
new System.Int16[,] { {
16901,
30876, } },
    NullableValue = 
new System.Int16[,] { {
32676,
343, } },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 111,
    Value = 
new System.Int16[,] { {
9513,
10425, } },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 135,
    Value = 
new System.Int16[,] { {
7500,
17818, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 120,
    Value = 
new System.Int16[,] { {
11175,
7780, } },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 144,
    Value = 
new System.Int16[,] { {
21693,
24439, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 127,
    Value = 
new System.Int16[,] { {
32008,
23019, } },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 147,
    Value = 
new System.Int16[,] { {
16404,
24108, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { {
17975,
7304, } },
},
            new Int16MArrayD2E1M
{
    Id = 134,
    Value = 
new System.Int16[,] { {
32291,
14837, } },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 155,
    Value = 
new System.Int16[,] { {
28792,
16973, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 137,
    Value = 
new System.Int16[,] { {
5743,
30454, } },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 156,
    Value = 
new System.Int16[,] { {
17487,
1729, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 143,
    Value = 
new System.Int16[,] { {
1653,
21083, } },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 163,
    Value = 
new System.Int16[,] { {
10184,
156, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { {
280,
30071, } },
},
            new Int16MArrayD2E1M
{
    Id = 150,
    Value = 
new System.Int16[,] { {
18561,
19716, } },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 165,
    Value = 
new System.Int16[,] { {
10505,
10893, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { {
17127,
19885, } },
},
            new Int16MArrayD2E1M
{
    Id = 154,
    Value = 
new System.Int16[,] { {
12882,
14605, } },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 167,
    Value = 
new System.Int16[,] { {
7237,
30422, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 162,
    Value = 
new System.Int16[,] { {
18098,
6786, } },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 176,
    Value = 
new System.Int16[,] { {
17775,
5585, } },
    NullableValue = 
new System.Int16[,] { {
20381,
16773, } },
},
    NullableValue = 
new System.Int16[,] { {
22299,
20126, } },
},
            new Int16MArrayD2E1M
{
    Id = 170,
    Value = 
new System.Int16[,] { {
8087,
17158, } },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 178,
    Value = 
new System.Int16[,] { {
17696,
4923, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { {
32604,
31098, } },
},
            new Int16MArrayD2E1M
{
    Id = 175,
    Value = 
new System.Int16[,] { {
22488,
22133, } },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 184,
    Value = 
new System.Int16[,] { {
4554,
32660, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { {
6075,
30618, } },
},
            new Int16MArrayD2E1M
{
    Id = 181,
    Value = 
new System.Int16[,] { {
18249,
16960, } },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 187,
    Value = 
new System.Int16[,] { {
2180,
27986, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 182,
    Value = 
new System.Int16[,] { {
17875,
698, } },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 195,
    Value = 
new System.Int16[,] { {
21719,
30189, } },
    NullableValue = 
new System.Int16[,] { {
5145,
5074, } },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 189,
    Value = 
new System.Int16[,] { {
18031,
3514, } },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 202,
    Value = 
new System.Int16[,] { {
19640,
11472, } },
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

