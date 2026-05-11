

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
    internal partial interface IInt16MArrayArrayInt16
    {
    }
    
    internal partial class Int16MArrayArrayInt16 : IInt16MArrayArrayInt16
    {


#region TestData

        private readonly Int16ArrayInt16E1M[] _testData = new Int16ArrayInt16E1M[]
        {
            new Int16ArrayInt16E1M
{
    Id = 4,
    Value = 
new System.Int16[3]
{
24406,
25749,
207,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 7,
    Value = 
new System.Int16[4]
{
9693,
30377,
14785,
30665,
},
    NullableValue = 
new System.Int16[3]
{
12615,
12565,
206,
},
},
    NullableValue = null,
},
            new Int16ArrayInt16E1M
{
    Id = 7,
    Value = 
new System.Int16[4]
{
19824,
9286,
18041,
22756,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 8,
    Value = 
new System.Int16[4]
{
13142,
18447,
822,
10440,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16ArrayInt16E1M
{
    Id = 8,
    Value = 
new System.Int16[3]
{
18762,
16734,
13417,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 10,
    Value = 
new System.Int16[4]
{
30205,
21895,
22675,
4071,
},
    NullableValue = 
new System.Int16[4]
{
6351,
10819,
7797,
25022,
},
},
    NullableValue = null,
},
            new Int16ArrayInt16E1M
{
    Id = 12,
    Value = 
new System.Int16[3]
{
27415,
11885,
19731,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 12,
    Value = 
new System.Int16[3]
{
11530,
31104,
29712,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16ArrayInt16E1M
{
    Id = 19,
    Value = 
new System.Int16[3]
{
26324,
9187,
16225,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 16,
    Value = 
new System.Int16[4]
{
18992,
28116,
32131,
26211,
},
    NullableValue = 
new System.Int16[3]
{
5083,
27626,
32552,
},
},
    NullableValue = 
new System.Int16[4]
{
23370,
26760,
27547,
25421,
},
},
            new Int16ArrayInt16E1M
{
    Id = 28,
    Value = 
new System.Int16[3]
{
20841,
19293,
23614,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 23,
    Value = 
new System.Int16[4]
{
23249,
23306,
17189,
26579,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
13337,
14144,
4480,
9123,
},
},
            new Int16ArrayInt16E1M
{
    Id = 36,
    Value = 
new System.Int16[3]
{
28121,
32347,
2436,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 27,
    Value = 
new System.Int16[3]
{
24472,
1989,
27400,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16ArrayInt16E1M
{
    Id = 45,
    Value = 
new System.Int16[4]
{
3871,
22713,
18959,
4021,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 31,
    Value = 
new System.Int16[4]
{
10880,
32245,
14104,
6668,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16ArrayInt16E1M
{
    Id = 50,
    Value = 
new System.Int16[3]
{
25987,
19105,
16453,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 33,
    Value = 
new System.Int16[3]
{
78,
25132,
24563,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
32702,
27027,
23887,
},
},
            new Int16ArrayInt16E1M
{
    Id = 54,
    Value = 
new System.Int16[4]
{
23086,
23173,
32706,
6430,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 34,
    Value = 
new System.Int16[3]
{
12708,
17698,
1236,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16ArrayInt16E1M
{
    Id = 58,
    Value = 
new System.Int16[3]
{
18082,
3146,
17854,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 38,
    Value = 
new System.Int16[4]
{
21650,
9265,
8738,
31266,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
10017,
13179,
23904,
5624,
},
},
            new Int16ArrayInt16E1M
{
    Id = 66,
    Value = 
new System.Int16[4]
{
23541,
8852,
30495,
752,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 39,
    Value = 
new System.Int16[4]
{
16002,
6158,
4743,
2429,
},
    NullableValue = 
new System.Int16[4]
{
22637,
4605,
22424,
4807,
},
},
    NullableValue = null,
},
            new Int16ArrayInt16E1M
{
    Id = 73,
    Value = 
new System.Int16[4]
{
16470,
7817,
29240,
19890,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 45,
    Value = 
new System.Int16[4]
{
17464,
23928,
23843,
27153,
},
    NullableValue = 
new System.Int16[3]
{
19084,
419,
7996,
},
},
    NullableValue = null,
},
            new Int16ArrayInt16E1M
{
    Id = 80,
    Value = 
new System.Int16[4]
{
7253,
19291,
10129,
13802,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 49,
    Value = 
new System.Int16[4]
{
24518,
27847,
4393,
20026,
},
    NullableValue = 
new System.Int16[3]
{
16552,
21194,
23422,
},
},
    NullableValue = 
new System.Int16[4]
{
20969,
5458,
27631,
17380,
},
},
            new Int16ArrayInt16E1M
{
    Id = 85,
    Value = 
new System.Int16[3]
{
27153,
31494,
32035,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 58,
    Value = 
new System.Int16[3]
{
9873,
2604,
2386,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16ArrayInt16E1M
{
    Id = 92,
    Value = 
new System.Int16[4]
{
11929,
5716,
20820,
14212,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 65,
    Value = 
new System.Int16[3]
{
5795,
27248,
7107,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
5196,
27450,
21688,
},
},
            new Int16ArrayInt16E1M
{
    Id = 94,
    Value = 
new System.Int16[3]
{
24489,
20996,
26802,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 71,
    Value = 
new System.Int16[4]
{
8154,
13875,
28083,
876,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16ArrayInt16E1M
{
    Id = 102,
    Value = 
new System.Int16[4]
{
18589,
26891,
13675,
24698,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 78,
    Value = 
new System.Int16[4]
{
22442,
2781,
32639,
18959,
},
    NullableValue = 
new System.Int16[3]
{
12611,
6124,
2449,
},
},
    NullableValue = null,
},
            new Int16ArrayInt16E1M
{
    Id = 111,
    Value = 
new System.Int16[3]
{
9935,
21638,
24120,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 83,
    Value = 
new System.Int16[4]
{
24198,
19374,
10347,
27668,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
30605,
14304,
30663,
},
},
            new Int16ArrayInt16E1M
{
    Id = 119,
    Value = 
new System.Int16[4]
{
14006,
9670,
25771,
30746,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 92,
    Value = 
new System.Int16[4]
{
12261,
9522,
26919,
22960,
},
    NullableValue = 
new System.Int16[4]
{
31169,
1805,
20987,
1683,
},
},
    NullableValue = 
new System.Int16[3]
{
21028,
19788,
21295,
},
},
            new Int16ArrayInt16E1M
{
    Id = 127,
    Value = 
new System.Int16[3]
{
9439,
20723,
25826,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 93,
    Value = 
new System.Int16[4]
{
403,
18382,
3103,
6042,
},
    NullableValue = 
new System.Int16[3]
{
17313,
24173,
17312,
},
},
    NullableValue = 
new System.Int16[4]
{
15708,
483,
13660,
31659,
},
},
            new Int16ArrayInt16E1M
{
    Id = 132,
    Value = 
new System.Int16[4]
{
8411,
19991,
7273,
14534,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 98,
    Value = 
new System.Int16[3]
{
20833,
4509,
6743,
},
    NullableValue = 
new System.Int16[3]
{
31627,
29480,
15328,
},
},
    NullableValue = null,
},
            new Int16ArrayInt16E1M
{
    Id = 138,
    Value = 
new System.Int16[3]
{
23811,
10438,
16387,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 106,
    Value = 
new System.Int16[3]
{
8881,
8811,
19075,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16ArrayInt16E1M
{
    Id = 139,
    Value = 
new System.Int16[4]
{
17803,
2655,
7256,
9345,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 109,
    Value = 
new System.Int16[4]
{
12580,
31789,
28914,
15453,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
19597,
21751,
24072,
21737,
},
},
            new Int16ArrayInt16E1M
{
    Id = 141,
    Value = 
new System.Int16[3]
{
15096,
10377,
22530,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 111,
    Value = 
new System.Int16[3]
{
5438,
13541,
17154,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16ArrayInt16E1M
{
    Id = 149,
    Value = 
new System.Int16[3]
{
5406,
7666,
26746,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 114,
    Value = 
new System.Int16[3]
{
9245,
1276,
28904,
},
    NullableValue = 
new System.Int16[3]
{
17676,
22602,
23268,
},
},
    NullableValue = 
new System.Int16[4]
{
452,
1346,
1823,
12914,
},
},
            new Int16ArrayInt16E1M
{
    Id = 155,
    Value = 
new System.Int16[4]
{
25799,
17880,
9183,
14016,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 118,
    Value = 
new System.Int16[4]
{
25087,
19180,
9207,
861,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
12594,
30300,
29704,
31206,
},
},
            new Int16ArrayInt16E1M
{
    Id = 161,
    Value = 
new System.Int16[3]
{
27704,
25053,
5059,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 122,
    Value = 
new System.Int16[4]
{
10523,
20964,
22922,
2539,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
13228,
15100,
11365,
1260,
},
},
            new Int16ArrayInt16E1M
{
    Id = 169,
    Value = 
new System.Int16[3]
{
12455,
27267,
9420,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 125,
    Value = 
new System.Int16[3]
{
30059,
12356,
30679,
},
    NullableValue = 
new System.Int16[3]
{
9809,
30544,
20629,
},
},
    NullableValue = null,
},
            new Int16ArrayInt16E1M
{
    Id = 170,
    Value = 
new System.Int16[3]
{
7,
15266,
10616,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 127,
    Value = 
new System.Int16[3]
{
14375,
23909,
14358,
},
    NullableValue = 
new System.Int16[3]
{
10320,
25586,
2713,
},
},
    NullableValue = 
new System.Int16[4]
{
8324,
11227,
32545,
9230,
},
},
            new Int16ArrayInt16E1M
{
    Id = 172,
    Value = 
new System.Int16[4]
{
10469,
9344,
9489,
29312,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 131,
    Value = 
new System.Int16[3]
{
28551,
32285,
4791,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
2742,
10413,
13603,
31020,
},
},
            new Int16ArrayInt16E1M
{
    Id = 179,
    Value = 
new System.Int16[4]
{
29272,
17418,
5587,
12475,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 140,
    Value = 
new System.Int16[4]
{
27564,
18127,
5675,
24575,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16ArrayInt16E1M
{
    Id = 181,
    Value = 
new System.Int16[4]
{
13929,
23769,
4177,
24967,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 149,
    Value = 
new System.Int16[4]
{
25263,
22463,
32369,
9663,
},
    NullableValue = 
new System.Int16[4]
{
6888,
30933,
12007,
9506,
},
},
    NullableValue = 
new System.Int16[4]
{
25578,
1564,
10383,
25644,
},
},
            new Int16ArrayInt16E1M
{
    Id = 183,
    Value = 
new System.Int16[4]
{
23044,
28661,
2992,
21573,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 155,
    Value = 
new System.Int16[4]
{
7857,
10279,
959,
11430,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16ArrayInt16E1M
{
    Id = 188,
    Value = 
new System.Int16[4]
{
27533,
32534,
3136,
11758,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 160,
    Value = 
new System.Int16[4]
{
13497,
29257,
18786,
4708,
},
    NullableValue = 
new System.Int16[3]
{
2513,
15351,
16843,
},
},
    NullableValue = 
new System.Int16[3]
{
18242,
16692,
30510,
},
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int16arrayint16e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Int16)}, 
    {mi_id:Int32},
    {mi_value:Array(Int16)}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArrayArrayInt16)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16[]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16[]), 
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
                    await ((IInt16MArrayArrayInt16)this).InsertModelDbConnectionAsync(
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
                     ((IInt16MArrayArrayInt16)this).InsertModelDbConnection(
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
FROM gedaqtests.int16arrayint16e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int16ArrayInt16E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArrayArrayInt16)),
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
                    var models = await ((IInt16MArrayArrayInt16)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int16ArrayInt16E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IInt16MArrayArrayInt16)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int16ArrayInt16E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

