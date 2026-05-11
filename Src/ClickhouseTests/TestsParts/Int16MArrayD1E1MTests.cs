

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
    internal partial interface IInt16MArrayMArrayD1
    {
    }
    
    internal partial class Int16MArrayMArrayD1 : IInt16MArrayMArrayD1
    {


#region TestData

        private readonly Int16MArrayD1E1M[] _testData = new Int16MArrayD1E1M[]
        {
            new Int16MArrayD1E1M
{
    Id = 8,
    Value = 
new System.Int16[3]
{
28592,
4541,
5691,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 9,
    Value = 
new System.Int16[4]
{
6618,
17848,
21726,
14414,
},
    NullableValue = 
new System.Int16[3]
{
11539,
32170,
1084,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 9,
    Value = 
new System.Int16[3]
{
2966,
25562,
21313,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 14,
    Value = 
new System.Int16[3]
{
25739,
19596,
22847,
},
    NullableValue = 
new System.Int16[4]
{
26715,
18854,
9982,
16559,
},
},
    NullableValue = 
new System.Int16[3]
{
7814,
32119,
25542,
},
},
            new Int16MArrayD1E1M
{
    Id = 10,
    Value = 
new System.Int16[4]
{
4238,
29322,
19724,
23684,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 16,
    Value = 
new System.Int16[3]
{
20435,
10793,
23247,
},
    NullableValue = 
new System.Int16[4]
{
1071,
13840,
30981,
11375,
},
},
    NullableValue = 
new System.Int16[4]
{
18092,
30620,
434,
24013,
},
},
            new Int16MArrayD1E1M
{
    Id = 19,
    Value = 
new System.Int16[4]
{
26844,
18359,
20444,
3241,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 18,
    Value = 
new System.Int16[3]
{
30625,
17979,
30199,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
20400,
6479,
29049,
},
},
            new Int16MArrayD1E1M
{
    Id = 24,
    Value = 
new System.Int16[4]
{
486,
9234,
31856,
14900,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 23,
    Value = 
new System.Int16[3]
{
8451,
3499,
21776,
},
    NullableValue = 
new System.Int16[3]
{
24980,
30701,
9210,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 31,
    Value = 
new System.Int16[3]
{
27733,
28630,
31619,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 29,
    Value = 
new System.Int16[3]
{
10341,
10354,
8565,
},
    NullableValue = 
new System.Int16[3]
{
28602,
2102,
1160,
},
},
    NullableValue = 
new System.Int16[3]
{
2186,
6155,
20382,
},
},
            new Int16MArrayD1E1M
{
    Id = 32,
    Value = 
new System.Int16[4]
{
23195,
6481,
11931,
4220,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 38,
    Value = 
new System.Int16[4]
{
32466,
3410,
7586,
4566,
},
    NullableValue = 
new System.Int16[3]
{
28884,
21728,
13344,
},
},
    NullableValue = 
new System.Int16[3]
{
2514,
8523,
4992,
},
},
            new Int16MArrayD1E1M
{
    Id = 34,
    Value = 
new System.Int16[4]
{
31193,
31268,
2260,
15097,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 47,
    Value = 
new System.Int16[3]
{
10064,
31286,
14332,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
27926,
9636,
13225,
24724,
},
},
            new Int16MArrayD1E1M
{
    Id = 38,
    Value = 
new System.Int16[3]
{
16304,
24087,
8743,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 54,
    Value = 
new System.Int16[3]
{
28846,
4083,
14071,
},
    NullableValue = 
new System.Int16[3]
{
20351,
6330,
797,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 44,
    Value = 
new System.Int16[3]
{
4044,
11068,
32353,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 59,
    Value = 
new System.Int16[3]
{
9670,
1055,
2553,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 51,
    Value = 
new System.Int16[3]
{
13925,
9241,
26262,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 63,
    Value = 
new System.Int16[4]
{
16762,
29162,
28188,
12974,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
19512,
28262,
18344,
},
},
            new Int16MArrayD1E1M
{
    Id = 59,
    Value = 
new System.Int16[3]
{
13314,
4706,
11543,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 69,
    Value = 
new System.Int16[3]
{
22650,
26460,
13708,
},
    NullableValue = 
new System.Int16[4]
{
18440,
23649,
21655,
21959,
},
},
    NullableValue = 
new System.Int16[4]
{
6254,
14592,
31026,
25754,
},
},
            new Int16MArrayD1E1M
{
    Id = 62,
    Value = 
new System.Int16[3]
{
947,
3079,
6771,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 71,
    Value = 
new System.Int16[3]
{
21194,
10950,
27645,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 63,
    Value = 
new System.Int16[3]
{
23718,
11456,
26147,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 80,
    Value = 
new System.Int16[4]
{
17688,
11001,
3579,
15133,
},
    NullableValue = 
new System.Int16[3]
{
7739,
13165,
9696,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 69,
    Value = 
new System.Int16[4]
{
1130,
12949,
29457,
4168,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 83,
    Value = 
new System.Int16[3]
{
4565,
962,
15809,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
30977,
10876,
11555,
},
},
            new Int16MArrayD1E1M
{
    Id = 70,
    Value = 
new System.Int16[3]
{
15,
23041,
28501,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 84,
    Value = 
new System.Int16[4]
{
22128,
1426,
2629,
17577,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
23107,
22803,
1901,
29510,
},
},
            new Int16MArrayD1E1M
{
    Id = 71,
    Value = 
new System.Int16[3]
{
19090,
20407,
4742,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 88,
    Value = 
new System.Int16[4]
{
29942,
6743,
14073,
1320,
},
    NullableValue = 
new System.Int16[4]
{
16311,
4180,
24607,
28710,
},
},
    NullableValue = 
new System.Int16[3]
{
10090,
15048,
7981,
},
},
            new Int16MArrayD1E1M
{
    Id = 72,
    Value = 
new System.Int16[4]
{
2103,
28981,
642,
17706,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 93,
    Value = 
new System.Int16[3]
{
12108,
26472,
5297,
},
    NullableValue = 
new System.Int16[3]
{
22017,
27603,
10909,
},
},
    NullableValue = 
new System.Int16[3]
{
18014,
9950,
4348,
},
},
            new Int16MArrayD1E1M
{
    Id = 79,
    Value = 
new System.Int16[3]
{
11035,
8002,
27523,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 95,
    Value = 
new System.Int16[4]
{
30602,
14492,
17068,
17345,
},
    NullableValue = 
new System.Int16[3]
{
12589,
31325,
24830,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 80,
    Value = 
new System.Int16[4]
{
27541,
6371,
7837,
12079,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 102,
    Value = 
new System.Int16[3]
{
13327,
18382,
6900,
},
    NullableValue = 
new System.Int16[4]
{
19814,
9674,
8125,
1102,
},
},
    NullableValue = 
new System.Int16[4]
{
23445,
17031,
27529,
30575,
},
},
            new Int16MArrayD1E1M
{
    Id = 86,
    Value = 
new System.Int16[3]
{
28190,
16598,
27214,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 110,
    Value = 
new System.Int16[3]
{
18556,
12358,
17773,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 93,
    Value = 
new System.Int16[4]
{
26204,
19926,
29923,
29233,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 117,
    Value = 
new System.Int16[4]
{
10376,
14841,
26892,
25292,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
9543,
17830,
12862,
26670,
},
},
            new Int16MArrayD1E1M
{
    Id = 101,
    Value = 
new System.Int16[4]
{
18873,
26346,
4553,
18583,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 126,
    Value = 
new System.Int16[4]
{
13889,
24426,
15207,
3188,
},
    NullableValue = 
new System.Int16[4]
{
18429,
22771,
18697,
19938,
},
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 110,
    Value = 
new System.Int16[3]
{
17920,
8973,
18640,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 128,
    Value = 
new System.Int16[3]
{
8335,
21914,
19579,
},
    NullableValue = 
new System.Int16[4]
{
8438,
8697,
6089,
14187,
},
},
    NullableValue = 
new System.Int16[3]
{
19053,
24832,
25888,
},
},
            new Int16MArrayD1E1M
{
    Id = 111,
    Value = 
new System.Int16[3]
{
25019,
23825,
26707,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 130,
    Value = 
new System.Int16[4]
{
3567,
30441,
31358,
10627,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 114,
    Value = 
new System.Int16[4]
{
16252,
12086,
6654,
13761,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 135,
    Value = 
new System.Int16[4]
{
30746,
108,
17969,
4596,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
7047,
11974,
6136,
},
},
            new Int16MArrayD1E1M
{
    Id = 119,
    Value = 
new System.Int16[4]
{
31988,
28896,
30101,
16771,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 140,
    Value = 
new System.Int16[4]
{
2103,
3685,
24315,
14485,
},
    NullableValue = 
new System.Int16[4]
{
10770,
16104,
3224,
14132,
},
},
    NullableValue = 
new System.Int16[4]
{
4936,
2821,
31793,
4277,
},
},
            new Int16MArrayD1E1M
{
    Id = 124,
    Value = 
new System.Int16[4]
{
10965,
17805,
481,
647,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 143,
    Value = 
new System.Int16[4]
{
27566,
21368,
28403,
6885,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 127,
    Value = 
new System.Int16[4]
{
17086,
3345,
21217,
5049,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 146,
    Value = 
new System.Int16[3]
{
6198,
24461,
31587,
},
    NullableValue = 
new System.Int16[4]
{
19504,
32277,
9671,
30250,
},
},
    NullableValue = 
new System.Int16[3]
{
3230,
20799,
6106,
},
},
            new Int16MArrayD1E1M
{
    Id = 131,
    Value = 
new System.Int16[4]
{
10288,
17866,
1461,
18676,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 153,
    Value = 
new System.Int16[3]
{
27406,
15233,
8580,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 138,
    Value = 
new System.Int16[4]
{
25831,
20932,
21420,
16801,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 155,
    Value = 
new System.Int16[3]
{
32399,
810,
3025,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
8000,
23259,
19472,
},
},
            new Int16MArrayD1E1M
{
    Id = 140,
    Value = 
new System.Int16[4]
{
8078,
24506,
8516,
27482,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 163,
    Value = 
new System.Int16[4]
{
29785,
32130,
8922,
10268,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 148,
    Value = 
new System.Int16[4]
{
20069,
15294,
268,
22563,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 166,
    Value = 
new System.Int16[3]
{
31754,
28708,
6416,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 151,
    Value = 
new System.Int16[4]
{
17808,
21309,
10234,
31589,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 169,
    Value = 
new System.Int16[3]
{
1024,
15471,
9237,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD1E1M
{
    Id = 155,
    Value = 
new System.Int16[3]
{
24366,
8206,
22718,
},
    ModelInner = new Int16MArrayD1E1MI
{
    Id = 178,
    Value = 
new System.Int16[3]
{
18747,
18508,
7225,
},
    NullableValue = 
new System.Int16[4]
{
20493,
10025,
8865,
13291,
},
},
    NullableValue = 
new System.Int16[4]
{
2206,
30233,
3096,
8386,
},
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int16marrayd1e1m(
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
            asPartInterface: typeof(IInt16MArrayMArrayD1)),
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
                    await ((IInt16MArrayMArrayD1)this).InsertModelDbConnectionAsync(
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
                     ((IInt16MArrayMArrayD1)this).InsertModelDbConnection(
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
FROM gedaqtests.int16marrayd1e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int16MArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArrayMArrayD1)),
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
                    var models = await ((IInt16MArrayMArrayD1)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int16MArrayD1E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IInt16MArrayMArrayD1)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int16MArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

