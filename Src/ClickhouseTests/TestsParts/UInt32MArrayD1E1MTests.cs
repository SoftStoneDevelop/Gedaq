

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
    internal partial interface IUInt32MArrayMArrayD1
    {
    }
    
    internal partial class UInt32MArrayMArrayD1 : IUInt32MArrayMArrayD1
    {


#region TestData

        private readonly UInt32MArrayD1E1M[] _testData = new UInt32MArrayD1E1M[]
        {
            new UInt32MArrayD1E1M
{
    Id = 5,
    Value = 
new System.UInt32[3]
{
621922449,
1857367071,
1149481945,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 9,
    Value = 
new System.UInt32[4]
{
3186006571,
4240277822,
4020746378,
1393108533,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 11,
    Value = 
new System.UInt32[3]
{
3600398633,
834070362,
1078340048,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 14,
    Value = 
new System.UInt32[3]
{
2377643537,
167605586,
2982437237,
},
    NullableValue = 
new System.UInt32[4]
{
666205235,
2633003948,
1329865769,
2928068784,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 19,
    Value = 
new System.UInt32[4]
{
1536981264,
3210036527,
1950887885,
3512047561,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 17,
    Value = 
new System.UInt32[3]
{
578321256,
2305035230,
4232020888,
},
    NullableValue = 
new System.UInt32[4]
{
124290579,
2875515359,
498754767,
3373077621,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 21,
    Value = 
new System.UInt32[4]
{
4095482994,
2937546399,
161975847,
1447762217,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 19,
    Value = 
new System.UInt32[4]
{
3422155410,
1347352249,
1098375870,
2678266107,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
324133779,
1785171463,
2428342390,
2742155083,
},
},
            new UInt32MArrayD1E1M
{
    Id = 22,
    Value = 
new System.UInt32[3]
{
984623045,
344332666,
3248766576,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 27,
    Value = 
new System.UInt32[4]
{
1977643262,
1839505589,
2416149627,
3408028200,
},
    NullableValue = 
new System.UInt32[3]
{
1194110543,
4257451756,
1378519295,
},
},
    NullableValue = 
new System.UInt32[3]
{
1478605906,
4272547789,
668408326,
},
},
            new UInt32MArrayD1E1M
{
    Id = 30,
    Value = 
new System.UInt32[4]
{
850376283,
77575762,
413137279,
2608981863,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 36,
    Value = 
new System.UInt32[4]
{
2157940081,
1856874937,
1948487340,
2641832838,
},
    NullableValue = 
new System.UInt32[4]
{
33013596,
3959234275,
1694437311,
2726621785,
},
},
    NullableValue = 
new System.UInt32[4]
{
4111114545,
2248604913,
2556009522,
1969965853,
},
},
            new UInt32MArrayD1E1M
{
    Id = 31,
    Value = 
new System.UInt32[4]
{
3146369620,
2323363621,
647032679,
3986473220,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 39,
    Value = 
new System.UInt32[4]
{
2273136700,
3514597263,
197340985,
1640300252,
},
    NullableValue = 
new System.UInt32[4]
{
1338976929,
1273271766,
568899831,
990130656,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 33,
    Value = 
new System.UInt32[3]
{
1002428677,
3817709507,
2038455904,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 44,
    Value = 
new System.UInt32[4]
{
2767890222,
1786343474,
1528255540,
3534236814,
},
    NullableValue = 
new System.UInt32[3]
{
2456845786,
1650672710,
3971890680,
},
},
    NullableValue = 
new System.UInt32[4]
{
1433636821,
4030137189,
83712795,
1050268119,
},
},
            new UInt32MArrayD1E1M
{
    Id = 38,
    Value = 
new System.UInt32[3]
{
3939984664,
1954878148,
3640049662,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 53,
    Value = 
new System.UInt32[4]
{
1192365148,
73937529,
1193426065,
1518604180,
},
    NullableValue = 
new System.UInt32[3]
{
2249885117,
2870635311,
207059128,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 42,
    Value = 
new System.UInt32[4]
{
3365871151,
1212226458,
3754303366,
1602963185,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 58,
    Value = 
new System.UInt32[3]
{
3983482564,
981818301,
958693078,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
4095843330,
731432732,
1135013896,
},
},
            new UInt32MArrayD1E1M
{
    Id = 49,
    Value = 
new System.UInt32[3]
{
2923776126,
420304600,
3630745102,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 59,
    Value = 
new System.UInt32[4]
{
3831468417,
3080644251,
2092298313,
1939486357,
},
    NullableValue = 
new System.UInt32[4]
{
3916375278,
2372489731,
2563323425,
1114318725,
},
},
    NullableValue = 
new System.UInt32[4]
{
2106761111,
3525179539,
1724339878,
2205912353,
},
},
            new UInt32MArrayD1E1M
{
    Id = 54,
    Value = 
new System.UInt32[4]
{
1377298354,
744653752,
3428515533,
2695566871,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 67,
    Value = 
new System.UInt32[3]
{
32678498,
3041483760,
4085826022,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
3942391202,
2963948312,
2624318887,
},
},
            new UInt32MArrayD1E1M
{
    Id = 57,
    Value = 
new System.UInt32[3]
{
1708935752,
90392494,
43779767,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 76,
    Value = 
new System.UInt32[4]
{
1661998683,
2158370184,
110929338,
3961948902,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
1269579154,
4101015043,
626729876,
1602724554,
},
},
            new UInt32MArrayD1E1M
{
    Id = 64,
    Value = 
new System.UInt32[3]
{
803656790,
725006745,
2614103722,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 78,
    Value = 
new System.UInt32[4]
{
2583116147,
321687636,
2880793764,
3313885750,
},
    NullableValue = 
new System.UInt32[3]
{
2835034129,
1497184539,
885511808,
},
},
    NullableValue = 
new System.UInt32[4]
{
758163768,
2068493194,
3049554713,
3933295940,
},
},
            new UInt32MArrayD1E1M
{
    Id = 65,
    Value = 
new System.UInt32[3]
{
2523060018,
1465063345,
2681228586,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 87,
    Value = 
new System.UInt32[4]
{
3080176019,
3484062283,
2946866023,
4077748075,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 68,
    Value = 
new System.UInt32[3]
{
1307127308,
3344182862,
3472322688,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 92,
    Value = 
new System.UInt32[3]
{
3800003714,
3070453827,
3797633216,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 76,
    Value = 
new System.UInt32[3]
{
1495605562,
850752139,
2936215509,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 96,
    Value = 
new System.UInt32[3]
{
127856668,
878304368,
1517012242,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
80489849,
2604333754,
1230712066,
3850126661,
},
},
            new UInt32MArrayD1E1M
{
    Id = 80,
    Value = 
new System.UInt32[4]
{
615513237,
2333627568,
1992220695,
3259572451,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 99,
    Value = 
new System.UInt32[3]
{
4260050982,
1669623195,
834191844,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
686189682,
4246718523,
2091355112,
102648648,
},
},
            new UInt32MArrayD1E1M
{
    Id = 87,
    Value = 
new System.UInt32[4]
{
3105969391,
822220109,
791181566,
1263430994,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 100,
    Value = 
new System.UInt32[3]
{
51848316,
461444406,
747520540,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
1794421515,
3288727462,
186064937,
},
},
            new UInt32MArrayD1E1M
{
    Id = 95,
    Value = 
new System.UInt32[4]
{
4177696516,
709003119,
3357265446,
3362887574,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 108,
    Value = 
new System.UInt32[4]
{
1033483392,
1311147576,
3454529959,
1382677246,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
792183519,
1983640896,
968151701,
},
},
            new UInt32MArrayD1E1M
{
    Id = 96,
    Value = 
new System.UInt32[3]
{
1928485911,
984504644,
351536935,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 115,
    Value = 
new System.UInt32[4]
{
1048241621,
2686954880,
1029041544,
1471332883,
},
    NullableValue = 
new System.UInt32[3]
{
4195378481,
1049383703,
1996170111,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 97,
    Value = 
new System.UInt32[3]
{
3697711106,
1283088727,
499875012,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 117,
    Value = 
new System.UInt32[3]
{
2048063167,
2049059867,
233339197,
},
    NullableValue = 
new System.UInt32[4]
{
243890969,
3383153794,
1332670304,
3699780277,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 102,
    Value = 
new System.UInt32[3]
{
1181771156,
3723962199,
92512636,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 123,
    Value = 
new System.UInt32[4]
{
1310872756,
3321590670,
3023855160,
649700310,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[4]
{
3091420376,
2611036775,
3868983457,
2030460362,
},
},
            new UInt32MArrayD1E1M
{
    Id = 111,
    Value = 
new System.UInt32[3]
{
4199250824,
2387599855,
248655077,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 124,
    Value = 
new System.UInt32[3]
{
3697073981,
1641567131,
2809502890,
},
    NullableValue = 
new System.UInt32[4]
{
4187880369,
3101379832,
2238136087,
4135235740,
},
},
    NullableValue = 
new System.UInt32[3]
{
4221061226,
769802629,
2138338597,
},
},
            new UInt32MArrayD1E1M
{
    Id = 117,
    Value = 
new System.UInt32[4]
{
1224347015,
1838990683,
468384955,
1528630493,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 133,
    Value = 
new System.UInt32[3]
{
446824991,
182674763,
24057161,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 119,
    Value = 
new System.UInt32[4]
{
4290908485,
3073450278,
2776909865,
465045465,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 135,
    Value = 
new System.UInt32[3]
{
2832827036,
1082156207,
2925860018,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 124,
    Value = 
new System.UInt32[3]
{
1312840400,
1056416871,
1160282705,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 140,
    Value = 
new System.UInt32[4]
{
683640700,
728500808,
3866953033,
1020767021,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 127,
    Value = 
new System.UInt32[3]
{
23929112,
3428316106,
10385991,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 144,
    Value = 
new System.UInt32[4]
{
2495818655,
3705466760,
447121363,
3899292280,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 135,
    Value = 
new System.UInt32[3]
{
2818661078,
4227726216,
3766011030,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 149,
    Value = 
new System.UInt32[3]
{
4205658178,
2852221548,
41786117,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
2180046072,
2525559990,
4215671399,
},
},
            new UInt32MArrayD1E1M
{
    Id = 137,
    Value = 
new System.UInt32[3]
{
1277495272,
206193717,
322387386,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 154,
    Value = 
new System.UInt32[3]
{
2340524734,
1668213558,
1630784943,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 141,
    Value = 
new System.UInt32[4]
{
410990683,
2158683187,
967187115,
718737990,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 156,
    Value = 
new System.UInt32[3]
{
2654319677,
131216017,
1286390810,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 145,
    Value = 
new System.UInt32[3]
{
1439256284,
1435016738,
2096403517,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 160,
    Value = 
new System.UInt32[4]
{
2040343686,
2227562523,
2974653711,
2600644043,
},
    NullableValue = 
new System.UInt32[4]
{
595963137,
1943771254,
899209237,
241512540,
},
},
    NullableValue = 
new System.UInt32[4]
{
3933749210,
2519330374,
2111845857,
2550336488,
},
},
            new UInt32MArrayD1E1M
{
    Id = 146,
    Value = 
new System.UInt32[3]
{
2648733022,
3885305913,
4145489873,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 162,
    Value = 
new System.UInt32[3]
{
3509794649,
4150743876,
2406853450,
},
    NullableValue = 
new System.UInt32[3]
{
947941436,
1985328722,
3704811637,
},
},
    NullableValue = null,
},
            new UInt32MArrayD1E1M
{
    Id = 149,
    Value = 
new System.UInt32[3]
{
3264739978,
1193015774,
2450140030,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 164,
    Value = 
new System.UInt32[3]
{
1271986938,
350544714,
1553036447,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[3]
{
3640137061,
2478287407,
3582477075,
},
},
            new UInt32MArrayD1E1M
{
    Id = 152,
    Value = 
new System.UInt32[4]
{
3158926291,
704844909,
2796307333,
4157433108,
},
    ModelInner = new UInt32MArrayD1E1MI
{
    Id = 168,
    Value = 
new System.UInt32[4]
{
539961981,
158941203,
4288063393,
1138693307,
},
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
INSERT INTO gedaqtests.uint32marrayd1e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(UInt32)}, 
    {mi_id:Int32},
    {mi_value:Array(UInt32)}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32MArrayMArrayD1)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt32[]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt32[]), 
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
                    await ((IUInt32MArrayMArrayD1)this).InsertModelDbConnectionAsync(
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
                     ((IUInt32MArrayMArrayD1)this).InsertModelDbConnection(
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
FROM gedaqtests.uint32marrayd1e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt32MArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32MArrayMArrayD1)),
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
                    var models = await ((IUInt32MArrayMArrayD1)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt32MArrayD1E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IUInt32MArrayMArrayD1)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt32MArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

