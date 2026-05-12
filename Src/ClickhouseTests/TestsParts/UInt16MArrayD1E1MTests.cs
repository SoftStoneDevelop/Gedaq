

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
    internal partial interface IUInt16MArrayMArrayD1
    {
    }
    
    internal partial class UInt16MArrayMArrayD1 : IUInt16MArrayMArrayD1
    {


#region TestData

        private readonly UInt16MArrayD1E1M[] _testData = new UInt16MArrayD1E1M[]
        {
            new UInt16MArrayD1E1M
{
    Id = 1,
    Value = 
new System.UInt16[4]
{
33371,
26032,
30196,
12301,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 8,
    Value = 
new System.UInt16[4]
{
30658,
13891,
25876,
24617,
},
    NullableValue = 
new System.UInt16[4]
{
14504,
48564,
15626,
1465,
},
},
    NullableValue = 
new System.UInt16[3]
{
42727,
21988,
58333,
},
},
            new UInt16MArrayD1E1M
{
    Id = 5,
    Value = 
new System.UInt16[4]
{
52293,
50559,
28577,
18766,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 13,
    Value = 
new System.UInt16[4]
{
13644,
9472,
28305,
37958,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 7,
    Value = 
new System.UInt16[4]
{
4969,
34409,
14430,
11723,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 19,
    Value = 
new System.UInt16[4]
{
31512,
60334,
26276,
12461,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
11661,
51316,
27407,
},
},
            new UInt16MArrayD1E1M
{
    Id = 12,
    Value = 
new System.UInt16[4]
{
50283,
54064,
40098,
30800,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 22,
    Value = 
new System.UInt16[4]
{
30529,
34936,
38793,
60327,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 14,
    Value = 
new System.UInt16[3]
{
57934,
60317,
50918,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 29,
    Value = 
new System.UInt16[4]
{
43321,
57490,
41556,
58553,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
5151,
13423,
1405,
},
},
            new UInt16MArrayD1E1M
{
    Id = 16,
    Value = 
new System.UInt16[4]
{
36512,
39817,
48277,
47047,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 33,
    Value = 
new System.UInt16[4]
{
16057,
5312,
24717,
50783,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 22,
    Value = 
new System.UInt16[4]
{
51229,
26043,
7848,
44325,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 35,
    Value = 
new System.UInt16[3]
{
24409,
39277,
12430,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
19711,
31528,
55164,
},
},
            new UInt16MArrayD1E1M
{
    Id = 28,
    Value = 
new System.UInt16[4]
{
31873,
815,
41463,
45363,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 40,
    Value = 
new System.UInt16[4]
{
61543,
59546,
14254,
63312,
},
    NullableValue = 
new System.UInt16[3]
{
29790,
41777,
45801,
},
},
    NullableValue = 
new System.UInt16[3]
{
23827,
42858,
43410,
},
},
            new UInt16MArrayD1E1M
{
    Id = 31,
    Value = 
new System.UInt16[4]
{
36912,
38669,
23921,
12667,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 47,
    Value = 
new System.UInt16[3]
{
46766,
13002,
8768,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
4169,
41878,
9185,
42257,
},
},
            new UInt16MArrayD1E1M
{
    Id = 33,
    Value = 
new System.UInt16[4]
{
58772,
19877,
3614,
56345,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 54,
    Value = 
new System.UInt16[3]
{
26807,
9388,
2734,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 38,
    Value = 
new System.UInt16[4]
{
4146,
35633,
57023,
54472,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 62,
    Value = 
new System.UInt16[4]
{
48951,
9624,
53888,
18662,
},
    NullableValue = 
new System.UInt16[4]
{
43302,
58258,
34494,
35522,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 45,
    Value = 
new System.UInt16[3]
{
57698,
51522,
18551,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 66,
    Value = 
new System.UInt16[4]
{
17954,
41160,
49412,
46079,
},
    NullableValue = 
new System.UInt16[3]
{
56645,
28746,
16584,
},
},
    NullableValue = 
new System.UInt16[3]
{
60887,
27385,
55007,
},
},
            new UInt16MArrayD1E1M
{
    Id = 52,
    Value = 
new System.UInt16[3]
{
59429,
52578,
6502,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 68,
    Value = 
new System.UInt16[3]
{
3449,
47428,
4573,
},
    NullableValue = 
new System.UInt16[3]
{
17529,
60435,
63054,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 53,
    Value = 
new System.UInt16[3]
{
8252,
4905,
48863,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 71,
    Value = 
new System.UInt16[4]
{
28887,
54279,
35205,
55525,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
46324,
57706,
13988,
},
},
            new UInt16MArrayD1E1M
{
    Id = 62,
    Value = 
new System.UInt16[4]
{
18824,
61545,
15435,
63584,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 79,
    Value = 
new System.UInt16[4]
{
60933,
44075,
57393,
39075,
},
    NullableValue = 
new System.UInt16[4]
{
64674,
61266,
52893,
11183,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 66,
    Value = 
new System.UInt16[4]
{
12963,
33961,
34938,
31843,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 81,
    Value = 
new System.UInt16[4]
{
51363,
34533,
34719,
12671,
},
    NullableValue = 
new System.UInt16[4]
{
3957,
49074,
20840,
15288,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 72,
    Value = 
new System.UInt16[4]
{
4314,
1522,
53806,
35954,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 83,
    Value = 
new System.UInt16[4]
{
37255,
56389,
45045,
2985,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
6123,
52958,
45911,
22864,
},
},
            new UInt16MArrayD1E1M
{
    Id = 74,
    Value = 
new System.UInt16[3]
{
59685,
18765,
10064,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 90,
    Value = 
new System.UInt16[3]
{
4421,
32961,
39154,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
6161,
40596,
1630,
},
},
            new UInt16MArrayD1E1M
{
    Id = 79,
    Value = 
new System.UInt16[4]
{
1417,
33634,
39651,
13564,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 95,
    Value = 
new System.UInt16[4]
{
28125,
47790,
7479,
21642,
},
    NullableValue = 
new System.UInt16[3]
{
17132,
63700,
27555,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 83,
    Value = 
new System.UInt16[3]
{
47781,
4637,
28612,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 97,
    Value = 
new System.UInt16[4]
{
57769,
32486,
5847,
31467,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
49891,
14628,
58857,
},
},
            new UInt16MArrayD1E1M
{
    Id = 91,
    Value = 
new System.UInt16[4]
{
23567,
9864,
63516,
56311,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 106,
    Value = 
new System.UInt16[4]
{
65426,
13542,
53190,
54453,
},
    NullableValue = 
new System.UInt16[3]
{
33989,
10629,
27334,
},
},
    NullableValue = 
new System.UInt16[3]
{
19910,
45805,
8922,
},
},
            new UInt16MArrayD1E1M
{
    Id = 97,
    Value = 
new System.UInt16[3]
{
47693,
39948,
31795,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 109,
    Value = 
new System.UInt16[3]
{
51958,
54079,
21126,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 101,
    Value = 
new System.UInt16[4]
{
55233,
6285,
56202,
39979,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 114,
    Value = 
new System.UInt16[3]
{
41492,
26852,
24925,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 108,
    Value = 
new System.UInt16[3]
{
4300,
33158,
7417,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 121,
    Value = 
new System.UInt16[3]
{
38561,
24471,
40453,
},
    NullableValue = 
new System.UInt16[3]
{
11807,
34865,
476,
},
},
    NullableValue = 
new System.UInt16[4]
{
60436,
23181,
24412,
31109,
},
},
            new UInt16MArrayD1E1M
{
    Id = 109,
    Value = 
new System.UInt16[4]
{
15117,
54183,
16237,
48181,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 125,
    Value = 
new System.UInt16[4]
{
61044,
34681,
3076,
36641,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 118,
    Value = 
new System.UInt16[4]
{
61092,
26856,
4138,
39849,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 126,
    Value = 
new System.UInt16[4]
{
18194,
40006,
24209,
98,
},
    NullableValue = 
new System.UInt16[4]
{
23794,
5497,
26646,
4458,
},
},
    NullableValue = 
new System.UInt16[3]
{
64162,
22540,
35269,
},
},
            new UInt16MArrayD1E1M
{
    Id = 125,
    Value = 
new System.UInt16[3]
{
3394,
36004,
64621,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 130,
    Value = 
new System.UInt16[4]
{
33978,
60976,
34323,
47719,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
32245,
21899,
11977,
},
},
            new UInt16MArrayD1E1M
{
    Id = 129,
    Value = 
new System.UInt16[4]
{
21821,
51986,
26594,
32748,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 138,
    Value = 
new System.UInt16[3]
{
23311,
56035,
22206,
},
    NullableValue = 
new System.UInt16[4]
{
55684,
41136,
28081,
57287,
},
},
    NullableValue = 
new System.UInt16[3]
{
60577,
47056,
4568,
},
},
            new UInt16MArrayD1E1M
{
    Id = 137,
    Value = 
new System.UInt16[4]
{
47892,
55531,
53560,
5195,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 143,
    Value = 
new System.UInt16[3]
{
63482,
44846,
40582,
},
    NullableValue = 
new System.UInt16[4]
{
10758,
52435,
3559,
12318,
},
},
    NullableValue = 
new System.UInt16[4]
{
61757,
51952,
59680,
36403,
},
},
            new UInt16MArrayD1E1M
{
    Id = 142,
    Value = 
new System.UInt16[3]
{
8054,
50059,
14059,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 148,
    Value = 
new System.UInt16[4]
{
53461,
12243,
62232,
57070,
},
    NullableValue = 
new System.UInt16[3]
{
10980,
59422,
49,
},
},
    NullableValue = 
new System.UInt16[3]
{
22678,
7281,
26197,
},
},
            new UInt16MArrayD1E1M
{
    Id = 149,
    Value = 
new System.UInt16[3]
{
53708,
39641,
38168,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 152,
    Value = 
new System.UInt16[4]
{
34011,
33704,
6970,
46996,
},
    NullableValue = 
new System.UInt16[4]
{
27948,
27941,
12933,
34964,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 152,
    Value = 
new System.UInt16[4]
{
41986,
14483,
3415,
43069,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 159,
    Value = 
new System.UInt16[3]
{
56846,
39424,
41460,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
58158,
43915,
13210,
},
},
            new UInt16MArrayD1E1M
{
    Id = 158,
    Value = 
new System.UInt16[4]
{
44994,
39454,
37617,
29578,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 164,
    Value = 
new System.UInt16[3]
{
5321,
16263,
37266,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
50394,
5088,
2189,
},
},
            new UInt16MArrayD1E1M
{
    Id = 164,
    Value = 
new System.UInt16[3]
{
18033,
37470,
12037,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 168,
    Value = 
new System.UInt16[4]
{
54613,
2149,
15391,
3568,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
11699,
5048,
57089,
},
},
            new UInt16MArrayD1E1M
{
    Id = 170,
    Value = 
new System.UInt16[4]
{
50566,
51886,
64310,
46247,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 174,
    Value = 
new System.UInt16[3]
{
62520,
62722,
15729,
},
    NullableValue = 
new System.UInt16[3]
{
31957,
25147,
19016,
},
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
INSERT INTO gedaqtests.uint16marrayd1e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(UInt16)}, 
    {mi_id:Int32},
    {mi_value:Array(UInt16)}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16MArrayMArrayD1)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt16[]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt16[]), 
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
                    await ((IUInt16MArrayMArrayD1)this).InsertModelDbConnectionAsync(
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
                     ((IUInt16MArrayMArrayD1)this).InsertModelDbConnection(
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
FROM gedaqtests.uint16marrayd1e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt16MArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16MArrayMArrayD1)),
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
                    var models = await ((IUInt16MArrayMArrayD1)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt16MArrayD1E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IUInt16MArrayMArrayD1)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt16MArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

