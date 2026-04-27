

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
    internal partial interface IInt32ListintegerArray
    {
    }
    
    internal partial class Int32ListintegerArray : IInt32ListintegerArray
    {


#region TestData

        private readonly Int32integerArray2M[] _testData = new Int32integerArray2M[]
        {
            new Int32integerArray2M
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
582647314,

747662117,

1101519475,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
213051785,

1210824291,

1102474176,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
789604779,

1577577073,

141290285,

586801616,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1653020347,

884452763,

1362354029,

1274466706,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1205560724,

824701518,

1658014640,

1523447283,

},
},
            new Int32integerArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
288785327,

1037288616,

843311743,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
626742474,

1726992337,

1679767311,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
605756223,

460795627,

66785889,

1747112926,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
644078119,

540355886,

1897344189,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
239565424,

1550993431,

1954850222,

},
},
            new Int32integerArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1664928026,

338779570,

1391272677,

1049867598,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
151933113,

196353066,

538824134,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
226877778,

1582055612,

1144242836,

1669896057,

},
},
            new Int32integerArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1743971160,

940938386,

1005728217,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
158607243,

703524314,

1184116915,

},
},
            new Int32integerArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1091853292,

454233522,

368672932,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1070105826,

211715055,

364106116,

1410539312,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
604429568,

1393849953,

450448196,

144388435,

},
},
            new Int32integerArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
2076823423,

1869186163,

111013944,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
285680403,

1831548347,

591438249,

855034893,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1262989697,

965170152,

1679743383,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1169600688,

706125121,

1313397653,

847043496,

},
},
            new Int32integerArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1760126665,

1499520789,

120471363,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1350020695,

530813502,

1998903737,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
716166390,

453597000,

1009891464,

393926090,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
396974328,

1580292583,

1842766637,

490607962,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
262553259,

1758770819,

83218317,

},
},
            new Int32integerArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
117450076,

1892722280,

1539582487,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1281939845,

414956041,

188023118,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1602157811,

603255873,

993263020,

},
},
            new Int32integerArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1851238004,

2075161303,

1891385716,

493976382,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1750942192,

771902360,

116485061,

1911378339,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1535370228,

1564245539,

619713369,

1757060282,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
287528949,

539349918,

185962835,

},
},
            new Int32integerArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1934553927,

1618887615,

1342765432,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
2043948596,

835243285,

426450995,

1480470314,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
948511101,

149214760,

1676744195,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1616599750,

1133972620,

410303629,

131808101,

},
},
            new Int32integerArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1260745680,

1970960104,

1000573752,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
580397684,

950709620,

1605560990,

},
},
            new Int32integerArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1243185835,

1575257124,

245066990,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1376221450,

159936411,

958584748,

412747719,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1769794426,

1648175357,

1457975657,

},
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
566149941,

1743046389,

1833972065,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1610444762,

1693306851,

1639767450,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
434350907,

2040106749,

169471465,

314930426,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
1660616018,

1994459210,

1780529851,

1550821298,

},
},
            new Int32integerArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1960514129,

1806786339,

1293702416,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
847495088,

454761045,

212653534,

},
},
            new Int32integerArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1377725881,

1800243844,

1751171289,

1577864705,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
2086186570,

1920773440,

2138454202,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
469394338,

1567414549,

69680730,

1016737715,

},
},
            new Int32integerArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1290501808,

1413681448,

1079668224,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(4)
{
196752685,

452145600,

1389236130,

86456095,

},
},
            new Int32integerArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
2132287449,

1651013916,

1430144438,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
836920359,

1766402107,

331508602,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
1061791687,

782269909,

287228844,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.Int32>(3)
{
2105894830,

2048486622,

1086611731,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
2008356713,

1426051828,

1016035818,

1048769904,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1831359985,

1996135220,

1166781109,

},
},
    NullableValue = null,
},
            new Int32integerArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
792095121,

829848508,

1850836771,

320670008,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1059079774,

456021943,

46286837,

},
},
            new Int32integerArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1112025326,

424896845,

363800704,

1570798347,

},
    ModelInner = new Int32integerArray2MI
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Int32>(4)
{
1501503513,

1426123822,

1732538722,

2129797326,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int32>(3)
{
1438581663,

259266362,

1320727770,

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integerarray2mi(
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
            asPartInterface: typeof(IInt32ListintegerArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int32>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int32>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integerarray2mi(
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
            queryMapTypes: [typeof(Int32integerArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int32>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int32>), 
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

                changedRows =  ((IInt32ListintegerArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt32ListintegerArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt32ListintegerArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32ListintegerArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt32ListintegerArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt32ListintegerArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt32ListintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt32ListintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt32ListintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt32ListintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt32ListintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt32ListintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt32ListintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt32ListintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt32ListintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integerarray2m(
	id,
    value,
    nullablevalue,
    int32integerarray2mi_id
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
            asPartInterface: typeof(IInt32ListintegerArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int32>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int32>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int32integerarray2mi_id", 
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
                changedRows =  ((IInt32ListintegerArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt32ListintegerArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt32ListintegerArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt32ListintegerArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integerarray2m(
	id,
    value,
    nullablevalue,
    int32integerarray2mi_id
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
    int32integerarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int32integerArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integerarray2m(
	id,
    value,
    nullablevalue,
    int32integerarray2mi_id
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
    int32integerarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int32integerArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int32>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int32>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483639)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int32integerarray2mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int32integerArray2M> models = null;

                models =  ((IInt32ListintegerArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IInt32ListintegerArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IInt32ListintegerArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IInt32ListintegerArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int32integerArray2M> models = null;

                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt32ListintegerArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerArray2M), typeof(FlatInt32integerArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
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
FROM public.int32integerarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt32integerArray2M>();
                var models2 = new List<FlatInt32integerArray2M>();
                await ((IInt32ListintegerArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int32integerarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt32integerArray2M>();
                var models2 = new List<FlatInt32integerArray2M>();
                ((IInt32ListintegerArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
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
FROM public.int32integerarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt32ListintegerArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integerarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt32ListintegerArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integerarray2m m
LEFT JOIN public.int32integerarray2mi mi ON mi.id = m.int32integerarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int32integerArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
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
                var models = await ((IInt32ListintegerArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32integerArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt32ListintegerArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32integerArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerArray2M), typeof(FlatInt32integerArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
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
FROM public.int32integerarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integerArray2M>();
                var models2 = new List<FlatInt32integerArray2M>();
                await ((IInt32ListintegerArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int32integerarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integerArray2M>();
                var models2 = new List<FlatInt32integerArray2M>();
                ((IInt32ListintegerArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
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
FROM public.int32integerarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt32ListintegerArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integerarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt32ListintegerArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integerarray2m m
LEFT JOIN public.int32integerarray2mi mi ON mi.id = m.int32integerarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int32integerArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
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
                var models = await ((IInt32ListintegerArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32integerArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt32ListintegerArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32integerArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerArray2M), typeof(FlatInt32integerArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
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
            asPartInterface: typeof(IInt32ListintegerArray)),
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32integerArray2M>();
                var models2 = new List<FlatInt32integerArray2M>();
                await((IInt32ListintegerArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
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
FROM public.int32integerarray2m m
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray2M>();
                var firstItems2 = new List<FlatInt32integerArray2M>();
                var secondItems1 = new List<FlatInt32integerArray2M>();
                var secondItems2 = new List<FlatInt32integerArray2M>();
                await ((IInt32ListintegerArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[19],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
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
FROM public.int32integerarray2m m
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray2M>();
                var firstItems2 = new List<FlatInt32integerArray2M>();
                var secondItems1 = new List<FlatInt32integerArray2M>();
                await ((IInt32ListintegerArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[14],_testData[29], false);
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32integerArray2M>();
                var models2 = new List<FlatInt32integerArray2M>();
                ((IInt32ListintegerArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
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
FROM public.int32integerarray2m m
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray2M>();
                var firstItems2 = new List<FlatInt32integerArray2M>();
                var secondItems1 = new List<FlatInt32integerArray2M>();
                var secondItems2 = new List<FlatInt32integerArray2M>();
                 ((IInt32ListintegerArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[16],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
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
FROM public.int32integerarray2m m
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray2M>();
                var firstItems2 = new List<FlatInt32integerArray2M>();
                var secondItems1 = new List<FlatInt32integerArray2M>();
                 ((IInt32ListintegerArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[22],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
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
            asPartInterface: typeof(IInt32ListintegerArray)),
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt32ListintegerArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integerarray2m m
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32ListintegerArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt32integerArray2M.AssertModel(models[0],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(models[1],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(models[2],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(models[3],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatInt32integerArray2M.AssertModel(models[0],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(models[1],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(models[2],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(models[3],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(models[4],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(models[5],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(models[6],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(models[7],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(models[8],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(models[9],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(models[10],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(models[11],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(models[12],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(models[13],_testData[29], false);
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integerarray2m m
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray2M>();
                var secondItems1 = new List<FlatInt32integerArray2M>();
                var secondItems2 = new List<FlatInt32integerArray2M>();
                await ((IInt32ListintegerArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[4],_testData[29], false);
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt32ListintegerArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integerarray2m m
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32ListintegerArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatInt32integerArray2M.AssertModel(models[0],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(models[1],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatInt32integerArray2M.AssertModel(models[0],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(models[1],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(models[2],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(models[3],_testData[29], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integerarray2m m
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray2M>();
                var secondItems1 = new List<FlatInt32integerArray2M>();
                var secondItems2 = new List<FlatInt32integerArray2M>();
                 ((IInt32ListintegerArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[18],_testData[29], false);
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
FROM public.int32integerarray2m m
LEFT JOIN public.int32integerarray2mi mi ON mi.id = m.int32integerarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int32integerArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
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
                var models = await((IInt32ListintegerArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32integerArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32ListintegerArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Int32integerArray2M.AssertModel(models[0],_testData[19], false);
                        Int32integerArray2M.AssertModel(models[1],_testData[20], false);
                        Int32integerArray2M.AssertModel(models[2],_testData[21], false);
                        Int32integerArray2M.AssertModel(models[3],_testData[22], false);
                        Int32integerArray2M.AssertModel(models[4],_testData[23], false);
                        Int32integerArray2M.AssertModel(models[5],_testData[24], false);
                        Int32integerArray2M.AssertModel(models[6],_testData[25], false);
                        Int32integerArray2M.AssertModel(models[7],_testData[26], false);
                        Int32integerArray2M.AssertModel(models[8],_testData[27], false);
                        Int32integerArray2M.AssertModel(models[9],_testData[28], false);
                        Int32integerArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Int32integerArray2M.AssertModel(models[0],_testData[21], false);
                        Int32integerArray2M.AssertModel(models[1],_testData[22], false);
                        Int32integerArray2M.AssertModel(models[2],_testData[23], false);
                        Int32integerArray2M.AssertModel(models[3],_testData[24], false);
                        Int32integerArray2M.AssertModel(models[4],_testData[25], false);
                        Int32integerArray2M.AssertModel(models[5],_testData[26], false);
                        Int32integerArray2M.AssertModel(models[6],_testData[27], false);
                        Int32integerArray2M.AssertModel(models[7],_testData[28], false);
                        Int32integerArray2M.AssertModel(models[8],_testData[29], false);
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
                var models = ((IInt32ListintegerArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32integerArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32ListintegerArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Int32integerArray2M.AssertModel(models[0],_testData[10], false);
                        Int32integerArray2M.AssertModel(models[1],_testData[11], false);
                        Int32integerArray2M.AssertModel(models[2],_testData[12], false);
                        Int32integerArray2M.AssertModel(models[3],_testData[13], false);
                        Int32integerArray2M.AssertModel(models[4],_testData[14], false);
                        Int32integerArray2M.AssertModel(models[5],_testData[15], false);
                        Int32integerArray2M.AssertModel(models[6],_testData[16], false);
                        Int32integerArray2M.AssertModel(models[7],_testData[17], false);
                        Int32integerArray2M.AssertModel(models[8],_testData[18], false);
                        Int32integerArray2M.AssertModel(models[9],_testData[19], false);
                        Int32integerArray2M.AssertModel(models[10],_testData[20], false);
                        Int32integerArray2M.AssertModel(models[11],_testData[21], false);
                        Int32integerArray2M.AssertModel(models[12],_testData[22], false);
                        Int32integerArray2M.AssertModel(models[13],_testData[23], false);
                        Int32integerArray2M.AssertModel(models[14],_testData[24], false);
                        Int32integerArray2M.AssertModel(models[15],_testData[25], false);
                        Int32integerArray2M.AssertModel(models[16],_testData[26], false);
                        Int32integerArray2M.AssertModel(models[17],_testData[27], false);
                        Int32integerArray2M.AssertModel(models[18],_testData[28], false);
                        Int32integerArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int32integerArray2M.AssertModel(models[0],_testData[27], false);
                        Int32integerArray2M.AssertModel(models[1],_testData[28], false);
                        Int32integerArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerArray2M), typeof(FlatInt32integerArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
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
            asPartInterface: typeof(IInt32ListintegerArray)),
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
            asPartInterface: typeof(IInt32ListintegerArray)),
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integerArray2M>();
                var models2 = new List<FlatInt32integerArray2M>();
                await((IInt32ListintegerArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int32integerarray2m m
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray2M>();
                var firstItems2 = new List<FlatInt32integerArray2M>();
                var secondItems1 = new List<FlatInt32integerArray2M>();
                var secondItems2 = new List<FlatInt32integerArray2M>();
                await ((IInt32ListintegerArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 15, query1, 107, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[6],_testData[29], false);
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
FROM public.int32integerarray2m m
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray2M>();
                var firstItems2 = new List<FlatInt32integerArray2M>();
                var secondItems1 = new List<FlatInt32integerArray2M>();
                await ((IInt32ListintegerArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 1, query1, 23, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[22],_testData[29], false);
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integerArray2M>();
                var models2 = new List<FlatInt32integerArray2M>();
                ((IInt32ListintegerArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int32integerarray2m m
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray2M>();
                var firstItems2 = new List<FlatInt32integerArray2M>();
                var secondItems1 = new List<FlatInt32integerArray2M>();
                var secondItems2 = new List<FlatInt32integerArray2M>();
                 ((IInt32ListintegerArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 23, query1, 33, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[20],_testData[29], false);
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
FROM public.int32integerarray2m m
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray2M>();
                var firstItems2 = new List<FlatInt32integerArray2M>();
                var secondItems1 = new List<FlatInt32integerArray2M>();
                 ((IInt32ListintegerArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 59, query1, 102, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
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
            asPartInterface: typeof(IInt32ListintegerArray)),
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
            asPartInterface: typeof(IInt32ListintegerArray)),
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt32ListintegerArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integerarray2m m
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32ListintegerArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 46, query1, 17, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatInt32integerArray2M.AssertModel(models[0],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(models[1],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(models[2],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(models[3],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(models[4],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(models[5],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(models[6],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(models[7],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(models[8],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(models[9],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(models[10],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(models[11],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(models[12],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(models[13],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(models[14],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(models[15],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(models[16],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatInt32integerArray2M.AssertModel(models[0],_testData[5], false);
                        FlatInt32integerArray2M.AssertModel(models[1],_testData[6], false);
                        FlatInt32integerArray2M.AssertModel(models[2],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(models[3],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(models[4],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(models[5],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(models[6],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(models[7],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(models[8],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(models[9],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(models[10],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(models[11],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(models[12],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(models[13],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(models[14],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(models[15],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(models[16],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(models[17],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(models[18],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(models[19],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(models[20],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(models[21],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(models[22],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(models[23],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(models[24],_testData[29], false);
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
FROM public.int32integerarray2m m
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray2M>();
                var secondItems1 = new List<FlatInt32integerArray2M>();
                var secondItems2 = new List<FlatInt32integerArray2M>();
                await ((IInt32ListintegerArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 6, query1, 82, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[11],_testData[29], false);
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt32ListintegerArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integerarray2m m
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32ListintegerArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 59, query1, 107, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatInt32integerArray2M.AssertModel(models[0],_testData[14], false);
                        FlatInt32integerArray2M.AssertModel(models[1],_testData[15], false);
                        FlatInt32integerArray2M.AssertModel(models[2],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(models[3],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(models[4],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(models[5],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(models[6],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(models[7],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(models[8],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(models[9],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(models[10],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(models[11],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(models[12],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(models[13],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(models[14],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatInt32integerArray2M.AssertModel(models[0],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(models[1],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(models[2],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(models[3],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(models[4],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(models[5],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(models[6],_testData[29], false);
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
FROM public.int32integerarray2m m
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
FROM public.int32integerarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray2M>();
                var secondItems1 = new List<FlatInt32integerArray2M>();
                var secondItems2 = new List<FlatInt32integerArray2M>();
                 ((IInt32ListintegerArray)this).DbConnectionDynQuerySelectModelBatch(connection, 124, query1, 71, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatInt32integerArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatInt32integerArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatInt32integerArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatInt32integerArray2M.AssertModel(secondItems2[13],_testData[29], false);
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
FROM public.int32integerarray2m m
LEFT JOIN public.int32integerarray2mi mi ON mi.id = m.int32integerarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int32integerArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray)),
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
            asPartInterface: typeof(IInt32ListintegerArray)),
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
                var models = await((IInt32ListintegerArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32integerArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt32ListintegerArray)this).DbConnectionSTSelectModelBatchAsync(connection, 73, 111))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Int32integerArray2M.AssertModel(models[0],_testData[17], false);
                        Int32integerArray2M.AssertModel(models[1],_testData[18], false);
                        Int32integerArray2M.AssertModel(models[2],_testData[19], false);
                        Int32integerArray2M.AssertModel(models[3],_testData[20], false);
                        Int32integerArray2M.AssertModel(models[4],_testData[21], false);
                        Int32integerArray2M.AssertModel(models[5],_testData[22], false);
                        Int32integerArray2M.AssertModel(models[6],_testData[23], false);
                        Int32integerArray2M.AssertModel(models[7],_testData[24], false);
                        Int32integerArray2M.AssertModel(models[8],_testData[25], false);
                        Int32integerArray2M.AssertModel(models[9],_testData[26], false);
                        Int32integerArray2M.AssertModel(models[10],_testData[27], false);
                        Int32integerArray2M.AssertModel(models[11],_testData[28], false);
                        Int32integerArray2M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Int32integerArray2M.AssertModel(models[0],_testData[24], false);
                        Int32integerArray2M.AssertModel(models[1],_testData[25], false);
                        Int32integerArray2M.AssertModel(models[2],_testData[26], false);
                        Int32integerArray2M.AssertModel(models[3],_testData[27], false);
                        Int32integerArray2M.AssertModel(models[4],_testData[28], false);
                        Int32integerArray2M.AssertModel(models[5],_testData[29], false);
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
                var models = ((IInt32ListintegerArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32integerArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt32ListintegerArray)this).DbConnectionSTSelectModelBatch(connection, 36, 73))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Int32integerArray2M.AssertModel(models[0],_testData[10], false);
                        Int32integerArray2M.AssertModel(models[1],_testData[11], false);
                        Int32integerArray2M.AssertModel(models[2],_testData[12], false);
                        Int32integerArray2M.AssertModel(models[3],_testData[13], false);
                        Int32integerArray2M.AssertModel(models[4],_testData[14], false);
                        Int32integerArray2M.AssertModel(models[5],_testData[15], false);
                        Int32integerArray2M.AssertModel(models[6],_testData[16], false);
                        Int32integerArray2M.AssertModel(models[7],_testData[17], false);
                        Int32integerArray2M.AssertModel(models[8],_testData[18], false);
                        Int32integerArray2M.AssertModel(models[9],_testData[19], false);
                        Int32integerArray2M.AssertModel(models[10],_testData[20], false);
                        Int32integerArray2M.AssertModel(models[11],_testData[21], false);
                        Int32integerArray2M.AssertModel(models[12],_testData[22], false);
                        Int32integerArray2M.AssertModel(models[13],_testData[23], false);
                        Int32integerArray2M.AssertModel(models[14],_testData[24], false);
                        Int32integerArray2M.AssertModel(models[15],_testData[25], false);
                        Int32integerArray2M.AssertModel(models[16],_testData[26], false);
                        Int32integerArray2M.AssertModel(models[17],_testData[27], false);
                        Int32integerArray2M.AssertModel(models[18],_testData[28], false);
                        Int32integerArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Int32integerArray2M.AssertModel(models[0],_testData[17], false);
                        Int32integerArray2M.AssertModel(models[1],_testData[18], false);
                        Int32integerArray2M.AssertModel(models[2],_testData[19], false);
                        Int32integerArray2M.AssertModel(models[3],_testData[20], false);
                        Int32integerArray2M.AssertModel(models[4],_testData[21], false);
                        Int32integerArray2M.AssertModel(models[5],_testData[22], false);
                        Int32integerArray2M.AssertModel(models[6],_testData[23], false);
                        Int32integerArray2M.AssertModel(models[7],_testData[24], false);
                        Int32integerArray2M.AssertModel(models[8],_testData[25], false);
                        Int32integerArray2M.AssertModel(models[9],_testData[26], false);
                        Int32integerArray2M.AssertModel(models[10],_testData[27], false);
                        Int32integerArray2M.AssertModel(models[11],_testData[28], false);
                        Int32integerArray2M.AssertModel(models[12],_testData[29], false);
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
                await using var cmd = await ((IInt32ListintegerArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt32ListintegerArray)this).SetDbConnectionSelectModelParametrs(cmd, 82);
                var models = await ((IInt32ListintegerArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
Int32integerArray2M.AssertModel(models[0],_testData[18], false);Int32integerArray2M.AssertModel(models[1],_testData[19], false);Int32integerArray2M.AssertModel(models[2],_testData[20], false);Int32integerArray2M.AssertModel(models[3],_testData[21], false);Int32integerArray2M.AssertModel(models[4],_testData[22], false);Int32integerArray2M.AssertModel(models[5],_testData[23], false);Int32integerArray2M.AssertModel(models[6],_testData[24], false);Int32integerArray2M.AssertModel(models[7],_testData[25], false);Int32integerArray2M.AssertModel(models[8],_testData[26], false);Int32integerArray2M.AssertModel(models[9],_testData[27], false);Int32integerArray2M.AssertModel(models[10],_testData[28], false);Int32integerArray2M.AssertModel(models[11],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32ListintegerArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32ListintegerArray)this).SetDbConnectionSelectModelParametrs(cmd, 55);
                var models =  ((IInt32ListintegerArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(17));
Int32integerArray2M.AssertModel(models[0],_testData[13], false);Int32integerArray2M.AssertModel(models[1],_testData[14], false);Int32integerArray2M.AssertModel(models[2],_testData[15], false);Int32integerArray2M.AssertModel(models[3],_testData[16], false);Int32integerArray2M.AssertModel(models[4],_testData[17], false);Int32integerArray2M.AssertModel(models[5],_testData[18], false);Int32integerArray2M.AssertModel(models[6],_testData[19], false);Int32integerArray2M.AssertModel(models[7],_testData[20], false);Int32integerArray2M.AssertModel(models[8],_testData[21], false);Int32integerArray2M.AssertModel(models[9],_testData[22], false);Int32integerArray2M.AssertModel(models[10],_testData[23], false);Int32integerArray2M.AssertModel(models[11],_testData[24], false);Int32integerArray2M.AssertModel(models[12],_testData[25], false);Int32integerArray2M.AssertModel(models[13],_testData[26], false);Int32integerArray2M.AssertModel(models[14],_testData[27], false);Int32integerArray2M.AssertModel(models[15],_testData[28], false);Int32integerArray2M.AssertModel(models[16],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int32integerarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int32integerArray2MI),
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
            asPartInterface: typeof(IInt32ListintegerArray))]
        private void ImportModelInnerConfig()
        {
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_int32integerarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int32integerArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Int32integerArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IInt32ListintegerArray)this).ImportModelInner(connection, importCollection);
                var models = ((IInt32ListintegerArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
                importCollection.Clear();

                importCollection.Add(_testData[15].ModelInner);
                importCollection.Add(_testData[17].ModelInner);
                importCollection.Add(_testData[19].ModelInner);
                importCollection.Add(_testData[21].ModelInner);
                importCollection.Add(_testData[23].ModelInner);
                importCollection.Add(_testData[25].ModelInner);
                importCollection.Add(_testData[27].ModelInner);
                importCollection.Add(_testData[29].ModelInner);
                await ((IInt32ListintegerArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IInt32ListintegerArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int32integerarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int32integerarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int32integerArray2M),
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
            asPartInterface: typeof(IInt32ListintegerArray))]
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
FROM public.binary_int32integerarray2m m
LEFT JOIN public.binary_int32integerarray2mi mi ON mi.id = m.int32integerarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int32integerArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ListintegerArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Int32integerArray2M>(15);

                    importCollection.Add(_testData[0]);
                    importCollection.Add(_testData[1]);
                    importCollection.Add(_testData[2]);
                    importCollection.Add(_testData[3]);
                    importCollection.Add(_testData[4]);
                    importCollection.Add(_testData[5]);
                    importCollection.Add(_testData[6]);
                    importCollection.Add(_testData[7]);
                    importCollection.Add(_testData[8]);
                    importCollection.Add(_testData[9]);
                    importCollection.Add(_testData[10]);
                    importCollection.Add(_testData[11]);
                    importCollection.Add(_testData[12]);
                    importCollection.Add(_testData[13]);
                    importCollection.Add(_testData[14]);
                ((IInt32ListintegerArray)this).ImportModel(connection, importCollection);
                var models = ((IInt32ListintegerArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                Int32integerArray2M.AssertModel(models[0],_testData[0], false);
                Int32integerArray2M.AssertModel(models[1],_testData[1], false);
                Int32integerArray2M.AssertModel(models[2],_testData[2], false);
                Int32integerArray2M.AssertModel(models[3],_testData[3], false);
                Int32integerArray2M.AssertModel(models[4],_testData[4], false);
                Int32integerArray2M.AssertModel(models[5],_testData[5], false);
                Int32integerArray2M.AssertModel(models[6],_testData[6], false);
                Int32integerArray2M.AssertModel(models[7],_testData[7], false);
                Int32integerArray2M.AssertModel(models[8],_testData[8], false);
                Int32integerArray2M.AssertModel(models[9],_testData[9], false);
                Int32integerArray2M.AssertModel(models[10],_testData[10], false);
                Int32integerArray2M.AssertModel(models[11],_testData[11], false);
                Int32integerArray2M.AssertModel(models[12],_testData[12], false);
                Int32integerArray2M.AssertModel(models[13],_testData[13], false);
                Int32integerArray2M.AssertModel(models[14],_testData[14], false);
                importCollection.Clear();

                    importCollection.Add(_testData[15]);
                    importCollection.Add(_testData[16]);
                    importCollection.Add(_testData[17]);
                    importCollection.Add(_testData[18]);
                    importCollection.Add(_testData[19]);
                    importCollection.Add(_testData[20]);
                    importCollection.Add(_testData[21]);
                    importCollection.Add(_testData[22]);
                    importCollection.Add(_testData[23]);
                    importCollection.Add(_testData[24]);
                    importCollection.Add(_testData[25]);
                    importCollection.Add(_testData[26]);
                    importCollection.Add(_testData[27]);
                    importCollection.Add(_testData[28]);
                    importCollection.Add(_testData[29]);
                await ((IInt32ListintegerArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IInt32ListintegerArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                Int32integerArray2M.AssertModel(models[0],_testData[0], false);
                Int32integerArray2M.AssertModel(models[1],_testData[1], false);
                Int32integerArray2M.AssertModel(models[2],_testData[2], false);
                Int32integerArray2M.AssertModel(models[3],_testData[3], false);
                Int32integerArray2M.AssertModel(models[4],_testData[4], false);
                Int32integerArray2M.AssertModel(models[5],_testData[5], false);
                Int32integerArray2M.AssertModel(models[6],_testData[6], false);
                Int32integerArray2M.AssertModel(models[7],_testData[7], false);
                Int32integerArray2M.AssertModel(models[8],_testData[8], false);
                Int32integerArray2M.AssertModel(models[9],_testData[9], false);
                Int32integerArray2M.AssertModel(models[10],_testData[10], false);
                Int32integerArray2M.AssertModel(models[11],_testData[11], false);
                Int32integerArray2M.AssertModel(models[12],_testData[12], false);
                Int32integerArray2M.AssertModel(models[13],_testData[13], false);
                Int32integerArray2M.AssertModel(models[14],_testData[14], false);
                Int32integerArray2M.AssertModel(models[15],_testData[15], false);
                Int32integerArray2M.AssertModel(models[16],_testData[16], false);
                Int32integerArray2M.AssertModel(models[17],_testData[17], false);
                Int32integerArray2M.AssertModel(models[18],_testData[18], false);
                Int32integerArray2M.AssertModel(models[19],_testData[19], false);
                Int32integerArray2M.AssertModel(models[20],_testData[20], false);
                Int32integerArray2M.AssertModel(models[21],_testData[21], false);
                Int32integerArray2M.AssertModel(models[22],_testData[22], false);
                Int32integerArray2M.AssertModel(models[23],_testData[23], false);
                Int32integerArray2M.AssertModel(models[24],_testData[24], false);
                Int32integerArray2M.AssertModel(models[25],_testData[25], false);
                Int32integerArray2M.AssertModel(models[26],_testData[26], false);
                Int32integerArray2M.AssertModel(models[27],_testData[27], false);
                Int32integerArray2M.AssertModel(models[28],_testData[28], false);
                Int32integerArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int32integerarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int32integerarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int32integerArray2M)],
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
            asPartInterface: typeof(IInt32ListintegerArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt32ListintegerArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int32integerArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt32ListintegerArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int32integerArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int32integerarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int32integerArray2MI)],
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
            asPartInterface: typeof(IInt32ListintegerArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt32ListintegerArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt32ListintegerArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

