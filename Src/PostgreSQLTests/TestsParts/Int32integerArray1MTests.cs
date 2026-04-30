

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
    internal partial interface IInt32ArrayintegerArray
    {
    }
    
    internal partial class Int32ArrayintegerArray : IInt32ArrayintegerArray
    {


#region TestData

        private readonly Int32integerArray1M[] _testData = new Int32integerArray1M[]
        {
            new Int32integerArray1M
{
    Id = 2,
    Value = 
new System.Int32[3]
{
2061879340,
1083899438,
66141111,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[4]
{
475940892,
2099956336,
1212449819,
1721491730,
},
},
            new Int32integerArray1M
{
    Id = 8,
    Value = 
new System.Int32[4]
{
1406022325,
1391937863,
1772006587,
2145271465,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 6,
    Value = 
new System.Int32[4]
{
1520379540,
367533751,
562216543,
1583861646,
},
    NullableValue = 
new System.Int32[4]
{
51054191,
1378637291,
1831562678,
1062268613,
},
},
    NullableValue = 
new System.Int32[3]
{
1882713524,
2128033894,
1953166783,
},
},
            new Int32integerArray1M
{
    Id = 11,
    Value = 
new System.Int32[4]
{
1957276592,
530186850,
960631391,
24117140,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[4]
{
1900427529,
1611191037,
715663432,
900149941,
},
},
            new Int32integerArray1M
{
    Id = 19,
    Value = 
new System.Int32[3]
{
1770523611,
1035592834,
365290678,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 9,
    Value = 
new System.Int32[4]
{
499190001,
839379215,
347526016,
378055730,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 24,
    Value = 
new System.Int32[3]
{
451926691,
488212694,
669745214,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
1065092061,
355356809,
798152705,
},
},
            new Int32integerArray1M
{
    Id = 28,
    Value = 
new System.Int32[3]
{
972777558,
1489084803,
1665182973,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 14,
    Value = 
new System.Int32[4]
{
1099288821,
310369248,
1665260165,
84332337,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 31,
    Value = 
new System.Int32[4]
{
1340976941,
368845910,
443860716,
56906483,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[4]
{
2029026810,
2110630345,
643984421,
1365033951,
},
},
            new Int32integerArray1M
{
    Id = 38,
    Value = 
new System.Int32[3]
{
58170074,
1312733806,
405250918,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 18,
    Value = 
new System.Int32[3]
{
1592862669,
1367190871,
45982950,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
1427896799,
1454699667,
139167323,
},
},
            new Int32integerArray1M
{
    Id = 43,
    Value = 
new System.Int32[3]
{
1305972786,
472934889,
187360646,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 51,
    Value = 
new System.Int32[4]
{
729286257,
547208979,
1055128952,
1580851004,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 21,
    Value = 
new System.Int32[3]
{
1517363201,
99289310,
162966693,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 54,
    Value = 
new System.Int32[4]
{
377871520,
1059533508,
89890816,
139317661,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 62,
    Value = 
new System.Int32[3]
{
2092480618,
1145757498,
1377261793,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 29,
    Value = 
new System.Int32[3]
{
1243681069,
382524209,
189430141,
},
    NullableValue = 
new System.Int32[4]
{
294511513,
201194485,
1361337691,
1547046115,
},
},
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 68,
    Value = 
new System.Int32[4]
{
895785666,
1271017366,
1365789000,
2071222609,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 71,
    Value = 
new System.Int32[3]
{
975235736,
1873516804,
79299406,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 37,
    Value = 
new System.Int32[3]
{
2070242131,
1494927679,
1248523295,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int32[3]
{
74754129,
1223057980,
297990622,
},
},
            new Int32integerArray1M
{
    Id = 77,
    Value = 
new System.Int32[3]
{
463425820,
331341172,
992876158,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 80,
    Value = 
new System.Int32[3]
{
1875937814,
1935093235,
517530479,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 41,
    Value = 
new System.Int32[4]
{
950479174,
1048966119,
2098025424,
782109633,
},
    NullableValue = 
new System.Int32[4]
{
2014807639,
601978155,
2144211168,
1312520380,
},
},
    NullableValue = 
new System.Int32[3]
{
2119694259,
1167901359,
1795196541,
},
},
            new Int32integerArray1M
{
    Id = 81,
    Value = 
new System.Int32[4]
{
114169101,
1958757619,
521642115,
1924320576,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 82,
    Value = 
new System.Int32[4]
{
854041457,
857786717,
1391404774,
1191324264,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 49,
    Value = 
new System.Int32[3]
{
2016531434,
1822491632,
1294313737,
},
    NullableValue = 
new System.Int32[3]
{
699814247,
317538245,
1964421146,
},
},
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 91,
    Value = 
new System.Int32[3]
{
711335935,
2142979017,
1977547469,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 93,
    Value = 
new System.Int32[4]
{
642435752,
1878472401,
918371552,
219869666,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 56,
    Value = 
new System.Int32[3]
{
1275022199,
1897358089,
232319744,
},
    NullableValue = 
new System.Int32[3]
{
2043344690,
396274432,
1349320403,
},
},
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 102,
    Value = 
new System.Int32[3]
{
791652652,
788769252,
1167454526,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[4]
{
500361656,
1170929383,
820109223,
2145038345,
},
},
            new Int32integerArray1M
{
    Id = 107,
    Value = 
new System.Int32[4]
{
249528750,
224228719,
809612372,
1427919759,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 58,
    Value = 
new System.Int32[4]
{
1272332395,
588613176,
949212353,
1071274591,
},
    NullableValue = 
new System.Int32[3]
{
114135634,
555520360,
74897641,
},
},
    NullableValue = 
new System.Int32[4]
{
1435108589,
1304252099,
1739127354,
100227646,
},
},
            new Int32integerArray1M
{
    Id = 116,
    Value = 
new System.Int32[3]
{
849554096,
1643130071,
1317253285,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
1551323505,
721560115,
632613276,
},
},
            new Int32integerArray1M
{
    Id = 124,
    Value = 
new System.Int32[4]
{
1219677166,
517711602,
1690279478,
1207618721,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 59,
    Value = 
new System.Int32[4]
{
565913948,
1823615982,
248058412,
15846571,
},
    NullableValue = 
new System.Int32[4]
{
1934761187,
686639057,
1220663702,
51169088,
},
},
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 132,
    Value = 
new System.Int32[3]
{
1734110298,
404666223,
501274292,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 140,
    Value = 
new System.Int32[3]
{
1477249669,
1533563725,
343530129,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 60,
    Value = 
new System.Int32[4]
{
307156922,
1506341413,
1753457285,
827249870,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 147,
    Value = 
new System.Int32[3]
{
2047020231,
1824381381,
703509617,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 151,
    Value = 
new System.Int32[3]
{
1062680730,
566454220,
1785652595,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 65,
    Value = 
new System.Int32[4]
{
1205501243,
274213702,
828633982,
1303911283,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integerArray1M
{
    Id = 159,
    Value = 
new System.Int32[3]
{
1586237977,
381786519,
571083204,
},
    ModelInner = null,
    NullableValue = 
new System.Int32[3]
{
1704820396,
1486200100,
193587191,
},
},
            new Int32integerArray1M
{
    Id = 162,
    Value = 
new System.Int32[4]
{
1140627993,
1802066347,
14507040,
1086510266,
},
    ModelInner = new Int32integerArray1MI
{
    Id = 74,
    Value = 
new System.Int32[4]
{
1099791593,
217610531,
204337573,
104441943,
},
    NullableValue = 
new System.Int32[3]
{
1755605736,
1102659958,
324698178,
},
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integerarray1mi(
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
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
INSERT INTO public.int32integerarray1mi(
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
            queryMapTypes: [typeof(Int32integerArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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

                changedRows =  ((IInt32ArrayintegerArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt32ArrayintegerArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt32ArrayintegerArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32ArrayintegerArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt32ArrayintegerArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt32ArrayintegerArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt32ArrayintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt32ArrayintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt32ArrayintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt32ArrayintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt32ArrayintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt32ArrayintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt32ArrayintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt32ArrayintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt32ArrayintegerArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integerarray1m(
	id,
    value,
    nullablevalue,
    int32integerarray1mi_id
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
            asPartInterface: typeof(IInt32ArrayintegerArray)), 
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
                methodParametrName: "int32integerarray1mi_id", 
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
                changedRows =  ((IInt32ArrayintegerArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt32ArrayintegerArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt32ArrayintegerArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt32ArrayintegerArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integerarray1m(
	id,
    value,
    nullablevalue,
    int32integerarray1mi_id
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
    int32integerarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int32integerArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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

                    nullable =  ((IInt32ArrayintegerArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[3]
{
1065092061,
355356809,
798152705,
}));
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

                    nullable =  ((IInt32ArrayintegerArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable = await ((IInt32ArrayintegerArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[4]
{
2029026810,
2110630345,
643984421,
1365033951,
}));
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

                    nullable = await ((IInt32ArrayintegerArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int32[3]
{
1427896799,
1454699667,
139167323,
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integerarray1m(
	id,
    value,
    nullablevalue,
    int32integerarray1mi_id
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
    int32integerarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int32integerArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
                methodParametrName: "int32integerarray1mi_id", 
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
                nullable =  ((IInt32ArrayintegerArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IInt32ArrayintegerArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
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
                nullable = await ((IInt32ArrayintegerArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IInt32ArrayintegerArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int32integerArray1M> models = null;

                models =  ((IInt32ArrayintegerArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((IInt32ArrayintegerArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((IInt32ArrayintegerArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((IInt32ArrayintegerArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int32integerArray1M> models = null;

                models = await ((IInt32ArrayintegerArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt32ArrayintegerArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt32ArrayintegerArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt32ArrayintegerArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt32ArrayintegerArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt32ArrayintegerArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt32ArrayintegerArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt32ArrayintegerArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt32ArrayintegerArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt32ArrayintegerArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt32ArrayintegerArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt32ArrayintegerArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt32ArrayintegerArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt32ArrayintegerArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integerArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerArray1M), typeof(FlatInt32integerArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
FROM public.int32integerarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt32integerArray1M>();
                var models2 = new List<FlatInt32integerArray1M>();
                await ((IInt32ArrayintegerArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int32integerarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt32integerArray1M>();
                var models2 = new List<FlatInt32integerArray1M>();
                ((IInt32ArrayintegerArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
FROM public.int32integerarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt32ArrayintegerArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integerarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt32ArrayintegerArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integerarray1m m
LEFT JOIN public.int32integerarray1mi mi ON mi.id = m.int32integerarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int32integerArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
                var models = await ((IInt32ArrayintegerArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32integerArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt32ArrayintegerArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32integerArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerArray1M), typeof(FlatInt32integerArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
FROM public.int32integerarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integerArray1M>();
                var models2 = new List<FlatInt32integerArray1M>();
                await ((IInt32ArrayintegerArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int32integerarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integerArray1M>();
                var models2 = new List<FlatInt32integerArray1M>();
                ((IInt32ArrayintegerArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
FROM public.int32integerarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt32ArrayintegerArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integerarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt32ArrayintegerArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integerarray1m m
LEFT JOIN public.int32integerarray1mi mi ON mi.id = m.int32integerarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int32integerArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
                var models = await ((IInt32ArrayintegerArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32integerArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt32ArrayintegerArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32integerArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerArray1M), typeof(FlatInt32integerArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32integerArray1M>();
                var models2 = new List<FlatInt32integerArray1M>();
                await((IInt32ArrayintegerArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
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
FROM public.int32integerarray1m m
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray1M>();
                var firstItems2 = new List<FlatInt32integerArray1M>();
                var secondItems1 = new List<FlatInt32integerArray1M>();
                var secondItems2 = new List<FlatInt32integerArray1M>();
                await ((IInt32ArrayintegerArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[1],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
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
FROM public.int32integerarray1m m
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray1M>();
                var firstItems2 = new List<FlatInt32integerArray1M>();
                var secondItems1 = new List<FlatInt32integerArray1M>();
                await ((IInt32ArrayintegerArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[27],_testData[29], false);
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32integerArray1M>();
                var models2 = new List<FlatInt32integerArray1M>();
                ((IInt32ArrayintegerArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
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
FROM public.int32integerarray1m m
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray1M>();
                var firstItems2 = new List<FlatInt32integerArray1M>();
                var secondItems1 = new List<FlatInt32integerArray1M>();
                var secondItems2 = new List<FlatInt32integerArray1M>();
                 ((IInt32ArrayintegerArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
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
FROM public.int32integerarray1m m
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray1M>();
                var firstItems2 = new List<FlatInt32integerArray1M>();
                var secondItems1 = new List<FlatInt32integerArray1M>();
                 ((IInt32ArrayintegerArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[7],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integerArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt32ArrayintegerArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integerarray1m m
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32ArrayintegerArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatInt32integerArray1M.AssertModel(models[0],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(models[1],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(models[2],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(models[3],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(models[4],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(models[5],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(models[6],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(models[7],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(models[8],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(models[9],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(models[10],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(models[11],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(models[12],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(models[13],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(models[14],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(models[15],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(models[16],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(models[17],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(models[18],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(models[19],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatInt32integerArray1M.AssertModel(models[0],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(models[1],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(models[2],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(models[3],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(models[4],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(models[5],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(models[6],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(models[7],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(models[8],_testData[29], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integerarray1m m
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray1M>();
                var secondItems1 = new List<FlatInt32integerArray1M>();
                var secondItems2 = new List<FlatInt32integerArray1M>();
                await ((IInt32ArrayintegerArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[13],_testData[29], false);
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt32ArrayintegerArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 151;
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
FROM public.int32integerarray1m m
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32ArrayintegerArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatInt32integerArray1M.AssertModel(models[0],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatInt32integerArray1M.AssertModel(models[0],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(models[1],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(models[2],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(models[3],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(models[4],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(models[5],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(models[6],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(models[7],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(models[8],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(models[9],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(models[10],_testData[29], false);
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
                parametr1.Value = 8;
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
FROM public.int32integerarray1m m
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray1M>();
                var secondItems1 = new List<FlatInt32integerArray1M>();
                var secondItems2 = new List<FlatInt32integerArray1M>();
                 ((IInt32ArrayintegerArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[27],_testData[29], false);
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
FROM public.int32integerarray1m m
LEFT JOIN public.int32integerarray1mi mi ON mi.id = m.int32integerarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int32integerArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
                var models = await((IInt32ArrayintegerArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32integerArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32ArrayintegerArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Int32integerArray1M.AssertModel(models[0],_testData[18], false);
                        Int32integerArray1M.AssertModel(models[1],_testData[19], false);
                        Int32integerArray1M.AssertModel(models[2],_testData[20], false);
                        Int32integerArray1M.AssertModel(models[3],_testData[21], false);
                        Int32integerArray1M.AssertModel(models[4],_testData[22], false);
                        Int32integerArray1M.AssertModel(models[5],_testData[23], false);
                        Int32integerArray1M.AssertModel(models[6],_testData[24], false);
                        Int32integerArray1M.AssertModel(models[7],_testData[25], false);
                        Int32integerArray1M.AssertModel(models[8],_testData[26], false);
                        Int32integerArray1M.AssertModel(models[9],_testData[27], false);
                        Int32integerArray1M.AssertModel(models[10],_testData[28], false);
                        Int32integerArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Int32integerArray1M.AssertModel(models[0],_testData[28], false);
                        Int32integerArray1M.AssertModel(models[1],_testData[29], false);
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
                var models = ((IInt32ArrayintegerArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32integerArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32ArrayintegerArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Int32integerArray1M.AssertModel(models[0],_testData[18], false);
                        Int32integerArray1M.AssertModel(models[1],_testData[19], false);
                        Int32integerArray1M.AssertModel(models[2],_testData[20], false);
                        Int32integerArray1M.AssertModel(models[3],_testData[21], false);
                        Int32integerArray1M.AssertModel(models[4],_testData[22], false);
                        Int32integerArray1M.AssertModel(models[5],_testData[23], false);
                        Int32integerArray1M.AssertModel(models[6],_testData[24], false);
                        Int32integerArray1M.AssertModel(models[7],_testData[25], false);
                        Int32integerArray1M.AssertModel(models[8],_testData[26], false);
                        Int32integerArray1M.AssertModel(models[9],_testData[27], false);
                        Int32integerArray1M.AssertModel(models[10],_testData[28], false);
                        Int32integerArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Int32integerArray1M.AssertModel(models[0],_testData[12], false);
                        Int32integerArray1M.AssertModel(models[1],_testData[13], false);
                        Int32integerArray1M.AssertModel(models[2],_testData[14], false);
                        Int32integerArray1M.AssertModel(models[3],_testData[15], false);
                        Int32integerArray1M.AssertModel(models[4],_testData[16], false);
                        Int32integerArray1M.AssertModel(models[5],_testData[17], false);
                        Int32integerArray1M.AssertModel(models[6],_testData[18], false);
                        Int32integerArray1M.AssertModel(models[7],_testData[19], false);
                        Int32integerArray1M.AssertModel(models[8],_testData[20], false);
                        Int32integerArray1M.AssertModel(models[9],_testData[21], false);
                        Int32integerArray1M.AssertModel(models[10],_testData[22], false);
                        Int32integerArray1M.AssertModel(models[11],_testData[23], false);
                        Int32integerArray1M.AssertModel(models[12],_testData[24], false);
                        Int32integerArray1M.AssertModel(models[13],_testData[25], false);
                        Int32integerArray1M.AssertModel(models[14],_testData[26], false);
                        Int32integerArray1M.AssertModel(models[15],_testData[27], false);
                        Int32integerArray1M.AssertModel(models[16],_testData[28], false);
                        Int32integerArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerArray1M), typeof(FlatInt32integerArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integerArray1M>();
                var models2 = new List<FlatInt32integerArray1M>();
                await((IInt32ArrayintegerArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int32integerarray1m m
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray1M>();
                var firstItems2 = new List<FlatInt32integerArray1M>();
                var secondItems1 = new List<FlatInt32integerArray1M>();
                var secondItems2 = new List<FlatInt32integerArray1M>();
                await ((IInt32ArrayintegerArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 124, query1, 62, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[17],_testData[29], false);
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
FROM public.int32integerarray1m m
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray1M>();
                var firstItems2 = new List<FlatInt32integerArray1M>();
                var secondItems1 = new List<FlatInt32integerArray1M>();
                await ((IInt32ArrayintegerArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 77, query1, 54, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[18],_testData[29], false);
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integerArray1M>();
                var models2 = new List<FlatInt32integerArray1M>();
                ((IInt32ArrayintegerArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int32integerarray1m m
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray1M>();
                var firstItems2 = new List<FlatInt32integerArray1M>();
                var secondItems1 = new List<FlatInt32integerArray1M>();
                var secondItems2 = new List<FlatInt32integerArray1M>();
                 ((IInt32ArrayintegerArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 81, query1, 68, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[16],_testData[29], false);
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
FROM public.int32integerarray1m m
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray1M>();
                var firstItems2 = new List<FlatInt32integerArray1M>();
                var secondItems1 = new List<FlatInt32integerArray1M>();
                 ((IInt32ArrayintegerArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 82, query1, 28, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[23],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integerArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt32ArrayintegerArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integerarray1m m
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32ArrayintegerArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 62, query1, 82, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatInt32integerArray1M.AssertModel(models[0],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(models[1],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(models[2],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(models[3],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(models[4],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(models[5],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(models[6],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(models[7],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(models[8],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(models[9],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(models[10],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(models[11],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(models[12],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(models[13],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(models[14],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(models[15],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(models[16],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatInt32integerArray1M.AssertModel(models[0],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(models[1],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(models[2],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(models[3],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(models[4],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(models[5],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(models[6],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(models[7],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(models[8],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(models[9],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(models[10],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(models[11],_testData[29], false);
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
FROM public.int32integerarray1m m
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray1M>();
                var secondItems1 = new List<FlatInt32integerArray1M>();
                var secondItems2 = new List<FlatInt32integerArray1M>();
                await ((IInt32ArrayintegerArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 24, query1, 132, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[4],_testData[29], false);
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt32ArrayintegerArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32integerArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integerarray1m m
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32ArrayintegerArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 151, query1, 147, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatInt32integerArray1M.AssertModel(models[0],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatInt32integerArray1M.AssertModel(models[0],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(models[1],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(models[2],_testData[29], false);
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
FROM public.int32integerarray1m m
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
FROM public.int32integerarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integerArray1M>();
                var secondItems1 = new List<FlatInt32integerArray1M>();
                var secondItems2 = new List<FlatInt32integerArray1M>();
                 ((IInt32ArrayintegerArray)this).DbConnectionDynQuerySelectModelBatch(connection, 51, query1, 124, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatInt32integerArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatInt32integerArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatInt32integerArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatInt32integerArray1M.AssertModel(secondItems2[5],_testData[29], false);
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
FROM public.int32integerarray1m m
LEFT JOIN public.int32integerarray1mi mi ON mi.id = m.int32integerarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int32integerArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
            asPartInterface: typeof(IInt32ArrayintegerArray)),
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
                var models = await((IInt32ArrayintegerArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32integerArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt32ArrayintegerArray)this).DbConnectionSTSelectModelBatchAsync(connection, 28, 116))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Int32integerArray1M.AssertModel(models[0],_testData[6], false);
                        Int32integerArray1M.AssertModel(models[1],_testData[7], false);
                        Int32integerArray1M.AssertModel(models[2],_testData[8], false);
                        Int32integerArray1M.AssertModel(models[3],_testData[9], false);
                        Int32integerArray1M.AssertModel(models[4],_testData[10], false);
                        Int32integerArray1M.AssertModel(models[5],_testData[11], false);
                        Int32integerArray1M.AssertModel(models[6],_testData[12], false);
                        Int32integerArray1M.AssertModel(models[7],_testData[13], false);
                        Int32integerArray1M.AssertModel(models[8],_testData[14], false);
                        Int32integerArray1M.AssertModel(models[9],_testData[15], false);
                        Int32integerArray1M.AssertModel(models[10],_testData[16], false);
                        Int32integerArray1M.AssertModel(models[11],_testData[17], false);
                        Int32integerArray1M.AssertModel(models[12],_testData[18], false);
                        Int32integerArray1M.AssertModel(models[13],_testData[19], false);
                        Int32integerArray1M.AssertModel(models[14],_testData[20], false);
                        Int32integerArray1M.AssertModel(models[15],_testData[21], false);
                        Int32integerArray1M.AssertModel(models[16],_testData[22], false);
                        Int32integerArray1M.AssertModel(models[17],_testData[23], false);
                        Int32integerArray1M.AssertModel(models[18],_testData[24], false);
                        Int32integerArray1M.AssertModel(models[19],_testData[25], false);
                        Int32integerArray1M.AssertModel(models[20],_testData[26], false);
                        Int32integerArray1M.AssertModel(models[21],_testData[27], false);
                        Int32integerArray1M.AssertModel(models[22],_testData[28], false);
                        Int32integerArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Int32integerArray1M.AssertModel(models[0],_testData[23], false);
                        Int32integerArray1M.AssertModel(models[1],_testData[24], false);
                        Int32integerArray1M.AssertModel(models[2],_testData[25], false);
                        Int32integerArray1M.AssertModel(models[3],_testData[26], false);
                        Int32integerArray1M.AssertModel(models[4],_testData[27], false);
                        Int32integerArray1M.AssertModel(models[5],_testData[28], false);
                        Int32integerArray1M.AssertModel(models[6],_testData[29], false);
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
                var models = ((IInt32ArrayintegerArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32integerArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt32ArrayintegerArray)this).DbConnectionSTSelectModelBatch(connection, 93, 24))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Int32integerArray1M.AssertModel(models[0],_testData[20], false);
                        Int32integerArray1M.AssertModel(models[1],_testData[21], false);
                        Int32integerArray1M.AssertModel(models[2],_testData[22], false);
                        Int32integerArray1M.AssertModel(models[3],_testData[23], false);
                        Int32integerArray1M.AssertModel(models[4],_testData[24], false);
                        Int32integerArray1M.AssertModel(models[5],_testData[25], false);
                        Int32integerArray1M.AssertModel(models[6],_testData[26], false);
                        Int32integerArray1M.AssertModel(models[7],_testData[27], false);
                        Int32integerArray1M.AssertModel(models[8],_testData[28], false);
                        Int32integerArray1M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Int32integerArray1M.AssertModel(models[0],_testData[5], false);
                        Int32integerArray1M.AssertModel(models[1],_testData[6], false);
                        Int32integerArray1M.AssertModel(models[2],_testData[7], false);
                        Int32integerArray1M.AssertModel(models[3],_testData[8], false);
                        Int32integerArray1M.AssertModel(models[4],_testData[9], false);
                        Int32integerArray1M.AssertModel(models[5],_testData[10], false);
                        Int32integerArray1M.AssertModel(models[6],_testData[11], false);
                        Int32integerArray1M.AssertModel(models[7],_testData[12], false);
                        Int32integerArray1M.AssertModel(models[8],_testData[13], false);
                        Int32integerArray1M.AssertModel(models[9],_testData[14], false);
                        Int32integerArray1M.AssertModel(models[10],_testData[15], false);
                        Int32integerArray1M.AssertModel(models[11],_testData[16], false);
                        Int32integerArray1M.AssertModel(models[12],_testData[17], false);
                        Int32integerArray1M.AssertModel(models[13],_testData[18], false);
                        Int32integerArray1M.AssertModel(models[14],_testData[19], false);
                        Int32integerArray1M.AssertModel(models[15],_testData[20], false);
                        Int32integerArray1M.AssertModel(models[16],_testData[21], false);
                        Int32integerArray1M.AssertModel(models[17],_testData[22], false);
                        Int32integerArray1M.AssertModel(models[18],_testData[23], false);
                        Int32integerArray1M.AssertModel(models[19],_testData[24], false);
                        Int32integerArray1M.AssertModel(models[20],_testData[25], false);
                        Int32integerArray1M.AssertModel(models[21],_testData[26], false);
                        Int32integerArray1M.AssertModel(models[22],_testData[27], false);
                        Int32integerArray1M.AssertModel(models[23],_testData[28], false);
                        Int32integerArray1M.AssertModel(models[24],_testData[29], false);
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
                await using var cmd = await ((IInt32ArrayintegerArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt32ArrayintegerArray)this).SetDbConnectionSelectModelParametrs(cmd, 82);
                var models = await ((IInt32ArrayintegerArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
Int32integerArray1M.AssertModel(models[0],_testData[18], false);Int32integerArray1M.AssertModel(models[1],_testData[19], false);Int32integerArray1M.AssertModel(models[2],_testData[20], false);Int32integerArray1M.AssertModel(models[3],_testData[21], false);Int32integerArray1M.AssertModel(models[4],_testData[22], false);Int32integerArray1M.AssertModel(models[5],_testData[23], false);Int32integerArray1M.AssertModel(models[6],_testData[24], false);Int32integerArray1M.AssertModel(models[7],_testData[25], false);Int32integerArray1M.AssertModel(models[8],_testData[26], false);Int32integerArray1M.AssertModel(models[9],_testData[27], false);Int32integerArray1M.AssertModel(models[10],_testData[28], false);Int32integerArray1M.AssertModel(models[11],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32ArrayintegerArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32ArrayintegerArray)this).SetDbConnectionSelectModelParametrs(cmd, 151);
                var models =  ((IInt32ArrayintegerArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
Int32integerArray1M.AssertModel(models[0],_testData[28], false);Int32integerArray1M.AssertModel(models[1],_testData[29], false);
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
FROM public.binary_int32integerarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int32integerArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int32integerArray1MIWA),
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
            asPartInterface: typeof(IInt32ArrayintegerArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt32ArrayintegerArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int32integerarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt32ArrayintegerArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Int32integerArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integerArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt32ArrayintegerArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int32integerarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt32ArrayintegerArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int32integerarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int32integerArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int32integerarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int32integerArray1MI),
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
            asPartInterface: typeof(IInt32ArrayintegerArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integerArray1MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt32ArrayintegerArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt32ArrayintegerArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Int32integerArray1MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt32ArrayintegerArray)this).ImportModelInner(connection, importCollection);
                var models = ((IInt32ArrayintegerArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integerArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int32integerarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int32integerarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int32integerArray1M),
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
            asPartInterface: typeof(IInt32ArrayintegerArray))]
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
FROM public.binary_int32integerarray1m m
LEFT JOIN public.binary_int32integerarray1mi mi ON mi.id = m.int32integerarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int32integerArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32ArrayintegerArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(5)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Int32integerArray1M>(15);

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
                ((IInt32ArrayintegerArray)this).ImportModel(connection, importCollection);
                var models = ((IInt32ArrayintegerArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                Int32integerArray1M.AssertModel(models[0],_testData[0], false);
                Int32integerArray1M.AssertModel(models[1],_testData[1], false);
                Int32integerArray1M.AssertModel(models[2],_testData[2], false);
                Int32integerArray1M.AssertModel(models[3],_testData[3], false);
                Int32integerArray1M.AssertModel(models[4],_testData[4], false);
                Int32integerArray1M.AssertModel(models[5],_testData[5], false);
                Int32integerArray1M.AssertModel(models[6],_testData[6], false);
                Int32integerArray1M.AssertModel(models[7],_testData[7], false);
                Int32integerArray1M.AssertModel(models[8],_testData[8], false);
                Int32integerArray1M.AssertModel(models[9],_testData[9], false);
                Int32integerArray1M.AssertModel(models[10],_testData[10], false);
                Int32integerArray1M.AssertModel(models[11],_testData[11], false);
                Int32integerArray1M.AssertModel(models[12],_testData[12], false);
                Int32integerArray1M.AssertModel(models[13],_testData[13], false);
                Int32integerArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((IInt32ArrayintegerArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IInt32ArrayintegerArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                Int32integerArray1M.AssertModel(models[0],_testData[0], false);
                Int32integerArray1M.AssertModel(models[1],_testData[1], false);
                Int32integerArray1M.AssertModel(models[2],_testData[2], false);
                Int32integerArray1M.AssertModel(models[3],_testData[3], false);
                Int32integerArray1M.AssertModel(models[4],_testData[4], false);
                Int32integerArray1M.AssertModel(models[5],_testData[5], false);
                Int32integerArray1M.AssertModel(models[6],_testData[6], false);
                Int32integerArray1M.AssertModel(models[7],_testData[7], false);
                Int32integerArray1M.AssertModel(models[8],_testData[8], false);
                Int32integerArray1M.AssertModel(models[9],_testData[9], false);
                Int32integerArray1M.AssertModel(models[10],_testData[10], false);
                Int32integerArray1M.AssertModel(models[11],_testData[11], false);
                Int32integerArray1M.AssertModel(models[12],_testData[12], false);
                Int32integerArray1M.AssertModel(models[13],_testData[13], false);
                Int32integerArray1M.AssertModel(models[14],_testData[14], false);
                Int32integerArray1M.AssertModel(models[15],_testData[15], false);
                Int32integerArray1M.AssertModel(models[16],_testData[16], false);
                Int32integerArray1M.AssertModel(models[17],_testData[17], false);
                Int32integerArray1M.AssertModel(models[18],_testData[18], false);
                Int32integerArray1M.AssertModel(models[19],_testData[19], false);
                Int32integerArray1M.AssertModel(models[20],_testData[20], false);
                Int32integerArray1M.AssertModel(models[21],_testData[21], false);
                Int32integerArray1M.AssertModel(models[22],_testData[22], false);
                Int32integerArray1M.AssertModel(models[23],_testData[23], false);
                Int32integerArray1M.AssertModel(models[24],_testData[24], false);
                Int32integerArray1M.AssertModel(models[25],_testData[25], false);
                Int32integerArray1M.AssertModel(models[26],_testData[26], false);
                Int32integerArray1M.AssertModel(models[27],_testData[27], false);
                Int32integerArray1M.AssertModel(models[28],_testData[28], false);
                Int32integerArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int32integerarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int32integerarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int32integerArray1M)],
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
            asPartInterface: typeof(IInt32ArrayintegerArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt32ArrayintegerArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int32integerArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt32ArrayintegerArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int32integerArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int32integerarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int32integerArray1MI)],
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
            asPartInterface: typeof(IInt32ArrayintegerArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt32ArrayintegerArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt32ArrayintegerArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integerArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

