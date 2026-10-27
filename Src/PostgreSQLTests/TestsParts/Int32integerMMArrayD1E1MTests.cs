

using Npgsql;
using NpgsqlTypes;
using Gedaq.Common.Enums;
using Gedaq.Npgsql.Attributes;
using Gedaq.Npgsql.Enums;
using System;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IInt32MArrayintegerMMArrayD1
    {
    }
    
    internal partial class Int32MArrayintegerMMArrayD1 : IInt32MArrayintegerMMArrayD1
    {


#region TestData

        private readonly Int32integerMMArrayD1E1M[] _testData = new Int32integerMMArrayD1E1M[]
        {
            new Int32integerMMArrayD1E1M
{
    Id = 4,
    Value = 
new System.Int32[4]
{
82121271,
19011535,
1871075675,
149896354,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 8,
    Value = 
new System.Int32[4]
{
1984167303,
767887626,
2120034205,
1634829129,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 6,
    Value = 
new System.Int32[4]
{
1563733081,
270045018,
1013876942,
1412676325,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 17,
    Value = 
new System.Int32[4]
{
365731833,
74981355,
1297315167,
1260156443,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 26,
    Value = 
new System.Int32[4]
{
981194401,
984222400,
24635481,
1323575665,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 15,
    Value = 
new System.Int32[3]
{
355183607,
2108000302,
711320337,
},
    NullableValue = 
new System.Int32[4]
{
682394115,
145237789,
1684974544,
359543984,
},
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 29,
    Value = 
new System.Int32[4]
{
267285897,
1319010082,
693066075,
1504596067,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 30,
    Value = 
new System.Int32[3]
{
1575442664,
1273865998,
528497252,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 23,
    Value = 
new System.Int32[3]
{
778628086,
1695465026,
2074426092,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 37,
    Value = 
new System.Int32[4]
{
561536974,
2061216147,
647413201,
1622785464,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 45,
    Value = 
new System.Int32[3]
{
899772915,
1821910013,
37116185,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 24,
    Value = 
new System.Int32[4]
{
2026621329,
1939370258,
324108442,
1792128510,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 48,
    Value = 
new System.Int32[4]
{
398468353,
361117466,
282247892,
1028869349,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 50,
    Value = 
new System.Int32[3]
{
23840904,
1792722725,
1594669164,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 27,
    Value = 
new System.Int32[3]
{
662292763,
1417546502,
420139012,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 56,
    Value = 
new System.Int32[4]
{
1630134133,
910095234,
299709760,
171830408,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
1829200131,
2116034815,
1383851148,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 60,
    Value = 
new System.Int32[4]
{
557924234,
215602659,
1761443115,
2091421940,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 31,
    Value = 
new System.Int32[4]
{
370402947,
834622365,
23119981,
843387179,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
1251375024,
1229369696,
1880422687,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 67,
    Value = 
new System.Int32[4]
{
708014127,
459654047,
1419131003,
1046150936,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[4]
{
870501132,
834179505,
636690552,
907146990,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 70,
    Value = 
new System.Int32[3]
{
644512843,
569591502,
1658046047,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 39,
    Value = 
new System.Int32[4]
{
1752209856,
1849025688,
1306836250,
46647386,
},
    NullableValue = 
new System.Int32[4]
{
586801936,
961458526,
1114377555,
2123218438,
},
},
    NullableValue = 
new System.Int32[4]
{
732755323,
289871188,
1791383376,
834859588,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 74,
    Value = 
new System.Int32[4]
{
1525774699,
1731787831,
1284404998,
1257598298,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
1457225153,
572351755,
2000973311,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 82,
    Value = 
new System.Int32[4]
{
494401556,
723407789,
521752832,
1116998240,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 48,
    Value = 
new System.Int32[4]
{
1878175435,
220568071,
1624299173,
534691861,
},
    NullableValue = 
new System.Int32[3]
{
1992168289,
1843525568,
750770240,
},
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 91,
    Value = 
new System.Int32[4]
{
1898936602,
857218445,
434020303,
313263668,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[4]
{
1877650869,
324122257,
160487137,
882228306,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 100,
    Value = 
new System.Int32[3]
{
875687696,
1258053871,
347023977,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 52,
    Value = 
new System.Int32[4]
{
1456048702,
30069659,
720884361,
1393160188,
},
    NullableValue = 
new System.Int32[3]
{
1889051120,
1596258463,
146689336,
},
},
    NullableValue = 
new System.Int32[4]
{
104359172,
191293255,
298747629,
88934331,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 106,
    Value = 
new System.Int32[4]
{
693052102,
1844595943,
1690798938,
364805791,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
1640263573,
870524089,
307400614,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 107,
    Value = 
new System.Int32[4]
{
2056465909,
1478159458,
1953299638,
1410417952,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 60,
    Value = 
new System.Int32[3]
{
492995562,
467083610,
970931775,
},
    NullableValue = 
new System.Int32[3]
{
2093657277,
576515378,
8664481,
},
},
    NullableValue = 
new System.Int32[4]
{
994612178,
1139088356,
2037144034,
972445506,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 109,
    Value = 
new System.Int32[3]
{
750266914,
1978632476,
33315734,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
1714393739,
1631092786,
492419116,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 113,
    Value = 
new System.Int32[4]
{
1835244126,
893517959,
725697742,
765036820,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 65,
    Value = 
new System.Int32[3]
{
920350272,
82669095,
1364360570,
},
    NullableValue = 
new System.Int32[3]
{
695479907,
1322949251,
1760880051,
},
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 114,
    Value = 
new System.Int32[4]
{
857995831,
817660812,
2102806706,
1766441840,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 117,
    Value = 
new System.Int32[4]
{
2057761974,
733027990,
1863283632,
737081600,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 73,
    Value = 
new System.Int32[4]
{
845417091,
784142901,
661329704,
1773918669,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 121,
    Value = 
new System.Int32[4]
{
559830471,
1436651439,
852705786,
202595979,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 123,
    Value = 
new System.Int32[4]
{
1787295422,
1553528114,
1356939190,
1267958449,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 77,
    Value = 
new System.Int32[3]
{
809291794,
1523758527,
770764239,
},
    NullableValue = 
new System.Int32[4]
{
1198742803,
1326104689,
2141640629,
422771953,
},
},
    NullableValue = 
new System.Int32[4]
{
740241710,
128709885,
1775529069,
180889599,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 124,
    Value = 
new System.Int32[4]
{
1788591356,
128855719,
1602593893,
56890234,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 132,
    Value = 
new System.Int32[3]
{
1540181097,
281428592,
424167184,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 78,
    Value = 
new System.Int32[4]
{
1176357481,
72404885,
65886634,
1802040701,
},
    NullableValue = 
new System.Int32[3]
{
1958589321,
1226586465,
1064540400,
},
},
    NullableValue = 
new System.Int32[4]
{
364891766,
1426931461,
109782483,
595255620,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 136,
    Value = 
new System.Int32[3]
{
2115389971,
18016419,
2098553497,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 144,
    Value = 
new System.Int32[3]
{
1556988814,
393392261,
714615129,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 82,
    Value = 
new System.Int32[3]
{
339810948,
1936167038,
2125514281,
},
    NullableValue = 
new System.Int32[3]
{
968669897,
306873538,
1648664479,
},
},
    NullableValue = 
new System.Int32[4]
{
282572838,
1065926472,
1094845908,
905245918,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 148,
    Value = 
new System.Int32[3]
{
818255063,
1949443984,
430636104,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
102925023,
557800002,
892290910,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 154,
    Value = 
new System.Int32[3]
{
1919572559,
805254521,
1671306801,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 85,
    Value = 
new System.Int32[4]
{
656785305,
338320822,
194482358,
1876576664,
},
    NullableValue = 
new System.Int32[3]
{
1796305274,
905004713,
71930219,
},
},
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 160,
    Value = 
new System.Int32[4]
{
235871830,
1312322093,
1129502364,
1294476993,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerMMArrayD1E1M
{
    Id = 161,
    Value = 
new System.Int32[3]
{
655279458,
801364847,
2045498261,
},
    ModelInner = new Int32integerMMArrayD1E1MI
{
    Id = 89,
    Value = 
new System.Int32[4]
{
3730620,
1371638794,
860100597,
1169733994,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
349227939,
294791702,
1890835813,
},
},
            new Int32integerMMArrayD1E1M
{
    Id = 163,
    Value = 
new System.Int32[3]
{
1564272345,
1580698359,
2089624042,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[4]
{
1102130470,
1481328923,
646532472,
1956360456,
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integermmarrayd1e1mi(
	id,
    value,
    nullablevalue
)
VALUES (
    $1, 
    $2, 
    $3
);
",
            methodName:"InsertModelInner",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integermmarrayd1e1mi(
	id,
    value,
    nullablevalue
)
VALUES (
    $1, 
    $2, 
    $3
)
RETURNING
    id,
    value,
    nullablevalue
;
",
            methodName:"InsertModelInnerReturning",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639))]
        public void InsertModelInnerReturningConfig()
        {
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((IInt32MArrayintegerMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt32MArrayintegerMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id =  ((IInt32MArrayintegerMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt32MArrayintegerMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[11].ModelInner.Id));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integermmarrayd1e1m(
	id,
    value,
    nullablevalue,
    int32integermmarrayd1e1mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
);
",
            methodName:"InsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int32integermmarrayd1e1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;
                changedRows =  ((IInt32MArrayintegerMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt32MArrayintegerMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;
                changedRows = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integermmarrayd1e1m(
	id,
    value,
    nullablevalue,
    int32integermmarrayd1e1mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
)
RETURNING
    nullablevalue,
    value,
~StartInner::ModelInner:Id~
~Reinterpret::Id~
    int32integermmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Int32[]>();
                    ((NpgsqlParameter<System.Int32[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483639);
                    ((NpgsqlParameter<System.Int32[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483639);
                    if (_testData[4].NullableValue != null)
                    {
                        parameters[2].Value = _testData[4].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[4].ModelInner != null)
                    {
                        parameters[3].Value = _testData[4].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((IInt32MArrayintegerMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Int32[]>();
                    ((NpgsqlParameter<System.Int32[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483639);
                    ((NpgsqlParameter<System.Int32[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483639);
                    if (_testData[5].NullableValue != null)
                    {
                        parameters[2].Value = _testData[5].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[5].ModelInner != null)
                    {
                        parameters[3].Value = _testData[5].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((IInt32MArrayintegerMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Int32[]>();
                    ((NpgsqlParameter<System.Int32[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483639);
                    ((NpgsqlParameter<System.Int32[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483639);
                    if (_testData[6].NullableValue != null)
                    {
                        parameters[2].Value = _testData[6].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[6].ModelInner != null)
                    {
                        parameters[3].Value = _testData[6].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((IInt32MArrayintegerMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Int32[]>();
                    ((NpgsqlParameter<System.Int32[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483639);
                    ((NpgsqlParameter<System.Int32[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483639);
                    if (_testData[7].NullableValue != null)
                    {
                        parameters[2].Value = _testData[7].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[7].ModelInner != null)
                    {
                        parameters[3].Value = _testData[7].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((IInt32MArrayintegerMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integermmarrayd1e1m(
	id,
    value,
    nullablevalue,
    int32integermmarrayd1e1mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
)
RETURNING
    nullablevalue,
    value,
~StartInner::ModelInner:Id~
~Reinterpret::Id~
    int32integermmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int32integermmarrayd1e1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32[] nullable = null;
                nullable =  ((IInt32MArrayintegerMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IInt32MArrayintegerMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32[] nullable = null;
                nullable = await ((IInt32MArrayintegerMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[3]
{
1829200131,
2116034815,
1383851148,
}));
                nullable = await ((IInt32MArrayintegerMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[3]
{
1251375024,
1229369696,
1880422687,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int32integerMMArrayD1E1M> models = null;

                models =  ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int32integerMMArrayD1E1M> models = null;

                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IInt32MArrayintegerMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerMMArrayD1E1M), typeof(FlatInt32integerMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void MMDynQuerySelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt32integerMMArrayD1E1M>();
                var models2 = new List<FlatInt32integerMMArrayD1E1M>();
                await ((IInt32MArrayintegerMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt32integerMMArrayD1E1M>();
                var models2 = new List<FlatInt32integerMMArrayD1E1M>();
                ((IInt32MArrayintegerMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void DynQuerySelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt32MArrayintegerMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt32MArrayintegerMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.int32integermmarrayd1e1m m
LEFT JOIN public.int32integermmarrayd1e1mi mi ON mi.id = m.int32integermmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void SelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt32MArrayintegerMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt32MArrayintegerMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerMMArrayD1E1M), typeof(FlatInt32integerMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void MMDynQuerySelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integerMMArrayD1E1M>();
                var models2 = new List<FlatInt32integerMMArrayD1E1M>();
                await ((IInt32MArrayintegerMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integerMMArrayD1E1M>();
                var models2 = new List<FlatInt32integerMMArrayD1E1M>();
                ((IInt32MArrayintegerMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void DynQuerySelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt32MArrayintegerMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt32MArrayintegerMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.int32integermmarrayd1e1m m
LEFT JOIN public.int32integermmarrayd1e1mi mi ON mi.id = m.int32integermmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt32MArrayintegerMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt32MArrayintegerMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerMMArrayD1E1M), typeof(FlatInt32integerMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionSTMMDynQuerySelectModelDynParBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionMMDynQuerySelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32integerMMArrayD1E1M>();
                var models2 = new List<FlatInt32integerMMArrayD1E1M>();
                await((IInt32MArrayintegerMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt32integerMMArrayD1E1M>();
                await ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                await ((IInt32MArrayintegerMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32integerMMArrayD1E1M>();
                var models2 = new List<FlatInt32integerMMArrayD1E1M>();
                ((IInt32MArrayintegerMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt32integerMMArrayD1E1M>();
                 ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                 ((IInt32MArrayintegerMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[25],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionDynQuerySelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt32MArrayintegerMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatInt32integerMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatInt32integerMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 160;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt32integerMMArrayD1E1M>();
                await ((IInt32MArrayintegerMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt32MArrayintegerMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatInt32integerMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatInt32integerMMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt32integerMMArrayD1E1M>();
                 ((IInt32MArrayintegerMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[17],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 

@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.int32integermmarrayd1e1m m
LEFT JOIN public.int32integermmarrayd1e1mi mi ON mi.id = m.int32integermmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 2)]
        private void DbConnectionSTSelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt32MArrayintegerMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerMMArrayD1E1M), typeof(FlatInt32integerMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 2)]
        private void DbConnectionSTMMDynQuerySelectModelBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 2)]
        private void DbConnectionMMDynQuerySelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integerMMArrayD1E1M>();
                var models2 = new List<FlatInt32integerMMArrayD1E1M>();
                await((IInt32MArrayintegerMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt32integerMMArrayD1E1M>();
                await ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 17, query1, 160, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                await ((IInt32MArrayintegerMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 37, query1, 132, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integerMMArrayD1E1M>();
                var models2 = new List<FlatInt32integerMMArrayD1E1M>();
                ((IInt32MArrayintegerMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integerMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt32integerMMArrayD1E1M>();
                 ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 74, query1, 113, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                 ((IInt32MArrayintegerMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 132, query1, 109, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[13],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 2)]
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 2)]
        private void DbConnectionDynQuerySelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt32MArrayintegerMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 70, query1, 26, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatInt32integerMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatInt32integerMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt32integerMMArrayD1E1M>();
                await ((IInt32MArrayintegerMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 48, query1, 113, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt32MArrayintegerMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integerMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 154, query1, 113, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatInt32integerMMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatInt32integerMMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.int32integermmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt32integerMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt32integerMMArrayD1E1M>();
                 ((IInt32MArrayintegerMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 121, query1, 154, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatInt32integerMMArrayD1E1M.AssertModel(secondItems2[2],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 

@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.int32integermmarrayd1e1m m
LEFT JOIN public.int32integermmarrayd1e1mi mi ON mi.id = m.int32integermmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2)]
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((IInt32MArrayintegerMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 117, 144))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integerMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32MArrayintegerMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 74, 26))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        Int32integerMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IInt32MArrayintegerMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt32MArrayintegerMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 113);
                var models = await ((IInt32MArrayintegerMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                Int32integerMMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                Int32integerMMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                Int32integerMMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                Int32integerMMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                Int32integerMMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                Int32integerMMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                Int32integerMMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                Int32integerMMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                Int32integerMMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                Int32integerMMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                Int32integerMMArrayD1E1M.AssertModel(models[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32MArrayintegerMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32MArrayintegerMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 100);
                var models =  ((IInt32MArrayintegerMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                Int32integerMMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                Int32integerMMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                Int32integerMMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                Int32integerMMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                Int32integerMMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                Int32integerMMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                Int32integerMMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                Int32integerMMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                Int32integerMMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                Int32integerMMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                Int32integerMMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                Int32integerMMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                Int32integerMMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                Int32integerMMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                Int32integerMMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                Int32integerMMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                Int32integerMMArrayD1E1M.AssertModel(models[16],_testData[34], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_int32integermmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int32integerMMArrayD1E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt32MArrayintegerMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int32integermmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt32MArrayintegerMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryWAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Int32integerMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt32MArrayintegerMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int32integermmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt32MArrayintegerMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_int32integermmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int32integerMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt32MArrayintegerMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int32integermmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt32MArrayintegerMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Int32integerMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt32MArrayintegerMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int32integermmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt32MArrayintegerMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_int32integermmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int32integermmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int32integerMMArrayD1E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt32MArrayintegerMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt32MArrayintegerMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerMMArrayD1E1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Int32integerMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt32MArrayintegerMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt32MArrayintegerMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerMMArrayD1E1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_int32integermmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int32integermmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int32integerMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt32MArrayintegerMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt32MArrayintegerMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Int32integerMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt32MArrayintegerMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((IInt32MArrayintegerMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int32integermmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int32integermmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int32integerMMArrayD1E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1))]
        private void ImportModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.binary_int32integermmarrayd1e1m m
LEFT JOIN public.binary_int32integermmarrayd1e1mi mi ON mi.id = m.int32integermmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt32MArrayintegerMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt32MArrayintegerMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int32integerMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(10)]
        public  void ImportModelTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Int32integerMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt32MArrayintegerMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((IInt32MArrayintegerMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int32integerMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int32integermmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int32integermmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639)
            })]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt32MArrayintegerMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int32integerMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt32MArrayintegerMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int32integerMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1MIWA), typeof(Int32integerMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639)
            })]
        private void MMDynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Int32integerMMArrayD1E1MIWA>();
                var models2 = new List<Int32integerMMArrayD1E1MIWA>();
                await ((IInt32MArrayintegerMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int32integermmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Int32integerMMArrayD1E1MIWA>();
                var models2 = new List<Int32integerMMArrayD1E1MIWA>();
                ((IInt32MArrayintegerMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int32integermmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639)
            })]
        private void DynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IInt32MArrayintegerMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int32integermmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IInt32MArrayintegerMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int32integermmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1MIWA), typeof(Int32integerMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1))]
        private void MMDynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Int32integerMMArrayD1E1MIWA>();
                var models2 = new List<Int32integerMMArrayD1E1MIWA>();
                await ((IInt32MArrayintegerMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int32integermmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Int32integerMMArrayD1E1MIWA>();
                var models2 = new List<Int32integerMMArrayD1E1MIWA>();
                ((IInt32MArrayintegerMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int32integermmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IInt32MArrayintegerMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int32integermmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IInt32MArrayintegerMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int32integermmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int32integermmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1MI), typeof(Int32integerMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639)
            })]
        private void MMWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Int32integerMMArrayD1E1MI>();
                var models2 = new List<Int32integerMMArrayD1E1MI>();
                await ((IInt32MArrayintegerMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Int32integerMMArrayD1E1MI>();
                var models2 = new List<Int32integerMMArrayD1E1MI>();
                ((IInt32MArrayintegerMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int32integermmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639),
                (NpgsqlTypes.NpgsqlDbType)(-2147483639)
            })]
        private void WAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task WAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IInt32MArrayintegerMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerMMArrayD1E1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void WAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IInt32MArrayintegerMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerMMArrayD1E1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int32integermmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1MIWA), typeof(Int32integerMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1))]
        private void MMExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Int32integerMMArrayD1E1MIWA>();
                var models2 = new List<Int32integerMMArrayD1E1MIWA>();
                await ((IInt32MArrayintegerMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Int32integerMMArrayD1E1MIWA>();
                var models2 = new List<Int32integerMMArrayD1E1MIWA>();
                ((IInt32MArrayintegerMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int32integermmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int32integerMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32MArrayintegerMMArrayD1))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IInt32MArrayintegerMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IInt32MArrayintegerMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

