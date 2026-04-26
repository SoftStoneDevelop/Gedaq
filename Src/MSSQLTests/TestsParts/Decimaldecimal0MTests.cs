

using Microsoft.Data.SqlClient;
using Gedaq.Common.Enums;
using Gedaq.SqlClient.Attributes;
using System;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IDecimalSingleTypedecimal
    {
    }
    
    internal partial class DecimalSingleTypedecimal : IDecimalSingleTypedecimal
    {


#region TestData

        private readonly Decimaldecimal0M[] _testData = new Decimaldecimal0M[]
        {
            new Decimaldecimal0M
{
    Id = 2,
    Value = 0.582052376000787m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 11,
    Value = 0.956798240060403m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 4,
    Value = 0.896320165494822m,
    NullableValue = null,
},
    NullableValue = 0.302657851712259m,
},
            new Decimaldecimal0M
{
    Id = 14,
    Value = 0.514659343995395m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 15,
    Value = 0.363328182630062m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 11,
    Value = 0.216541197938455m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 20,
    Value = 0.173341129960734m,
    ModelInner = null,
    NullableValue = 0.290084457464713m,
},
            new Decimaldecimal0M
{
    Id = 28,
    Value = 0.549808695414243m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 19,
    Value = 0.14683138214272m,
    NullableValue = 0.713249438716702m,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 34,
    Value = 0.126191155674509m,
    ModelInner = null,
    NullableValue = 0.300046787575214m,
},
            new Decimaldecimal0M
{
    Id = 43,
    Value = 0.00388744485917114m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 20,
    Value = 0.0657362620294596m,
    NullableValue = null,
},
    NullableValue = 0.218336549630865m,
},
            new Decimaldecimal0M
{
    Id = 51,
    Value = 0.343926506972841m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 56,
    Value = 0.456811398751596m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 23,
    Value = 0.0299080384127209m,
    NullableValue = null,
},
    NullableValue = 0.84866384084552m,
},
            new Decimaldecimal0M
{
    Id = 63,
    Value = 0.76835435598763m,
    ModelInner = null,
    NullableValue = 0.867748661741169m,
},
            new Decimaldecimal0M
{
    Id = 72,
    Value = 0.58084333661646m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 26,
    Value = 0.591905710691888m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 73,
    Value = 0.751623368024659m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 80,
    Value = 0.806486164526052m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 33,
    Value = 0.0651263395343264m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 81,
    Value = 0.596534946570065m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 88,
    Value = 0.387985931656052m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 34,
    Value = 0.388131085088874m,
    NullableValue = 0.978072542354056m,
},
    NullableValue = 0.0349351180766935m,
},
            new Decimaldecimal0M
{
    Id = 92,
    Value = 0.803331630534322m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 98,
    Value = 0.840965950327583m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 39,
    Value = 0.558676825402156m,
    NullableValue = 0.862963077869974m,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 100,
    Value = 0.887835467482175m,
    ModelInner = null,
    NullableValue = 0.758955646823911m,
},
            new Decimaldecimal0M
{
    Id = 102,
    Value = 0.421042688545359m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 42,
    Value = 0.90190109325517m,
    NullableValue = null,
},
    NullableValue = 0.727517519646163m,
},
            new Decimaldecimal0M
{
    Id = 104,
    Value = 0.394430895221476m,
    ModelInner = null,
    NullableValue = 0.641481272239667m,
},
            new Decimaldecimal0M
{
    Id = 107,
    Value = 0.105694798760837m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 43,
    Value = 0.0851815783134555m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 109,
    Value = 0.997485337400962m,
    ModelInner = null,
    NullableValue = 0.328901584677385m,
},
            new Decimaldecimal0M
{
    Id = 113,
    Value = 0.45200107463511m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 51,
    Value = 0.460190715759103m,
    NullableValue = 0.408661629567364m,
},
    NullableValue = 0.226349294263184m,
},
            new Decimaldecimal0M
{
    Id = 121,
    Value = 0.298637590528778m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 124,
    Value = 0.931845813644837m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 60,
    Value = 0.760727672371619m,
    NullableValue = 0.49395093857881m,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 128,
    Value = 0.748792419983744m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 137,
    Value = 0.724914840734291m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 67,
    Value = 0.568788326165106m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 145,
    Value = 0.0672857296167703m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 151,
    Value = 0.807232294531212m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 73,
    Value = 0.403568094686006m,
    NullableValue = 0.0418747452629098m,
},
    NullableValue = 0.169962155995128m,
},
        };

#endregion

#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.decimaldecimal0mi(
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
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                sqlDbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Decimal),
                parametrName: "value",
                methodParametrName: "value",
                sqlDbType: (System.Data.SqlDbType)(5)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                sqlDbType: (System.Data.SqlDbType)(5))
            ]
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

                changedRows =  ((IDecimalSingleTypedecimal)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalSingleTypedecimal)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDecimalSingleTypedecimal)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.decimaldecimal0mi(
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
            asPartInterface: typeof(IDecimalSingleTypedecimal)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Decimal), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)7),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)7, 
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

                changedRows =  ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModel(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
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

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModelAsync(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModelAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModelAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModelAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.decimaldecimal0m(
	id,
    value,
    nullablevalue,
    decimaldecimal0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @decimaldecimal0mi_id
)
",
            methodName:"InsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id",
                sqlDbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Decimal), 
                parametrName: "value", 
                methodParametrName: "value", 
                sqlDbType: (System.Data.SqlDbType)(5)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                sqlDbType: (System.Data.SqlDbType)(5),
                nullable: true),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "decimaldecimal0mi_id", 
                methodParametrName: "decimaldecimal0mi_id", 
                sqlDbType: (System.Data.SqlDbType)(8),
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

                changedRows =  ((IDecimalSingleTypedecimal)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalSingleTypedecimal)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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

                changedRows = await ((IDecimalSingleTypedecimal)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.decimaldecimal0m(
	id,
    value,
    nullablevalue,
    decimaldecimal0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @decimaldecimal0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Decimal), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)7),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)7,
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "decimaldecimal0mi_id", 
                methodParametrName: "decimaldecimal0mi_id", 
                dbType: (System.Data.DbType)11,
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

                changedRows =  ((IDecimalSingleTypedecimal)this).DbConnectionInsertModel(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalSingleTypedecimal)this).DbConnectionInsertModel(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
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

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimaldecimal0M), typeof(FlatDecimaldecimal0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
Gedaq.SqlClient.Attributes.DynamicParametr()]
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
FROM dbo.decimaldecimal0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimaldecimal0M>();
                var models2 = new List<FlatDecimaldecimal0M>();
                await((IDecimalSingleTypedecimal)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.decimaldecimal0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimaldecimal0M>();
                var models2 = new List<FlatDecimaldecimal0M>();
                ((IDecimalSingleTypedecimal)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimaldecimal0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
Gedaq.SqlClient.Attributes.DynamicParametr()]
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
FROM dbo.decimaldecimal0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = await((IDecimalSingleTypedecimal)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.decimaldecimal0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = ((IDecimalSingleTypedecimal)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
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
FROM dbo.decimaldecimal0m m
LEFT JOIN dbo.decimaldecimal0mi mi ON mi.id = m.decimaldecimal0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Decimaldecimal0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
Gedaq.SqlClient.Attributes.DynamicParametr()]
        private void SelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = await((IDecimalSingleTypedecimal)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Decimaldecimal0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = ((IDecimalSingleTypedecimal)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Decimaldecimal0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimaldecimal0M), typeof(FlatDecimaldecimal0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            sqlDbType: (System.Data.SqlDbType)(8))]
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
FROM dbo.decimaldecimal0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimaldecimal0M>();
                var models2 = new List<FlatDecimaldecimal0M>();
                await((IDecimalSingleTypedecimal)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.decimaldecimal0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimaldecimal0M>();
                var models2 = new List<FlatDecimaldecimal0M>();
                ((IDecimalSingleTypedecimal)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimaldecimal0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            sqlDbType: (System.Data.SqlDbType)(8))]
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
FROM dbo.decimaldecimal0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalSingleTypedecimal)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.decimaldecimal0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalSingleTypedecimal)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
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
FROM dbo.decimaldecimal0m m
LEFT JOIN dbo.decimaldecimal0mi mi ON mi.id = m.decimaldecimal0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Decimaldecimal0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            sqlDbType: (System.Data.SqlDbType)(8))]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await((IDecimalSingleTypedecimal)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Decimaldecimal0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDecimalSingleTypedecimal)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Decimaldecimal0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimaldecimal0M), typeof(FlatDecimaldecimal0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
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
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimaldecimal0M>();
                var models2 = new List<FlatDecimaldecimal0M>();
                await((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
FROM dbo.decimaldecimal0m m
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimal0M>();
                var firstItems2 = new List<FlatDecimaldecimal0M>();
                var secondItems1 = new List<FlatDecimaldecimal0M>();
                var secondItems2 = new List<FlatDecimaldecimal0M>();
                await ((IDecimalSingleTypedecimal)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[15],_testData[29], false);
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
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
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
FROM dbo.decimaldecimal0m m
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimal0M>();
                var firstItems2 = new List<FlatDecimaldecimal0M>();
                var secondItems1 = new List<FlatDecimaldecimal0M>();
                await ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[29], false);
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimaldecimal0M>();
                var models2 = new List<FlatDecimaldecimal0M>();
                ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
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
FROM dbo.decimaldecimal0m m
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimal0M>();
                var firstItems2 = new List<FlatDecimaldecimal0M>();
                var secondItems1 = new List<FlatDecimaldecimal0M>();
                var secondItems2 = new List<FlatDecimaldecimal0M>();
                 ((IDecimalSingleTypedecimal)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[25],_testData[29], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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
FROM dbo.decimaldecimal0m m
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimal0M>();
                var firstItems2 = new List<FlatDecimaldecimal0M>();
                var secondItems1 = new List<FlatDecimaldecimal0M>();
                 ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[22],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimaldecimal0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
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
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 80;
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
FROM dbo.decimaldecimal0m m
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(models[2],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(models[3],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(models[4],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(models[5],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(models[6],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(models[7],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(models[8],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(models[9],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(models[10],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(models[11],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(models[12],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(models[13],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(models[14],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(models[2],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(models[3],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(models[4],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(models[5],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(models[6],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(models[7],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(models[8],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(models[9],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(models[10],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(models[11],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(models[12],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(models[13],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(models[14],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(models[15],_testData[29], false);
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
                parametr1.Value = 104;
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
FROM dbo.decimaldecimal0m m
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimal0M>();
                var secondItems1 = new List<FlatDecimaldecimal0M>();
                var secondItems2 = new List<FlatDecimaldecimal0M>();
                await ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[21],_testData[29], false);
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.decimaldecimal0m m
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(models[2],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(models[3],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(models[4],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(models[5],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(models[6],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(models[7],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(models[8],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(models[9],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(models[10],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(models[11],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(models[12],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(models[13],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(models[14],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(models[15],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(models[16],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(models[17],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(models[18],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(models[19],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(models[20],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(models[21],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(models[22],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(models[23],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(models[24],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(models[25],_testData[29], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.decimaldecimal0m m
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimal0M>();
                var secondItems1 = new List<FlatDecimaldecimal0M>();
                var secondItems2 = new List<FlatDecimaldecimal0M>();
                 ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[22],_testData[29], false);
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
FROM dbo.decimaldecimal0m m
LEFT JOIN dbo.decimaldecimal0mi mi ON mi.id = m.decimaldecimal0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Decimaldecimal0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
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
                var models = await((IDecimalSingleTypedecimal)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Decimaldecimal0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Decimaldecimal0M.AssertModel(models[0],_testData[22], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[23], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[24], false);
                        Decimaldecimal0M.AssertModel(models[3],_testData[25], false);
                        Decimaldecimal0M.AssertModel(models[4],_testData[26], false);
                        Decimaldecimal0M.AssertModel(models[5],_testData[27], false);
                        Decimaldecimal0M.AssertModel(models[6],_testData[28], false);
                        Decimaldecimal0M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Decimaldecimal0M.AssertModel(models[0],_testData[19], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[20], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[21], false);
                        Decimaldecimal0M.AssertModel(models[3],_testData[22], false);
                        Decimaldecimal0M.AssertModel(models[4],_testData[23], false);
                        Decimaldecimal0M.AssertModel(models[5],_testData[24], false);
                        Decimaldecimal0M.AssertModel(models[6],_testData[25], false);
                        Decimaldecimal0M.AssertModel(models[7],_testData[26], false);
                        Decimaldecimal0M.AssertModel(models[8],_testData[27], false);
                        Decimaldecimal0M.AssertModel(models[9],_testData[28], false);
                        Decimaldecimal0M.AssertModel(models[10],_testData[29], false);
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
                var models = ((IDecimalSingleTypedecimal)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Decimaldecimal0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Decimaldecimal0M.AssertModel(models[0],_testData[17], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[18], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[19], false);
                        Decimaldecimal0M.AssertModel(models[3],_testData[20], false);
                        Decimaldecimal0M.AssertModel(models[4],_testData[21], false);
                        Decimaldecimal0M.AssertModel(models[5],_testData[22], false);
                        Decimaldecimal0M.AssertModel(models[6],_testData[23], false);
                        Decimaldecimal0M.AssertModel(models[7],_testData[24], false);
                        Decimaldecimal0M.AssertModel(models[8],_testData[25], false);
                        Decimaldecimal0M.AssertModel(models[9],_testData[26], false);
                        Decimaldecimal0M.AssertModel(models[10],_testData[27], false);
                        Decimaldecimal0M.AssertModel(models[11],_testData[28], false);
                        Decimaldecimal0M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        Decimaldecimal0M.AssertModel(models[0],_testData[7], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[8], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[9], false);
                        Decimaldecimal0M.AssertModel(models[3],_testData[10], false);
                        Decimaldecimal0M.AssertModel(models[4],_testData[11], false);
                        Decimaldecimal0M.AssertModel(models[5],_testData[12], false);
                        Decimaldecimal0M.AssertModel(models[6],_testData[13], false);
                        Decimaldecimal0M.AssertModel(models[7],_testData[14], false);
                        Decimaldecimal0M.AssertModel(models[8],_testData[15], false);
                        Decimaldecimal0M.AssertModel(models[9],_testData[16], false);
                        Decimaldecimal0M.AssertModel(models[10],_testData[17], false);
                        Decimaldecimal0M.AssertModel(models[11],_testData[18], false);
                        Decimaldecimal0M.AssertModel(models[12],_testData[19], false);
                        Decimaldecimal0M.AssertModel(models[13],_testData[20], false);
                        Decimaldecimal0M.AssertModel(models[14],_testData[21], false);
                        Decimaldecimal0M.AssertModel(models[15],_testData[22], false);
                        Decimaldecimal0M.AssertModel(models[16],_testData[23], false);
                        Decimaldecimal0M.AssertModel(models[17],_testData[24], false);
                        Decimaldecimal0M.AssertModel(models[18],_testData[25], false);
                        Decimaldecimal0M.AssertModel(models[19],_testData[26], false);
                        Decimaldecimal0M.AssertModel(models[20],_testData[27], false);
                        Decimaldecimal0M.AssertModel(models[21],_testData[28], false);
                        Decimaldecimal0M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimaldecimal0M), typeof(FlatDecimaldecimal0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)11)]
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
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
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimaldecimal0M>();
                var models2 = new List<FlatDecimaldecimal0M>();
                await((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.decimaldecimal0m m
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimal0M>();
                var firstItems2 = new List<FlatDecimaldecimal0M>();
                var secondItems1 = new List<FlatDecimaldecimal0M>();
                var secondItems2 = new List<FlatDecimaldecimal0M>();
                await ((IDecimalSingleTypedecimal)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 2, query1, 121, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[4],_testData[29], false);
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
FROM dbo.decimaldecimal0m m
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimal0M>();
                var firstItems2 = new List<FlatDecimaldecimal0M>();
                var secondItems1 = new List<FlatDecimaldecimal0M>();
                await ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 11, query1, 128, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[29], false);
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimaldecimal0M>();
                var models2 = new List<FlatDecimaldecimal0M>();
                ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.decimaldecimal0m m
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimal0M>();
                var firstItems2 = new List<FlatDecimaldecimal0M>();
                var secondItems1 = new List<FlatDecimaldecimal0M>();
                var secondItems2 = new List<FlatDecimaldecimal0M>();
                 ((IDecimalSingleTypedecimal)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 92, query1, 51, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[20],_testData[29], false);
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
FROM dbo.decimaldecimal0m m
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimal0M>();
                var firstItems2 = new List<FlatDecimaldecimal0M>();
                var secondItems1 = new List<FlatDecimaldecimal0M>();
                 ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelBatch(connection, 124, query1, 15, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[25],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimaldecimal0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)11)]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
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
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.decimaldecimal0m m
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 14, query1, 100, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[3], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(models[2],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(models[3],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(models[4],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(models[5],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(models[6],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(models[7],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(models[8],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(models[9],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(models[10],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(models[11],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(models[12],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(models[13],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(models[14],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(models[15],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(models[16],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(models[17],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(models[18],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(models[19],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(models[20],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(models[21],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(models[22],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(models[23],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(models[24],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(models[25],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(models[2],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(models[3],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(models[4],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(models[5],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(models[6],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(models[7],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(models[8],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(models[9],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(models[10],_testData[29], false);
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
FROM dbo.decimaldecimal0m m
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimal0M>();
                var secondItems1 = new List<FlatDecimaldecimal0M>();
                var secondItems2 = new List<FlatDecimaldecimal0M>();
                await ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 20, query1, 109, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[6],_testData[29], false);
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.decimaldecimal0m m
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionSTDynQuerySelectModelBatch(connection, 72, query1, 11, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(models[2],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(models[3],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(models[4],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(models[5],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(models[6],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(models[7],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(models[8],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(models[9],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(models[10],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(models[11],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(models[12],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(models[13],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(models[14],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(models[15],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(models[16],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[2], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[3], false);
                        FlatDecimaldecimal0M.AssertModel(models[2],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(models[3],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(models[4],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(models[5],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(models[6],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(models[7],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(models[8],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(models[9],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(models[10],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(models[11],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(models[12],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(models[13],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(models[14],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(models[15],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(models[16],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(models[17],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(models[18],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(models[19],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(models[20],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(models[21],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(models[22],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(models[23],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(models[24],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(models[25],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(models[26],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(models[27],_testData[29], false);
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
FROM dbo.decimaldecimal0m m
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimal0M>();
                var secondItems1 = new List<FlatDecimaldecimal0M>();
                var secondItems2 = new List<FlatDecimaldecimal0M>();
                 ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelBatch(connection, 56, query1, 15, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[25],_testData[29], false);
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
FROM dbo.decimaldecimal0m m
LEFT JOIN dbo.decimaldecimal0mi mi ON mi.id = m.decimaldecimal0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Decimaldecimal0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)11)]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
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
                var models = await((IDecimalSingleTypedecimal)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Decimaldecimal0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelBatchAsync(connection, 43, 63))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Decimaldecimal0M.AssertModel(models[0],_testData[8], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[9], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[10], false);
                        Decimaldecimal0M.AssertModel(models[3],_testData[11], false);
                        Decimaldecimal0M.AssertModel(models[4],_testData[12], false);
                        Decimaldecimal0M.AssertModel(models[5],_testData[13], false);
                        Decimaldecimal0M.AssertModel(models[6],_testData[14], false);
                        Decimaldecimal0M.AssertModel(models[7],_testData[15], false);
                        Decimaldecimal0M.AssertModel(models[8],_testData[16], false);
                        Decimaldecimal0M.AssertModel(models[9],_testData[17], false);
                        Decimaldecimal0M.AssertModel(models[10],_testData[18], false);
                        Decimaldecimal0M.AssertModel(models[11],_testData[19], false);
                        Decimaldecimal0M.AssertModel(models[12],_testData[20], false);
                        Decimaldecimal0M.AssertModel(models[13],_testData[21], false);
                        Decimaldecimal0M.AssertModel(models[14],_testData[22], false);
                        Decimaldecimal0M.AssertModel(models[15],_testData[23], false);
                        Decimaldecimal0M.AssertModel(models[16],_testData[24], false);
                        Decimaldecimal0M.AssertModel(models[17],_testData[25], false);
                        Decimaldecimal0M.AssertModel(models[18],_testData[26], false);
                        Decimaldecimal0M.AssertModel(models[19],_testData[27], false);
                        Decimaldecimal0M.AssertModel(models[20],_testData[28], false);
                        Decimaldecimal0M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Decimaldecimal0M.AssertModel(models[0],_testData[11], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[12], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[13], false);
                        Decimaldecimal0M.AssertModel(models[3],_testData[14], false);
                        Decimaldecimal0M.AssertModel(models[4],_testData[15], false);
                        Decimaldecimal0M.AssertModel(models[5],_testData[16], false);
                        Decimaldecimal0M.AssertModel(models[6],_testData[17], false);
                        Decimaldecimal0M.AssertModel(models[7],_testData[18], false);
                        Decimaldecimal0M.AssertModel(models[8],_testData[19], false);
                        Decimaldecimal0M.AssertModel(models[9],_testData[20], false);
                        Decimaldecimal0M.AssertModel(models[10],_testData[21], false);
                        Decimaldecimal0M.AssertModel(models[11],_testData[22], false);
                        Decimaldecimal0M.AssertModel(models[12],_testData[23], false);
                        Decimaldecimal0M.AssertModel(models[13],_testData[24], false);
                        Decimaldecimal0M.AssertModel(models[14],_testData[25], false);
                        Decimaldecimal0M.AssertModel(models[15],_testData[26], false);
                        Decimaldecimal0M.AssertModel(models[16],_testData[27], false);
                        Decimaldecimal0M.AssertModel(models[17],_testData[28], false);
                        Decimaldecimal0M.AssertModel(models[18],_testData[29], false);
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
                var models = ((IDecimalSingleTypedecimal)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Decimaldecimal0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelBatch(connection, 34, 102))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        Decimaldecimal0M.AssertModel(models[0],_testData[7], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[8], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[9], false);
                        Decimaldecimal0M.AssertModel(models[3],_testData[10], false);
                        Decimaldecimal0M.AssertModel(models[4],_testData[11], false);
                        Decimaldecimal0M.AssertModel(models[5],_testData[12], false);
                        Decimaldecimal0M.AssertModel(models[6],_testData[13], false);
                        Decimaldecimal0M.AssertModel(models[7],_testData[14], false);
                        Decimaldecimal0M.AssertModel(models[8],_testData[15], false);
                        Decimaldecimal0M.AssertModel(models[9],_testData[16], false);
                        Decimaldecimal0M.AssertModel(models[10],_testData[17], false);
                        Decimaldecimal0M.AssertModel(models[11],_testData[18], false);
                        Decimaldecimal0M.AssertModel(models[12],_testData[19], false);
                        Decimaldecimal0M.AssertModel(models[13],_testData[20], false);
                        Decimaldecimal0M.AssertModel(models[14],_testData[21], false);
                        Decimaldecimal0M.AssertModel(models[15],_testData[22], false);
                        Decimaldecimal0M.AssertModel(models[16],_testData[23], false);
                        Decimaldecimal0M.AssertModel(models[17],_testData[24], false);
                        Decimaldecimal0M.AssertModel(models[18],_testData[25], false);
                        Decimaldecimal0M.AssertModel(models[19],_testData[26], false);
                        Decimaldecimal0M.AssertModel(models[20],_testData[27], false);
                        Decimaldecimal0M.AssertModel(models[21],_testData[28], false);
                        Decimaldecimal0M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Decimaldecimal0M.AssertModel(models[0],_testData[20], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[21], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[22], false);
                        Decimaldecimal0M.AssertModel(models[3],_testData[23], false);
                        Decimaldecimal0M.AssertModel(models[4],_testData[24], false);
                        Decimaldecimal0M.AssertModel(models[5],_testData[25], false);
                        Decimaldecimal0M.AssertModel(models[6],_testData[26], false);
                        Decimaldecimal0M.AssertModel(models[7],_testData[27], false);
                        Decimaldecimal0M.AssertModel(models[8],_testData[28], false);
                        Decimaldecimal0M.AssertModel(models[9],_testData[29], false);
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
                await using var cmd = await ((IDecimalSingleTypedecimal)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalSingleTypedecimal)this).SetDbConnectionSelectModelParametrs(cmd, 88);
                var models = await ((IDecimalSingleTypedecimal)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(14));
Decimaldecimal0M.AssertModel(models[0],_testData[16], false);Decimaldecimal0M.AssertModel(models[1],_testData[17], false);Decimaldecimal0M.AssertModel(models[2],_testData[18], false);Decimaldecimal0M.AssertModel(models[3],_testData[19], false);Decimaldecimal0M.AssertModel(models[4],_testData[20], false);Decimaldecimal0M.AssertModel(models[5],_testData[21], false);Decimaldecimal0M.AssertModel(models[6],_testData[22], false);Decimaldecimal0M.AssertModel(models[7],_testData[23], false);Decimaldecimal0M.AssertModel(models[8],_testData[24], false);Decimaldecimal0M.AssertModel(models[9],_testData[25], false);Decimaldecimal0M.AssertModel(models[10],_testData[26], false);Decimaldecimal0M.AssertModel(models[11],_testData[27], false);Decimaldecimal0M.AssertModel(models[12],_testData[28], false);Decimaldecimal0M.AssertModel(models[13],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalSingleTypedecimal)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalSingleTypedecimal)this).SetDbConnectionSelectModelParametrs(cmd, 80);
                var models =  ((IDecimalSingleTypedecimal)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
Decimaldecimal0M.AssertModel(models[0],_testData[14], false);Decimaldecimal0M.AssertModel(models[1],_testData[15], false);Decimaldecimal0M.AssertModel(models[2],_testData[16], false);Decimaldecimal0M.AssertModel(models[3],_testData[17], false);Decimaldecimal0M.AssertModel(models[4],_testData[18], false);Decimaldecimal0M.AssertModel(models[5],_testData[19], false);Decimaldecimal0M.AssertModel(models[6],_testData[20], false);Decimaldecimal0M.AssertModel(models[7],_testData[21], false);Decimaldecimal0M.AssertModel(models[8],_testData[22], false);Decimaldecimal0M.AssertModel(models[9],_testData[23], false);Decimaldecimal0M.AssertModel(models[10],_testData[24], false);Decimaldecimal0M.AssertModel(models[11],_testData[25], false);Decimaldecimal0M.AssertModel(models[12],_testData[26], false);Decimaldecimal0M.AssertModel(models[13],_testData[27], false);Decimaldecimal0M.AssertModel(models[14],_testData[28], false);Decimaldecimal0M.AssertModel(models[15],_testData[29], false);
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
FROM dbo.decimaldecimal0m m
LEFT JOIN dbo.decimaldecimal0mi mi ON mi.id = m.decimaldecimal0mi_id
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
            asPartInterface: typeof(IDecimalSingleTypedecimal))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalSingleTypedecimal)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.582052376000787m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.956798240060403m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.896320165494822m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.302657851712259m)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.514659343995395m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.363328182630062m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.216541197938455m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.173341129960734m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.290084457464713m)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.549808695414243m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.14683138214272m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.713249438716702m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.126191155674509m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.300046787575214m)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.00388744485917114m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.0657362620294596m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.218336549630865m)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.343926506972841m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.456811398751596m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.0299080384127209m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.84866384084552m)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.76835435598763m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.867748661741169m)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.58084333661646m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.591905710691888m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.751623368024659m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.806486164526052m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.0651263395343264m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.596534946570065m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.387985931656052m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.388131085088874m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.978072542354056m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0349351180766935m)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.803331630534322m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.840965950327583m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.558676825402156m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.862963077869974m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.887835467482175m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.758955646823911m)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.421042688545359m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.90190109325517m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.727517519646163m)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.394430895221476m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.641481272239667m)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.105694798760837m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.0851815783134555m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.997485337400962m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.328901584677385m)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.45200107463511m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.460190715759103m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.408661629567364m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.226349294263184m)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.298637590528778m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.931845813644837m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.760727672371619m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.49395093857881m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.748792419983744m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.724914840734291m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.568788326165106m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0672857296167703m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.807232294531212m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.403568094686006m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.0418747452629098m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.169962155995128m)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDecimalSingleTypedecimal)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.582052376000787m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.956798240060403m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.896320165494822m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.302657851712259m)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.514659343995395m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.363328182630062m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.216541197938455m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.173341129960734m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.290084457464713m)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.549808695414243m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.14683138214272m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.713249438716702m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.126191155674509m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.300046787575214m)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.00388744485917114m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.0657362620294596m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.218336549630865m)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.343926506972841m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.456811398751596m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.0299080384127209m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.84866384084552m)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.76835435598763m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.867748661741169m)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.58084333661646m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.591905710691888m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.751623368024659m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.806486164526052m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.0651263395343264m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.596534946570065m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.387985931656052m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.388131085088874m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.978072542354056m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0349351180766935m)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.803331630534322m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.840965950327583m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.558676825402156m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.862963077869974m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.887835467482175m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.758955646823911m)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.421042688545359m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.90190109325517m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.727517519646163m)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.394430895221476m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.641481272239667m)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.105694798760837m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.0851815783134555m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.997485337400962m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.328901584677385m)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.45200107463511m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.460190715759103m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.408661629567364m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.226349294263184m)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.298637590528778m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.931845813644837m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.760727672371619m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.49395093857881m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.748792419983744m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.724914840734291m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.568788326165106m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0672857296167703m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.807232294531212m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.403568094686006m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.0418747452629098m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.169962155995128m)));

            }
        }

#endregion

    }
}

