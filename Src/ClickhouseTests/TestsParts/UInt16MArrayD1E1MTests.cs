

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
    Id = 8,
    Value = 
new System.UInt16[3]
{
7961,
36488,
55448,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 6,
    Value = 
new System.UInt16[4]
{
35833,
53608,
57744,
40994,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
5943,
49258,
35206,
40028,
},
},
            new UInt16MArrayD1E1M
{
    Id = 17,
    Value = 
new System.UInt16[4]
{
36610,
23872,
54537,
37011,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 13,
    Value = 
new System.UInt16[3]
{
50826,
46125,
65333,
},
    NullableValue = 
new System.UInt16[3]
{
53414,
23708,
40776,
},
},
    NullableValue = 
new System.UInt16[4]
{
19241,
34915,
3716,
46364,
},
},
            new UInt16MArrayD1E1M
{
    Id = 23,
    Value = 
new System.UInt16[4]
{
17023,
13782,
54702,
16213,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 18,
    Value = 
new System.UInt16[3]
{
62380,
13409,
52616,
},
    NullableValue = 
new System.UInt16[4]
{
463,
55841,
3468,
23050,
},
},
    NullableValue = 
new System.UInt16[4]
{
63953,
60988,
28049,
5371,
},
},
            new UInt16MArrayD1E1M
{
    Id = 29,
    Value = 
new System.UInt16[3]
{
59344,
58527,
45478,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 25,
    Value = 
new System.UInt16[4]
{
46513,
25928,
50530,
27150,
},
    NullableValue = 
new System.UInt16[4]
{
49555,
59675,
33111,
61483,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 37,
    Value = 
new System.UInt16[3]
{
18321,
54054,
39040,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 32,
    Value = 
new System.UInt16[3]
{
40344,
63251,
9248,
},
    NullableValue = 
new System.UInt16[4]
{
2092,
51337,
16004,
51275,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 44,
    Value = 
new System.UInt16[4]
{
13722,
1237,
12309,
57272,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 35,
    Value = 
new System.UInt16[3]
{
49900,
48697,
36381,
},
    NullableValue = 
new System.UInt16[4]
{
30257,
42199,
31071,
20286,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 51,
    Value = 
new System.UInt16[4]
{
38336,
63716,
47847,
48463,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 44,
    Value = 
new System.UInt16[4]
{
44331,
48038,
65136,
50998,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 54,
    Value = 
new System.UInt16[4]
{
14349,
14604,
52927,
39501,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 53,
    Value = 
new System.UInt16[4]
{
22946,
4085,
57728,
24874,
},
    NullableValue = 
new System.UInt16[4]
{
44872,
5197,
15066,
3174,
},
},
    NullableValue = 
new System.UInt16[4]
{
41742,
40455,
56101,
13369,
},
},
            new UInt16MArrayD1E1M
{
    Id = 60,
    Value = 
new System.UInt16[3]
{
27650,
45811,
10115,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 60,
    Value = 
new System.UInt16[3]
{
1877,
6142,
4699,
},
    NullableValue = 
new System.UInt16[3]
{
58377,
18664,
36143,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 62,
    Value = 
new System.UInt16[3]
{
12598,
19146,
60278,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 65,
    Value = 
new System.UInt16[4]
{
29791,
50487,
41480,
41697,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
24787,
8842,
43661,
},
},
            new UInt16MArrayD1E1M
{
    Id = 70,
    Value = 
new System.UInt16[4]
{
58260,
44012,
22240,
562,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 74,
    Value = 
new System.UInt16[4]
{
45714,
34318,
4457,
4416,
},
    NullableValue = 
new System.UInt16[4]
{
57851,
48815,
23206,
50133,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 71,
    Value = 
new System.UInt16[4]
{
4853,
22259,
17331,
6468,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 76,
    Value = 
new System.UInt16[4]
{
41557,
50969,
17936,
27996,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 78,
    Value = 
new System.UInt16[4]
{
5174,
36605,
52023,
5794,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 85,
    Value = 
new System.UInt16[3]
{
39701,
62770,
49034,
},
    NullableValue = 
new System.UInt16[3]
{
37196,
37430,
46583,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 79,
    Value = 
new System.UInt16[3]
{
29207,
63374,
10272,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 91,
    Value = 
new System.UInt16[3]
{
54621,
54079,
8162,
},
    NullableValue = 
new System.UInt16[4]
{
31421,
38374,
27638,
2901,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 86,
    Value = 
new System.UInt16[4]
{
47056,
35050,
19936,
13374,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 93,
    Value = 
new System.UInt16[3]
{
62919,
29838,
10414,
},
    NullableValue = 
new System.UInt16[4]
{
27761,
25861,
32802,
29236,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 90,
    Value = 
new System.UInt16[4]
{
58367,
43941,
30790,
3511,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 100,
    Value = 
new System.UInt16[4]
{
60861,
39076,
29029,
64914,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
2223,
36637,
3000,
13500,
},
},
            new UInt16MArrayD1E1M
{
    Id = 97,
    Value = 
new System.UInt16[3]
{
21818,
33516,
18677,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 108,
    Value = 
new System.UInt16[3]
{
5750,
38188,
45704,
},
    NullableValue = 
new System.UInt16[4]
{
15814,
52063,
12912,
8127,
},
},
    NullableValue = 
new System.UInt16[4]
{
4790,
13542,
35456,
62616,
},
},
            new UInt16MArrayD1E1M
{
    Id = 103,
    Value = 
new System.UInt16[3]
{
53853,
45817,
36065,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 109,
    Value = 
new System.UInt16[4]
{
62067,
29904,
48006,
35593,
},
    NullableValue = 
new System.UInt16[3]
{
39648,
49228,
50452,
},
},
    NullableValue = 
new System.UInt16[4]
{
17268,
54629,
17012,
37243,
},
},
            new UInt16MArrayD1E1M
{
    Id = 106,
    Value = 
new System.UInt16[4]
{
62634,
31280,
8988,
18223,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 113,
    Value = 
new System.UInt16[4]
{
63781,
27994,
6353,
37167,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 111,
    Value = 
new System.UInt16[4]
{
61543,
9014,
52522,
21501,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 118,
    Value = 
new System.UInt16[3]
{
37981,
5883,
27764,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 114,
    Value = 
new System.UInt16[4]
{
1131,
23119,
44632,
52107,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 119,
    Value = 
new System.UInt16[4]
{
21301,
55422,
34196,
10927,
},
    NullableValue = 
new System.UInt16[3]
{
52371,
61883,
31004,
},
},
    NullableValue = 
new System.UInt16[3]
{
27822,
33187,
58956,
},
},
            new UInt16MArrayD1E1M
{
    Id = 123,
    Value = 
new System.UInt16[3]
{
34391,
9092,
52339,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 123,
    Value = 
new System.UInt16[3]
{
12334,
57652,
20348,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 131,
    Value = 
new System.UInt16[4]
{
40941,
48306,
40541,
28218,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 130,
    Value = 
new System.UInt16[3]
{
3515,
50692,
59218,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
48242,
32572,
29603,
},
},
            new UInt16MArrayD1E1M
{
    Id = 132,
    Value = 
new System.UInt16[4]
{
21955,
17154,
36825,
10988,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 134,
    Value = 
new System.UInt16[3]
{
29199,
49030,
42489,
},
    NullableValue = 
new System.UInt16[3]
{
40284,
23158,
28330,
},
},
    NullableValue = 
new System.UInt16[4]
{
16216,
13638,
27930,
26176,
},
},
            new UInt16MArrayD1E1M
{
    Id = 135,
    Value = 
new System.UInt16[3]
{
8029,
30706,
25623,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 139,
    Value = 
new System.UInt16[3]
{
56854,
58678,
32037,
},
    NullableValue = 
new System.UInt16[3]
{
26197,
3216,
17964,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 140,
    Value = 
new System.UInt16[4]
{
10036,
63024,
54812,
24666,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 142,
    Value = 
new System.UInt16[4]
{
6296,
52154,
47925,
20615,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 142,
    Value = 
new System.UInt16[3]
{
3120,
18573,
39161,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 149,
    Value = 
new System.UInt16[4]
{
1079,
16786,
31278,
2570,
},
    NullableValue = 
new System.UInt16[3]
{
29716,
26456,
13036,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 147,
    Value = 
new System.UInt16[3]
{
60313,
4919,
35760,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 153,
    Value = 
new System.UInt16[3]
{
41252,
54735,
49785,
},
    NullableValue = 
new System.UInt16[3]
{
4468,
24146,
15072,
},
},
    NullableValue = 
new System.UInt16[3]
{
44863,
3369,
29514,
},
},
            new UInt16MArrayD1E1M
{
    Id = 152,
    Value = 
new System.UInt16[3]
{
51938,
9204,
60111,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 154,
    Value = 
new System.UInt16[4]
{
28635,
13492,
46547,
49752,
},
    NullableValue = 
new System.UInt16[4]
{
43025,
11419,
16710,
13337,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 154,
    Value = 
new System.UInt16[3]
{
43946,
12251,
53847,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 163,
    Value = 
new System.UInt16[4]
{
34417,
30556,
18204,
59171,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[4]
{
43185,
24798,
44542,
46518,
},
},
            new UInt16MArrayD1E1M
{
    Id = 157,
    Value = 
new System.UInt16[4]
{
1169,
49314,
6548,
16640,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 170,
    Value = 
new System.UInt16[4]
{
22325,
42902,
53848,
19446,
},
    NullableValue = 
new System.UInt16[3]
{
30742,
48348,
59562,
},
},
    NullableValue = 
new System.UInt16[3]
{
32121,
4684,
32221,
},
},
            new UInt16MArrayD1E1M
{
    Id = 161,
    Value = 
new System.UInt16[4]
{
9889,
47377,
33949,
20748,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 176,
    Value = 
new System.UInt16[3]
{
14970,
33583,
17320,
},
    NullableValue = 
new System.UInt16[3]
{
27484,
26870,
11566,
},
},
    NullableValue = 
new System.UInt16[4]
{
51327,
36769,
18587,
40202,
},
},
            new UInt16MArrayD1E1M
{
    Id = 162,
    Value = 
new System.UInt16[3]
{
6728,
44071,
55740,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 178,
    Value = 
new System.UInt16[3]
{
48502,
7228,
45647,
},
    NullableValue = 
new System.UInt16[3]
{
36671,
51630,
53892,
},
},
    NullableValue = null,
},
            new UInt16MArrayD1E1M
{
    Id = 171,
    Value = 
new System.UInt16[4]
{
41326,
23137,
49924,
31672,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 184,
    Value = 
new System.UInt16[3]
{
50582,
40327,
289,
},
    NullableValue = 
new System.UInt16[4]
{
21839,
54121,
58345,
57611,
},
},
    NullableValue = 
new System.UInt16[3]
{
16949,
13728,
47660,
},
},
            new UInt16MArrayD1E1M
{
    Id = 179,
    Value = 
new System.UInt16[3]
{
61577,
16045,
33919,
},
    ModelInner = new UInt16MArrayD1E1MI
{
    Id = 189,
    Value = 
new System.UInt16[3]
{
14623,
50322,
31172,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[3]
{
15202,
35926,
33993,
},
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

