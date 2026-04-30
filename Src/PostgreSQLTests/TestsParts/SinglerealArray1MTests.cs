

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
    Id = 4,
    Value = 
new System.Single[4]
{
0.08188617f,
0.20659423f,
0.31072474f,
0.566215f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.45871407f,
0.98688674f,
0.88092935f,
},
},
            new SinglerealArray1M
{
    Id = 10,
    Value = 
new System.Single[4]
{
0.9831451f,
0.53825647f,
0.9922827f,
0.41153526f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 9,
    Value = 
new System.Single[3]
{
0.1662128f,
0.4537236f,
0.8590483f,
},
    NullableValue = 
new System.Single[3]
{
0.07315624f,
0.4667508f,
0.984737f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 14,
    Value = 
new System.Single[3]
{
0.032894313f,
0.2569509f,
0.5163402f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 22,
    Value = 
new System.Single[3]
{
0.7861943f,
0.96157515f,
0.4564879f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 18,
    Value = 
new System.Single[3]
{
0.99506605f,
0.16880739f,
0.35556787f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.16171491f,
0.92261916f,
0.2764973f,
0.5624724f,
},
},
            new SinglerealArray1M
{
    Id = 27,
    Value = 
new System.Single[4]
{
0.053600907f,
0.7848821f,
0.77307105f,
0.87440807f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.33872652f,
0.7881293f,
0.29989904f,
0.63986886f,
},
},
            new SinglerealArray1M
{
    Id = 28,
    Value = 
new System.Single[3]
{
0.8130296f,
0.594698f,
0.98232126f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 22,
    Value = 
new System.Single[3]
{
0.40453625f,
0.32782108f,
0.8453415f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 31,
    Value = 
new System.Single[4]
{
0.60106725f,
0.9030532f,
0.7940071f,
0.2886305f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.75761753f,
0.11680567f,
0.9573198f,
0.82590145f,
},
},
            new SinglerealArray1M
{
    Id = 40,
    Value = 
new System.Single[4]
{
0.3018871f,
0.21076405f,
0.9958146f,
0.1593973f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 30,
    Value = 
new System.Single[4]
{
0.01015383f,
0.023122072f,
0.34284925f,
0.022219837f,
},
    NullableValue = 
new System.Single[4]
{
0.84008616f,
0.6592847f,
0.20887566f,
0.17204618f,
},
},
    NullableValue = 
new System.Single[4]
{
0.093572915f,
0.091319144f,
0.98083484f,
0.3305968f,
},
},
            new SinglerealArray1M
{
    Id = 41,
    Value = 
new System.Single[4]
{
0.07238686f,
0.60786825f,
0.07944894f,
0.8683278f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.33750975f,
0.57585806f,
0.08821994f,
},
},
            new SinglerealArray1M
{
    Id = 49,
    Value = 
new System.Single[3]
{
0.96714026f,
0.90716904f,
0.66560143f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 36,
    Value = 
new System.Single[3]
{
0.93612146f,
0.65971714f,
0.306413f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 55,
    Value = 
new System.Single[4]
{
0.68294203f,
0.53639066f,
0.043284953f,
0.9363474f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 64,
    Value = 
new System.Single[4]
{
0.67201155f,
0.70239025f,
0.29966033f,
0.3471383f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 44,
    Value = 
new System.Single[4]
{
0.17376083f,
0.77970237f,
0.25067657f,
0.4655164f,
},
    NullableValue = 
new System.Single[3]
{
0.22842479f,
0.72814775f,
0.89449185f,
},
},
    NullableValue = 
new System.Single[3]
{
0.71692866f,
0.12634993f,
0.87604296f,
},
},
            new SinglerealArray1M
{
    Id = 67,
    Value = 
new System.Single[3]
{
0.21352816f,
0.59602547f,
0.26650202f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.74731195f,
0.1395182f,
0.07550871f,
},
},
            new SinglerealArray1M
{
    Id = 76,
    Value = 
new System.Single[3]
{
0.6157754f,
0.5683005f,
0.9718292f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 51,
    Value = 
new System.Single[3]
{
0.46936756f,
0.06800008f,
0.9274872f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 85,
    Value = 
new System.Single[3]
{
0.5402437f,
0.5457039f,
0.37688816f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.07088065f,
0.7975922f,
0.091902316f,
0.37644792f,
},
},
            new SinglerealArray1M
{
    Id = 90,
    Value = 
new System.Single[3]
{
0.19083351f,
0.64117765f,
0.75163513f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 59,
    Value = 
new System.Single[3]
{
0.2819296f,
0.9280184f,
0.629836f,
},
    NullableValue = 
new System.Single[4]
{
0.48320776f,
0.31431097f,
0.56193584f,
0.6028715f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 99,
    Value = 
new System.Single[4]
{
0.043577075f,
0.5377041f,
0.8917926f,
0.661324f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.7374629f,
0.8302406f,
0.3522159f,
},
},
            new SinglerealArray1M
{
    Id = 100,
    Value = 
new System.Single[3]
{
0.6760337f,
0.8351438f,
0.3706205f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 65,
    Value = 
new System.Single[3]
{
0.027879179f,
0.5140369f,
0.69597995f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 106,
    Value = 
new System.Single[3]
{
0.051118433f,
0.68770564f,
0.56315947f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.90088314f,
0.05025035f,
0.4161026f,
},
},
            new SinglerealArray1M
{
    Id = 107,
    Value = 
new System.Single[4]
{
0.091566086f,
0.6513688f,
0.17872244f,
0.02378273f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 72,
    Value = 
new System.Single[4]
{
0.55531317f,
0.21474874f,
0.31626642f,
0.31482f,
},
    NullableValue = 
new System.Single[4]
{
0.62520206f,
0.046207488f,
0.28102624f,
0.24025857f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 115,
    Value = 
new System.Single[4]
{
0.6456717f,
0.80222523f,
0.1563319f,
0.20386708f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 121,
    Value = 
new System.Single[4]
{
0.5859895f,
0.00653708f,
0.19605565f,
0.11212063f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 76,
    Value = 
new System.Single[3]
{
0.3354001f,
0.6887474f,
0.5827895f,
},
    NullableValue = 
new System.Single[4]
{
0.58169293f,
0.07460165f,
0.7021847f,
0.5130714f,
},
},
    NullableValue = 
new System.Single[3]
{
0.29197115f,
0.51902825f,
0.46900803f,
},
},
            new SinglerealArray1M
{
    Id = 127,
    Value = 
new System.Single[3]
{
0.95520425f,
0.0057680607f,
0.8680805f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 131,
    Value = 
new System.Single[4]
{
0.89359796f,
0.29664814f,
0.769137f,
0.23838347f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 77,
    Value = 
new System.Single[4]
{
0.7797098f,
0.24251974f,
0.675506f,
0.10979086f,
},
    NullableValue = 
new System.Single[3]
{
0.6742125f,
0.03490585f,
0.7155359f,
},
},
    NullableValue = 
new System.Single[4]
{
0.79860735f,
0.7108011f,
0.64037925f,
0.8463674f,
},
},
            new SinglerealArray1M
{
    Id = 140,
    Value = 
new System.Single[4]
{
0.08453286f,
0.82684654f,
0.61018455f,
0.97810805f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.16970211f,
0.06475717f,
0.122963846f,
0.26757312f,
},
},
            new SinglerealArray1M
{
    Id = 147,
    Value = 
new System.Single[3]
{
0.77954364f,
0.6790307f,
0.2770511f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 84,
    Value = 
new System.Single[4]
{
0.40777177f,
0.058705032f,
0.41326845f,
0.79509765f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 150,
    Value = 
new System.Single[3]
{
0.94939524f,
0.37029165f,
0.8991316f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 156,
    Value = 
new System.Single[4]
{
0.91950977f,
0.8627996f,
0.6240631f,
0.96793824f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 92,
    Value = 
new System.Single[3]
{
0.7831363f,
0.78582036f,
0.055218995f,
},
    NullableValue = 
new System.Single[4]
{
0.9864558f,
0.1027053f,
0.7759788f,
0.7442168f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 163,
    Value = 
new System.Single[3]
{
0.016525269f,
0.5771001f,
0.78685105f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.9447213f,
0.958356f,
0.55337167f,
0.52155507f,
},
},
            new SinglerealArray1M
{
    Id = 167,
    Value = 
new System.Single[4]
{
0.25812328f,
0.18449104f,
0.82174194f,
0.32024252f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 98,
    Value = 
new System.Single[3]
{
0.06699884f,
8.624792E-05f,
0.3773842f,
},
    NullableValue = 
new System.Single[4]
{
0.98178667f,
0.3942448f,
0.96887463f,
0.1812681f,
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
new System.Single[4]
{
0.33872652f,
0.7881293f,
0.29989904f,
0.63986886f,
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
0.75761753f,
0.11680567f,
0.9573198f,
0.82590145f,
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
new System.Single[4]
{
0.093572915f,
0.091319144f,
0.98083484f,
0.3305968f,
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
new System.Single[3]
{
0.33750975f,
0.57585806f,
0.08821994f,
}));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[3]
{
0.71692866f,
0.12634993f,
0.87604296f,
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[29], false);
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
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 100;
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
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[29], false);
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
                parametr1.Value = 49;
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 22;
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
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[17],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[18],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[19],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[20],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[21],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[22],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[23],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[24],_testData[29], false);
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
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[29], false);
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        SinglerealArray1M.AssertModel(models[0],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[29], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        SinglerealArray1M.AssertModel(models[0],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[29], false);
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
                await ((ISingleArrayrealArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 147, query1, 121, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[29], false);
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
                await ((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 55, query1, 22, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
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
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[25],_testData[29], false);
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
                 ((ISingleArrayrealArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 150, query1, 27, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[29], false);
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
                 ((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 40, query1, 22, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[25],_testData[29], false);
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
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 67, query1, 40, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[17],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[18],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[19],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[20],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[21],_testData[29], false);
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
                await ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 31, query1, 4, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 131, query1, 4, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[1], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[2], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[3], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[17],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[18],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[19],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[20],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[21],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[22],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[23],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[24],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[25],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[26],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[27],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[28],_testData[29], false);
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
                 ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelBatch(connection, 99, query1, 100, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[29], false);
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
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTSelectModelBatchAsync(connection, 90, 150))
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        SinglerealArray1M.AssertModel(models[0],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[29], false);
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
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTSelectModelBatch(connection, 55, 22))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        SinglerealArray1M.AssertModel(models[0],_testData[11], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[12], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[13], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[14], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[15], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[16], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[17], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[15],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[16],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[17],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        SinglerealArray1M.AssertModel(models[0],_testData[4], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[5], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[6], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[7], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[8], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[9], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[10], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[11], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[12], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[13], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[14], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[15], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[16], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[17], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[15],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[16],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[17],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[18],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[19],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[20],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[21],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[22],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[23],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[24],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[25],_testData[29], false);
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
                ((ISingleArrayrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 28);
                var models = await ((ISingleArrayrealArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
SinglerealArray1M.AssertModel(models[0],_testData[6], false);SinglerealArray1M.AssertModel(models[1],_testData[7], false);SinglerealArray1M.AssertModel(models[2],_testData[8], false);SinglerealArray1M.AssertModel(models[3],_testData[9], false);SinglerealArray1M.AssertModel(models[4],_testData[10], false);SinglerealArray1M.AssertModel(models[5],_testData[11], false);SinglerealArray1M.AssertModel(models[6],_testData[12], false);SinglerealArray1M.AssertModel(models[7],_testData[13], false);SinglerealArray1M.AssertModel(models[8],_testData[14], false);SinglerealArray1M.AssertModel(models[9],_testData[15], false);SinglerealArray1M.AssertModel(models[10],_testData[16], false);SinglerealArray1M.AssertModel(models[11],_testData[17], false);SinglerealArray1M.AssertModel(models[12],_testData[18], false);SinglerealArray1M.AssertModel(models[13],_testData[19], false);SinglerealArray1M.AssertModel(models[14],_testData[20], false);SinglerealArray1M.AssertModel(models[15],_testData[21], false);SinglerealArray1M.AssertModel(models[16],_testData[22], false);SinglerealArray1M.AssertModel(models[17],_testData[23], false);SinglerealArray1M.AssertModel(models[18],_testData[24], false);SinglerealArray1M.AssertModel(models[19],_testData[25], false);SinglerealArray1M.AssertModel(models[20],_testData[26], false);SinglerealArray1M.AssertModel(models[21],_testData[27], false);SinglerealArray1M.AssertModel(models[22],_testData[28], false);SinglerealArray1M.AssertModel(models[23],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleArrayrealArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleArrayrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 22);
                var models =  ((ISingleArrayrealArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(26));
SinglerealArray1M.AssertModel(models[0],_testData[4], false);SinglerealArray1M.AssertModel(models[1],_testData[5], false);SinglerealArray1M.AssertModel(models[2],_testData[6], false);SinglerealArray1M.AssertModel(models[3],_testData[7], false);SinglerealArray1M.AssertModel(models[4],_testData[8], false);SinglerealArray1M.AssertModel(models[5],_testData[9], false);SinglerealArray1M.AssertModel(models[6],_testData[10], false);SinglerealArray1M.AssertModel(models[7],_testData[11], false);SinglerealArray1M.AssertModel(models[8],_testData[12], false);SinglerealArray1M.AssertModel(models[9],_testData[13], false);SinglerealArray1M.AssertModel(models[10],_testData[14], false);SinglerealArray1M.AssertModel(models[11],_testData[15], false);SinglerealArray1M.AssertModel(models[12],_testData[16], false);SinglerealArray1M.AssertModel(models[13],_testData[17], false);SinglerealArray1M.AssertModel(models[14],_testData[18], false);SinglerealArray1M.AssertModel(models[15],_testData[19], false);SinglerealArray1M.AssertModel(models[16],_testData[20], false);SinglerealArray1M.AssertModel(models[17],_testData[21], false);SinglerealArray1M.AssertModel(models[18],_testData[22], false);SinglerealArray1M.AssertModel(models[19],_testData[23], false);SinglerealArray1M.AssertModel(models[20],_testData[24], false);SinglerealArray1M.AssertModel(models[21],_testData[25], false);SinglerealArray1M.AssertModel(models[22],_testData[26], false);SinglerealArray1M.AssertModel(models[23],_testData[27], false);SinglerealArray1M.AssertModel(models[24],_testData[28], false);SinglerealArray1M.AssertModel(models[25],_testData[29], false);
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
        public async Task DynQueryImportModelInnerAsyncTest()
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
        public  void DynQueryImportModelInnerTest()
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

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealArray1MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ISingleArrayrealArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ISingleArrayrealArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<SinglerealArray1MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ISingleArrayrealArray)this).ImportModelInner(connection, importCollection);
                var models = ((ISingleArrayrealArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
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

        [Test, Order(5)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

