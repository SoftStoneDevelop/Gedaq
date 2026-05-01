

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
new System.Single[4]
{
0.59793615f,
0.9100628f,
0.14094055f,
0.14038265f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 15,
    Value = 
new System.Single[4]
{
0.3818428f,
0.355025f,
0.054584682f,
0.20871735f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 3,
    Value = 
new System.Single[3]
{
0.30484825f,
0.75740963f,
0.904385f,
},
    NullableValue = 
new System.Single[3]
{
0.70627445f,
0.5421469f,
0.69073075f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 23,
    Value = 
new System.Single[3]
{
0.79403466f,
0.07796186f,
0.08948296f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.33282048f,
0.6332887f,
0.67834693f,
},
},
            new SinglerealArray1M
{
    Id = 25,
    Value = 
new System.Single[3]
{
0.3124898f,
0.33648187f,
0.90038866f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 6,
    Value = 
new System.Single[3]
{
0.9623681f,
0.052798808f,
0.965203f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 26,
    Value = 
new System.Single[4]
{
0.14300734f,
0.8826322f,
0.2292369f,
0.43446195f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 31,
    Value = 
new System.Single[4]
{
0.44170785f,
0.630084f,
0.50073576f,
0.70382017f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 9,
    Value = 
new System.Single[3]
{
0.38549072f,
0.45930588f,
0.38125592f,
},
    NullableValue = 
new System.Single[3]
{
0.517381f,
0.008939683f,
0.05573815f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 38,
    Value = 
new System.Single[4]
{
0.12363273f,
0.25935262f,
0.28515995f,
0.7409352f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.9056041f,
0.2637732f,
0.5980846f,
},
},
            new SinglerealArray1M
{
    Id = 42,
    Value = 
new System.Single[4]
{
0.39686656f,
0.76678646f,
0.66196734f,
0.5350028f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 12,
    Value = 
new System.Single[4]
{
0.78071666f,
0.86000067f,
0.9673402f,
0.41287518f,
},
    NullableValue = 
new System.Single[4]
{
0.9653659f,
0.78611904f,
0.1461131f,
0.14153141f,
},
},
    NullableValue = 
new System.Single[3]
{
0.54479325f,
0.2899571f,
0.23718178f,
},
},
            new SinglerealArray1M
{
    Id = 49,
    Value = 
new System.Single[4]
{
0.41464937f,
0.42789555f,
0.15031493f,
0.7280412f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 51,
    Value = 
new System.Single[4]
{
0.939373f,
0.69973564f,
0.26842606f,
0.2896515f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 15,
    Value = 
new System.Single[4]
{
0.7788499f,
0.34169096f,
0.6465894f,
0.7177847f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 52,
    Value = 
new System.Single[4]
{
0.6418908f,
0.17884779f,
0.15559077f,
0.7615706f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 59,
    Value = 
new System.Single[3]
{
0.27667135f,
0.06830937f,
0.7315333f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 22,
    Value = 
new System.Single[3]
{
0.22231889f,
0.1661129f,
0.14833415f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 65,
    Value = 
new System.Single[4]
{
0.22302246f,
0.89464813f,
0.9508176f,
0.61353946f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 66,
    Value = 
new System.Single[3]
{
0.8848423f,
0.8636784f,
0.039316297f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 27,
    Value = 
new System.Single[4]
{
0.30885708f,
0.0038542151f,
0.65346974f,
0.85802644f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 69,
    Value = 
new System.Single[4]
{
0.34918243f,
0.5249872f,
0.72808f,
0.3228624f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.48143905f,
0.79031235f,
0.0011240244f,
},
},
            new SinglerealArray1M
{
    Id = 76,
    Value = 
new System.Single[3]
{
0.9347334f,
0.4117676f,
0.6360324f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 35,
    Value = 
new System.Single[4]
{
0.10600674f,
0.39988613f,
0.6332103f,
0.64087164f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[3]
{
0.66795963f,
0.37003958f,
0.6346508f,
},
},
            new SinglerealArray1M
{
    Id = 84,
    Value = 
new System.Single[3]
{
0.6101167f,
0.95021474f,
0.67623746f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 93,
    Value = 
new System.Single[4]
{
0.33752644f,
0.7581542f,
0.36887723f,
0.8609174f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 42,
    Value = 
new System.Single[4]
{
0.02975452f,
0.586266f,
0.2843876f,
0.17194676f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 94,
    Value = 
new System.Single[4]
{
0.120446146f,
0.5946095f,
0.72250956f,
0.41519308f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 99,
    Value = 
new System.Single[4]
{
0.4052642f,
0.8185043f,
0.68134654f,
0.26931655f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 51,
    Value = 
new System.Single[4]
{
0.8996488f,
0.8300126f,
0.8425264f,
0.44229192f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[3]
{
0.5691884f,
0.13763201f,
0.45582658f,
},
},
            new SinglerealArray1M
{
    Id = 106,
    Value = 
new System.Single[4]
{
0.6665844f,
0.05328405f,
0.60692513f,
0.48014516f,
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
0.44536036f,
0.63975185f,
0.20191544f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 56,
    Value = 
new System.Single[3]
{
0.70486635f,
0.37356f,
0.7142134f,
},
    NullableValue = 
new System.Single[4]
{
0.1406461f,
0.6521762f,
0.9168701f,
0.120838284f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 112,
    Value = 
new System.Single[4]
{
0.53333545f,
0.71422625f,
0.4414791f,
0.6857201f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.2337268f,
0.59020936f,
0.63130367f,
0.6574808f,
},
},
            new SinglerealArray1M
{
    Id = 118,
    Value = 
new System.Single[4]
{
0.16640276f,
0.042345226f,
0.45318657f,
0.6755983f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 64,
    Value = 
new System.Single[3]
{
0.5166438f,
0.94137734f,
0.5240767f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.29018384f,
0.8632454f,
0.58081836f,
0.26784748f,
},
},
            new SinglerealArray1M
{
    Id = 123,
    Value = 
new System.Single[4]
{
0.7618491f,
0.5088689f,
0.4180895f,
0.9868011f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 126,
    Value = 
new System.Single[4]
{
0.24719667f,
0.32265508f,
0.3754403f,
0.8120324f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 72,
    Value = 
new System.Single[3]
{
0.3763817f,
0.67447263f,
0.8535971f,
},
    NullableValue = 
new System.Single[3]
{
0.6112687f,
0.9484137f,
0.6424064f,
},
},
    NullableValue = 
new System.Single[4]
{
0.72104406f,
0.42003506f,
0.037131727f,
0.83866817f,
},
},
            new SinglerealArray1M
{
    Id = 129,
    Value = 
new System.Single[3]
{
0.74998045f,
0.44339788f,
0.9978971f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.02169472f,
0.6241663f,
0.023456037f,
0.28499937f,
},
},
            new SinglerealArray1M
{
    Id = 130,
    Value = 
new System.Single[3]
{
0.14386016f,
0.7594922f,
0.63477325f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 80,
    Value = 
new System.Single[3]
{
0.107447445f,
0.04978746f,
0.47010028f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 135,
    Value = 
new System.Single[4]
{
0.47009885f,
0.80324376f,
0.69372135f,
0.3328091f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.41728693f,
0.47865862f,
0.084912956f,
0.6237697f,
},
},
            new SinglerealArray1M
{
    Id = 137,
    Value = 
new System.Single[3]
{
0.29703403f,
0.122737765f,
0.046301603f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 87,
    Value = 
new System.Single[4]
{
0.6634783f,
0.730878f,
0.40514952f,
0.08823687f,
},
    NullableValue = 
new System.Single[4]
{
0.10518974f,
0.94520897f,
0.20781308f,
0.7298519f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 140,
    Value = 
new System.Single[3]
{
0.23768431f,
0.90872973f,
0.77465665f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.7080246f,
0.9965943f,
0.40119547f,
},
},
            new SinglerealArray1M
{
    Id = 148,
    Value = 
new System.Single[4]
{
0.7494084f,
0.8307415f,
0.7433137f,
0.37438357f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 88,
    Value = 
new System.Single[4]
{
0.38089997f,
0.10378337f,
0.9804905f,
0.8602009f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 154,
    Value = 
new System.Single[3]
{
0.09331179f,
0.41198766f,
0.016729772f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.06574732f,
0.72734064f,
0.84545815f,
0.3658796f,
},
},
            new SinglerealArray1M
{
    Id = 157,
    Value = 
new System.Single[3]
{
0.19036126f,
0.70140094f,
0.9331268f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 95,
    Value = 
new System.Single[3]
{
0.36892694f,
0.58819205f,
0.012067556f,
},
    NullableValue = 
new System.Single[4]
{
0.7974654f,
0.49330527f,
0.7910445f,
0.7668993f,
},
},
    NullableValue = 
new System.Single[3]
{
0.24891728f,
0.33141613f,
0.59774697f,
},
},
            new SinglerealArray1M
{
    Id = 162,
    Value = 
new System.Single[4]
{
0.036439f,
0.7307646f,
0.4641021f,
0.9024454f,
},
    ModelInner = null,
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

                id = await ((ISingleArrayrealArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((ISingleArrayrealArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                Assert.That(nullable, Is.Null);
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
new System.Single[3]
{
0.9056041f,
0.2637732f,
0.5980846f,
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
0.54479325f,
0.2899571f,
0.23718178f,
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
                Assert.That(nullable, Is.Null);
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
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
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
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
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
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
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
                        FlatSinglerealArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
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

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[23],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
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
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[3], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[17],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[18],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[19],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[20],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[21],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[22],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[23],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[24],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[25],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[26],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(models[27],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(models[28],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(models[29],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(models[30],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

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
                        FlatSinglerealArray1M.AssertModel(models[23],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(models[24],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(models[25],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(models[26],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
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
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[25],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        SinglerealArray1M.AssertModel(models[0],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[29], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[30], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[31], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[32], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[33], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        SinglerealArray1M.AssertModel(models[0],_testData[2], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[3], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[4], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[5], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[6], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[7], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[8], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[9], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[10], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[11], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[12], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[13], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[14], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[15], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[16], false);
                        SinglerealArray1M.AssertModel(models[15],_testData[17], false);
                        SinglerealArray1M.AssertModel(models[16],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[17],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[18],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[19],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[20],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[21],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[22],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[23],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[24],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[25],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[26],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[27],_testData[29], false);
                        SinglerealArray1M.AssertModel(models[28],_testData[30], false);
                        SinglerealArray1M.AssertModel(models[29],_testData[31], false);
                        SinglerealArray1M.AssertModel(models[30],_testData[32], false);
                        SinglerealArray1M.AssertModel(models[31],_testData[33], false);
                        SinglerealArray1M.AssertModel(models[32],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        SinglerealArray1M.AssertModel(models[0],_testData[15], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[16], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[17], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[29], false);
                        SinglerealArray1M.AssertModel(models[15],_testData[30], false);
                        SinglerealArray1M.AssertModel(models[16],_testData[31], false);
                        SinglerealArray1M.AssertModel(models[17],_testData[32], false);
                        SinglerealArray1M.AssertModel(models[18],_testData[33], false);
                        SinglerealArray1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        SinglerealArray1M.AssertModel(models[0],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[29], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[30], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[31], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[32], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[33], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
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
                await ((ISingleArrayrealArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 52, query1, 154, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[34], false);
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
                await ((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 38, query1, 59, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
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
                 ((ISingleArrayrealArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 76, query1, 99, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[34], false);
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
                 ((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 84, query1, 76, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 51, query1, 93, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

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
                        FlatSinglerealArray1M.AssertModel(models[20],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(models[21],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(models[22],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(models[23],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[34], false);
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
                await ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 112, query1, 26, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
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
                        FlatSinglerealArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[29],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 31, query1, 154, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

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
                        FlatSinglerealArray1M.AssertModel(models[24],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(models[25],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(models[26],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(models[27],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[34], false);
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
                 ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelBatch(connection, 106, query1, 49, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[25],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTSelectModelBatchAsync(connection, 126, 15))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        SinglerealArray1M.AssertModel(models[0],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[29], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[30], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[31], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[32], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[33], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        SinglerealArray1M.AssertModel(models[0],_testData[2], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[3], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[4], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[5], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[6], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[7], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[8], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[9], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[10], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[11], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[12], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[13], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[14], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[15], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[16], false);
                        SinglerealArray1M.AssertModel(models[15],_testData[17], false);
                        SinglerealArray1M.AssertModel(models[16],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[17],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[18],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[19],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[20],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[21],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[22],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[23],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[24],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[25],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[26],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[27],_testData[29], false);
                        SinglerealArray1M.AssertModel(models[28],_testData[30], false);
                        SinglerealArray1M.AssertModel(models[29],_testData[31], false);
                        SinglerealArray1M.AssertModel(models[30],_testData[32], false);
                        SinglerealArray1M.AssertModel(models[31],_testData[33], false);
                        SinglerealArray1M.AssertModel(models[32],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTSelectModelBatch(connection, 112, 123))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        SinglerealArray1M.AssertModel(models[0],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[29], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[30], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[31], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[32], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[33], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        SinglerealArray1M.AssertModel(models[0],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[29], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[30], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[31], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[32], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[33], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[34], false);
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
                ((ISingleArrayrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 123);
                var models = await ((ISingleArrayrealArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(10));

                SinglerealArray1M.AssertModel(models[0],_testData[25], false);
                SinglerealArray1M.AssertModel(models[1],_testData[26], false);
                SinglerealArray1M.AssertModel(models[2],_testData[27], false);
                SinglerealArray1M.AssertModel(models[3],_testData[28], false);
                SinglerealArray1M.AssertModel(models[4],_testData[29], false);
                SinglerealArray1M.AssertModel(models[5],_testData[30], false);
                SinglerealArray1M.AssertModel(models[6],_testData[31], false);
                SinglerealArray1M.AssertModel(models[7],_testData[32], false);
                SinglerealArray1M.AssertModel(models[8],_testData[33], false);
                SinglerealArray1M.AssertModel(models[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleArrayrealArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleArrayrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 69);
                var models =  ((ISingleArrayrealArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(20));

                SinglerealArray1M.AssertModel(models[0],_testData[15], false);
                SinglerealArray1M.AssertModel(models[1],_testData[16], false);
                SinglerealArray1M.AssertModel(models[2],_testData[17], false);
                SinglerealArray1M.AssertModel(models[3],_testData[18], false);
                SinglerealArray1M.AssertModel(models[4],_testData[19], false);
                SinglerealArray1M.AssertModel(models[5],_testData[20], false);
                SinglerealArray1M.AssertModel(models[6],_testData[21], false);
                SinglerealArray1M.AssertModel(models[7],_testData[22], false);
                SinglerealArray1M.AssertModel(models[8],_testData[23], false);
                SinglerealArray1M.AssertModel(models[9],_testData[24], false);
                SinglerealArray1M.AssertModel(models[10],_testData[25], false);
                SinglerealArray1M.AssertModel(models[11],_testData[26], false);
                SinglerealArray1M.AssertModel(models[12],_testData[27], false);
                SinglerealArray1M.AssertModel(models[13],_testData[28], false);
                SinglerealArray1M.AssertModel(models[14],_testData[29], false);
                SinglerealArray1M.AssertModel(models[15],_testData[30], false);
                SinglerealArray1M.AssertModel(models[16],_testData[31], false);
                SinglerealArray1M.AssertModel(models[17],_testData[32], false);
                SinglerealArray1M.AssertModel(models[18],_testData[33], false);
                SinglerealArray1M.AssertModel(models[19],_testData[34], false);
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
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(SinglerealArray1MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISingleArrayrealArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_singlerealarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ISingleArrayrealArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISingleArrayrealArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_singlerealarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISingleArrayrealArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_singlerealarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(SinglerealArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISingleArrayrealArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_singlerealarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ISingleArrayrealArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISingleArrayrealArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_singlerealarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISingleArrayrealArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_singlerealarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
        private void WASelectImportModelInnerConfig()
        {
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
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ISingleArrayrealArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((ISingleArrayrealArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ISingleArrayrealArray)this).WAImportModelInner(connection, importCollection);
                var models = ((ISingleArrayrealArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_singlerealarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_singlerealarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(SinglerealArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISingleArrayrealArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ISingleArrayrealArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISingleArrayrealArray)this).ImportModelInner(connection, importCollection);
                var models = ((ISingleArrayrealArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((ISingleArrayrealArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((ISingleArrayrealArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    SinglerealArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((ISingleArrayrealArray)this).ImportModel(connection, importCollection);
                var models = ((ISingleArrayrealArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    SinglerealArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MIWA), typeof(SinglerealArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
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
                var models1 = new List<SinglerealArray1MIWA>();
                var models2 = new List<SinglerealArray1MIWA>();
                await ((ISingleArrayrealArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlerealarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealArray1MIWA>();
                var models2 = new List<SinglerealArray1MIWA>();
                ((ISingleArrayrealArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlerealarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
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
                var models = await ((ISingleArrayrealArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_singlerealarray1mi
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
                    SinglerealArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleArrayrealArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_singlerealarray1mi
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
                    SinglerealArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MIWA), typeof(SinglerealArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
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
                var models1 = new List<SinglerealArray1MIWA>();
                var models2 = new List<SinglerealArray1MIWA>();
                await ((ISingleArrayrealArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlerealarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealArray1MIWA>();
                var models2 = new List<SinglerealArray1MIWA>();
                ((ISingleArrayrealArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlerealarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
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
                var models = await ((ISingleArrayrealArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_singlerealarray1mi
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
                    SinglerealArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleArrayrealArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_singlerealarray1mi
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
                    SinglerealArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_singlerealarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MI), typeof(SinglerealArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
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
                var models1 = new List<SinglerealArray1MI>();
                var models2 = new List<SinglerealArray1MI>();
                await ((ISingleArrayrealArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealArray1MI>();
                var models2 = new List<SinglerealArray1MI>();
                ((ISingleArrayrealArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlerealarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
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
                var models = await ((ISingleArrayrealArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleArrayrealArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_singlerealarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MIWA), typeof(SinglerealArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
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
                var models1 = new List<SinglerealArray1MIWA>();
                var models2 = new List<SinglerealArray1MIWA>();
                await ((ISingleArrayrealArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealArray1MIWA>();
                var models2 = new List<SinglerealArray1MIWA>();
                ((ISingleArrayrealArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlerealarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
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
                var models = await ((ISingleArrayrealArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleArrayrealArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

