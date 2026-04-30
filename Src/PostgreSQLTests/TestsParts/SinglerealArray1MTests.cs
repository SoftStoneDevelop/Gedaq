

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
    internal partial interface ISingleArrayrealArray
    {
    }
    
    internal partial class SingleArrayrealArray : ISingleArrayrealArray
    {


#region TestData

        private readonly SinglerealArray1M[] _testData = new SinglerealArray1M[]
        {
            new SinglerealArray1M
{
    Id = 2,
    Value = 
new System.Single[3]
{
0.45123267f,
0.6169041f,
0.43127495f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.46844214f,
0.72651076f,
0.17081213f,
0.7724978f,
},
},
            new SinglerealArray1M
{
    Id = 5,
    Value = 
new System.Single[3]
{
0.4962774f,
0.49749553f,
0.1778807f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 3,
    Value = 
new System.Single[4]
{
0.2405569f,
0.5196725f,
0.81157017f,
0.8351773f,
},
    NullableValue = 
new System.Single[4]
{
0.6309789f,
0.15968382f,
0.6628394f,
0.36989135f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 12,
    Value = 
new System.Single[3]
{
0.55720145f,
0.8788912f,
0.6775932f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 19,
    Value = 
new System.Single[4]
{
0.4568606f,
0.4278487f,
0.6145861f,
0.4068303f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 10,
    Value = 
new System.Single[4]
{
0.9855175f,
0.5116539f,
0.1097399f,
0.00019031763f,
},
    NullableValue = 
new System.Single[4]
{
0.0938732f,
0.31841683f,
0.9066635f,
0.50273705f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 22,
    Value = 
new System.Single[4]
{
0.43693233f,
0.84880036f,
0.8147976f,
0.97525674f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.36477572f,
0.46891373f,
0.5573455f,
},
},
            new SinglerealArray1M
{
    Id = 26,
    Value = 
new System.Single[4]
{
0.9651088f,
0.82262176f,
0.05343461f,
0.96590704f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 14,
    Value = 
new System.Single[4]
{
0.9602651f,
0.2011661f,
0.7455363f,
0.36047488f,
},
    NullableValue = 
new System.Single[3]
{
0.049010336f,
0.019701958f,
0.68574154f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 33,
    Value = 
new System.Single[4]
{
0.54130775f,
0.109927416f,
0.6472419f,
0.8811582f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 42,
    Value = 
new System.Single[4]
{
0.6034862f,
0.35313696f,
0.21017975f,
0.9398387f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 15,
    Value = 
new System.Single[3]
{
0.76104766f,
0.55526835f,
0.6440944f,
},
    NullableValue = 
new System.Single[4]
{
0.98032254f,
0.26658803f,
0.3090195f,
0.027483702f,
},
},
    NullableValue = 
new System.Single[3]
{
0.25818402f,
0.66318905f,
0.66113704f,
},
},
            new SinglerealArray1M
{
    Id = 48,
    Value = 
new System.Single[4]
{
0.5159131f,
0.123517096f,
0.74084985f,
0.022662163f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 54,
    Value = 
new System.Single[4]
{
0.8953928f,
0.47673702f,
0.799926f,
0.7273931f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 19,
    Value = 
new System.Single[3]
{
0.037080288f,
0.8120302f,
0.105879664f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 59,
    Value = 
new System.Single[4]
{
0.3803705f,
0.2830773f,
0.14056784f,
0.50788325f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.79287547f,
0.25000525f,
0.436701f,
0.8410939f,
},
},
            new SinglerealArray1M
{
    Id = 65,
    Value = 
new System.Single[3]
{
0.24931568f,
0.8321052f,
0.4720981f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 21,
    Value = 
new System.Single[3]
{
0.42037678f,
0.37477577f,
0.66282105f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 69,
    Value = 
new System.Single[3]
{
0.9734332f,
0.7314236f,
0.5936259f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.8855788f,
0.008615315f,
0.68929505f,
0.04772532f,
},
},
            new SinglerealArray1M
{
    Id = 72,
    Value = 
new System.Single[4]
{
0.072601914f,
0.3646031f,
0.27072453f,
0.7003152f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 29,
    Value = 
new System.Single[3]
{
0.5610982f,
0.4436009f,
0.989582f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 73,
    Value = 
new System.Single[3]
{
0.13349938f,
0.68679726f,
0.16441739f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 79,
    Value = 
new System.Single[3]
{
0.4117787f,
0.7050348f,
0.9958949f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 36,
    Value = 
new System.Single[4]
{
0.821553f,
0.74236715f,
0.6394835f,
0.42188084f,
},
    NullableValue = 
new System.Single[3]
{
0.42683047f,
0.37101656f,
0.25882697f,
},
},
    NullableValue = 
new System.Single[3]
{
0.07551944f,
0.93356353f,
0.46797097f,
},
},
            new SinglerealArray1M
{
    Id = 82,
    Value = 
new System.Single[4]
{
0.907643f,
0.8771445f,
0.4834603f,
0.7737548f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 90,
    Value = 
new System.Single[4]
{
0.61775756f,
0.09848195f,
0.7051265f,
0.93653345f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 38,
    Value = 
new System.Single[3]
{
0.4302979f,
0.5165543f,
0.83439916f,
},
    NullableValue = 
new System.Single[3]
{
0.20493138f,
0.28872287f,
0.30497593f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 96,
    Value = 
new System.Single[3]
{
0.6352436f,
0.110299945f,
0.36061138f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.17484057f,
0.6323825f,
0.8524452f,
0.06795424f,
},
},
            new SinglerealArray1M
{
    Id = 100,
    Value = 
new System.Single[4]
{
0.2498151f,
0.9929567f,
0.16416138f,
0.29181033f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 42,
    Value = 
new System.Single[4]
{
0.6107678f,
0.83128035f,
0.6395263f,
0.50133157f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 107,
    Value = 
new System.Single[4]
{
0.66309774f,
0.7300168f,
0.54498786f,
0.77719307f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 111,
    Value = 
new System.Single[3]
{
0.8112444f,
0.31891626f,
0.88597226f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 48,
    Value = 
new System.Single[4]
{
0.48887777f,
0.17082125f,
0.1271292f,
0.67544407f,
},
    NullableValue = 
new System.Single[4]
{
0.9128423f,
0.70577717f,
0.9257752f,
0.624047f,
},
},
    NullableValue = 
new System.Single[4]
{
0.74471277f,
0.9381174f,
0.3840887f,
0.15789294f,
},
},
            new SinglerealArray1M
{
    Id = 114,
    Value = 
new System.Single[3]
{
0.19528228f,
0.12721962f,
0.77431697f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.15779155f,
0.8073367f,
0.25747895f,
},
},
            new SinglerealArray1M
{
    Id = 119,
    Value = 
new System.Single[3]
{
0.30115092f,
0.8336394f,
0.41841036f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 57,
    Value = 
new System.Single[4]
{
0.8241941f,
0.7509621f,
0.2338404f,
0.51344496f,
},
    NullableValue = 
new System.Single[4]
{
0.12150407f,
0.23555088f,
0.9606401f,
0.34826225f,
},
},
    NullableValue = 
new System.Single[4]
{
0.07213521f,
0.0064867735f,
0.26791137f,
0.24569243f,
},
},
            new SinglerealArray1M
{
    Id = 122,
    Value = 
new System.Single[4]
{
0.098755896f,
0.32214248f,
0.7969104f,
0.11147308f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.001454711f,
0.2607473f,
0.8668142f,
},
},
            new SinglerealArray1M
{
    Id = 127,
    Value = 
new System.Single[4]
{
0.86064166f,
0.09132528f,
0.25019056f,
0.6565819f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 62,
    Value = 
new System.Single[3]
{
0.4209084f,
0.10016745f,
0.03505677f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.22211564f,
0.25716037f,
0.8219017f,
0.08127439f,
},
},
            new SinglerealArray1M
{
    Id = 134,
    Value = 
new System.Single[4]
{
0.614863f,
0.03761393f,
0.09575683f,
0.9067289f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.72348285f,
0.8302324f,
0.5989666f,
},
},
            new SinglerealArray1M
{
    Id = 139,
    Value = 
new System.Single[3]
{
0.9672295f,
0.88676155f,
0.7435864f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 69,
    Value = 
new System.Single[4]
{
0.156703f,
0.92511916f,
0.97595984f,
0.6658295f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 146,
    Value = 
new System.Single[4]
{
0.38404173f,
0.6867988f,
0.62891996f,
0.6016851f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.18233305f,
0.4738208f,
0.24728864f,
},
},
            new SinglerealArray1M
{
    Id = 153,
    Value = 
new System.Single[4]
{
0.683113f,
0.29449725f,
0.29362506f,
0.8135406f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 77,
    Value = 
new System.Single[4]
{
0.35329437f,
0.22795194f,
0.61381996f,
0.6053055f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.569239f,
0.93698424f,
0.757761f,
0.7846495f,
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealarray1mi(
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
            asPartInterface: typeof(ISingleArrayrealArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealarray1mi(
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
            queryMapTypes: [typeof(SinglerealArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631))]
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

                changedRows =  ((ISingleArrayrealArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISingleArrayrealArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ISingleArrayrealArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleArrayrealArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((ISingleArrayrealArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((ISingleArrayrealArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((ISingleArrayrealArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((ISingleArrayrealArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((ISingleArrayrealArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((ISingleArrayrealArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((ISingleArrayrealArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((ISingleArrayrealArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((ISingleArrayrealArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((ISingleArrayrealArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((ISingleArrayrealArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealarray1m(
	id,
    value,
    nullablevalue,
    singlerealarray1mi_id
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
            asPartInterface: typeof(ISingleArrayrealArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "singlerealarray1mi_id", 
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
                changedRows =  ((ISingleArrayrealArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((ISingleArrayrealArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((ISingleArrayrealArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((ISingleArrayrealArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealarray1m(
	id,
    value,
    nullablevalue,
    singlerealarray1mi_id
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
    singlerealarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(SinglerealArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
                System.Single[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Single[]>();
                    ((NpgsqlParameter<System.Single[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483631);
                    ((NpgsqlParameter<System.Single[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483631);
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

                    nullable =  ((ISingleArrayrealArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[3]
{
0.36477572f,
0.46891373f,
0.5573455f,
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Single[]>();
                    ((NpgsqlParameter<System.Single[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483631);
                    ((NpgsqlParameter<System.Single[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483631);
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

                    nullable =  ((ISingleArrayrealArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                System.Single[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Single[]>();
                    ((NpgsqlParameter<System.Single[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483631);
                    ((NpgsqlParameter<System.Single[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483631);
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

                    nullable = await ((ISingleArrayrealArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Single[]>();
                    ((NpgsqlParameter<System.Single[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483631);
                    ((NpgsqlParameter<System.Single[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483631);
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

                    nullable = await ((ISingleArrayrealArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[3]
{
0.25818402f,
0.66318905f,
0.66113704f,
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealarray1m(
	id,
    value,
    nullablevalue,
    singlerealarray1mi_id
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
    singlerealarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(SinglerealArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "singlerealarray1mi_id", 
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
                System.Single[] nullable = null;
                nullable =  ((ISingleArrayrealArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((ISingleArrayrealArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Single[] nullable = null;
                nullable = await ((ISingleArrayrealArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[4]
{
0.79287547f,
0.25000525f,
0.436701f,
0.8410939f,
}));
                nullable = await ((ISingleArrayrealArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<SinglerealArray1M> models = null;

                models =  ((ISingleArrayrealArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((ISingleArrayrealArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((ISingleArrayrealArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((ISingleArrayrealArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<SinglerealArray1M> models = null;

                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealArray1M), typeof(FlatSinglerealArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
FROM public.singlerealarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSinglerealArray1M>();
                var models2 = new List<FlatSinglerealArray1M>();
                await ((ISingleArrayrealArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSinglerealArray1M>();
                var models2 = new List<FlatSinglerealArray1M>();
                ((ISingleArrayrealArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
FROM public.singlerealarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ISingleArrayrealArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ISingleArrayrealArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray1m m
LEFT JOIN public.singlerealarray1mi mi ON mi.id = m.singlerealarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(SinglerealArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
                var models = await ((ISingleArrayrealArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((ISingleArrayrealArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealArray1M), typeof(FlatSinglerealArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
FROM public.singlerealarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealArray1M>();
                var models2 = new List<FlatSinglerealArray1M>();
                await ((ISingleArrayrealArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealArray1M>();
                var models2 = new List<FlatSinglerealArray1M>();
                ((ISingleArrayrealArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
FROM public.singlerealarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ISingleArrayrealArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ISingleArrayrealArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray1m m
LEFT JOIN public.singlerealarray1mi mi ON mi.id = m.singlerealarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(SinglerealArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
                var models = await ((ISingleArrayrealArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((ISingleArrayrealArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealArray1M), typeof(FlatSinglerealArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
            asPartInterface: typeof(ISingleArrayrealArray)),
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglerealArray1M>();
                var models2 = new List<FlatSinglerealArray1M>();
                await((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
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
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray1M>();
                var firstItems2 = new List<FlatSinglerealArray1M>();
                var secondItems1 = new List<FlatSinglerealArray1M>();
                var secondItems2 = new List<FlatSinglerealArray1M>();
                await ((ISingleArrayrealArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
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
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray1M>();
                var firstItems2 = new List<FlatSinglerealArray1M>();
                var secondItems1 = new List<FlatSinglerealArray1M>();
                await ((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[29], false);
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglerealArray1M>();
                var models2 = new List<FlatSinglerealArray1M>();
                ((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
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
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray1M>();
                var firstItems2 = new List<FlatSinglerealArray1M>();
                var secondItems1 = new List<FlatSinglerealArray1M>();
                var secondItems2 = new List<FlatSinglerealArray1M>();
                 ((ISingleArrayrealArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
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
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray1M>();
                var firstItems2 = new List<FlatSinglerealArray1M>();
                var secondItems1 = new List<FlatSinglerealArray1M>();
                 ((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[24],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
            asPartInterface: typeof(ISingleArrayrealArray)),
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[17],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[18],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[19],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[20],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[21],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[22],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[23],_testData[29], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray1M>();
                var secondItems1 = new List<FlatSinglerealArray1M>();
                var secondItems2 = new List<FlatSinglerealArray1M>();
                await ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[19],_testData[29], false);
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[29], false);
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray1M>();
                var secondItems1 = new List<FlatSinglerealArray1M>();
                var secondItems2 = new List<FlatSinglerealArray1M>();
                 ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[21],_testData[29], false);
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
FROM public.singlerealarray1m m
LEFT JOIN public.singlerealarray1mi mi ON mi.id = m.singlerealarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(SinglerealArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
                var models = await((ISingleArrayrealArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        SinglerealArray1M.AssertModel(models[0],_testData[5], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[6], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[7], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[8], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[9], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[10], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[11], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[12], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[13], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[14], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[15], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[16], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[17], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[15],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[16],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[17],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[18],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[19],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[20],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[21],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[22],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[23],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        SinglerealArray1M.AssertModel(models[0],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[29], false);
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
                var models = ((ISingleArrayrealArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        SinglerealArray1M.AssertModel(models[0],_testData[16], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[17], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        SinglerealArray1M.AssertModel(models[0],_testData[8], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[9], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[10], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[11], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[12], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[13], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[14], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[15], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[16], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[17], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[15],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[16],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[17],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[18],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[19],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[20],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealArray1M), typeof(FlatSinglerealArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
            asPartInterface: typeof(ISingleArrayrealArray)),
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
            asPartInterface: typeof(ISingleArrayrealArray)),
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealArray1M>();
                var models2 = new List<FlatSinglerealArray1M>();
                await((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray1M>();
                var firstItems2 = new List<FlatSinglerealArray1M>();
                var secondItems1 = new List<FlatSinglerealArray1M>();
                var secondItems2 = new List<FlatSinglerealArray1M>();
                await ((ISingleArrayrealArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 119, query1, 69, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[16],_testData[29], false);
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
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray1M>();
                var firstItems2 = new List<FlatSinglerealArray1M>();
                var secondItems1 = new List<FlatSinglerealArray1M>();
                await ((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 90, query1, 114, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[29], false);
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealArray1M>();
                var models2 = new List<FlatSinglerealArray1M>();
                ((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray1M>();
                var firstItems2 = new List<FlatSinglerealArray1M>();
                var secondItems1 = new List<FlatSinglerealArray1M>();
                var secondItems2 = new List<FlatSinglerealArray1M>();
                 ((ISingleArrayrealArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 72, query1, 119, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[29], false);
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
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray1M>();
                var firstItems2 = new List<FlatSinglerealArray1M>();
                var secondItems1 = new List<FlatSinglerealArray1M>();
                 ((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 73, query1, 90, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
            asPartInterface: typeof(ISingleArrayrealArray)),
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
            asPartInterface: typeof(ISingleArrayrealArray)),
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 19, query1, 127, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[17],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[18],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[19],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[20],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[21],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[22],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[23],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[24],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[29], false);
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
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray1M>();
                var secondItems1 = new List<FlatSinglerealArray1M>();
                var secondItems2 = new List<FlatSinglerealArray1M>();
                await ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 134, query1, 119, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[29], false);
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 134, query1, 96, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[29], false);
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
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray1M>();
                var secondItems1 = new List<FlatSinglerealArray1M>();
                var secondItems2 = new List<FlatSinglerealArray1M>();
                 ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelBatch(connection, 100, query1, 2, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[28],_testData[29], false);
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
FROM public.singlerealarray1m m
LEFT JOIN public.singlerealarray1mi mi ON mi.id = m.singlerealarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(SinglerealArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
            asPartInterface: typeof(ISingleArrayrealArray)),
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
                var models = await((ISingleArrayrealArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTSelectModelBatchAsync(connection, 127, 139))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        SinglerealArray1M.AssertModel(models[0],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        SinglerealArray1M.AssertModel(models[0],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[29], false);
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
                var models = ((ISingleArrayrealArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTSelectModelBatch(connection, 42, 54))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        SinglerealArray1M.AssertModel(models[0],_testData[8], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[9], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[10], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[11], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[12], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[13], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[14], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[15], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[16], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[17], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[15],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[16],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[17],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[18],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[19],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[20],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        SinglerealArray1M.AssertModel(models[0],_testData[10], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[11], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[12], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[13], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[14], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[15], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[16], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[17], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[15],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[16],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[17],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[18],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[19],_testData[29], false);
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
                await using var cmd = await ((ISingleArrayrealArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ISingleArrayrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 107);
                var models = await ((ISingleArrayrealArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
SinglerealArray1M.AssertModel(models[0],_testData[21], false);SinglerealArray1M.AssertModel(models[1],_testData[22], false);SinglerealArray1M.AssertModel(models[2],_testData[23], false);SinglerealArray1M.AssertModel(models[3],_testData[24], false);SinglerealArray1M.AssertModel(models[4],_testData[25], false);SinglerealArray1M.AssertModel(models[5],_testData[26], false);SinglerealArray1M.AssertModel(models[6],_testData[27], false);SinglerealArray1M.AssertModel(models[7],_testData[28], false);SinglerealArray1M.AssertModel(models[8],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleArrayrealArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleArrayrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 100);
                var models =  ((ISingleArrayrealArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(10));
SinglerealArray1M.AssertModel(models[0],_testData[20], false);SinglerealArray1M.AssertModel(models[1],_testData[21], false);SinglerealArray1M.AssertModel(models[2],_testData[22], false);SinglerealArray1M.AssertModel(models[3],_testData[23], false);SinglerealArray1M.AssertModel(models[4],_testData[24], false);SinglerealArray1M.AssertModel(models[5],_testData[25], false);SinglerealArray1M.AssertModel(models[6],_testData[26], false);SinglerealArray1M.AssertModel(models[7],_testData[27], false);SinglerealArray1M.AssertModel(models[8],_testData[28], false);SinglerealArray1M.AssertModel(models[9],_testData[29], false);
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
FROM public.binary_singlerealarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(SinglerealArray1MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<SinglerealArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((ISingleArrayrealArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_singlerealarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISingleArrayrealArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray1MI.AssertModel(actual, expect, false);
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
                await ((ISingleArrayrealArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_singlerealarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                models = await ((ISingleArrayrealArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_singlerealarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(SinglerealArray1MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<SinglerealArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((ISingleArrayrealArray)this).ImportModelInner(connection, importCollection);
                var models = ((ISingleArrayrealArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray1MI.AssertModel(actual, expect, false);
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
                await ((ISingleArrayrealArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((ISingleArrayrealArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_singlerealarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
singlerealarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(SinglerealArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
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
FROM public.binary_singlerealarray1m m
LEFT JOIN public.binary_singlerealarray1mi mi ON mi.id = m.singlerealarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(SinglerealArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<SinglerealArray1M>(15);

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
                ((ISingleArrayrealArray)this).ImportModel(connection, importCollection);
                var models = ((ISingleArrayrealArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                SinglerealArray1M.AssertModel(models[0],_testData[0], false);
                SinglerealArray1M.AssertModel(models[1],_testData[1], false);
                SinglerealArray1M.AssertModel(models[2],_testData[2], false);
                SinglerealArray1M.AssertModel(models[3],_testData[3], false);
                SinglerealArray1M.AssertModel(models[4],_testData[4], false);
                SinglerealArray1M.AssertModel(models[5],_testData[5], false);
                SinglerealArray1M.AssertModel(models[6],_testData[6], false);
                SinglerealArray1M.AssertModel(models[7],_testData[7], false);
                SinglerealArray1M.AssertModel(models[8],_testData[8], false);
                SinglerealArray1M.AssertModel(models[9],_testData[9], false);
                SinglerealArray1M.AssertModel(models[10],_testData[10], false);
                SinglerealArray1M.AssertModel(models[11],_testData[11], false);
                SinglerealArray1M.AssertModel(models[12],_testData[12], false);
                SinglerealArray1M.AssertModel(models[13],_testData[13], false);
                SinglerealArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((ISingleArrayrealArray)this).ImportModelAsync(connection, importCollection);
                models = await ((ISingleArrayrealArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                SinglerealArray1M.AssertModel(models[0],_testData[0], false);
                SinglerealArray1M.AssertModel(models[1],_testData[1], false);
                SinglerealArray1M.AssertModel(models[2],_testData[2], false);
                SinglerealArray1M.AssertModel(models[3],_testData[3], false);
                SinglerealArray1M.AssertModel(models[4],_testData[4], false);
                SinglerealArray1M.AssertModel(models[5],_testData[5], false);
                SinglerealArray1M.AssertModel(models[6],_testData[6], false);
                SinglerealArray1M.AssertModel(models[7],_testData[7], false);
                SinglerealArray1M.AssertModel(models[8],_testData[8], false);
                SinglerealArray1M.AssertModel(models[9],_testData[9], false);
                SinglerealArray1M.AssertModel(models[10],_testData[10], false);
                SinglerealArray1M.AssertModel(models[11],_testData[11], false);
                SinglerealArray1M.AssertModel(models[12],_testData[12], false);
                SinglerealArray1M.AssertModel(models[13],_testData[13], false);
                SinglerealArray1M.AssertModel(models[14],_testData[14], false);
                SinglerealArray1M.AssertModel(models[15],_testData[15], false);
                SinglerealArray1M.AssertModel(models[16],_testData[16], false);
                SinglerealArray1M.AssertModel(models[17],_testData[17], false);
                SinglerealArray1M.AssertModel(models[18],_testData[18], false);
                SinglerealArray1M.AssertModel(models[19],_testData[19], false);
                SinglerealArray1M.AssertModel(models[20],_testData[20], false);
                SinglerealArray1M.AssertModel(models[21],_testData[21], false);
                SinglerealArray1M.AssertModel(models[22],_testData[22], false);
                SinglerealArray1M.AssertModel(models[23],_testData[23], false);
                SinglerealArray1M.AssertModel(models[24],_testData[24], false);
                SinglerealArray1M.AssertModel(models[25],_testData[25], false);
                SinglerealArray1M.AssertModel(models[26],_testData[26], false);
                SinglerealArray1M.AssertModel(models[27],_testData[27], false);
                SinglerealArray1M.AssertModel(models[28],_testData[28], false);
                SinglerealArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlerealarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    singlerealarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(SinglerealArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ISingleArrayrealArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    SinglerealArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISingleArrayrealArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    SinglerealArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlerealarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ISingleArrayrealArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISingleArrayrealArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

