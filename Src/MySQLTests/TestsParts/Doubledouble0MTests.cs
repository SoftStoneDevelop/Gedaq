

using MySqlConnector;
using System;
using Gedaq.Common.Enums;
using Gedaq.MySqlConnector.Attributes;
using Gedaq.MySqlConnector.Enums;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IDoubleSingleTypedouble
    {
    }
    
    internal partial class DoubleSingleTypedouble : IDoubleSingleTypedouble
    {


#region TestData

        private readonly Doubledouble0M[] _testData = new Doubledouble0M[]
        {
            new Doubledouble0M
{
    Id = 2,
    Value = 0.3544874258076285d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 8,
    Value = 0.1982587135930306d,
    ModelInner = new Doubledouble0MI
{
    Id = 9,
    Value = 0.9400495234513794d,
    NullableValue = null,
},
    NullableValue = 0.28361319172207144d,
},
            new Doubledouble0M
{
    Id = 13,
    Value = 0.09804795954246237d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 17,
    Value = 0.5708818008725414d,
    ModelInner = new Doubledouble0MI
{
    Id = 15,
    Value = 0.9345909480031869d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 19,
    Value = 0.4205678630280162d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 20,
    Value = 0.916463195462271d,
    ModelInner = new Doubledouble0MI
{
    Id = 24,
    Value = 0.06463989799218339d,
    NullableValue = null,
},
    NullableValue = 0.8848655596960645d,
},
            new Doubledouble0M
{
    Id = 22,
    Value = 0.4943808204031799d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 23,
    Value = 0.6743243637190535d,
    ModelInner = new Doubledouble0MI
{
    Id = 29,
    Value = 0.12373396462310715d,
    NullableValue = 0.3748276681538856d,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 29,
    Value = 0.4242949562224825d,
    ModelInner = null,
    NullableValue = 0.006757383387638427d,
},
            new Doubledouble0M
{
    Id = 31,
    Value = 0.9054391799948712d,
    ModelInner = new Doubledouble0MI
{
    Id = 31,
    Value = 0.7750644333056047d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 32,
    Value = 0.6038250335041752d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 38,
    Value = 0.45317339115428856d,
    ModelInner = new Doubledouble0MI
{
    Id = 37,
    Value = 0.32577960936345207d,
    NullableValue = 0.8243438622832158d,
},
    NullableValue = 0.15163466762267974d,
},
            new Doubledouble0M
{
    Id = 40,
    Value = 0.5260195281941791d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 48,
    Value = 0.5977447872821602d,
    ModelInner = new Doubledouble0MI
{
    Id = 46,
    Value = 0.3353580602811447d,
    NullableValue = 0.9243586721737111d,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 54,
    Value = 0.4492410297766013d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 63,
    Value = 0.695464256587126d,
    ModelInner = new Doubledouble0MI
{
    Id = 50,
    Value = 0.9528559771022974d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 72,
    Value = 0.8728473582495672d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 80,
    Value = 0.7611745359576719d,
    ModelInner = new Doubledouble0MI
{
    Id = 54,
    Value = 0.547646690829922d,
    NullableValue = null,
},
    NullableValue = 0.34826552773863195d,
},
            new Doubledouble0M
{
    Id = 81,
    Value = 0.6889217905937669d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 88,
    Value = 0.7139142334630705d,
    ModelInner = new Doubledouble0MI
{
    Id = 56,
    Value = 0.9226517075236155d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 89,
    Value = 0.653109285468703d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 98,
    Value = 0.8274562136846003d,
    ModelInner = new Doubledouble0MI
{
    Id = 58,
    Value = 0.08398282298985171d,
    NullableValue = 0.8301477630124087d,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 105,
    Value = 0.3669209888865841d,
    ModelInner = null,
    NullableValue = 0.8645491993850417d,
},
            new Doubledouble0M
{
    Id = 110,
    Value = 0.9572722434728009d,
    ModelInner = new Doubledouble0MI
{
    Id = 61,
    Value = 0.1071407945252073d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 111,
    Value = 0.3147921867507947d,
    ModelInner = null,
    NullableValue = 0.7617899134584324d,
},
            new Doubledouble0M
{
    Id = 118,
    Value = 0.008190130044687605d,
    ModelInner = new Doubledouble0MI
{
    Id = 65,
    Value = 0.6850292038626901d,
    NullableValue = null,
},
    NullableValue = 0.7154017350984744d,
},
            new Doubledouble0M
{
    Id = 120,
    Value = 0.5372410592402534d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 129,
    Value = 0.7781109172125513d,
    ModelInner = new Doubledouble0MI
{
    Id = 67,
    Value = 0.7318549751282662d,
    NullableValue = 0.8963083254820468d,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 138,
    Value = 0.3690422179693752d,
    ModelInner = null,
    NullableValue = 0.32301986089364076d,
},
            new Doubledouble0M
{
    Id = 140,
    Value = 0.8517582606601798d,
    ModelInner = new Doubledouble0MI
{
    Id = 75,
    Value = 0.4573295118052034d,
    NullableValue = null,
},
    NullableValue = 0.3615832894619444d,
},
            new Doubledouble0M
{
    Id = 144,
    Value = 0.5419590017105902d,
    ModelInner = null,
    NullableValue = 0.9518271866027944d,
},
            new Doubledouble0M
{
    Id = 150,
    Value = 0.2738199280612007d,
    ModelInner = new Doubledouble0MI
{
    Id = 81,
    Value = 0.24979246994835536d,
    NullableValue = 0.4117842968382104d,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 153,
    Value = 0.16083473835670137d,
    ModelInner = null,
    NullableValue = 0.8564759183154682d,
},
            new Doubledouble0M
{
    Id = 156,
    Value = 0.32354176789948585d,
    ModelInner = new Doubledouble0MI
{
    Id = 85,
    Value = 0.626522285706747d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 162,
    Value = 0.8895809579901764d,
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.doubledouble0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    @id, 
    @value, 
    @nullablevalue
);
",
            methodName:"InsertModelInner",
            sourceType: SourceType.MySqlConnection,
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Double),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (MySqlConnector.MySqlDbType)(5)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (MySqlConnector.MySqlDbType)(5))]
        public void InsertModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((IDoubleSingleTypedouble)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleSingleTypedouble)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleSingleTypedouble)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.doubledouble0mi(
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
            asPartInterface: typeof(IDoubleSingleTypedouble)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Double), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(8)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(8), 
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

                changedRows =  ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModel(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.doubledouble0m(
	id,
    value,
    nullablevalue,
    doubledouble0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @doubledouble0mi_id
)
",
            methodName:"InsertModel",
            sourceType: SourceType.MySqlConnection,
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Double), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (MySqlConnector.MySqlDbType)(5)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (MySqlConnector.MySqlDbType)(5),
                nullable: true),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "doubledouble0mi_id", 
                methodParametrName: "doubledouble0mi_id", 
                dbType: (MySqlConnector.MySqlDbType)(3),
                nullable: true)]
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

                changedRows =  ((IDoubleSingleTypedouble)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleSingleTypedouble)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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

                changedRows = await ((IDoubleSingleTypedouble)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.doubledouble0m(
	id,
    value,
    nullablevalue,
    doubledouble0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @doubledouble0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Double), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(8)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(8),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "doubledouble0mi_id", 
                methodParametrName: "doubledouble0mi_id", 
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

                changedRows =  ((IDoubleSingleTypedouble)this).DbConnectionInsertModel(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleSingleTypedouble)this).DbConnectionInsertModel(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
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

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble0M), typeof(FlatDoubledouble0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
Gedaq.MySqlConnector.Attributes.DynamicParametr()]
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
FROM gedaqtests.doubledouble0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble0M>();
                var models2 = new List<FlatDoubledouble0M>();
                await((IDoubleSingleTypedouble)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.doubledouble0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble0M>();
                var models2 = new List<FlatDoubledouble0M>();
                ((IDoubleSingleTypedouble)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
Gedaq.MySqlConnector.Attributes.DynamicParametr()]
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
FROM gedaqtests.doubledouble0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = await((IDoubleSingleTypedouble)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.doubledouble0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = ((IDoubleSingleTypedouble)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
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
FROM gedaqtests.doubledouble0m m
LEFT JOIN gedaqtests.doubledouble0mi mi ON mi.id = m.doubledouble0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
Gedaq.MySqlConnector.Attributes.DynamicParametr()]
        private void SelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = await((IDoubleSingleTypedouble)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = ((IDoubleSingleTypedouble)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble0M), typeof(FlatDoubledouble0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
Gedaq.MySqlConnector.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (MySqlConnector.MySqlDbType)(3))]
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
FROM gedaqtests.doubledouble0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble0M>();
                var models2 = new List<FlatDoubledouble0M>();
                await((IDoubleSingleTypedouble)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.doubledouble0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble0M>();
                var models2 = new List<FlatDoubledouble0M>();
                ((IDoubleSingleTypedouble)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
Gedaq.MySqlConnector.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (MySqlConnector.MySqlDbType)(3))]
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
FROM gedaqtests.doubledouble0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleSingleTypedouble)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.doubledouble0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleSingleTypedouble)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
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
FROM gedaqtests.doubledouble0m m
LEFT JOIN gedaqtests.doubledouble0mi mi ON mi.id = m.doubledouble0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Doubledouble0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
Gedaq.MySqlConnector.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (MySqlConnector.MySqlDbType)(3))]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await((IDoubleSingleTypedouble)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDoubleSingleTypedouble)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble0M), typeof(FlatDoubledouble0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble0M>();
                var models2 = new List<FlatDoubledouble0M>();
                await((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble0M>();
                var firstItems2 = new List<FlatDoubledouble0M>();
                var secondItems1 = new List<FlatDoubledouble0M>();
                var secondItems2 = new List<FlatDoubledouble0M>();
                await ((IDoubleSingleTypedouble)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble0M>();
                var firstItems2 = new List<FlatDoubledouble0M>();
                var secondItems1 = new List<FlatDoubledouble0M>();
                await ((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[19],_testData[34], false);
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble0M>();
                var models2 = new List<FlatDoubledouble0M>();
                ((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 153;
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble0M>();
                var firstItems2 = new List<FlatDoubledouble0M>();
                var secondItems1 = new List<FlatDoubledouble0M>();
                var secondItems2 = new List<FlatDoubledouble0M>();
                 ((IDoubleSingleTypedouble)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble0M>();
                var firstItems2 = new List<FlatDoubledouble0M>();
                var secondItems1 = new List<FlatDoubledouble0M>();
                 ((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[29],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypedouble)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(models[6],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(models[7],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(models[8],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(models[9],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble0M>();
                var secondItems1 = new List<FlatDoubledouble0M>();
                var secondItems2 = new List<FlatDoubledouble0M>();
                await ((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 38;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypedouble)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(models[6],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(models[7],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(models[8],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(models[9],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(models[10],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(models[11],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(models[12],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(models[13],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(models[14],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(models[15],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(models[16],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(models[17],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(models[18],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(models[19],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(models[20],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(models[21],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(models[22],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(models[23],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(models[24],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(models[25],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(models[26],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(models[6],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(models[7],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(models[8],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(models[9],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(models[10],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(models[11],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(models[12],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(models[13],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(models[14],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(models[15],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(models[16],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(models[17],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(models[18],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(models[19],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(models[20],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(models[21],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble0M>();
                var secondItems1 = new List<FlatDoubledouble0M>();
                var secondItems2 = new List<FlatDoubledouble0M>();
                 ((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM gedaqtests.doubledouble0m m
LEFT JOIN gedaqtests.doubledouble0mi mi ON mi.id = m.doubledouble0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
                var models = await((IDoubleSingleTypedouble)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypedouble)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        Doubledouble0M.AssertModel(models[0],_testData[3], false);
                        Doubledouble0M.AssertModel(models[1],_testData[4], false);
                        Doubledouble0M.AssertModel(models[2],_testData[5], false);
                        Doubledouble0M.AssertModel(models[3],_testData[6], false);
                        Doubledouble0M.AssertModel(models[4],_testData[7], false);
                        Doubledouble0M.AssertModel(models[5],_testData[8], false);
                        Doubledouble0M.AssertModel(models[6],_testData[9], false);
                        Doubledouble0M.AssertModel(models[7],_testData[10], false);
                        Doubledouble0M.AssertModel(models[8],_testData[11], false);
                        Doubledouble0M.AssertModel(models[9],_testData[12], false);
                        Doubledouble0M.AssertModel(models[10],_testData[13], false);
                        Doubledouble0M.AssertModel(models[11],_testData[14], false);
                        Doubledouble0M.AssertModel(models[12],_testData[15], false);
                        Doubledouble0M.AssertModel(models[13],_testData[16], false);
                        Doubledouble0M.AssertModel(models[14],_testData[17], false);
                        Doubledouble0M.AssertModel(models[15],_testData[18], false);
                        Doubledouble0M.AssertModel(models[16],_testData[19], false);
                        Doubledouble0M.AssertModel(models[17],_testData[20], false);
                        Doubledouble0M.AssertModel(models[18],_testData[21], false);
                        Doubledouble0M.AssertModel(models[19],_testData[22], false);
                        Doubledouble0M.AssertModel(models[20],_testData[23], false);
                        Doubledouble0M.AssertModel(models[21],_testData[24], false);
                        Doubledouble0M.AssertModel(models[22],_testData[25], false);
                        Doubledouble0M.AssertModel(models[23],_testData[26], false);
                        Doubledouble0M.AssertModel(models[24],_testData[27], false);
                        Doubledouble0M.AssertModel(models[25],_testData[28], false);
                        Doubledouble0M.AssertModel(models[26],_testData[29], false);
                        Doubledouble0M.AssertModel(models[27],_testData[30], false);
                        Doubledouble0M.AssertModel(models[28],_testData[31], false);
                        Doubledouble0M.AssertModel(models[29],_testData[32], false);
                        Doubledouble0M.AssertModel(models[30],_testData[33], false);
                        Doubledouble0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Doubledouble0M.AssertModel(models[0],_testData[4], false);
                        Doubledouble0M.AssertModel(models[1],_testData[5], false);
                        Doubledouble0M.AssertModel(models[2],_testData[6], false);
                        Doubledouble0M.AssertModel(models[3],_testData[7], false);
                        Doubledouble0M.AssertModel(models[4],_testData[8], false);
                        Doubledouble0M.AssertModel(models[5],_testData[9], false);
                        Doubledouble0M.AssertModel(models[6],_testData[10], false);
                        Doubledouble0M.AssertModel(models[7],_testData[11], false);
                        Doubledouble0M.AssertModel(models[8],_testData[12], false);
                        Doubledouble0M.AssertModel(models[9],_testData[13], false);
                        Doubledouble0M.AssertModel(models[10],_testData[14], false);
                        Doubledouble0M.AssertModel(models[11],_testData[15], false);
                        Doubledouble0M.AssertModel(models[12],_testData[16], false);
                        Doubledouble0M.AssertModel(models[13],_testData[17], false);
                        Doubledouble0M.AssertModel(models[14],_testData[18], false);
                        Doubledouble0M.AssertModel(models[15],_testData[19], false);
                        Doubledouble0M.AssertModel(models[16],_testData[20], false);
                        Doubledouble0M.AssertModel(models[17],_testData[21], false);
                        Doubledouble0M.AssertModel(models[18],_testData[22], false);
                        Doubledouble0M.AssertModel(models[19],_testData[23], false);
                        Doubledouble0M.AssertModel(models[20],_testData[24], false);
                        Doubledouble0M.AssertModel(models[21],_testData[25], false);
                        Doubledouble0M.AssertModel(models[22],_testData[26], false);
                        Doubledouble0M.AssertModel(models[23],_testData[27], false);
                        Doubledouble0M.AssertModel(models[24],_testData[28], false);
                        Doubledouble0M.AssertModel(models[25],_testData[29], false);
                        Doubledouble0M.AssertModel(models[26],_testData[30], false);
                        Doubledouble0M.AssertModel(models[27],_testData[31], false);
                        Doubledouble0M.AssertModel(models[28],_testData[32], false);
                        Doubledouble0M.AssertModel(models[29],_testData[33], false);
                        Doubledouble0M.AssertModel(models[30],_testData[34], false);
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
                var models = ((IDoubleSingleTypedouble)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypedouble)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Doubledouble0M.AssertModel(models[0],_testData[19], false);
                        Doubledouble0M.AssertModel(models[1],_testData[20], false);
                        Doubledouble0M.AssertModel(models[2],_testData[21], false);
                        Doubledouble0M.AssertModel(models[3],_testData[22], false);
                        Doubledouble0M.AssertModel(models[4],_testData[23], false);
                        Doubledouble0M.AssertModel(models[5],_testData[24], false);
                        Doubledouble0M.AssertModel(models[6],_testData[25], false);
                        Doubledouble0M.AssertModel(models[7],_testData[26], false);
                        Doubledouble0M.AssertModel(models[8],_testData[27], false);
                        Doubledouble0M.AssertModel(models[9],_testData[28], false);
                        Doubledouble0M.AssertModel(models[10],_testData[29], false);
                        Doubledouble0M.AssertModel(models[11],_testData[30], false);
                        Doubledouble0M.AssertModel(models[12],_testData[31], false);
                        Doubledouble0M.AssertModel(models[13],_testData[32], false);
                        Doubledouble0M.AssertModel(models[14],_testData[33], false);
                        Doubledouble0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Doubledouble0M.AssertModel(models[0],_testData[32], false);
                        Doubledouble0M.AssertModel(models[1],_testData[33], false);
                        Doubledouble0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble0M), typeof(FlatDoubledouble0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble0M>();
                var models2 = new List<FlatDoubledouble0M>();
                await((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble0M>();
                var firstItems2 = new List<FlatDoubledouble0M>();
                var secondItems1 = new List<FlatDoubledouble0M>();
                var secondItems2 = new List<FlatDoubledouble0M>();
                await ((IDoubleSingleTypedouble)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 129, query1, 111, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble0M>();
                var firstItems2 = new List<FlatDoubledouble0M>();
                var secondItems1 = new List<FlatDoubledouble0M>();
                await ((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 23, query1, 31, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[24],_testData[34], false);
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble0M>();
                var models2 = new List<FlatDoubledouble0M>();
                ((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble0M>();
                var firstItems2 = new List<FlatDoubledouble0M>();
                var secondItems1 = new List<FlatDoubledouble0M>();
                var secondItems2 = new List<FlatDoubledouble0M>();
                 ((IDoubleSingleTypedouble)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 129, query1, 22, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble0M>();
                var firstItems2 = new List<FlatDoubledouble0M>();
                var secondItems1 = new List<FlatDoubledouble0M>();
                 ((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModelBatch(connection, 110, query1, 111, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypedouble)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 150, query1, 17, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(models[6],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(models[7],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(models[8],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(models[9],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(models[10],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(models[11],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(models[12],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(models[13],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(models[14],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(models[15],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(models[16],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(models[17],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(models[18],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(models[19],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(models[20],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(models[21],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(models[22],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(models[23],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(models[24],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(models[25],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(models[26],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(models[27],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(models[28],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(models[29],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(models[30],_testData[34], false);
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble0M>();
                var secondItems1 = new List<FlatDoubledouble0M>();
                var secondItems2 = new List<FlatDoubledouble0M>();
                await ((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 129, query1, 8, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypedouble)this).DbConnectionSTDynQuerySelectModelBatch(connection, 32, query1, 153, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(models[6],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(models[7],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(models[8],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(models[9],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(models[10],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(models[11],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(models[12],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(models[13],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(models[14],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(models[15],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(models[16],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(models[17],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(models[18],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(models[19],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(models[20],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(models[21],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(models[22],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[34], false);
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble0M>();
                var secondItems1 = new List<FlatDoubledouble0M>();
                var secondItems2 = new List<FlatDoubledouble0M>();
                 ((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModelBatch(connection, 138, query1, 40, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM gedaqtests.doubledouble0m m
LEFT JOIN gedaqtests.doubledouble0mi mi ON mi.id = m.doubledouble0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Doubledouble0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
                var models = await((IDoubleSingleTypedouble)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleSingleTypedouble)this).DbConnectionSTSelectModelBatchAsync(connection, 19, 38))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        Doubledouble0M.AssertModel(models[0],_testData[5], false);
                        Doubledouble0M.AssertModel(models[1],_testData[6], false);
                        Doubledouble0M.AssertModel(models[2],_testData[7], false);
                        Doubledouble0M.AssertModel(models[3],_testData[8], false);
                        Doubledouble0M.AssertModel(models[4],_testData[9], false);
                        Doubledouble0M.AssertModel(models[5],_testData[10], false);
                        Doubledouble0M.AssertModel(models[6],_testData[11], false);
                        Doubledouble0M.AssertModel(models[7],_testData[12], false);
                        Doubledouble0M.AssertModel(models[8],_testData[13], false);
                        Doubledouble0M.AssertModel(models[9],_testData[14], false);
                        Doubledouble0M.AssertModel(models[10],_testData[15], false);
                        Doubledouble0M.AssertModel(models[11],_testData[16], false);
                        Doubledouble0M.AssertModel(models[12],_testData[17], false);
                        Doubledouble0M.AssertModel(models[13],_testData[18], false);
                        Doubledouble0M.AssertModel(models[14],_testData[19], false);
                        Doubledouble0M.AssertModel(models[15],_testData[20], false);
                        Doubledouble0M.AssertModel(models[16],_testData[21], false);
                        Doubledouble0M.AssertModel(models[17],_testData[22], false);
                        Doubledouble0M.AssertModel(models[18],_testData[23], false);
                        Doubledouble0M.AssertModel(models[19],_testData[24], false);
                        Doubledouble0M.AssertModel(models[20],_testData[25], false);
                        Doubledouble0M.AssertModel(models[21],_testData[26], false);
                        Doubledouble0M.AssertModel(models[22],_testData[27], false);
                        Doubledouble0M.AssertModel(models[23],_testData[28], false);
                        Doubledouble0M.AssertModel(models[24],_testData[29], false);
                        Doubledouble0M.AssertModel(models[25],_testData[30], false);
                        Doubledouble0M.AssertModel(models[26],_testData[31], false);
                        Doubledouble0M.AssertModel(models[27],_testData[32], false);
                        Doubledouble0M.AssertModel(models[28],_testData[33], false);
                        Doubledouble0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        Doubledouble0M.AssertModel(models[0],_testData[12], false);
                        Doubledouble0M.AssertModel(models[1],_testData[13], false);
                        Doubledouble0M.AssertModel(models[2],_testData[14], false);
                        Doubledouble0M.AssertModel(models[3],_testData[15], false);
                        Doubledouble0M.AssertModel(models[4],_testData[16], false);
                        Doubledouble0M.AssertModel(models[5],_testData[17], false);
                        Doubledouble0M.AssertModel(models[6],_testData[18], false);
                        Doubledouble0M.AssertModel(models[7],_testData[19], false);
                        Doubledouble0M.AssertModel(models[8],_testData[20], false);
                        Doubledouble0M.AssertModel(models[9],_testData[21], false);
                        Doubledouble0M.AssertModel(models[10],_testData[22], false);
                        Doubledouble0M.AssertModel(models[11],_testData[23], false);
                        Doubledouble0M.AssertModel(models[12],_testData[24], false);
                        Doubledouble0M.AssertModel(models[13],_testData[25], false);
                        Doubledouble0M.AssertModel(models[14],_testData[26], false);
                        Doubledouble0M.AssertModel(models[15],_testData[27], false);
                        Doubledouble0M.AssertModel(models[16],_testData[28], false);
                        Doubledouble0M.AssertModel(models[17],_testData[29], false);
                        Doubledouble0M.AssertModel(models[18],_testData[30], false);
                        Doubledouble0M.AssertModel(models[19],_testData[31], false);
                        Doubledouble0M.AssertModel(models[20],_testData[32], false);
                        Doubledouble0M.AssertModel(models[21],_testData[33], false);
                        Doubledouble0M.AssertModel(models[22],_testData[34], false);
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
                var models = ((IDoubleSingleTypedouble)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleSingleTypedouble)this).DbConnectionSTSelectModelBatch(connection, 2, 13))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Doubledouble0M.AssertModel(models[0],_testData[1], false);
                        Doubledouble0M.AssertModel(models[1],_testData[2], false);
                        Doubledouble0M.AssertModel(models[2],_testData[3], false);
                        Doubledouble0M.AssertModel(models[3],_testData[4], false);
                        Doubledouble0M.AssertModel(models[4],_testData[5], false);
                        Doubledouble0M.AssertModel(models[5],_testData[6], false);
                        Doubledouble0M.AssertModel(models[6],_testData[7], false);
                        Doubledouble0M.AssertModel(models[7],_testData[8], false);
                        Doubledouble0M.AssertModel(models[8],_testData[9], false);
                        Doubledouble0M.AssertModel(models[9],_testData[10], false);
                        Doubledouble0M.AssertModel(models[10],_testData[11], false);
                        Doubledouble0M.AssertModel(models[11],_testData[12], false);
                        Doubledouble0M.AssertModel(models[12],_testData[13], false);
                        Doubledouble0M.AssertModel(models[13],_testData[14], false);
                        Doubledouble0M.AssertModel(models[14],_testData[15], false);
                        Doubledouble0M.AssertModel(models[15],_testData[16], false);
                        Doubledouble0M.AssertModel(models[16],_testData[17], false);
                        Doubledouble0M.AssertModel(models[17],_testData[18], false);
                        Doubledouble0M.AssertModel(models[18],_testData[19], false);
                        Doubledouble0M.AssertModel(models[19],_testData[20], false);
                        Doubledouble0M.AssertModel(models[20],_testData[21], false);
                        Doubledouble0M.AssertModel(models[21],_testData[22], false);
                        Doubledouble0M.AssertModel(models[22],_testData[23], false);
                        Doubledouble0M.AssertModel(models[23],_testData[24], false);
                        Doubledouble0M.AssertModel(models[24],_testData[25], false);
                        Doubledouble0M.AssertModel(models[25],_testData[26], false);
                        Doubledouble0M.AssertModel(models[26],_testData[27], false);
                        Doubledouble0M.AssertModel(models[27],_testData[28], false);
                        Doubledouble0M.AssertModel(models[28],_testData[29], false);
                        Doubledouble0M.AssertModel(models[29],_testData[30], false);
                        Doubledouble0M.AssertModel(models[30],_testData[31], false);
                        Doubledouble0M.AssertModel(models[31],_testData[32], false);
                        Doubledouble0M.AssertModel(models[32],_testData[33], false);
                        Doubledouble0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        Doubledouble0M.AssertModel(models[0],_testData[3], false);
                        Doubledouble0M.AssertModel(models[1],_testData[4], false);
                        Doubledouble0M.AssertModel(models[2],_testData[5], false);
                        Doubledouble0M.AssertModel(models[3],_testData[6], false);
                        Doubledouble0M.AssertModel(models[4],_testData[7], false);
                        Doubledouble0M.AssertModel(models[5],_testData[8], false);
                        Doubledouble0M.AssertModel(models[6],_testData[9], false);
                        Doubledouble0M.AssertModel(models[7],_testData[10], false);
                        Doubledouble0M.AssertModel(models[8],_testData[11], false);
                        Doubledouble0M.AssertModel(models[9],_testData[12], false);
                        Doubledouble0M.AssertModel(models[10],_testData[13], false);
                        Doubledouble0M.AssertModel(models[11],_testData[14], false);
                        Doubledouble0M.AssertModel(models[12],_testData[15], false);
                        Doubledouble0M.AssertModel(models[13],_testData[16], false);
                        Doubledouble0M.AssertModel(models[14],_testData[17], false);
                        Doubledouble0M.AssertModel(models[15],_testData[18], false);
                        Doubledouble0M.AssertModel(models[16],_testData[19], false);
                        Doubledouble0M.AssertModel(models[17],_testData[20], false);
                        Doubledouble0M.AssertModel(models[18],_testData[21], false);
                        Doubledouble0M.AssertModel(models[19],_testData[22], false);
                        Doubledouble0M.AssertModel(models[20],_testData[23], false);
                        Doubledouble0M.AssertModel(models[21],_testData[24], false);
                        Doubledouble0M.AssertModel(models[22],_testData[25], false);
                        Doubledouble0M.AssertModel(models[23],_testData[26], false);
                        Doubledouble0M.AssertModel(models[24],_testData[27], false);
                        Doubledouble0M.AssertModel(models[25],_testData[28], false);
                        Doubledouble0M.AssertModel(models[26],_testData[29], false);
                        Doubledouble0M.AssertModel(models[27],_testData[30], false);
                        Doubledouble0M.AssertModel(models[28],_testData[31], false);
                        Doubledouble0M.AssertModel(models[29],_testData[32], false);
                        Doubledouble0M.AssertModel(models[30],_testData[33], false);
                        Doubledouble0M.AssertModel(models[31],_testData[34], false);
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
                await using var cmd = await ((IDoubleSingleTypedouble)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleSingleTypedouble)this).SetDbConnectionSelectModelParametrs(cmd, 89);
                var models = await ((IDoubleSingleTypedouble)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(14));

                Doubledouble0M.AssertModel(models[0],_testData[21], false);
                Doubledouble0M.AssertModel(models[1],_testData[22], false);
                Doubledouble0M.AssertModel(models[2],_testData[23], false);
                Doubledouble0M.AssertModel(models[3],_testData[24], false);
                Doubledouble0M.AssertModel(models[4],_testData[25], false);
                Doubledouble0M.AssertModel(models[5],_testData[26], false);
                Doubledouble0M.AssertModel(models[6],_testData[27], false);
                Doubledouble0M.AssertModel(models[7],_testData[28], false);
                Doubledouble0M.AssertModel(models[8],_testData[29], false);
                Doubledouble0M.AssertModel(models[9],_testData[30], false);
                Doubledouble0M.AssertModel(models[10],_testData[31], false);
                Doubledouble0M.AssertModel(models[11],_testData[32], false);
                Doubledouble0M.AssertModel(models[12],_testData[33], false);
                Doubledouble0M.AssertModel(models[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleSingleTypedouble)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleSingleTypedouble)this).SetDbConnectionSelectModelParametrs(cmd, 98);
                var models =  ((IDoubleSingleTypedouble)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                Doubledouble0M.AssertModel(models[0],_testData[22], false);
                Doubledouble0M.AssertModel(models[1],_testData[23], false);
                Doubledouble0M.AssertModel(models[2],_testData[24], false);
                Doubledouble0M.AssertModel(models[3],_testData[25], false);
                Doubledouble0M.AssertModel(models[4],_testData[26], false);
                Doubledouble0M.AssertModel(models[5],_testData[27], false);
                Doubledouble0M.AssertModel(models[6],_testData[28], false);
                Doubledouble0M.AssertModel(models[7],_testData[29], false);
                Doubledouble0M.AssertModel(models[8],_testData[30], false);
                Doubledouble0M.AssertModel(models[9],_testData[31], false);
                Doubledouble0M.AssertModel(models[10],_testData[32], false);
                Doubledouble0M.AssertModel(models[11],_testData[33], false);
                Doubledouble0M.AssertModel(models[12],_testData[34], false);
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
FROM gedaqtests.doubledouble0m m
LEFT JOIN gedaqtests.doubledouble0mi mi ON mi.id = m.doubledouble0mi_id
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
            asPartInterface: typeof(IDoubleSingleTypedouble))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleSingleTypedouble)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3544874258076285d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.1982587135930306d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9400495234513794d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.28361319172207144d)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.09804795954246237d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5708818008725414d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9345909480031869d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4205678630280162d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.916463195462271d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.06463989799218339d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8848655596960645d)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4943808204031799d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6743243637190535d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.12373396462310715d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.3748276681538856d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4242949562224825d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.006757383387638427d)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9054391799948712d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7750644333056047d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6038250335041752d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.45317339115428856d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.32577960936345207d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.8243438622832158d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.15163466762267974d)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5260195281941791d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5977447872821602d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3353580602811447d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.9243586721737111d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4492410297766013d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.695464256587126d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9528559771022974d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8728473582495672d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7611745359576719d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.547646690829922d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.34826552773863195d)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6889217905937669d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7139142334630705d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9226517075236155d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.653109285468703d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8274562136846003d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.08398282298985171d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.8301477630124087d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3669209888865841d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8645491993850417d)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9572722434728009d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.1071407945252073d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3147921867507947d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7617899134584324d)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.008190130044687605d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6850292038626901d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7154017350984744d)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5372410592402534d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7781109172125513d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7318549751282662d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.8963083254820468d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3690422179693752d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.32301986089364076d)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8517582606601798d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4573295118052034d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3615832894619444d)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5419590017105902d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9518271866027944d)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2738199280612007d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.24979246994835536d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.4117842968382104d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.16083473835670137d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8564759183154682d)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.32354176789948585d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.626522285706747d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8895809579901764d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDoubleSingleTypedouble)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3544874258076285d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.1982587135930306d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9400495234513794d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.28361319172207144d)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.09804795954246237d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5708818008725414d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9345909480031869d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4205678630280162d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.916463195462271d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.06463989799218339d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8848655596960645d)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4943808204031799d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6743243637190535d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.12373396462310715d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.3748276681538856d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4242949562224825d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.006757383387638427d)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9054391799948712d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7750644333056047d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6038250335041752d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.45317339115428856d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.32577960936345207d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.8243438622832158d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.15163466762267974d)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5260195281941791d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5977447872821602d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3353580602811447d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.9243586721737111d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4492410297766013d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.695464256587126d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9528559771022974d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8728473582495672d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7611745359576719d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.547646690829922d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.34826552773863195d)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6889217905937669d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7139142334630705d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9226517075236155d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.653109285468703d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8274562136846003d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.08398282298985171d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.8301477630124087d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3669209888865841d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8645491993850417d)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9572722434728009d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.1071407945252073d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3147921867507947d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7617899134584324d)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.008190130044687605d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6850292038626901d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7154017350984744d)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5372410592402534d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7781109172125513d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7318549751282662d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.8963083254820468d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3690422179693752d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.32301986089364076d)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8517582606601798d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4573295118052034d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3615832894619444d)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5419590017105902d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9518271866027944d)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2738199280612007d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.24979246994835536d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.4117842968382104d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.16083473835670137d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8564759183154682d)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.32354176789948585d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.626522285706747d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8895809579901764d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

