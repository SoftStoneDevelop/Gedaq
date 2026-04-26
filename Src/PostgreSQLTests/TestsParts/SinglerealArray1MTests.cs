

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
    Id = 7,
    Value = 
new System.Single[3]
{
0.5313018f,
0.40438497f,
0.2358104f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.54997885f,
0.12642342f,
0.13525325f,
0.19137037f,
},
},
            new SinglerealArray1M
{
    Id = 9,
    Value = 
new System.Single[4]
{
0.42010784f,
0.24521768f,
0.6123929f,
0.09917337f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 7,
    Value = 
new System.Single[4]
{
0.015009165f,
0.5274643f,
0.1844297f,
0.9389571f,
},
    NullableValue = 
new System.Single[3]
{
0.31539446f,
0.6131979f,
0.05883819f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 13,
    Value = 
new System.Single[3]
{
0.6045978f,
0.08801699f,
0.15010214f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.90372956f,
0.28790504f,
0.007695377f,
0.18849838f,
},
},
            new SinglerealArray1M
{
    Id = 14,
    Value = 
new System.Single[4]
{
0.97791266f,
0.51483077f,
0.4266587f,
0.96437687f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 14,
    Value = 
new System.Single[4]
{
0.69056106f,
0.84993476f,
0.27464426f,
0.10406804f,
},
    NullableValue = 
new System.Single[4]
{
0.13048947f,
0.4058308f,
0.2923894f,
0.3802811f,
},
},
    NullableValue = 
new System.Single[4]
{
0.21605986f,
0.20704663f,
0.7140404f,
0.7292045f,
},
},
            new SinglerealArray1M
{
    Id = 16,
    Value = 
new System.Single[3]
{
0.1764459f,
0.007319927f,
0.25821346f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.6044963f,
0.24031532f,
0.68773854f,
},
},
            new SinglerealArray1M
{
    Id = 24,
    Value = 
new System.Single[3]
{
0.54699147f,
0.38407242f,
0.31861973f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 16,
    Value = 
new System.Single[3]
{
0.5343355f,
0.10789597f,
0.15381426f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 27,
    Value = 
new System.Single[3]
{
0.07746601f,
0.4145835f,
0.9674846f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.26955658f,
0.030829966f,
0.78755605f,
0.076863766f,
},
},
            new SinglerealArray1M
{
    Id = 35,
    Value = 
new System.Single[3]
{
0.9519996f,
0.13568431f,
0.8467482f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 24,
    Value = 
new System.Single[3]
{
0.69586366f,
0.18768895f,
0.923641f,
},
    NullableValue = 
new System.Single[4]
{
0.24482578f,
0.33068353f,
0.88727874f,
0.34840333f,
},
},
    NullableValue = 
new System.Single[3]
{
0.8233956f,
0.6808925f,
0.37636513f,
},
},
            new SinglerealArray1M
{
    Id = 36,
    Value = 
new System.Single[4]
{
0.65841264f,
0.45343417f,
0.9441086f,
0.79129046f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.13099104f,
0.4808104f,
0.39541274f,
0.16470587f,
},
},
            new SinglerealArray1M
{
    Id = 43,
    Value = 
new System.Single[3]
{
0.16096812f,
0.32237786f,
0.23656237f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 26,
    Value = 
new System.Single[4]
{
0.19013822f,
0.13949758f,
0.33220857f,
0.45128793f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.312101f,
0.46530616f,
0.93619835f,
0.8311082f,
},
},
            new SinglerealArray1M
{
    Id = 45,
    Value = 
new System.Single[4]
{
0.60295683f,
0.018974245f,
0.3138141f,
0.061649203f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.17094898f,
0.84721756f,
0.6712598f,
},
},
            new SinglerealArray1M
{
    Id = 54,
    Value = 
new System.Single[4]
{
0.496279f,
0.36410695f,
0.035783947f,
0.44948477f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 32,
    Value = 
new System.Single[4]
{
0.53062254f,
0.4152252f,
0.4674222f,
0.64744854f,
},
    NullableValue = 
new System.Single[3]
{
0.5512409f,
0.9825035f,
0.19833434f,
},
},
    NullableValue = 
new System.Single[3]
{
0.8995942f,
0.7700048f,
0.6507478f,
},
},
            new SinglerealArray1M
{
    Id = 60,
    Value = 
new System.Single[3]
{
0.8051994f,
0.38642353f,
0.6547734f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.6144498f,
0.15836859f,
0.3451841f,
},
},
            new SinglerealArray1M
{
    Id = 62,
    Value = 
new System.Single[4]
{
0.4387632f,
0.48852545f,
0.41258603f,
0.97244686f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 33,
    Value = 
new System.Single[4]
{
0.48603237f,
0.38087928f,
0.26803946f,
0.5478199f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.5851997f,
0.94574004f,
0.21678764f,
0.25269508f,
},
},
            new SinglerealArray1M
{
    Id = 64,
    Value = 
new System.Single[4]
{
0.8838684f,
0.71788f,
0.73568845f,
0.8262625f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.55632573f,
0.5847606f,
0.49427724f,
0.38152093f,
},
},
            new SinglerealArray1M
{
    Id = 73,
    Value = 
new System.Single[3]
{
0.0076844096f,
0.98450685f,
0.7603826f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 42,
    Value = 
new System.Single[4]
{
0.26292753f,
0.9551937f,
0.10716343f,
0.26788807f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 75,
    Value = 
new System.Single[4]
{
0.095196724f,
0.17870057f,
0.6827492f,
0.88154227f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.7333226f,
0.09474212f,
0.3571753f,
0.31287605f,
},
},
            new SinglerealArray1M
{
    Id = 76,
    Value = 
new System.Single[3]
{
0.25337917f,
0.3558424f,
0.69756633f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 44,
    Value = 
new System.Single[4]
{
0.3737092f,
0.093455315f,
0.17885077f,
0.4229377f,
},
    NullableValue = 
new System.Single[4]
{
0.67598045f,
0.8235366f,
0.030159712f,
0.752119f,
},
},
    NullableValue = 
new System.Single[3]
{
0.42173123f,
0.15386021f,
0.12714636f,
},
},
            new SinglerealArray1M
{
    Id = 82,
    Value = 
new System.Single[3]
{
0.8022933f,
0.83590686f,
0.8349155f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 85,
    Value = 
new System.Single[4]
{
0.3728652f,
0.20782709f,
0.97449464f,
0.623126f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 51,
    Value = 
new System.Single[4]
{
0.7002966f,
0.44888854f,
0.99305856f,
0.7214702f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 86,
    Value = 
new System.Single[4]
{
0.30342537f,
0.64772886f,
0.582333f,
0.9488869f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.66932243f,
0.4643042f,
0.62673247f,
0.48206508f,
},
},
            new SinglerealArray1M
{
    Id = 95,
    Value = 
new System.Single[3]
{
0.5911936f,
0.025246978f,
0.8113189f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 60,
    Value = 
new System.Single[3]
{
0.6731528f,
0.50779456f,
0.13528836f,
},
    NullableValue = 
new System.Single[4]
{
0.8779692f,
0.6534656f,
0.3816654f,
0.9917358f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 104,
    Value = 
new System.Single[3]
{
0.06810063f,
0.7141115f,
0.59058434f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.11216134f,
0.24255526f,
0.29731494f,
},
},
            new SinglerealArray1M
{
    Id = 111,
    Value = 
new System.Single[4]
{
0.374067f,
0.28562605f,
0.629226f,
0.95877755f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 66,
    Value = 
new System.Single[3]
{
0.38724244f,
0.49209046f,
0.194843f,
},
    NullableValue = 
new System.Single[3]
{
0.91404647f,
0.5666812f,
0.8189875f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 119,
    Value = 
new System.Single[3]
{
0.37484598f,
0.08432853f,
0.8775247f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 126,
    Value = 
new System.Single[3]
{
0.55690515f,
0.57220006f,
0.20630234f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 75,
    Value = 
new System.Single[4]
{
0.68196577f,
0.8474426f,
0.057582438f,
0.19761306f,
},
    NullableValue = 
new System.Single[4]
{
0.10421556f,
0.8848642f,
0.32600147f,
0.53344953f,
},
},
    NullableValue = 
new System.Single[4]
{
0.23137945f,
0.50067425f,
0.06731981f,
0.3743875f,
},
},
            new SinglerealArray1M
{
    Id = 135,
    Value = 
new System.Single[3]
{
0.83642334f,
0.717427f,
0.5813125f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.41722983f,
0.33435887f,
0.92303866f,
},
},
            new SinglerealArray1M
{
    Id = 141,
    Value = 
new System.Single[3]
{
0.85118276f,
0.39801663f,
0.84493315f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 78,
    Value = 
new System.Single[3]
{
0.83130103f,
0.5233764f,
0.85521233f,
},
    NullableValue = 
new System.Single[4]
{
0.18533826f,
0.021744728f,
0.5563694f,
0.83379245f,
},
},
    NullableValue = 
new System.Single[3]
{
0.003399074f,
0.5477333f,
0.8612506f,
},
},
            new SinglerealArray1M
{
    Id = 144,
    Value = 
new System.Single[4]
{
0.35618097f,
0.7334869f,
0.3475113f,
0.88662577f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 149,
    Value = 
new System.Single[4]
{
0.1156795f,
0.93580765f,
0.32999682f,
0.7755431f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 80,
    Value = 
new System.Single[3]
{
0.31004322f,
0.33561105f,
0.122160494f,
},
    NullableValue = 
new System.Single[3]
{
0.9743856f,
0.6310112f,
0.45339996f,
},
},
    NullableValue = null,
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
0.6044963f,
0.24031532f,
0.68773854f,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[4]
{
0.26955658f,
0.030829966f,
0.78755605f,
0.076863766f,
}));
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
0.8233956f,
0.6808925f,
0.37636513f,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[4]
{
0.13099104f,
0.4808104f,
0.39541274f,
0.16470587f,
}));
                nullable =  ((ISingleArrayrealArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[4]
{
0.312101f,
0.46530616f,
0.93619835f,
0.8311082f,
}));
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
new System.Single[3]
{
0.17094898f,
0.84721756f,
0.6712598f,
}));
                nullable = await ((ISingleArrayrealArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[3]
{
0.8995942f,
0.7700048f,
0.6507478f,
}));
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[25],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[19],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[24],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
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
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[17],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[18],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[19],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
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
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[17],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[18],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[22],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        SinglerealArray1M.AssertModel(models[0],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        SinglerealArray1M.AssertModel(models[0],_testData[13], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[14], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[15], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[16], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[17], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[15],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        SinglerealArray1M.AssertModel(models[0],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[29], false);
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
                int resultIndex = 0;
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
                await ((ISingleArrayrealArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 64, query1, 86, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                await ((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 9, query1, 13, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[26],_testData[29], false);
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
                int resultIndex = 0;
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
                 ((ISingleArrayrealArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 85, query1, 75, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                 ((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 76, query1, 119, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[29], false);
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
                int resultIndex = 0;
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
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 27, query1, 73, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[17],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[18],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[19],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[20],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[21],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[29], false);
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
                int resultIndex = 0;
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
                await ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 54, query1, 95, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[29], false);
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
                int resultIndex = 0;
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
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 14, query1, 141, query2))
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
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[29], false);
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
                int resultIndex = 0;
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
                 ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelBatch(connection, 13, query1, 126, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[29], false);
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
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTSelectModelBatchAsync(connection, 54, 43))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        SinglerealArray1M.AssertModel(models[0],_testData[12], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[13], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[14], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[15], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[16], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[17], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[15],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[16],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[17],_testData[29], false);
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
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTSelectModelBatch(connection, 135, 54))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        SinglerealArray1M.AssertModel(models[0],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        SinglerealArray1M.AssertModel(models[0],_testData[12], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[13], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[14], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[15], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[16], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[17], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[15],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[16],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[17],_testData[29], false);
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
                ((ISingleArrayrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 27);
                var models = await ((ISingleArrayrealArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
SinglerealArray1M.AssertModel(models[0],_testData[7], false);SinglerealArray1M.AssertModel(models[1],_testData[8], false);SinglerealArray1M.AssertModel(models[2],_testData[9], false);SinglerealArray1M.AssertModel(models[3],_testData[10], false);SinglerealArray1M.AssertModel(models[4],_testData[11], false);SinglerealArray1M.AssertModel(models[5],_testData[12], false);SinglerealArray1M.AssertModel(models[6],_testData[13], false);SinglerealArray1M.AssertModel(models[7],_testData[14], false);SinglerealArray1M.AssertModel(models[8],_testData[15], false);SinglerealArray1M.AssertModel(models[9],_testData[16], false);SinglerealArray1M.AssertModel(models[10],_testData[17], false);SinglerealArray1M.AssertModel(models[11],_testData[18], false);SinglerealArray1M.AssertModel(models[12],_testData[19], false);SinglerealArray1M.AssertModel(models[13],_testData[20], false);SinglerealArray1M.AssertModel(models[14],_testData[21], false);SinglerealArray1M.AssertModel(models[15],_testData[22], false);SinglerealArray1M.AssertModel(models[16],_testData[23], false);SinglerealArray1M.AssertModel(models[17],_testData[24], false);SinglerealArray1M.AssertModel(models[18],_testData[25], false);SinglerealArray1M.AssertModel(models[19],_testData[26], false);SinglerealArray1M.AssertModel(models[20],_testData[27], false);SinglerealArray1M.AssertModel(models[21],_testData[28], false);SinglerealArray1M.AssertModel(models[22],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleArrayrealArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleArrayrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 85);
                var models =  ((ISingleArrayrealArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(10));
SinglerealArray1M.AssertModel(models[0],_testData[20], false);SinglerealArray1M.AssertModel(models[1],_testData[21], false);SinglerealArray1M.AssertModel(models[2],_testData[22], false);SinglerealArray1M.AssertModel(models[3],_testData[23], false);SinglerealArray1M.AssertModel(models[4],_testData[24], false);SinglerealArray1M.AssertModel(models[5],_testData[25], false);SinglerealArray1M.AssertModel(models[6],_testData[26], false);SinglerealArray1M.AssertModel(models[7],_testData[27], false);SinglerealArray1M.AssertModel(models[8],_testData[28], false);SinglerealArray1M.AssertModel(models[9],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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

