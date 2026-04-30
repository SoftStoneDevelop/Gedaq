

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
    internal partial interface IGuidSingleTypeuuid
    {
    }
    
    internal partial class GuidSingleTypeuuid : IGuidSingleTypeuuid
    {


#region TestData

        private readonly Guiduuid0M[] _testData = new Guiduuid0M[]
        {
            new Guiduuid0M
{
    Id = 2,
    Value = Guid.Parse("87ac5707-f437-489c-9437-ac206bdf5d84"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 5,
    Value = Guid.Parse("14f503e2-c3af-4acd-80f3-29dec0f8d3c4"),
    ModelInner = new Guiduuid0MI
{
    Id = 8,
    Value = Guid.Parse("393f6192-5174-40c4-9a2a-c06a7d8a7c8a"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 11,
    Value = Guid.Parse("a9411d43-a1e4-4212-8af0-4ccb05bd11cd"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 15,
    Value = Guid.Parse("72dd9200-0d86-4352-9b12-e2b7a58482db"),
    ModelInner = new Guiduuid0MI
{
    Id = 12,
    Value = Guid.Parse("8c4ebede-e734-42a0-89e5-85817c671df1"),
    NullableValue = Guid.Parse("fb06d8bf-00c1-45a6-8595-ee18ef489dd7"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 24,
    Value = Guid.Parse("871ed11f-9e84-4a09-a791-580376bd6fa8"),
    ModelInner = null,
    NullableValue = Guid.Parse("b34d5341-5471-4275-a727-3e1ad9ca4fcc"),
},
            new Guiduuid0M
{
    Id = 32,
    Value = Guid.Parse("5417526f-2f66-44f9-9401-94b035475f5c"),
    ModelInner = new Guiduuid0MI
{
    Id = 20,
    Value = Guid.Parse("1fb9f711-3003-4cec-9284-e4e579590440"),
    NullableValue = Guid.Parse("70cd31ca-c79c-4ebf-bc8f-8c8f05074615"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 40,
    Value = Guid.Parse("7507ad78-a407-4a83-b13b-20270d0236d5"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 44,
    Value = Guid.Parse("42c4cfda-590b-43f5-b8ab-62d41df8fd42"),
    ModelInner = new Guiduuid0MI
{
    Id = 26,
    Value = Guid.Parse("c460297e-9f80-4788-9973-e246c9b8c69e"),
    NullableValue = Guid.Parse("e9e6b362-134a-4b27-95b3-d8dfb5cdf49e"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 49,
    Value = Guid.Parse("42ade9bc-483f-4ea7-83d0-12a1c78d9579"),
    ModelInner = null,
    NullableValue = Guid.Parse("94a70cfb-d428-4671-951d-8118fe78094f"),
},
            new Guiduuid0M
{
    Id = 51,
    Value = Guid.Parse("7bdc68e5-18a2-44a0-b1dd-f7c7566de2a8"),
    ModelInner = new Guiduuid0MI
{
    Id = 29,
    Value = Guid.Parse("0d37cc81-0290-4766-ad91-8754a246c365"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("b1667987-3a03-49b8-bb6b-54cd9c5ef28d"),
},
            new Guiduuid0M
{
    Id = 54,
    Value = Guid.Parse("cab61956-0e5f-449c-a06b-92d9d1815f82"),
    ModelInner = null,
    NullableValue = Guid.Parse("68bd3a5b-4994-4091-a0ba-92f74da19cf3"),
},
            new Guiduuid0M
{
    Id = 63,
    Value = Guid.Parse("e44b1578-162a-4015-8844-0b1f34690fcb"),
    ModelInner = new Guiduuid0MI
{
    Id = 33,
    Value = Guid.Parse("e19b52a5-e511-49c0-a3c0-5de2fc353040"),
    NullableValue = Guid.Parse("20b30226-a5e7-4141-aeba-65cfffd07465"),
},
    NullableValue = Guid.Parse("cd45ea49-35c0-47fc-b8d6-55b057a9dcad"),
},
            new Guiduuid0M
{
    Id = 71,
    Value = Guid.Parse("473bd0a4-19f0-4ea7-8129-83ebc8c383e7"),
    ModelInner = null,
    NullableValue = Guid.Parse("1027335a-f699-4b8f-8be0-f3f23f9100e4"),
},
            new Guiduuid0M
{
    Id = 79,
    Value = Guid.Parse("da331245-d6bc-4157-ae62-463b3b14da56"),
    ModelInner = new Guiduuid0MI
{
    Id = 37,
    Value = Guid.Parse("e2992478-5929-458c-b10e-e090371e6cfd"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("dd4eafde-19b8-49e0-98ae-1c62f5175f71"),
},
            new Guiduuid0M
{
    Id = 82,
    Value = Guid.Parse("cf78a428-3216-47b2-b11a-2dd777446a12"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 83,
    Value = Guid.Parse("17937980-de41-4003-abcc-a8f97b2e0bcc"),
    ModelInner = new Guiduuid0MI
{
    Id = 40,
    Value = Guid.Parse("230490aa-3e85-4966-9f07-914785b93606"),
    NullableValue = Guid.Parse("9de5c266-6002-4877-a75d-87bcb4760712"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 91,
    Value = Guid.Parse("630c94cb-fcea-4870-a678-c1e91c93d4a6"),
    ModelInner = null,
    NullableValue = Guid.Parse("1ed4b40f-6e1c-4f97-9202-5e8691da1f31"),
},
            new Guiduuid0M
{
    Id = 93,
    Value = Guid.Parse("8f2df41c-900c-490c-99a0-c6f0d3056e82"),
    ModelInner = new Guiduuid0MI
{
    Id = 41,
    Value = Guid.Parse("3cede452-266c-4ccb-829f-2bd416d0f757"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 95,
    Value = Guid.Parse("7d6a2c61-f5d4-4a1d-8bc5-6a8c56cb9893"),
    ModelInner = null,
    NullableValue = Guid.Parse("acec380f-0be8-483b-b584-7a248d0c4b58"),
},
            new Guiduuid0M
{
    Id = 97,
    Value = Guid.Parse("edef393e-f94d-4909-b662-4043e116dea8"),
    ModelInner = new Guiduuid0MI
{
    Id = 44,
    Value = Guid.Parse("b1b85ca6-745b-4398-b543-97bd1b3adfdc"),
    NullableValue = Guid.Parse("81dbc74a-fa10-4670-87de-b80c7bbf87c2"),
},
    NullableValue = Guid.Parse("0cd67b63-a35e-41d0-bb0e-6397cc06f099"),
},
            new Guiduuid0M
{
    Id = 105,
    Value = Guid.Parse("fd7fe3f2-10a9-4f1f-899c-0b9a5b8709a0"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 111,
    Value = Guid.Parse("0f686d5f-9fbb-47ff-ac83-ded64b0abd63"),
    ModelInner = new Guiduuid0MI
{
    Id = 50,
    Value = Guid.Parse("8422df62-17f1-4b05-ae13-227d248815ea"),
    NullableValue = Guid.Parse("69b4687b-bd55-42c0-883b-011696492687"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 119,
    Value = Guid.Parse("e53b8751-3f68-4740-a01a-e666794a0450"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 126,
    Value = Guid.Parse("09fde26a-0c9e-4df7-a302-3a4b9206bbeb"),
    ModelInner = new Guiduuid0MI
{
    Id = 53,
    Value = Guid.Parse("761ad231-8797-40c3-9cdb-36ae67a6ffb3"),
    NullableValue = Guid.Parse("c607547f-9653-449d-9c15-a4b7141fcbe7"),
},
    NullableValue = Guid.Parse("3771453b-33f9-46a5-a90b-f04043f1037c"),
},
            new Guiduuid0M
{
    Id = 130,
    Value = Guid.Parse("516b4b2a-414b-4769-b81f-8c07c19f20a0"),
    ModelInner = null,
    NullableValue = Guid.Parse("8ae04543-1489-4172-9ebc-c2a25a8fc677"),
},
            new Guiduuid0M
{
    Id = 139,
    Value = Guid.Parse("203440f3-df45-4860-9953-5f22931f733b"),
    ModelInner = new Guiduuid0MI
{
    Id = 61,
    Value = Guid.Parse("b00b13a9-16f3-42a8-92a2-585c54d4fccb"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("65a56f63-cf50-4d37-af8a-81812b001e1f"),
},
            new Guiduuid0M
{
    Id = 142,
    Value = Guid.Parse("2a48d2ab-85da-4555-874b-b52446db1ab2"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 144,
    Value = Guid.Parse("7c5535d8-5144-4c15-8e29-9b25d72f563f"),
    ModelInner = new Guiduuid0MI
{
    Id = 66,
    Value = Guid.Parse("c67520ee-148d-485c-9d0f-ed001b84cc32"),
    NullableValue = Guid.Parse("dd75671b-3070-426f-9be9-1cda178d8ab1"),
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 147,
    Value = Guid.Parse("c44aa55c-1065-42cb-8a5e-220f17f39c87"),
    ModelInner = null,
    NullableValue = Guid.Parse("bdfabe2f-2e9d-4b4a-b3a5-3c24be6dddcf"),
},
            new Guiduuid0M
{
    Id = 150,
    Value = Guid.Parse("dab9d9ac-bc1e-425c-b8bd-8b9e1cf98acd"),
    ModelInner = new Guiduuid0MI
{
    Id = 68,
    Value = Guid.Parse("36b26cda-dc91-4dcd-b06b-03e5fae1927d"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 155,
    Value = Guid.Parse("bb6e980c-2840-4aed-a022-010c2cf14ade"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 162,
    Value = Guid.Parse("f8288464-95ee-43e3-a4aa-81d45b92b657"),
    ModelInner = new Guiduuid0MI
{
    Id = 73,
    Value = Guid.Parse("099f446c-89b9-4964-b706-63ed977472f9"),
    NullableValue = null,
},
    NullableValue = Guid.Parse("bd95e364-e8eb-43fd-b053-d08dce620960"),
},
            new Guiduuid0M
{
    Id = 165,
    Value = Guid.Parse("a8bd72b1-c80c-4bdd-9755-2953b032c4b4"),
    ModelInner = null,
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 166,
    Value = Guid.Parse("602f2e8e-c818-4e8b-ad9e-584c29bd3c8a"),
    ModelInner = new Guiduuid0MI
{
    Id = 80,
    Value = Guid.Parse("3559fe1e-8961-4def-ab63-e061a5ea17a5"),
    NullableValue = null,
},
    NullableValue = null,
},
            new Guiduuid0M
{
    Id = 168,
    Value = Guid.Parse("68d37e3a-5081-4720-bd16-4879f8ed54e2"),
    ModelInner = null,
    NullableValue = Guid.Parse("72a334e3-a704-4897-b8da-de75ad91931f"),
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuid0mi(
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
            asPartInterface: typeof(IGuidSingleTypeuuid)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(27)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(27))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuid0mi(
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
            queryMapTypes: [typeof(Guiduuid0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(27)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(27))]
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

                changedRows =  ((IGuidSingleTypeuuid)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidSingleTypeuuid)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IGuidSingleTypeuuid)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IGuidSingleTypeuuid)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IGuidSingleTypeuuid)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IGuidSingleTypeuuid)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IGuidSingleTypeuuid)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.guiduuid0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    @id,
    @value, 
    @nullablevalue
)
",
            methodName:"DbConnectionInsertInnerModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(9)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(9), 
                nullable: true)]
        public void DbConnectionInsertInnerModelConfig()
        {
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((IGuidSingleTypeuuid)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuid0m(
	id,
    value,
    nullablevalue,
    guiduuid0mi_id
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
            asPartInterface: typeof(IGuidSingleTypeuuid)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(27)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(27)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuid0mi_id", 
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
                changedRows =  ((IGuidSingleTypeuuid)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IGuidSingleTypeuuid)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IGuidSingleTypeuuid)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IGuidSingleTypeuuid)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuid0m(
	id,
    value,
    nullablevalue,
    guiduuid0mi_id
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
    guiduuid0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Guiduuid0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
                System.Guid? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid>();
                    ((NpgsqlParameter<System.Guid>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(27);
                    ((NpgsqlParameter<System.Guid>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(27);
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

                    nullable =  ((IGuidSingleTypeuuid)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("b34d5341-5471-4275-a727-3e1ad9ca4fcc")));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid>();
                    ((NpgsqlParameter<System.Guid>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(27);
                    ((NpgsqlParameter<System.Guid>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(27);
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

                    nullable =  ((IGuidSingleTypeuuid)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                System.Guid? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid>();
                    ((NpgsqlParameter<System.Guid>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(27);
                    ((NpgsqlParameter<System.Guid>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(27);
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

                    nullable = await ((IGuidSingleTypeuuid)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid>();
                    ((NpgsqlParameter<System.Guid>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(27);
                    ((NpgsqlParameter<System.Guid>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(27);
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

                    nullable = await ((IGuidSingleTypeuuid)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuid0m(
	id,
    value,
    nullablevalue,
    guiduuid0mi_id
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
    guiduuid0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Guiduuid0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(27)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(27)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuid0mi_id", 
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
                System.Guid? nullable = null;
                nullable =  ((IGuidSingleTypeuuid)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("94a70cfb-d428-4671-951d-8118fe78094f")));
                nullable =  ((IGuidSingleTypeuuid)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("b1667987-3a03-49b8-bb6b-54cd9c5ef28d")));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Guid? nullable = null;
                nullable = await ((IGuidSingleTypeuuid)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("68bd3a5b-4994-4091-a0ba-92f74da19cf3")));
                nullable = await ((IGuidSingleTypeuuid)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(Guid.Parse("cd45ea49-35c0-47fc-b8d6-55b057a9dcad")));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Guiduuid0M> models = null;

                models =  ((IGuidSingleTypeuuid)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guiduuid0M.AssertModel(models[0],_testData[12], true);
                models =  ((IGuidSingleTypeuuid)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guiduuid0M.AssertModel(models[0],_testData[13], true);
                models =  ((IGuidSingleTypeuuid)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guiduuid0M.AssertModel(models[0],_testData[14], true);
                models =  ((IGuidSingleTypeuuid)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guiduuid0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Guiduuid0M> models = null;

                models = await ((IGuidSingleTypeuuid)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guiduuid0M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidSingleTypeuuid)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guiduuid0M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidSingleTypeuuid)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guiduuid0M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidSingleTypeuuid)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Guiduuid0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.guiduuid0m(
	id,
    value,
    nullablevalue,
    guiduuid0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @guiduuid0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Guid), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(9)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(9),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "guiduuid0mi_id", 
                methodParametrName: "guiduuid0mi_id", 
                dbType: (System.Data.DbType)(11),
                nullable: true)]
        public void DbConnectionInsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((IGuidSingleTypeuuid)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidSingleTypeuuid)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidSingleTypeuuid)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuid0M), typeof(FlatGuiduuid0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
FROM public.guiduuid0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuid0M>();
                var models2 = new List<FlatGuiduuid0M>();
                await ((IGuidSingleTypeuuid)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuid0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuid0M>();
                var models2 = new List<FlatGuiduuid0M>();
                ((IGuidSingleTypeuuid)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuid0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
FROM public.guiduuid0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidSingleTypeuuid)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuid0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidSingleTypeuuid)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuid0m m
LEFT JOIN public.guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Guiduuid0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
                var models = await ((IGuidSingleTypeuuid)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guiduuid0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IGuidSingleTypeuuid)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guiduuid0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuid0M), typeof(FlatGuiduuid0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
FROM public.guiduuid0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuid0M>();
                var models2 = new List<FlatGuiduuid0M>();
                await ((IGuidSingleTypeuuid)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuid0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuid0M>();
                var models2 = new List<FlatGuiduuid0M>();
                ((IGuidSingleTypeuuid)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuid0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
FROM public.guiduuid0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidSingleTypeuuid)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuid0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidSingleTypeuuid)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuid0m m
LEFT JOIN public.guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Guiduuid0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
                var models = await ((IGuidSingleTypeuuid)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guiduuid0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidSingleTypeuuid)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guiduuid0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuid0M), typeof(FlatGuiduuid0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuid0M>();
                var models2 = new List<FlatGuiduuid0M>();
                await((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
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
FROM public.guiduuid0m m
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuid0M>();
                var firstItems2 = new List<FlatGuiduuid0M>();
                var secondItems1 = new List<FlatGuiduuid0M>();
                var secondItems2 = new List<FlatGuiduuid0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[34], false);
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
                parametr2.Value = 162;
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
FROM public.guiduuid0m m
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuid0M>();
                var firstItems2 = new List<FlatGuiduuid0M>();
                var secondItems1 = new List<FlatGuiduuid0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[34], false);
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuid0M>();
                var models2 = new List<FlatGuiduuid0M>();
                ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 155;
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
FROM public.guiduuid0m m
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuid0M>();
                var firstItems2 = new List<FlatGuiduuid0M>();
                var secondItems1 = new List<FlatGuiduuid0M>();
                var secondItems2 = new List<FlatGuiduuid0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
FROM public.guiduuid0m m
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuid0M>();
                var firstItems2 = new List<FlatGuiduuid0M>();
                var secondItems1 = new List<FlatGuiduuid0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[26],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuid0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 162;
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
FROM public.guiduuid0m m
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[13],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[14],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[15],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[16],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(models[17],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(models[18],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(models[19],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(models[20],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 144;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuid0m m
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuid0M>();
                var secondItems1 = new List<FlatGuiduuid0M>();
                var secondItems2 = new List<FlatGuiduuid0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuid0m m
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(models[13],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(models[14],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(models[15],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(models[16],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[13],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[14],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[15],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(models[16],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(models[17],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(models[18],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(models[19],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 15;
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
FROM public.guiduuid0m m
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuid0M>();
                var secondItems1 = new List<FlatGuiduuid0M>();
                var secondItems2 = new List<FlatGuiduuid0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.guiduuid0m m
LEFT JOIN public.guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Guiduuid0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
                var models = await((IGuidSingleTypeuuid)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guiduuid0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 162;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Guiduuid0M.AssertModel(models[0],_testData[4], false);
                        Guiduuid0M.AssertModel(models[1],_testData[5], false);
                        Guiduuid0M.AssertModel(models[2],_testData[6], false);
                        Guiduuid0M.AssertModel(models[3],_testData[7], false);
                        Guiduuid0M.AssertModel(models[4],_testData[8], false);
                        Guiduuid0M.AssertModel(models[5],_testData[9], false);
                        Guiduuid0M.AssertModel(models[6],_testData[10], false);
                        Guiduuid0M.AssertModel(models[7],_testData[11], false);
                        Guiduuid0M.AssertModel(models[8],_testData[12], false);
                        Guiduuid0M.AssertModel(models[9],_testData[13], false);
                        Guiduuid0M.AssertModel(models[10],_testData[14], false);
                        Guiduuid0M.AssertModel(models[11],_testData[15], false);
                        Guiduuid0M.AssertModel(models[12],_testData[16], false);
                        Guiduuid0M.AssertModel(models[13],_testData[17], false);
                        Guiduuid0M.AssertModel(models[14],_testData[18], false);
                        Guiduuid0M.AssertModel(models[15],_testData[19], false);
                        Guiduuid0M.AssertModel(models[16],_testData[20], false);
                        Guiduuid0M.AssertModel(models[17],_testData[21], false);
                        Guiduuid0M.AssertModel(models[18],_testData[22], false);
                        Guiduuid0M.AssertModel(models[19],_testData[23], false);
                        Guiduuid0M.AssertModel(models[20],_testData[24], false);
                        Guiduuid0M.AssertModel(models[21],_testData[25], false);
                        Guiduuid0M.AssertModel(models[22],_testData[26], false);
                        Guiduuid0M.AssertModel(models[23],_testData[27], false);
                        Guiduuid0M.AssertModel(models[24],_testData[28], false);
                        Guiduuid0M.AssertModel(models[25],_testData[29], false);
                        Guiduuid0M.AssertModel(models[26],_testData[30], false);
                        Guiduuid0M.AssertModel(models[27],_testData[31], false);
                        Guiduuid0M.AssertModel(models[28],_testData[32], false);
                        Guiduuid0M.AssertModel(models[29],_testData[33], false);
                        Guiduuid0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Guiduuid0M.AssertModel(models[0],_testData[32], false);
                        Guiduuid0M.AssertModel(models[1],_testData[33], false);
                        Guiduuid0M.AssertModel(models[2],_testData[34], false);
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
                var models = ((IGuidSingleTypeuuid)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guiduuid0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Guiduuid0M.AssertModel(models[0],_testData[13], false);
                        Guiduuid0M.AssertModel(models[1],_testData[14], false);
                        Guiduuid0M.AssertModel(models[2],_testData[15], false);
                        Guiduuid0M.AssertModel(models[3],_testData[16], false);
                        Guiduuid0M.AssertModel(models[4],_testData[17], false);
                        Guiduuid0M.AssertModel(models[5],_testData[18], false);
                        Guiduuid0M.AssertModel(models[6],_testData[19], false);
                        Guiduuid0M.AssertModel(models[7],_testData[20], false);
                        Guiduuid0M.AssertModel(models[8],_testData[21], false);
                        Guiduuid0M.AssertModel(models[9],_testData[22], false);
                        Guiduuid0M.AssertModel(models[10],_testData[23], false);
                        Guiduuid0M.AssertModel(models[11],_testData[24], false);
                        Guiduuid0M.AssertModel(models[12],_testData[25], false);
                        Guiduuid0M.AssertModel(models[13],_testData[26], false);
                        Guiduuid0M.AssertModel(models[14],_testData[27], false);
                        Guiduuid0M.AssertModel(models[15],_testData[28], false);
                        Guiduuid0M.AssertModel(models[16],_testData[29], false);
                        Guiduuid0M.AssertModel(models[17],_testData[30], false);
                        Guiduuid0M.AssertModel(models[18],_testData[31], false);
                        Guiduuid0M.AssertModel(models[19],_testData[32], false);
                        Guiduuid0M.AssertModel(models[20],_testData[33], false);
                        Guiduuid0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Guiduuid0M.AssertModel(models[0],_testData[10], false);
                        Guiduuid0M.AssertModel(models[1],_testData[11], false);
                        Guiduuid0M.AssertModel(models[2],_testData[12], false);
                        Guiduuid0M.AssertModel(models[3],_testData[13], false);
                        Guiduuid0M.AssertModel(models[4],_testData[14], false);
                        Guiduuid0M.AssertModel(models[5],_testData[15], false);
                        Guiduuid0M.AssertModel(models[6],_testData[16], false);
                        Guiduuid0M.AssertModel(models[7],_testData[17], false);
                        Guiduuid0M.AssertModel(models[8],_testData[18], false);
                        Guiduuid0M.AssertModel(models[9],_testData[19], false);
                        Guiduuid0M.AssertModel(models[10],_testData[20], false);
                        Guiduuid0M.AssertModel(models[11],_testData[21], false);
                        Guiduuid0M.AssertModel(models[12],_testData[22], false);
                        Guiduuid0M.AssertModel(models[13],_testData[23], false);
                        Guiduuid0M.AssertModel(models[14],_testData[24], false);
                        Guiduuid0M.AssertModel(models[15],_testData[25], false);
                        Guiduuid0M.AssertModel(models[16],_testData[26], false);
                        Guiduuid0M.AssertModel(models[17],_testData[27], false);
                        Guiduuid0M.AssertModel(models[18],_testData[28], false);
                        Guiduuid0M.AssertModel(models[19],_testData[29], false);
                        Guiduuid0M.AssertModel(models[20],_testData[30], false);
                        Guiduuid0M.AssertModel(models[21],_testData[31], false);
                        Guiduuid0M.AssertModel(models[22],_testData[32], false);
                        Guiduuid0M.AssertModel(models[23],_testData[33], false);
                        Guiduuid0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuid0M), typeof(FlatGuiduuid0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuid0M>();
                var models2 = new List<FlatGuiduuid0M>();
                await((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuid0m m
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuid0M>();
                var firstItems2 = new List<FlatGuiduuid0M>();
                var secondItems1 = new List<FlatGuiduuid0M>();
                var secondItems2 = new List<FlatGuiduuid0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 79, query1, 91, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.guiduuid0m m
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuid0M>();
                var firstItems2 = new List<FlatGuiduuid0M>();
                var secondItems1 = new List<FlatGuiduuid0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 51, query1, 95, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[34], false);
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuid0M>();
                var models2 = new List<FlatGuiduuid0M>();
                ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuid0m m
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuid0M>();
                var firstItems2 = new List<FlatGuiduuid0M>();
                var secondItems1 = new List<FlatGuiduuid0M>();
                var secondItems2 = new List<FlatGuiduuid0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 155, query1, 54, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.guiduuid0m m
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuid0M>();
                var firstItems2 = new List<FlatGuiduuid0M>();
                var secondItems1 = new List<FlatGuiduuid0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionMMDynQuerySelectModelBatch(connection, 91, query1, 32, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[28],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuid0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuid0m m
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 93, query1, 71, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(models[13],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(models[14],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(models[15],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[13],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[14],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[15],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[16],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(models[17],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(models[18],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(models[19],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(models[20],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(models[21],_testData[34], false);
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
FROM public.guiduuid0m m
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuid0M>();
                var secondItems1 = new List<FlatGuiduuid0M>();
                var secondItems2 = new List<FlatGuiduuid0M>();
                await ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 32, query1, 130, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuid0M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuid0m m
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTDynQuerySelectModelBatch(connection, 32, query1, 144, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[6], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[7], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[8], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[9], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[10], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[11], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(models[7],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(models[8],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(models[9],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(models[10],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(models[11],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(models[12],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(models[13],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(models[14],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(models[15],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(models[16],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(models[17],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(models[18],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(models[19],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(models[20],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(models[21],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(models[22],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[23],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(models[24],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(models[25],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(models[26],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(models[27],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatGuiduuid0M.AssertModel(models[0],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(models[1],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(models[2],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(models[3],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(models[4],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(models[5],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(models[6],_testData[34], false);
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
FROM public.guiduuid0m m
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
FROM public.guiduuid0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuid0M>();
                var secondItems1 = new List<FlatGuiduuid0M>();
                var secondItems2 = new List<FlatGuiduuid0M>();
                 ((IGuidSingleTypeuuid)this).DbConnectionDynQuerySelectModelBatch(connection, 79, query1, 63, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatGuiduuid0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatGuiduuid0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatGuiduuid0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatGuiduuid0M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.guiduuid0m m
LEFT JOIN public.guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Guiduuid0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
            asPartInterface: typeof(IGuidSingleTypeuuid)),
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
                var models = await((IGuidSingleTypeuuid)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guiduuid0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelBatchAsync(connection, 44, 32))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Guiduuid0M.AssertModel(models[0],_testData[8], false);
                        Guiduuid0M.AssertModel(models[1],_testData[9], false);
                        Guiduuid0M.AssertModel(models[2],_testData[10], false);
                        Guiduuid0M.AssertModel(models[3],_testData[11], false);
                        Guiduuid0M.AssertModel(models[4],_testData[12], false);
                        Guiduuid0M.AssertModel(models[5],_testData[13], false);
                        Guiduuid0M.AssertModel(models[6],_testData[14], false);
                        Guiduuid0M.AssertModel(models[7],_testData[15], false);
                        Guiduuid0M.AssertModel(models[8],_testData[16], false);
                        Guiduuid0M.AssertModel(models[9],_testData[17], false);
                        Guiduuid0M.AssertModel(models[10],_testData[18], false);
                        Guiduuid0M.AssertModel(models[11],_testData[19], false);
                        Guiduuid0M.AssertModel(models[12],_testData[20], false);
                        Guiduuid0M.AssertModel(models[13],_testData[21], false);
                        Guiduuid0M.AssertModel(models[14],_testData[22], false);
                        Guiduuid0M.AssertModel(models[15],_testData[23], false);
                        Guiduuid0M.AssertModel(models[16],_testData[24], false);
                        Guiduuid0M.AssertModel(models[17],_testData[25], false);
                        Guiduuid0M.AssertModel(models[18],_testData[26], false);
                        Guiduuid0M.AssertModel(models[19],_testData[27], false);
                        Guiduuid0M.AssertModel(models[20],_testData[28], false);
                        Guiduuid0M.AssertModel(models[21],_testData[29], false);
                        Guiduuid0M.AssertModel(models[22],_testData[30], false);
                        Guiduuid0M.AssertModel(models[23],_testData[31], false);
                        Guiduuid0M.AssertModel(models[24],_testData[32], false);
                        Guiduuid0M.AssertModel(models[25],_testData[33], false);
                        Guiduuid0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Guiduuid0M.AssertModel(models[0],_testData[6], false);
                        Guiduuid0M.AssertModel(models[1],_testData[7], false);
                        Guiduuid0M.AssertModel(models[2],_testData[8], false);
                        Guiduuid0M.AssertModel(models[3],_testData[9], false);
                        Guiduuid0M.AssertModel(models[4],_testData[10], false);
                        Guiduuid0M.AssertModel(models[5],_testData[11], false);
                        Guiduuid0M.AssertModel(models[6],_testData[12], false);
                        Guiduuid0M.AssertModel(models[7],_testData[13], false);
                        Guiduuid0M.AssertModel(models[8],_testData[14], false);
                        Guiduuid0M.AssertModel(models[9],_testData[15], false);
                        Guiduuid0M.AssertModel(models[10],_testData[16], false);
                        Guiduuid0M.AssertModel(models[11],_testData[17], false);
                        Guiduuid0M.AssertModel(models[12],_testData[18], false);
                        Guiduuid0M.AssertModel(models[13],_testData[19], false);
                        Guiduuid0M.AssertModel(models[14],_testData[20], false);
                        Guiduuid0M.AssertModel(models[15],_testData[21], false);
                        Guiduuid0M.AssertModel(models[16],_testData[22], false);
                        Guiduuid0M.AssertModel(models[17],_testData[23], false);
                        Guiduuid0M.AssertModel(models[18],_testData[24], false);
                        Guiduuid0M.AssertModel(models[19],_testData[25], false);
                        Guiduuid0M.AssertModel(models[20],_testData[26], false);
                        Guiduuid0M.AssertModel(models[21],_testData[27], false);
                        Guiduuid0M.AssertModel(models[22],_testData[28], false);
                        Guiduuid0M.AssertModel(models[23],_testData[29], false);
                        Guiduuid0M.AssertModel(models[24],_testData[30], false);
                        Guiduuid0M.AssertModel(models[25],_testData[31], false);
                        Guiduuid0M.AssertModel(models[26],_testData[32], false);
                        Guiduuid0M.AssertModel(models[27],_testData[33], false);
                        Guiduuid0M.AssertModel(models[28],_testData[34], false);
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
                var models = ((IGuidSingleTypeuuid)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Guiduuid0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidSingleTypeuuid)this).DbConnectionSTSelectModelBatch(connection, 44, 142))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Guiduuid0M.AssertModel(models[0],_testData[8], false);
                        Guiduuid0M.AssertModel(models[1],_testData[9], false);
                        Guiduuid0M.AssertModel(models[2],_testData[10], false);
                        Guiduuid0M.AssertModel(models[3],_testData[11], false);
                        Guiduuid0M.AssertModel(models[4],_testData[12], false);
                        Guiduuid0M.AssertModel(models[5],_testData[13], false);
                        Guiduuid0M.AssertModel(models[6],_testData[14], false);
                        Guiduuid0M.AssertModel(models[7],_testData[15], false);
                        Guiduuid0M.AssertModel(models[8],_testData[16], false);
                        Guiduuid0M.AssertModel(models[9],_testData[17], false);
                        Guiduuid0M.AssertModel(models[10],_testData[18], false);
                        Guiduuid0M.AssertModel(models[11],_testData[19], false);
                        Guiduuid0M.AssertModel(models[12],_testData[20], false);
                        Guiduuid0M.AssertModel(models[13],_testData[21], false);
                        Guiduuid0M.AssertModel(models[14],_testData[22], false);
                        Guiduuid0M.AssertModel(models[15],_testData[23], false);
                        Guiduuid0M.AssertModel(models[16],_testData[24], false);
                        Guiduuid0M.AssertModel(models[17],_testData[25], false);
                        Guiduuid0M.AssertModel(models[18],_testData[26], false);
                        Guiduuid0M.AssertModel(models[19],_testData[27], false);
                        Guiduuid0M.AssertModel(models[20],_testData[28], false);
                        Guiduuid0M.AssertModel(models[21],_testData[29], false);
                        Guiduuid0M.AssertModel(models[22],_testData[30], false);
                        Guiduuid0M.AssertModel(models[23],_testData[31], false);
                        Guiduuid0M.AssertModel(models[24],_testData[32], false);
                        Guiduuid0M.AssertModel(models[25],_testData[33], false);
                        Guiduuid0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Guiduuid0M.AssertModel(models[0],_testData[27], false);
                        Guiduuid0M.AssertModel(models[1],_testData[28], false);
                        Guiduuid0M.AssertModel(models[2],_testData[29], false);
                        Guiduuid0M.AssertModel(models[3],_testData[30], false);
                        Guiduuid0M.AssertModel(models[4],_testData[31], false);
                        Guiduuid0M.AssertModel(models[5],_testData[32], false);
                        Guiduuid0M.AssertModel(models[6],_testData[33], false);
                        Guiduuid0M.AssertModel(models[7],_testData[34], false);
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
                await using var cmd = await ((IGuidSingleTypeuuid)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 49);
                var models = await ((IGuidSingleTypeuuid)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));
Guiduuid0M.AssertModel(models[0],_testData[9], false);Guiduuid0M.AssertModel(models[1],_testData[10], false);Guiduuid0M.AssertModel(models[2],_testData[11], false);Guiduuid0M.AssertModel(models[3],_testData[12], false);Guiduuid0M.AssertModel(models[4],_testData[13], false);Guiduuid0M.AssertModel(models[5],_testData[14], false);Guiduuid0M.AssertModel(models[6],_testData[15], false);Guiduuid0M.AssertModel(models[7],_testData[16], false);Guiduuid0M.AssertModel(models[8],_testData[17], false);Guiduuid0M.AssertModel(models[9],_testData[18], false);Guiduuid0M.AssertModel(models[10],_testData[19], false);Guiduuid0M.AssertModel(models[11],_testData[20], false);Guiduuid0M.AssertModel(models[12],_testData[21], false);Guiduuid0M.AssertModel(models[13],_testData[22], false);Guiduuid0M.AssertModel(models[14],_testData[23], false);Guiduuid0M.AssertModel(models[15],_testData[24], false);Guiduuid0M.AssertModel(models[16],_testData[25], false);Guiduuid0M.AssertModel(models[17],_testData[26], false);Guiduuid0M.AssertModel(models[18],_testData[27], false);Guiduuid0M.AssertModel(models[19],_testData[28], false);Guiduuid0M.AssertModel(models[20],_testData[29], false);Guiduuid0M.AssertModel(models[21],_testData[30], false);Guiduuid0M.AssertModel(models[22],_testData[31], false);Guiduuid0M.AssertModel(models[23],_testData[32], false);Guiduuid0M.AssertModel(models[24],_testData[33], false);Guiduuid0M.AssertModel(models[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidSingleTypeuuid)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidSingleTypeuuid)this).SetDbConnectionSelectModelParametrs(cmd, 32);
                var models =  ((IGuidSingleTypeuuid)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
Guiduuid0M.AssertModel(models[0],_testData[6], false);Guiduuid0M.AssertModel(models[1],_testData[7], false);Guiduuid0M.AssertModel(models[2],_testData[8], false);Guiduuid0M.AssertModel(models[3],_testData[9], false);Guiduuid0M.AssertModel(models[4],_testData[10], false);Guiduuid0M.AssertModel(models[5],_testData[11], false);Guiduuid0M.AssertModel(models[6],_testData[12], false);Guiduuid0M.AssertModel(models[7],_testData[13], false);Guiduuid0M.AssertModel(models[8],_testData[14], false);Guiduuid0M.AssertModel(models[9],_testData[15], false);Guiduuid0M.AssertModel(models[10],_testData[16], false);Guiduuid0M.AssertModel(models[11],_testData[17], false);Guiduuid0M.AssertModel(models[12],_testData[18], false);Guiduuid0M.AssertModel(models[13],_testData[19], false);Guiduuid0M.AssertModel(models[14],_testData[20], false);Guiduuid0M.AssertModel(models[15],_testData[21], false);Guiduuid0M.AssertModel(models[16],_testData[22], false);Guiduuid0M.AssertModel(models[17],_testData[23], false);Guiduuid0M.AssertModel(models[18],_testData[24], false);Guiduuid0M.AssertModel(models[19],_testData[25], false);Guiduuid0M.AssertModel(models[20],_testData[26], false);Guiduuid0M.AssertModel(models[21],_testData[27], false);Guiduuid0M.AssertModel(models[22],_testData[28], false);Guiduuid0M.AssertModel(models[23],_testData[29], false);Guiduuid0M.AssertModel(models[24],_testData[30], false);Guiduuid0M.AssertModel(models[25],_testData[31], false);Guiduuid0M.AssertModel(models[26],_testData[32], false);Guiduuid0M.AssertModel(models[27],_testData[33], false);Guiduuid0M.AssertModel(models[28],_testData[34], false);
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
FROM public.guiduuid0m m
LEFT JOIN public.guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelToObjArr",
            queryMapTypes: [typeof(object[])],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidSingleTypeuuid)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("87ac5707-f437-489c-9437-ac206bdf5d84"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("14f503e2-c3af-4acd-80f3-29dec0f8d3c4"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("393f6192-5174-40c4-9a2a-c06a7d8a7c8a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a9411d43-a1e4-4212-8af0-4ccb05bd11cd"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("72dd9200-0d86-4352-9b12-e2b7a58482db"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8c4ebede-e734-42a0-89e5-85817c671df1"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("fb06d8bf-00c1-45a6-8595-ee18ef489dd7"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("871ed11f-9e84-4a09-a791-580376bd6fa8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b34d5341-5471-4275-a727-3e1ad9ca4fcc"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5417526f-2f66-44f9-9401-94b035475f5c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1fb9f711-3003-4cec-9284-e4e579590440"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("70cd31ca-c79c-4ebf-bc8f-8c8f05074615"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7507ad78-a407-4a83-b13b-20270d0236d5"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("42c4cfda-590b-43f5-b8ab-62d41df8fd42"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c460297e-9f80-4788-9973-e246c9b8c69e"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("e9e6b362-134a-4b27-95b3-d8dfb5cdf49e"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("42ade9bc-483f-4ea7-83d0-12a1c78d9579"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("94a70cfb-d428-4671-951d-8118fe78094f"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7bdc68e5-18a2-44a0-b1dd-f7c7566de2a8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0d37cc81-0290-4766-ad91-8754a246c365"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b1667987-3a03-49b8-bb6b-54cd9c5ef28d"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cab61956-0e5f-449c-a06b-92d9d1815f82"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("68bd3a5b-4994-4091-a0ba-92f74da19cf3"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e44b1578-162a-4015-8844-0b1f34690fcb"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e19b52a5-e511-49c0-a3c0-5de2fc353040"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("20b30226-a5e7-4141-aeba-65cfffd07465"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("cd45ea49-35c0-47fc-b8d6-55b057a9dcad"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("473bd0a4-19f0-4ea7-8129-83ebc8c383e7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1027335a-f699-4b8f-8be0-f3f23f9100e4"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("da331245-d6bc-4157-ae62-463b3b14da56"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e2992478-5929-458c-b10e-e090371e6cfd"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("dd4eafde-19b8-49e0-98ae-1c62f5175f71"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cf78a428-3216-47b2-b11a-2dd777446a12"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("17937980-de41-4003-abcc-a8f97b2e0bcc"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("230490aa-3e85-4966-9f07-914785b93606"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("9de5c266-6002-4877-a75d-87bcb4760712"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("630c94cb-fcea-4870-a678-c1e91c93d4a6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1ed4b40f-6e1c-4f97-9202-5e8691da1f31"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8f2df41c-900c-490c-99a0-c6f0d3056e82"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3cede452-266c-4ccb-829f-2bd416d0f757"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7d6a2c61-f5d4-4a1d-8bc5-6a8c56cb9893"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("acec380f-0be8-483b-b584-7a248d0c4b58"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("edef393e-f94d-4909-b662-4043e116dea8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b1b85ca6-745b-4398-b543-97bd1b3adfdc"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("81dbc74a-fa10-4670-87de-b80c7bbf87c2"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0cd67b63-a35e-41d0-bb0e-6397cc06f099"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fd7fe3f2-10a9-4f1f-899c-0b9a5b8709a0"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0f686d5f-9fbb-47ff-ac83-ded64b0abd63"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8422df62-17f1-4b05-ae13-227d248815ea"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("69b4687b-bd55-42c0-883b-011696492687"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e53b8751-3f68-4740-a01a-e666794a0450"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("09fde26a-0c9e-4df7-a302-3a4b9206bbeb"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("761ad231-8797-40c3-9cdb-36ae67a6ffb3"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("c607547f-9653-449d-9c15-a4b7141fcbe7"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3771453b-33f9-46a5-a90b-f04043f1037c"))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("516b4b2a-414b-4769-b81f-8c07c19f20a0"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8ae04543-1489-4172-9ebc-c2a25a8fc677"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("203440f3-df45-4860-9953-5f22931f733b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b00b13a9-16f3-42a8-92a2-585c54d4fccb"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("65a56f63-cf50-4d37-af8a-81812b001e1f"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2a48d2ab-85da-4555-874b-b52446db1ab2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7c5535d8-5144-4c15-8e29-9b25d72f563f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c67520ee-148d-485c-9d0f-ed001b84cc32"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("dd75671b-3070-426f-9be9-1cda178d8ab1"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c44aa55c-1065-42cb-8a5e-220f17f39c87"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("bdfabe2f-2e9d-4b4a-b3a5-3c24be6dddcf"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("dab9d9ac-bc1e-425c-b8bd-8b9e1cf98acd"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("36b26cda-dc91-4dcd-b06b-03e5fae1927d"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bb6e980c-2840-4aed-a022-010c2cf14ade"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f8288464-95ee-43e3-a4aa-81d45b92b657"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("099f446c-89b9-4964-b706-63ed977472f9"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("bd95e364-e8eb-43fd-b053-d08dce620960"))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a8bd72b1-c80c-4bdd-9755-2953b032c4b4"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("602f2e8e-c818-4e8b-ad9e-584c29bd3c8a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3559fe1e-8961-4def-ab63-e061a5ea17a5"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("68d37e3a-5081-4720-bd16-4879f8ed54e2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("72a334e3-a704-4897-b8da-de75ad91931f"))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IGuidSingleTypeuuid)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("87ac5707-f437-489c-9437-ac206bdf5d84"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("14f503e2-c3af-4acd-80f3-29dec0f8d3c4"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("393f6192-5174-40c4-9a2a-c06a7d8a7c8a"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a9411d43-a1e4-4212-8af0-4ccb05bd11cd"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("72dd9200-0d86-4352-9b12-e2b7a58482db"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8c4ebede-e734-42a0-89e5-85817c671df1"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("fb06d8bf-00c1-45a6-8595-ee18ef489dd7"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("871ed11f-9e84-4a09-a791-580376bd6fa8"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b34d5341-5471-4275-a727-3e1ad9ca4fcc"))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("5417526f-2f66-44f9-9401-94b035475f5c"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("1fb9f711-3003-4cec-9284-e4e579590440"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("70cd31ca-c79c-4ebf-bc8f-8c8f05074615"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7507ad78-a407-4a83-b13b-20270d0236d5"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("42c4cfda-590b-43f5-b8ab-62d41df8fd42"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c460297e-9f80-4788-9973-e246c9b8c69e"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("e9e6b362-134a-4b27-95b3-d8dfb5cdf49e"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("42ade9bc-483f-4ea7-83d0-12a1c78d9579"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("94a70cfb-d428-4671-951d-8118fe78094f"))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7bdc68e5-18a2-44a0-b1dd-f7c7566de2a8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("0d37cc81-0290-4766-ad91-8754a246c365"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("b1667987-3a03-49b8-bb6b-54cd9c5ef28d"))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cab61956-0e5f-449c-a06b-92d9d1815f82"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("68bd3a5b-4994-4091-a0ba-92f74da19cf3"))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e44b1578-162a-4015-8844-0b1f34690fcb"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e19b52a5-e511-49c0-a3c0-5de2fc353040"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("20b30226-a5e7-4141-aeba-65cfffd07465"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("cd45ea49-35c0-47fc-b8d6-55b057a9dcad"))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("473bd0a4-19f0-4ea7-8129-83ebc8c383e7"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1027335a-f699-4b8f-8be0-f3f23f9100e4"))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("da331245-d6bc-4157-ae62-463b3b14da56"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("e2992478-5929-458c-b10e-e090371e6cfd"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("dd4eafde-19b8-49e0-98ae-1c62f5175f71"))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("cf78a428-3216-47b2-b11a-2dd777446a12"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("17937980-de41-4003-abcc-a8f97b2e0bcc"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("230490aa-3e85-4966-9f07-914785b93606"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("9de5c266-6002-4877-a75d-87bcb4760712"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("630c94cb-fcea-4870-a678-c1e91c93d4a6"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("1ed4b40f-6e1c-4f97-9202-5e8691da1f31"))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("8f2df41c-900c-490c-99a0-c6f0d3056e82"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3cede452-266c-4ccb-829f-2bd416d0f757"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7d6a2c61-f5d4-4a1d-8bc5-6a8c56cb9893"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("acec380f-0be8-483b-b584-7a248d0c4b58"))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("edef393e-f94d-4909-b662-4043e116dea8"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b1b85ca6-745b-4398-b543-97bd1b3adfdc"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("81dbc74a-fa10-4670-87de-b80c7bbf87c2"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("0cd67b63-a35e-41d0-bb0e-6397cc06f099"))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("fd7fe3f2-10a9-4f1f-899c-0b9a5b8709a0"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("0f686d5f-9fbb-47ff-ac83-ded64b0abd63"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("8422df62-17f1-4b05-ae13-227d248815ea"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("69b4687b-bd55-42c0-883b-011696492687"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("e53b8751-3f68-4740-a01a-e666794a0450"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("09fde26a-0c9e-4df7-a302-3a4b9206bbeb"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("761ad231-8797-40c3-9cdb-36ae67a6ffb3"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("c607547f-9653-449d-9c15-a4b7141fcbe7"))));//InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("3771453b-33f9-46a5-a90b-f04043f1037c"))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("516b4b2a-414b-4769-b81f-8c07c19f20a0"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("8ae04543-1489-4172-9ebc-c2a25a8fc677"))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("203440f3-df45-4860-9953-5f22931f733b"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("b00b13a9-16f3-42a8-92a2-585c54d4fccb"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("65a56f63-cf50-4d37-af8a-81812b001e1f"))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("2a48d2ab-85da-4555-874b-b52446db1ab2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("7c5535d8-5144-4c15-8e29-9b25d72f563f"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("c67520ee-148d-485c-9d0f-ed001b84cc32"))));//InnerModel.Value

                Assert.That((System.Guid?)model[4], Is.EqualTo((Guid.Parse("dd75671b-3070-426f-9be9-1cda178d8ab1"))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("c44aa55c-1065-42cb-8a5e-220f17f39c87"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("bdfabe2f-2e9d-4b4a-b3a5-3c24be6dddcf"))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("dab9d9ac-bc1e-425c-b8bd-8b9e1cf98acd"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("36b26cda-dc91-4dcd-b06b-03e5fae1927d"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("bb6e980c-2840-4aed-a022-010c2cf14ade"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("f8288464-95ee-43e3-a4aa-81d45b92b657"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("099f446c-89b9-4964-b706-63ed977472f9"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("bd95e364-e8eb-43fd-b053-d08dce620960"))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("a8bd72b1-c80c-4bdd-9755-2953b032c4b4"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("602f2e8e-c818-4e8b-ad9e-584c29bd3c8a"))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Guid)model[3], Is.EqualTo((Guid.Parse("3559fe1e-8961-4def-ab63-e061a5ea17a5"))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((System.Guid)model[1], Is.EqualTo((Guid.Parse("68d37e3a-5081-4720-bd16-4879f8ed54e2"))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Guid?)model[5], Is.EqualTo((Guid.Parse("72a334e3-a704-4897-b8da-de75ad91931f"))));

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
FROM public.binary_guiduuid0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Guiduuid0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Guiduuid0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27),
                (NpgsqlTypes.NpgsqlDbType)(27)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Guiduuid0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guiduuid0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidSingleTypeuuid)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuid0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidSingleTypeuuid)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guiduuid0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Guiduuid0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guiduuid0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidSingleTypeuuid)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuid0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidSingleTypeuuid)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guiduuid0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuid0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Guiduuid0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Guiduuid0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Guiduuid0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guiduuid0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidSingleTypeuuid)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuid0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidSingleTypeuuid)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guiduuid0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Guiduuid0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guiduuid0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidSingleTypeuuid)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuid0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidSingleTypeuuid)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guiduuid0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuid0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Guiduuid0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuid0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Guiduuid0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27),
                (NpgsqlTypes.NpgsqlDbType)(27)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Guiduuid0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidSingleTypeuuid)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidSingleTypeuuid)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guiduuid0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Guiduuid0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidSingleTypeuuid)this).WAImportModelInner(connection, importCollection);
                var models = ((IGuidSingleTypeuuid)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guiduuid0MI.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuid0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Guiduuid0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuid0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Guiduuid0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Guiduuid0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guiduuid0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidSingleTypeuuid)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidSingleTypeuuid)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guiduuid0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Guiduuid0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Guiduuid0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidSingleTypeuuid)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidSingleTypeuuid)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Guiduuid0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuid0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guiduuid0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Guiduuid0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
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
FROM public.binary_guiduuid0m m
LEFT JOIN public.binary_guiduuid0mi mi ON mi.id = m.guiduuid0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Guiduuid0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Guiduuid0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IGuidSingleTypeuuid)this).ImportModelAsync(connection, importCollection);
                var models = await ((IGuidSingleTypeuuid)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Guiduuid0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Guiduuid0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IGuidSingleTypeuuid)this).ImportModel(connection, importCollection);
                var models = ((IGuidSingleTypeuuid)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Guiduuid0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuid0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guiduuid0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Guiduuid0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IGuidSingleTypeuuid)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Guiduuid0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidSingleTypeuuid)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Guiduuid0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Guiduuid0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27),
                (NpgsqlTypes.NpgsqlDbType)(27)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidSingleTypeuuid)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guiduuid0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Guiduuid0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IGuidSingleTypeuuid)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guiduuid0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Guiduuid0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuid0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Guiduuid0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(27),
                (NpgsqlTypes.NpgsqlDbType)(27)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidSingleTypeuuid))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidSingleTypeuuid)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Guiduuid0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IGuidSingleTypeuuid)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Guiduuid0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

