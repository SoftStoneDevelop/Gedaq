

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
    internal partial interface IInt16MArrayArrayArrayInt16
    {
    }
    
    internal partial class Int16MArrayArrayArrayInt16 : IInt16MArrayArrayArrayInt16
    {


#region TestData

        private readonly Int16ArrayArrayInt16E1M[] _testData = new Int16ArrayArrayInt16E1M[]
        {
            new Int16ArrayArrayInt16E1M
{
    Id = 8,
    Value = 
new System.Int16[,] { {
21334,
13518, } },
    ModelInner = new Int16ArrayArrayInt161MI
{
    Id = 7,
    Value = 
new System.Int16[,] { {
21780,
9109, } },
    NullableValue = 
new System.Int16[,] { {
19108,
12783, } },
},
    NullableValue = 
new System.Int16[,] { {
27413,
26956, } },
},
            new Int16ArrayArrayInt16E1M
{
    Id = 17,
    Value = 
new System.Int16[,] { {
4351,
19020, } },
    ModelInner = new Int16ArrayArrayInt161MI
{
    Id = 10,
    Value = 
new System.Int16[,] { {
5931,
11884, } },
    NullableValue = 
new System.Int16[,] { {
25431,
14308, } },
},
    NullableValue = null,
},
            new Int16ArrayArrayInt16E1M
{
    Id = 24,
    Value = 
new System.Int16[,] { {
6583,
31420, } },
    ModelInner = new Int16ArrayArrayInt161MI
{
    Id = 19,
    Value = 
new System.Int16[,] { {
5713,
31109, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { {
29753,
10256, } },
},
            new Int16ArrayArrayInt16E1M
{
    Id = 32,
    Value = 
new System.Int16[,] { {
5147,
22615, } },
    ModelInner = new Int16ArrayArrayInt161MI
{
    Id = 25,
    Value = 
new System.Int16[,] { {
27379,
19548, } },
    NullableValue = 
new System.Int16[,] { {
13691,
17235, } },
},
    NullableValue = 
new System.Int16[,] { {
27769,
23792, } },
},
            new Int16ArrayArrayInt16E1M
{
    Id = 35,
    Value = 
new System.Int16[,] { {
3960,
6031, } },
    ModelInner = new Int16ArrayArrayInt161MI
{
    Id = 32,
    Value = 
new System.Int16[,] { {
4875,
31046, } },
    NullableValue = 
new System.Int16[,] { {
26460,
24112, } },
},
    NullableValue = null,
},
            new Int16ArrayArrayInt16E1M
{
    Id = 36,
    Value = 
new System.Int16[,] { {
32697,
10691, } },
    ModelInner = new Int16ArrayArrayInt161MI
{
    Id = 38,
    Value = 
new System.Int16[,] { {
847,
1180, } },
    NullableValue = 
new System.Int16[,] { {
26432,
16716, } },
},
    NullableValue = null,
},
            new Int16ArrayArrayInt16E1M
{
    Id = 43,
    Value = 
new System.Int16[,] { {
28172,
32361, } },
    ModelInner = new Int16ArrayArrayInt161MI
{
    Id = 42,
    Value = 
new System.Int16[,] { {
20277,
12021, } },
    NullableValue = 
new System.Int16[,] { {
5388,
1292, } },
},
    NullableValue = null,
},
            new Int16ArrayArrayInt16E1M
{
    Id = 46,
    Value = 
new System.Int16[,] { {
15825,
3165, } },
    ModelInner = new Int16ArrayArrayInt161MI
{
    Id = 45,
    Value = 
new System.Int16[,] { {
9150,
12183, } },
    NullableValue = 
new System.Int16[,] { {
16207,
27228, } },
},
    NullableValue = 
new System.Int16[,] { {
19324,
1088, } },
},
            new Int16ArrayArrayInt16E1M
{
    Id = 51,
    Value = 
new System.Int16[,] { {
30726,
31574, } },
    ModelInner = new Int16ArrayArrayInt161MI
{
    Id = 52,
    Value = 
new System.Int16[,] { {
6337,
19848, } },
    NullableValue = 
new System.Int16[,] { {
8965,
4972, } },
},
    NullableValue = 
new System.Int16[,] { {
837,
20226, } },
},
            new Int16ArrayArrayInt16E1M
{
    Id = 60,
    Value = 
new System.Int16[,] { {
12636,
30120, } },
    ModelInner = new Int16ArrayArrayInt161MI
{
    Id = 55,
    Value = 
new System.Int16[,] { {
18249,
31088, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16ArrayArrayInt16E1M
{
    Id = 66,
    Value = 
new System.Int16[,] { {
6045,
31520, } },
    ModelInner = new Int16ArrayArrayInt161MI
{
    Id = 59,
    Value = 
new System.Int16[,] { {
29861,
20802, } },
    NullableValue = 
new System.Int16[,] { {
17073,
21047, } },
},
    NullableValue = null,
},
            new Int16ArrayArrayInt16E1M
{
    Id = 74,
    Value = 
new System.Int16[,] { {
31707,
21571, } },
    ModelInner = new Int16ArrayArrayInt161MI
{
    Id = 65,
    Value = 
new System.Int16[,] { {
2008,
26244, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { {
4018,
24809, } },
},
            new Int16ArrayArrayInt16E1M
{
    Id = 82,
    Value = 
new System.Int16[,] { {
22477,
8523, } },
    ModelInner = new Int16ArrayArrayInt161MI
{
    Id = 66,
    Value = 
new System.Int16[,] { {
15424,
5409, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16ArrayArrayInt16E1M
{
    Id = 87,
    Value = 
new System.Int16[,] { {
7105,
12127, } },
    ModelInner = new Int16ArrayArrayInt161MI
{
    Id = 68,
    Value = 
new System.Int16[,] { {
8635,
2452, } },
    NullableValue = 
new System.Int16[,] { {
4507,
30876, } },
},
    NullableValue = 
new System.Int16[,] { {
20529,
1854, } },
},
            new Int16ArrayArrayInt16E1M
{
    Id = 91,
    Value = 
new System.Int16[,] { {
28079,
12685, } },
    ModelInner = new Int16ArrayArrayInt161MI
{
    Id = 76,
    Value = 
new System.Int16[,] { {
10793,
8300, } },
    NullableValue = 
new System.Int16[,] { {
31329,
21734, } },
},
    NullableValue = null,
},
            new Int16ArrayArrayInt16E1M
{
    Id = 97,
    Value = 
new System.Int16[,] { {
2897,
30619, } },
    ModelInner = new Int16ArrayArrayInt161MI
{
    Id = 78,
    Value = 
new System.Int16[,] { {
15268,
29061, } },
    NullableValue = 
new System.Int16[,] { {
30616,
23075, } },
},
    NullableValue = 
new System.Int16[,] { {
8730,
21594, } },
},
            new Int16ArrayArrayInt16E1M
{
    Id = 100,
    Value = 
new System.Int16[,] { {
10791,
13225, } },
    ModelInner = new Int16ArrayArrayInt161MI
{
    Id = 86,
    Value = 
new System.Int16[,] { {
20460,
13621, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { {
20279,
4968, } },
},
            new Int16ArrayArrayInt16E1M
{
    Id = 106,
    Value = 
new System.Int16[,] { {
16422,
31416, } },
    ModelInner = new Int16ArrayArrayInt161MI
{
    Id = 93,
    Value = 
new System.Int16[,] { {
8504,
15299, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { {
32416,
11062, } },
},
            new Int16ArrayArrayInt16E1M
{
    Id = 109,
    Value = 
new System.Int16[,] { {
32671,
13333, } },
    ModelInner = new Int16ArrayArrayInt161MI
{
    Id = 101,
    Value = 
new System.Int16[,] { {
3795,
30761, } },
    NullableValue = 
new System.Int16[,] { {
24114,
1916, } },
},
    NullableValue = 
new System.Int16[,] { {
27900,
30796, } },
},
            new Int16ArrayArrayInt16E1M
{
    Id = 110,
    Value = 
new System.Int16[,] { {
30471,
12043, } },
    ModelInner = new Int16ArrayArrayInt161MI
{
    Id = 110,
    Value = 
new System.Int16[,] { {
9703,
12586, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { {
4795,
7932, } },
},
            new Int16ArrayArrayInt16E1M
{
    Id = 113,
    Value = 
new System.Int16[,] { {
5270,
21336, } },
    ModelInner = new Int16ArrayArrayInt161MI
{
    Id = 117,
    Value = 
new System.Int16[,] { {
27855,
87, } },
    NullableValue = 
new System.Int16[,] { {
19668,
30246, } },
},
    NullableValue = 
new System.Int16[,] { {
2458,
14050, } },
},
            new Int16ArrayArrayInt16E1M
{
    Id = 117,
    Value = 
new System.Int16[,] { {
14735,
12938, } },
    ModelInner = new Int16ArrayArrayInt161MI
{
    Id = 126,
    Value = 
new System.Int16[,] { {
18336,
5465, } },
    NullableValue = 
new System.Int16[,] { {
16863,
28183, } },
},
    NullableValue = null,
},
            new Int16ArrayArrayInt16E1M
{
    Id = 125,
    Value = 
new System.Int16[,] { {
22196,
23018, } },
    ModelInner = new Int16ArrayArrayInt161MI
{
    Id = 135,
    Value = 
new System.Int16[,] { {
30123,
20203, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16ArrayArrayInt16E1M
{
    Id = 133,
    Value = 
new System.Int16[,] { {
15961,
7002, } },
    ModelInner = new Int16ArrayArrayInt161MI
{
    Id = 139,
    Value = 
new System.Int16[,] { {
14643,
23144, } },
    NullableValue = 
new System.Int16[,] { {
13753,
733, } },
},
    NullableValue = null,
},
            new Int16ArrayArrayInt16E1M
{
    Id = 141,
    Value = 
new System.Int16[,] { {
27375,
31156, } },
    ModelInner = new Int16ArrayArrayInt161MI
{
    Id = 148,
    Value = 
new System.Int16[,] { {
28950,
3748, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16ArrayArrayInt16E1M
{
    Id = 145,
    Value = 
new System.Int16[,] { {
22124,
3098, } },
    ModelInner = new Int16ArrayArrayInt161MI
{
    Id = 152,
    Value = 
new System.Int16[,] { {
19974,
7699, } },
    NullableValue = 
new System.Int16[,] { {
6976,
18879, } },
},
    NullableValue = 
new System.Int16[,] { {
649,
5967, } },
},
            new Int16ArrayArrayInt16E1M
{
    Id = 151,
    Value = 
new System.Int16[,] { {
3134,
15042, } },
    ModelInner = new Int16ArrayArrayInt161MI
{
    Id = 158,
    Value = 
new System.Int16[,] { {
2852,
11159, } },
    NullableValue = 
new System.Int16[,] { {
16859,
2533, } },
},
    NullableValue = 
new System.Int16[,] { {
29353,
1673, } },
},
            new Int16ArrayArrayInt16E1M
{
    Id = 152,
    Value = 
new System.Int16[,] { {
21473,
6020, } },
    ModelInner = new Int16ArrayArrayInt161MI
{
    Id = 159,
    Value = 
new System.Int16[,] { {
30032,
14930, } },
    NullableValue = 
new System.Int16[,] { {
30388,
20883, } },
},
    NullableValue = null,
},
            new Int16ArrayArrayInt16E1M
{
    Id = 154,
    Value = 
new System.Int16[,] { {
5677,
22228, } },
    ModelInner = new Int16ArrayArrayInt161MI
{
    Id = 163,
    Value = 
new System.Int16[,] { {
188,
9133, } },
    NullableValue = 
new System.Int16[,] { {
19432,
18772, } },
},
    NullableValue = 
new System.Int16[,] { {
415,
23723, } },
},
            new Int16ArrayArrayInt16E1M
{
    Id = 162,
    Value = 
new System.Int16[,] { {
7707,
12361, } },
    ModelInner = new Int16ArrayArrayInt161MI
{
    Id = 164,
    Value = 
new System.Int16[,] { {
9016,
5478, } },
    NullableValue = 
new System.Int16[,] { {
25856,
8770, } },
},
    NullableValue = 
new System.Int16[,] { {
9549,
16193, } },
},
            new Int16ArrayArrayInt16E1M
{
    Id = 168,
    Value = 
new System.Int16[,] { {
32261,
23023, } },
    ModelInner = new Int16ArrayArrayInt161MI
{
    Id = 166,
    Value = 
new System.Int16[,] { {
20000,
26500, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { {
17332,
11185, } },
},
            new Int16ArrayArrayInt16E1M
{
    Id = 171,
    Value = 
new System.Int16[,] { {
7562,
751, } },
    ModelInner = new Int16ArrayArrayInt161MI
{
    Id = 170,
    Value = 
new System.Int16[,] { {
20633,
24622, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { {
25231,
1495, } },
},
            new Int16ArrayArrayInt16E1M
{
    Id = 177,
    Value = 
new System.Int16[,] { {
3101,
1992, } },
    ModelInner = new Int16ArrayArrayInt161MI
{
    Id = 179,
    Value = 
new System.Int16[,] { {
1371,
13445, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { {
30067,
4912, } },
},
            new Int16ArrayArrayInt16E1M
{
    Id = 178,
    Value = 
new System.Int16[,] { {
17740,
19167, } },
    ModelInner = new Int16ArrayArrayInt161MI
{
    Id = 183,
    Value = 
new System.Int16[,] { {
29954,
19155, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { {
9989,
5800, } },
},
            new Int16ArrayArrayInt16E1M
{
    Id = 185,
    Value = 
new System.Int16[,] { {
31933,
6033, } },
    ModelInner = new Int16ArrayArrayInt161MI
{
    Id = 188,
    Value = 
new System.Int16[,] { {
7909,
25252, } },
    NullableValue = 
new System.Int16[,] { {
18056,
2642, } },
},
    NullableValue = 
new System.Int16[,] { {
24321,
7308, } },
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int16arrayarrayint16e1m(
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
            asPartInterface: typeof(IInt16MArrayArrayArrayInt16)),
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
                    await ((IInt16MArrayArrayArrayInt16)this).InsertModelDbConnectionAsync(
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
                     ((IInt16MArrayArrayArrayInt16)this).InsertModelDbConnection(
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
FROM gedaqtests.int16arrayarrayint16e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int16ArrayArrayInt16E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArrayArrayArrayInt16)),
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
                    var models = await ((IInt16MArrayArrayArrayInt16)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int16ArrayArrayInt16E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IInt16MArrayArrayArrayInt16)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int16ArrayArrayInt16E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

