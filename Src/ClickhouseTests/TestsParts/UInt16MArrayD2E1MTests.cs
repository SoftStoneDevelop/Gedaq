

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
    internal partial interface IUInt16MArrayMArrayD2
    {
    }
    
    internal partial class UInt16MArrayMArrayD2 : IUInt16MArrayMArrayD2
    {


#region TestData

        private readonly UInt16MArrayD2E1M[] _testData = new UInt16MArrayD2E1M[]
        {
            new UInt16MArrayD2E1M
{
    Id = 5,
    Value = 
new System.UInt16[,] { {
8085,
38445, } },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 6,
    Value = 
new System.UInt16[,] { {
18457,
46224, } },
    NullableValue = 
new System.UInt16[,] { {
48776,
11688, } },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 10,
    Value = 
new System.UInt16[,] { {
13056,
18331, } },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 13,
    Value = 
new System.UInt16[,] { {
15605,
35172, } },
    NullableValue = 
new System.UInt16[,] { {
50351,
28361, } },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 11,
    Value = 
new System.UInt16[,] { {
51269,
60292, } },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 21,
    Value = 
new System.UInt16[,] { {
65055,
30612, } },
    NullableValue = 
new System.UInt16[,] { {
20458,
38730, } },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 16,
    Value = 
new System.UInt16[,] { {
51670,
61116, } },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 29,
    Value = 
new System.UInt16[,] { {
22695,
57078, } },
    NullableValue = 
new System.UInt16[,] { {
40908,
45447, } },
},
    NullableValue = 
new System.UInt16[,] { {
20362,
38691, } },
},
            new UInt16MArrayD2E1M
{
    Id = 19,
    Value = 
new System.UInt16[,] { {
1456,
52501, } },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 33,
    Value = 
new System.UInt16[,] { {
59916,
27569, } },
    NullableValue = 
new System.UInt16[,] { {
47034,
65433, } },
},
    NullableValue = 
new System.UInt16[,] { {
17307,
27150, } },
},
            new UInt16MArrayD2E1M
{
    Id = 27,
    Value = 
new System.UInt16[,] { {
13977,
62570, } },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 36,
    Value = 
new System.UInt16[,] { {
65243,
47596, } },
    NullableValue = 
new System.UInt16[,] { {
65348,
60168, } },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 32,
    Value = 
new System.UInt16[,] { {
23713,
10154, } },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 39,
    Value = 
new System.UInt16[,] { {
33383,
45131, } },
    NullableValue = 
new System.UInt16[,] { {
53432,
11719, } },
},
    NullableValue = 
new System.UInt16[,] { {
43324,
64344, } },
},
            new UInt16MArrayD2E1M
{
    Id = 35,
    Value = 
new System.UInt16[,] { {
59368,
29258, } },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 41,
    Value = 
new System.UInt16[,] { {
37900,
62267, } },
    NullableValue = 
new System.UInt16[,] { {
49028,
59446, } },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 39,
    Value = 
new System.UInt16[,] { {
39987,
28689, } },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 45,
    Value = 
new System.UInt16[,] { {
91,
53672, } },
    NullableValue = 
new System.UInt16[,] { {
29168,
23444, } },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 46,
    Value = 
new System.UInt16[,] { {
32401,
12956, } },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 47,
    Value = 
new System.UInt16[,] { {
51957,
6874, } },
    NullableValue = 
new System.UInt16[,] { {
54070,
47372, } },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 51,
    Value = 
new System.UInt16[,] { {
49930,
6947, } },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 50,
    Value = 
new System.UInt16[,] { {
13710,
35171, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { {
48219,
26869, } },
},
            new UInt16MArrayD2E1M
{
    Id = 54,
    Value = 
new System.UInt16[,] { {
12187,
35072, } },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 57,
    Value = 
new System.UInt16[,] { {
21348,
28672, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { {
37222,
50108, } },
},
            new UInt16MArrayD2E1M
{
    Id = 58,
    Value = 
new System.UInt16[,] { {
56881,
792, } },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 59,
    Value = 
new System.UInt16[,] { {
54143,
54546, } },
    NullableValue = 
new System.UInt16[,] { {
7096,
25561, } },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 66,
    Value = 
new System.UInt16[,] { {
40131,
16571, } },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 60,
    Value = 
new System.UInt16[,] { {
19422,
44633, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 67,
    Value = 
new System.UInt16[,] { {
19886,
56964, } },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 62,
    Value = 
new System.UInt16[,] { {
53973,
35180, } },
    NullableValue = 
new System.UInt16[,] { {
63696,
30562, } },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 76,
    Value = 
new System.UInt16[,] { {
55796,
30463, } },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 64,
    Value = 
new System.UInt16[,] { {
41078,
24759, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { {
1251,
10254, } },
},
            new UInt16MArrayD2E1M
{
    Id = 81,
    Value = 
new System.UInt16[,] { {
7387,
30027, } },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 67,
    Value = 
new System.UInt16[,] { {
18789,
1567, } },
    NullableValue = 
new System.UInt16[,] { {
2231,
48628, } },
},
    NullableValue = 
new System.UInt16[,] { {
8223,
26567, } },
},
            new UInt16MArrayD2E1M
{
    Id = 84,
    Value = 
new System.UInt16[,] { {
8427,
12776, } },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 76,
    Value = 
new System.UInt16[,] { {
28408,
27571, } },
    NullableValue = 
new System.UInt16[,] { {
16423,
14604, } },
},
    NullableValue = 
new System.UInt16[,] { {
49538,
36631, } },
},
            new UInt16MArrayD2E1M
{
    Id = 91,
    Value = 
new System.UInt16[,] { {
61345,
12559, } },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 82,
    Value = 
new System.UInt16[,] { {
41643,
37921, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { {
57424,
11958, } },
},
            new UInt16MArrayD2E1M
{
    Id = 98,
    Value = 
new System.UInt16[,] { {
30802,
21838, } },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 87,
    Value = 
new System.UInt16[,] { {
15260,
1673, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { {
19087,
9837, } },
},
            new UInt16MArrayD2E1M
{
    Id = 104,
    Value = 
new System.UInt16[,] { {
4410,
14182, } },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 92,
    Value = 
new System.UInt16[,] { {
28258,
45736, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 113,
    Value = 
new System.UInt16[,] { {
21639,
1014, } },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 100,
    Value = 
new System.UInt16[,] { {
38915,
35383, } },
    NullableValue = 
new System.UInt16[,] { {
27264,
39296, } },
},
    NullableValue = 
new System.UInt16[,] { {
61381,
51047, } },
},
            new UInt16MArrayD2E1M
{
    Id = 115,
    Value = 
new System.UInt16[,] { {
40107,
16587, } },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 107,
    Value = 
new System.UInt16[,] { {
48211,
17255, } },
    NullableValue = 
new System.UInt16[,] { {
21966,
23826, } },
},
    NullableValue = 
new System.UInt16[,] { {
42753,
57306, } },
},
            new UInt16MArrayD2E1M
{
    Id = 121,
    Value = 
new System.UInt16[,] { {
62467,
40683, } },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 116,
    Value = 
new System.UInt16[,] { {
11204,
36283, } },
    NullableValue = 
new System.UInt16[,] { {
12252,
48386, } },
},
    NullableValue = 
new System.UInt16[,] { {
1974,
64093, } },
},
            new UInt16MArrayD2E1M
{
    Id = 128,
    Value = 
new System.UInt16[,] { {
1094,
11946, } },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 123,
    Value = 
new System.UInt16[,] { {
24908,
6740, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { {
12447,
4461, } },
},
            new UInt16MArrayD2E1M
{
    Id = 130,
    Value = 
new System.UInt16[,] { {
16504,
43138, } },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 124,
    Value = 
new System.UInt16[,] { {
20963,
57478, } },
    NullableValue = 
new System.UInt16[,] { {
59687,
64693, } },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 135,
    Value = 
new System.UInt16[,] { {
42022,
59089, } },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 130,
    Value = 
new System.UInt16[,] { {
26316,
56910, } },
    NullableValue = 
new System.UInt16[,] { {
920,
20230, } },
},
    NullableValue = 
new System.UInt16[,] { {
34382,
53746, } },
},
            new UInt16MArrayD2E1M
{
    Id = 138,
    Value = 
new System.UInt16[,] { {
24255,
4532, } },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 136,
    Value = 
new System.UInt16[,] { {
32137,
11765, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 140,
    Value = 
new System.UInt16[,] { {
37605,
28400, } },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 143,
    Value = 
new System.UInt16[,] { {
59759,
61784, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 141,
    Value = 
new System.UInt16[,] { {
65263,
10490, } },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 149,
    Value = 
new System.UInt16[,] { {
36872,
51152, } },
    NullableValue = 
new System.UInt16[,] { {
61226,
7195, } },
},
    NullableValue = 
new System.UInt16[,] { {
49330,
41708, } },
},
            new UInt16MArrayD2E1M
{
    Id = 147,
    Value = 
new System.UInt16[,] { {
32557,
43695, } },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 151,
    Value = 
new System.UInt16[,] { {
26890,
57197, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { {
8204,
9342, } },
},
            new UInt16MArrayD2E1M
{
    Id = 149,
    Value = 
new System.UInt16[,] { {
15141,
21025, } },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 157,
    Value = 
new System.UInt16[,] { {
8605,
16286, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 152,
    Value = 
new System.UInt16[,] { {
59828,
44305, } },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 158,
    Value = 
new System.UInt16[,] { {
11616,
34675, } },
    NullableValue = 
new System.UInt16[,] { {
51269,
57868, } },
},
    NullableValue = 
new System.UInt16[,] { {
1447,
55408, } },
},
            new UInt16MArrayD2E1M
{
    Id = 161,
    Value = 
new System.UInt16[,] { {
1959,
45776, } },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 164,
    Value = 
new System.UInt16[,] { {
38050,
9271, } },
    NullableValue = 
new System.UInt16[,] { {
27036,
10908, } },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 168,
    Value = 
new System.UInt16[,] { {
55720,
37761, } },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 173,
    Value = 
new System.UInt16[,] { {
27389,
62108, } },
    NullableValue = 
new System.UInt16[,] { {
21332,
64355, } },
},
    NullableValue = 
new System.UInt16[,] { {
6949,
4157, } },
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.uint16marrayd2e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Array(UInt16))}, 
    {mi_id:Int32},
    {mi_value:Array(Array(UInt16))}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16MArrayMArrayD2)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt16[,]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt16[,]), 
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
                    await ((IUInt16MArrayMArrayD2)this).InsertModelDbConnectionAsync(
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
                     ((IUInt16MArrayMArrayD2)this).InsertModelDbConnection(
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
FROM gedaqtests.uint16marrayd2e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt16MArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16MArrayMArrayD2)),
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
                    var models = await ((IUInt16MArrayMArrayD2)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt16MArrayD2E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IUInt16MArrayMArrayD2)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt16MArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

