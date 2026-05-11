

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
    internal partial interface IInt32MArrayMArrayD1
    {
    }
    
    internal partial class Int32MArrayMArrayD1 : IInt32MArrayMArrayD1
    {


#region TestData

        private readonly Int32MArrayD1E1M[] _testData = new Int32MArrayD1E1M[]
        {
            new Int32MArrayD1E1M
{
    Id = 9,
    Value = 
new System.Int32[4]
{
785589204,
399398512,
1960860819,
2031907387,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 9,
    Value = 
new System.Int32[4]
{
981368118,
1867082827,
387211744,
1645901576,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
526230418,
1106141020,
1964985001,
806137491,
},
},
            new Int32MArrayD1E1M
{
    Id = 10,
    Value = 
new System.Int32[3]
{
590851106,
666447149,
728252866,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 18,
    Value = 
new System.Int32[4]
{
1453453267,
824591454,
1131159448,
313252790,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[4]
{
339088133,
1078738765,
2084583575,
1508596445,
},
},
            new Int32MArrayD1E1M
{
    Id = 15,
    Value = 
new System.Int32[4]
{
773488797,
354473774,
1306271520,
295284791,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 22,
    Value = 
new System.Int32[3]
{
1149215409,
1576074511,
837615635,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 20,
    Value = 
new System.Int32[4]
{
387421686,
1986702353,
784986745,
1096084421,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 23,
    Value = 
new System.Int32[4]
{
871435743,
1300267372,
1249152069,
1026772174,
},
    NullableValue = 
new System.Int32[3]
{
2004174247,
1263234032,
273196454,
},
},
    NullableValue = 
new System.Int32[3]
{
1179903294,
1148788249,
607066827,
},
},
            new Int32MArrayD1E1M
{
    Id = 23,
    Value = 
new System.Int32[4]
{
1324152325,
1818909129,
804933820,
1952059097,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 32,
    Value = 
new System.Int32[3]
{
380579309,
61135962,
1335676838,
},
    NullableValue = 
new System.Int32[4]
{
211542697,
1327387578,
2087911215,
1295519514,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 26,
    Value = 
new System.Int32[3]
{
2118569481,
48612042,
1491009782,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 41,
    Value = 
new System.Int32[3]
{
1612385604,
560820971,
960684769,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 31,
    Value = 
new System.Int32[4]
{
619125499,
554585262,
1239028272,
711397534,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 50,
    Value = 
new System.Int32[3]
{
1052677651,
2023339270,
1040088914,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
293582775,
1108794981,
872714907,
},
},
            new Int32MArrayD1E1M
{
    Id = 34,
    Value = 
new System.Int32[4]
{
1903298316,
1016477841,
1241135156,
2040854726,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 52,
    Value = 
new System.Int32[3]
{
679605501,
1677652733,
1393968242,
},
    NullableValue = 
new System.Int32[4]
{
700178433,
1058341013,
740840135,
754756840,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 36,
    Value = 
new System.Int32[3]
{
952292622,
1004186978,
423914665,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 59,
    Value = 
new System.Int32[3]
{
418433063,
96989423,
1447012582,
},
    NullableValue = 
new System.Int32[3]
{
209046273,
1236839243,
1937994446,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 39,
    Value = 
new System.Int32[4]
{
1730561387,
335704568,
1919171897,
1089092067,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 61,
    Value = 
new System.Int32[3]
{
1710435049,
65406594,
298673162,
},
    NullableValue = 
new System.Int32[3]
{
1897328792,
2021190120,
1352735571,
},
},
    NullableValue = 
new System.Int32[3]
{
1787944365,
1867048702,
1776930733,
},
},
            new Int32MArrayD1E1M
{
    Id = 41,
    Value = 
new System.Int32[3]
{
1191317023,
1320827591,
281103062,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 62,
    Value = 
new System.Int32[4]
{
678610645,
2018563061,
1958396710,
1723883644,
},
    NullableValue = 
new System.Int32[4]
{
1964483672,
1793679641,
1945421338,
2095507958,
},
},
    NullableValue = 
new System.Int32[4]
{
1255270579,
1745659344,
1296000051,
490380773,
},
},
            new Int32MArrayD1E1M
{
    Id = 47,
    Value = 
new System.Int32[4]
{
1331528067,
673949477,
1384870921,
1014801347,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 63,
    Value = 
new System.Int32[3]
{
269329993,
36068543,
1736184864,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
1900375162,
1304896908,
610871984,
},
},
            new Int32MArrayD1E1M
{
    Id = 50,
    Value = 
new System.Int32[4]
{
401762258,
1842012805,
284506906,
559535164,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 64,
    Value = 
new System.Int32[3]
{
1298256053,
1972718582,
2140103409,
},
    NullableValue = 
new System.Int32[4]
{
1590367088,
1335852034,
1228386775,
1750620901,
},
},
    NullableValue = 
new System.Int32[4]
{
655460706,
1756422425,
2044865129,
47029495,
},
},
            new Int32MArrayD1E1M
{
    Id = 51,
    Value = 
new System.Int32[4]
{
509467989,
1861690441,
1587632172,
177148947,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 69,
    Value = 
new System.Int32[4]
{
2030344556,
1898408213,
197835525,
66804784,
},
    NullableValue = 
new System.Int32[4]
{
1160964133,
302687044,
371065328,
1940302815,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 56,
    Value = 
new System.Int32[3]
{
1342351198,
1168357690,
625065494,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 76,
    Value = 
new System.Int32[4]
{
1063802727,
588142201,
1545567862,
588859061,
},
    NullableValue = 
new System.Int32[3]
{
1270133428,
1268730822,
869564772,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 62,
    Value = 
new System.Int32[3]
{
889682602,
1073681496,
1991153419,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 79,
    Value = 
new System.Int32[3]
{
2061927930,
1361419920,
52953021,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
779505452,
651456671,
649689933,
},
},
            new Int32MArrayD1E1M
{
    Id = 66,
    Value = 
new System.Int32[4]
{
759599154,
1249045328,
1718239,
2059154864,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 84,
    Value = 
new System.Int32[3]
{
1183949702,
1543620219,
1700934705,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 67,
    Value = 
new System.Int32[4]
{
1697425729,
669174125,
755436953,
234024307,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 92,
    Value = 
new System.Int32[4]
{
348675901,
1827928413,
154482939,
1439025184,
},
    NullableValue = 
new System.Int32[3]
{
1859633722,
1980958675,
1117345922,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 74,
    Value = 
new System.Int32[3]
{
1541823872,
1578578551,
880892310,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 93,
    Value = 
new System.Int32[3]
{
111299548,
163008407,
1899436760,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
1519681440,
2006148048,
651354328,
},
},
            new Int32MArrayD1E1M
{
    Id = 75,
    Value = 
new System.Int32[4]
{
1399989878,
1680873063,
319507105,
1068722840,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 99,
    Value = 
new System.Int32[4]
{
1888198898,
1568716174,
2023055097,
1319966349,
},
    NullableValue = 
new System.Int32[4]
{
2029510655,
1859441356,
2023339746,
137259619,
},
},
    NullableValue = 
new System.Int32[3]
{
1381378917,
513369602,
2140194472,
},
},
            new Int32MArrayD1E1M
{
    Id = 82,
    Value = 
new System.Int32[4]
{
1744384295,
1739207009,
1153119122,
1967511100,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 107,
    Value = 
new System.Int32[4]
{
584595761,
260583578,
1082487626,
72302880,
},
    NullableValue = 
new System.Int32[3]
{
1955168885,
620155338,
1608912723,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 90,
    Value = 
new System.Int32[3]
{
1079909396,
47585108,
1613808938,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 108,
    Value = 
new System.Int32[3]
{
1232132490,
774430303,
899637345,
},
    NullableValue = 
new System.Int32[4]
{
2121618279,
74991524,
740475448,
1832614087,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 99,
    Value = 
new System.Int32[4]
{
173078998,
1919297751,
1667214397,
1302128620,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 114,
    Value = 
new System.Int32[3]
{
2041099673,
781578028,
139405690,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 104,
    Value = 
new System.Int32[4]
{
1884622253,
1215040953,
1911809214,
1831772679,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 122,
    Value = 
new System.Int32[3]
{
1778712798,
1485046907,
483528175,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 112,
    Value = 
new System.Int32[3]
{
942539706,
751056566,
268755909,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 127,
    Value = 
new System.Int32[4]
{
1327320296,
1437437303,
778668085,
1002704931,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
1745722974,
1444417928,
114163652,
},
},
            new Int32MArrayD1E1M
{
    Id = 121,
    Value = 
new System.Int32[4]
{
1589684416,
1762327430,
403200512,
886624771,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 136,
    Value = 
new System.Int32[3]
{
719835980,
890131715,
683363543,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 125,
    Value = 
new System.Int32[4]
{
225770152,
1303708921,
1533691808,
630309349,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 139,
    Value = 
new System.Int32[4]
{
651468806,
1495435647,
1461266054,
1987050523,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
327332498,
1086427952,
517187648,
},
},
            new Int32MArrayD1E1M
{
    Id = 126,
    Value = 
new System.Int32[3]
{
725427978,
171202945,
365646386,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 142,
    Value = 
new System.Int32[3]
{
439522220,
235578728,
1057615059,
},
    NullableValue = 
new System.Int32[3]
{
1295172977,
274216589,
1013637394,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 135,
    Value = 
new System.Int32[3]
{
459779501,
270409982,
663193357,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 144,
    Value = 
new System.Int32[3]
{
67165848,
602088409,
1794301106,
},
    NullableValue = 
new System.Int32[4]
{
553334420,
1775772515,
2053018241,
1131693387,
},
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 142,
    Value = 
new System.Int32[3]
{
116708967,
1707328680,
810756405,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 149,
    Value = 
new System.Int32[3]
{
685117808,
48823912,
1776811011,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 146,
    Value = 
new System.Int32[3]
{
1251565621,
1970795595,
1837330531,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 153,
    Value = 
new System.Int32[3]
{
1360482717,
1888736096,
268704446,
},
    NullableValue = 
new System.Int32[4]
{
1979266878,
920496633,
982056092,
1626787068,
},
},
    NullableValue = 
new System.Int32[4]
{
883315086,
1411487567,
277206355,
1775497280,
},
},
            new Int32MArrayD1E1M
{
    Id = 152,
    Value = 
new System.Int32[4]
{
1598098551,
885298782,
352521651,
1127037696,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 155,
    Value = 
new System.Int32[3]
{
1109642517,
1814502066,
641099467,
},
    NullableValue = 
new System.Int32[4]
{
540614063,
563378329,
2108273568,
1775732020,
},
},
    NullableValue = 
new System.Int32[3]
{
1238125140,
1443238270,
1837617198,
},
},
            new Int32MArrayD1E1M
{
    Id = 159,
    Value = 
new System.Int32[4]
{
161875625,
1609584044,
275206250,
1052171384,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 156,
    Value = 
new System.Int32[4]
{
809887823,
496649912,
1762236791,
603177354,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
401513071,
1273357169,
646219242,
},
},
            new Int32MArrayD1E1M
{
    Id = 168,
    Value = 
new System.Int32[3]
{
13186071,
945974216,
1117480460,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 162,
    Value = 
new System.Int32[3]
{
530581570,
320442913,
1914362469,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32MArrayD1E1M
{
    Id = 171,
    Value = 
new System.Int32[4]
{
2006077227,
115457077,
1056677063,
101475938,
},
    ModelInner = new Int32MArrayD1E1MI
{
    Id = 170,
    Value = 
new System.Int32[3]
{
959355360,
126122302,
1366454265,
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
INSERT INTO gedaqtests.int32marrayd1e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Int32)}, 
    {mi_id:Int32},
    {mi_value:Array(Int32)}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayMArrayD1)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32[]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32[]), 
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
                    await ((IInt32MArrayMArrayD1)this).InsertModelDbConnectionAsync(
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
                     ((IInt32MArrayMArrayD1)this).InsertModelDbConnection(
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
FROM gedaqtests.int32marrayd1e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int32MArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayMArrayD1)),
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
                    var models = await ((IInt32MArrayMArrayD1)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int32MArrayD1E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IInt32MArrayMArrayD1)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int32MArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

