

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
    internal partial interface IDoubleSingleTypefloat
    {
    }
    
    internal partial class DoubleSingleTypefloat : IDoubleSingleTypefloat
    {


#region TestData

        private readonly DoublefloatE0M[] _testData = new DoublefloatE0M[]
        {
            new DoublefloatE0M
{
    Id = 7,
    Value = 0.19070739905392298d,
    ModelInner = null,
    NullableValue = 0.9765925333823662d,
},
            new DoublefloatE0M
{
    Id = 14,
    Value = 0.08641511833343318d,
    ModelInner = new Doublefloat0MI
{
    Id = 9,
    Value = 0.139878100325468d,
    NullableValue = 0.7338630314108646d,
},
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 23,
    Value = 0.7718855255051417d,
    ModelInner = null,
    NullableValue = 0.42174606084272037d,
},
            new DoublefloatE0M
{
    Id = 32,
    Value = 0.9381991831065005d,
    ModelInner = new Doublefloat0MI
{
    Id = 14,
    Value = 0.5374703812167567d,
    NullableValue = null,
},
    NullableValue = 0.2227601778472429d,
},
            new DoublefloatE0M
{
    Id = 41,
    Value = 0.910969977461252d,
    ModelInner = null,
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 45,
    Value = 0.23264530362439972d,
    ModelInner = new Doublefloat0MI
{
    Id = 22,
    Value = 0.8955786902359633d,
    NullableValue = null,
},
    NullableValue = 0.45741241686455714d,
},
            new DoublefloatE0M
{
    Id = 53,
    Value = 0.9319866160142132d,
    ModelInner = null,
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 57,
    Value = 0.32448424922206d,
    ModelInner = new Doublefloat0MI
{
    Id = 27,
    Value = 0.9154802161395525d,
    NullableValue = 0.77710827315028d,
},
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 62,
    Value = 0.4351991774996651d,
    ModelInner = null,
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 68,
    Value = 0.3635945231470893d,
    ModelInner = new Doublefloat0MI
{
    Id = 31,
    Value = 0.7690826617037372d,
    NullableValue = null,
},
    NullableValue = 0.08076545060278861d,
},
            new DoublefloatE0M
{
    Id = 75,
    Value = 0.8035009441075003d,
    ModelInner = null,
    NullableValue = 0.7532355992595613d,
},
            new DoublefloatE0M
{
    Id = 81,
    Value = 0.561228345415845d,
    ModelInner = new Doublefloat0MI
{
    Id = 34,
    Value = 0.3778890273440212d,
    NullableValue = null,
},
    NullableValue = 0.8661909705466155d,
},
            new DoublefloatE0M
{
    Id = 86,
    Value = 0.2365361428952727d,
    ModelInner = null,
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 94,
    Value = 0.20554411743674506d,
    ModelInner = new Doublefloat0MI
{
    Id = 39,
    Value = 0.6745158227731973d,
    NullableValue = null,
},
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 96,
    Value = 0.6113182649709867d,
    ModelInner = null,
    NullableValue = 0.4257790456296384d,
},
            new DoublefloatE0M
{
    Id = 102,
    Value = 0.1822739264903238d,
    ModelInner = new Doublefloat0MI
{
    Id = 45,
    Value = 0.24595453524462163d,
    NullableValue = null,
},
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 106,
    Value = 0.4000791385457456d,
    ModelInner = null,
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 111,
    Value = 0.4360510729398742d,
    ModelInner = new Doublefloat0MI
{
    Id = 51,
    Value = 0.5171374206414503d,
    NullableValue = null,
},
    NullableValue = 0.5016633031559051d,
},
            new DoublefloatE0M
{
    Id = 112,
    Value = 0.7260967310279661d,
    ModelInner = null,
    NullableValue = 0.6998398303051896d,
},
            new DoublefloatE0M
{
    Id = 113,
    Value = 0.8437950020404547d,
    ModelInner = new Doublefloat0MI
{
    Id = 58,
    Value = 0.3807165416726427d,
    NullableValue = null,
},
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 114,
    Value = 0.448875754338652d,
    ModelInner = null,
    NullableValue = 0.5270206144706164d,
},
            new DoublefloatE0M
{
    Id = 120,
    Value = 0.945946496233672d,
    ModelInner = new Doublefloat0MI
{
    Id = 63,
    Value = 0.8090189377808575d,
    NullableValue = null,
},
    NullableValue = 0.33542308705109114d,
},
            new DoublefloatE0M
{
    Id = 125,
    Value = 0.7699032897225354d,
    ModelInner = null,
    NullableValue = 0.03736513237721961d,
},
            new DoublefloatE0M
{
    Id = 131,
    Value = 0.9289109601900402d,
    ModelInner = new Doublefloat0MI
{
    Id = 71,
    Value = 0.05517730442961455d,
    NullableValue = null,
},
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 138,
    Value = 0.07479692567828522d,
    ModelInner = null,
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 146,
    Value = 0.9037923930216908d,
    ModelInner = new Doublefloat0MI
{
    Id = 72,
    Value = 0.5573263706728747d,
    NullableValue = null,
},
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 155,
    Value = 0.4502364122488939d,
    ModelInner = null,
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 158,
    Value = 0.9648003583390974d,
    ModelInner = new Doublefloat0MI
{
    Id = 81,
    Value = 0.3857951264055616d,
    NullableValue = 0.14302580584156754d,
},
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 161,
    Value = 0.9876085872463869d,
    ModelInner = null,
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 166,
    Value = 0.022647446330694487d,
    ModelInner = new Doublefloat0MI
{
    Id = 89,
    Value = 0.5429592231223568d,
    NullableValue = null,
},
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 175,
    Value = 0.4154775854104533d,
    ModelInner = null,
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 184,
    Value = 0.24593439310871357d,
    ModelInner = new Doublefloat0MI
{
    Id = 94,
    Value = 0.4745492521781307d,
    NullableValue = null,
},
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 187,
    Value = 0.9574747738781296d,
    ModelInner = null,
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 190,
    Value = 0.21505460913261265d,
    ModelInner = new Doublefloat0MI
{
    Id = 98,
    Value = 0.9033137509357636d,
    NullableValue = null,
},
    NullableValue = 0.5037739114267609d,
},
            new DoublefloatE0M
{
    Id = 193,
    Value = 0.43763476617816366d,
    ModelInner = null,
    NullableValue = 0.5845750903033856d,
},
        };

#endregion

#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.doublefloat0mi(
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
            asPartInterface: typeof(IDoubleSingleTypefloat)), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Double),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (System.Data.SqlDbType)(6)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (System.Data.SqlDbType)(6))
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

                changedRows =  ((IDoubleSingleTypefloat)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleSingleTypefloat)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleSingleTypefloat)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.doublefloat0mi(
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
            asPartInterface: typeof(IDoubleSingleTypefloat)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Double), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)8),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)8, 
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

                changedRows =  ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModel(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.doublefloate0m(
	id,
    value,
    nullablevalue,
    doublefloat0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @doublefloat0mi_id
)
",
            methodName:"InsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id",
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Double), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.SqlDbType)(6)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.SqlDbType)(6),
                nullable: true),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "doublefloat0mi_id", 
                methodParametrName: "doublefloat0mi_id", 
                dbType: (System.Data.SqlDbType)(8),
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

                changedRows =  ((IDoubleSingleTypefloat)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleSingleTypefloat)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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

                changedRows = await ((IDoubleSingleTypefloat)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.doublefloate0m(
	id,
    value,
    nullablevalue,
    doublefloat0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @doublefloat0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Double), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)8),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)8,
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "doublefloat0mi_id", 
                methodParametrName: "doublefloat0mi_id", 
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

                changedRows =  ((IDoubleSingleTypefloat)this).DbConnectionInsertModel(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleSingleTypefloat)this).DbConnectionInsertModel(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
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

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoublefloatE0M), typeof(FlatDoublefloatE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)),
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
FROM dbo.doublefloate0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoublefloatE0M>();
                var models2 = new List<FlatDoublefloatE0M>();
                await((IDoubleSingleTypefloat)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloatE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoublefloatE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.doublefloate0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoublefloatE0M>();
                var models2 = new List<FlatDoublefloatE0M>();
                ((IDoubleSingleTypefloat)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloatE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoublefloatE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoublefloatE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)),
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
FROM dbo.doublefloate0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = await((IDoubleSingleTypefloat)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloatE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.doublefloate0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = ((IDoubleSingleTypefloat)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloatE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.doublefloate0m m
LEFT JOIN dbo.doublefloat0mi mi ON mi.id = m.doublefloat0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DoublefloatE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)),
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
                var models = await((IDoubleSingleTypefloat)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DoublefloatE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDoubleSingleTypefloat)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DoublefloatE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoublefloatE0M), typeof(FlatDoublefloatE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (System.Data.SqlDbType)(8))]
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
FROM dbo.doublefloate0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoublefloatE0M>();
                var models2 = new List<FlatDoublefloatE0M>();
                await((IDoubleSingleTypefloat)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloatE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoublefloatE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.doublefloate0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoublefloatE0M>();
                var models2 = new List<FlatDoublefloatE0M>();
                ((IDoubleSingleTypefloat)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloatE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoublefloatE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoublefloatE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (System.Data.SqlDbType)(8))]
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
FROM dbo.doublefloate0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleSingleTypefloat)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloatE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.doublefloate0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleSingleTypefloat)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloatE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.doublefloate0m m
LEFT JOIN dbo.doublefloat0mi mi ON mi.id = m.doublefloat0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DoublefloatE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (System.Data.SqlDbType)(8))]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await((IDoubleSingleTypefloat)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DoublefloatE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDoubleSingleTypefloat)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DoublefloatE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoublefloatE0M), typeof(FlatDoublefloatE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)),
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
            asPartInterface: typeof(IDoubleSingleTypefloat)),
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoublefloatE0M>();
                var models2 = new List<FlatDoublefloatE0M>();
                await((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloatE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoublefloatE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
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
FROM dbo.doublefloate0m m
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloatE0M>();
                var firstItems2 = new List<FlatDoublefloatE0M>();
                var secondItems1 = new List<FlatDoublefloatE0M>();
                var secondItems2 = new List<FlatDoublefloatE0M>();
                await ((IDoubleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
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
FROM dbo.doublefloate0m m
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloatE0M>();
                var firstItems2 = new List<FlatDoublefloatE0M>();
                var secondItems1 = new List<FlatDoublefloatE0M>();
                await ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[11],_testData[34], false);
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoublefloatE0M>();
                var models2 = new List<FlatDoublefloatE0M>();
                ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloatE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoublefloatE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
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
FROM dbo.doublefloate0m m
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloatE0M>();
                var firstItems2 = new List<FlatDoublefloatE0M>();
                var secondItems1 = new List<FlatDoublefloatE0M>();
                var secondItems2 = new List<FlatDoublefloatE0M>();
                 ((IDoubleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 175;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 175;
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
FROM dbo.doublefloate0m m
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloatE0M>();
                var firstItems2 = new List<FlatDoublefloatE0M>();
                var secondItems1 = new List<FlatDoublefloatE0M>();
                 ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoublefloatE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)),
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
            asPartInterface: typeof(IDoubleSingleTypefloat)),
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloatE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.doublefloate0m m
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDoublefloatE0M.AssertModel(models[0],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(models[1],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(models[2],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(models[3],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(models[4],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(models[5],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(models[6],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(models[7],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(models[8],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(models[9],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(models[10],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(models[11],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(models[12],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(models[13],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(models[14],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(models[15],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(models[16],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(models[17],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(models[18],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(models[19],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatDoublefloatE0M.AssertModel(models[0],_testData[7], false);
                        FlatDoublefloatE0M.AssertModel(models[1],_testData[8], false);
                        FlatDoublefloatE0M.AssertModel(models[2],_testData[9], false);
                        FlatDoublefloatE0M.AssertModel(models[3],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(models[4],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(models[5],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(models[6],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(models[7],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(models[8],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(models[9],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(models[10],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(models[11],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(models[12],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(models[13],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(models[14],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(models[15],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(models[16],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(models[17],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(models[18],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(models[19],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(models[20],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(models[21],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(models[22],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(models[23],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(models[24],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(models[25],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(models[26],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.doublefloate0m m
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloatE0M>();
                var secondItems1 = new List<FlatDoublefloatE0M>();
                var secondItems2 = new List<FlatDoublefloatE0M>();
                await ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloatE0M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 32;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.doublefloate0m m
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatDoublefloatE0M.AssertModel(models[0],_testData[3], false);
                        FlatDoublefloatE0M.AssertModel(models[1],_testData[4], false);
                        FlatDoublefloatE0M.AssertModel(models[2],_testData[5], false);
                        FlatDoublefloatE0M.AssertModel(models[3],_testData[6], false);
                        FlatDoublefloatE0M.AssertModel(models[4],_testData[7], false);
                        FlatDoublefloatE0M.AssertModel(models[5],_testData[8], false);
                        FlatDoublefloatE0M.AssertModel(models[6],_testData[9], false);
                        FlatDoublefloatE0M.AssertModel(models[7],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(models[8],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(models[9],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(models[10],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(models[11],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(models[12],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(models[13],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(models[14],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(models[15],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(models[16],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(models[17],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(models[18],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(models[19],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(models[20],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(models[21],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(models[22],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(models[23],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(models[24],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(models[25],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(models[26],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(models[27],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(models[28],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(models[29],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(models[30],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatDoublefloatE0M.AssertModel(models[0],_testData[4], false);
                        FlatDoublefloatE0M.AssertModel(models[1],_testData[5], false);
                        FlatDoublefloatE0M.AssertModel(models[2],_testData[6], false);
                        FlatDoublefloatE0M.AssertModel(models[3],_testData[7], false);
                        FlatDoublefloatE0M.AssertModel(models[4],_testData[8], false);
                        FlatDoublefloatE0M.AssertModel(models[5],_testData[9], false);
                        FlatDoublefloatE0M.AssertModel(models[6],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(models[7],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(models[8],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(models[9],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(models[10],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(models[11],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(models[12],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(models[13],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(models[14],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(models[15],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(models[16],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(models[17],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(models[18],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(models[19],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(models[20],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(models[21],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(models[22],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(models[23],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(models[24],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(models[25],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(models[26],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(models[27],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(models[28],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(models[29],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.doublefloate0m m
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloatE0M>();
                var secondItems1 = new List<FlatDoublefloatE0M>();
                var secondItems2 = new List<FlatDoublefloatE0M>();
                 ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM dbo.doublefloate0m m
LEFT JOIN dbo.doublefloat0mi mi ON mi.id = m.doublefloat0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DoublefloatE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)),
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
                var models = await((IDoubleSingleTypefloat)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DoublefloatE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        DoublefloatE0M.AssertModel(models[0],_testData[15], false);
                        DoublefloatE0M.AssertModel(models[1],_testData[16], false);
                        DoublefloatE0M.AssertModel(models[2],_testData[17], false);
                        DoublefloatE0M.AssertModel(models[3],_testData[18], false);
                        DoublefloatE0M.AssertModel(models[4],_testData[19], false);
                        DoublefloatE0M.AssertModel(models[5],_testData[20], false);
                        DoublefloatE0M.AssertModel(models[6],_testData[21], false);
                        DoublefloatE0M.AssertModel(models[7],_testData[22], false);
                        DoublefloatE0M.AssertModel(models[8],_testData[23], false);
                        DoublefloatE0M.AssertModel(models[9],_testData[24], false);
                        DoublefloatE0M.AssertModel(models[10],_testData[25], false);
                        DoublefloatE0M.AssertModel(models[11],_testData[26], false);
                        DoublefloatE0M.AssertModel(models[12],_testData[27], false);
                        DoublefloatE0M.AssertModel(models[13],_testData[28], false);
                        DoublefloatE0M.AssertModel(models[14],_testData[29], false);
                        DoublefloatE0M.AssertModel(models[15],_testData[30], false);
                        DoublefloatE0M.AssertModel(models[16],_testData[31], false);
                        DoublefloatE0M.AssertModel(models[17],_testData[32], false);
                        DoublefloatE0M.AssertModel(models[18],_testData[33], false);
                        DoublefloatE0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        DoublefloatE0M.AssertModel(models[0],_testData[25], false);
                        DoublefloatE0M.AssertModel(models[1],_testData[26], false);
                        DoublefloatE0M.AssertModel(models[2],_testData[27], false);
                        DoublefloatE0M.AssertModel(models[3],_testData[28], false);
                        DoublefloatE0M.AssertModel(models[4],_testData[29], false);
                        DoublefloatE0M.AssertModel(models[5],_testData[30], false);
                        DoublefloatE0M.AssertModel(models[6],_testData[31], false);
                        DoublefloatE0M.AssertModel(models[7],_testData[32], false);
                        DoublefloatE0M.AssertModel(models[8],_testData[33], false);
                        DoublefloatE0M.AssertModel(models[9],_testData[34], false);
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
                var models = ((IDoubleSingleTypefloat)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DoublefloatE0M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 112;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        DoublefloatE0M.AssertModel(models[0],_testData[12], false);
                        DoublefloatE0M.AssertModel(models[1],_testData[13], false);
                        DoublefloatE0M.AssertModel(models[2],_testData[14], false);
                        DoublefloatE0M.AssertModel(models[3],_testData[15], false);
                        DoublefloatE0M.AssertModel(models[4],_testData[16], false);
                        DoublefloatE0M.AssertModel(models[5],_testData[17], false);
                        DoublefloatE0M.AssertModel(models[6],_testData[18], false);
                        DoublefloatE0M.AssertModel(models[7],_testData[19], false);
                        DoublefloatE0M.AssertModel(models[8],_testData[20], false);
                        DoublefloatE0M.AssertModel(models[9],_testData[21], false);
                        DoublefloatE0M.AssertModel(models[10],_testData[22], false);
                        DoublefloatE0M.AssertModel(models[11],_testData[23], false);
                        DoublefloatE0M.AssertModel(models[12],_testData[24], false);
                        DoublefloatE0M.AssertModel(models[13],_testData[25], false);
                        DoublefloatE0M.AssertModel(models[14],_testData[26], false);
                        DoublefloatE0M.AssertModel(models[15],_testData[27], false);
                        DoublefloatE0M.AssertModel(models[16],_testData[28], false);
                        DoublefloatE0M.AssertModel(models[17],_testData[29], false);
                        DoublefloatE0M.AssertModel(models[18],_testData[30], false);
                        DoublefloatE0M.AssertModel(models[19],_testData[31], false);
                        DoublefloatE0M.AssertModel(models[20],_testData[32], false);
                        DoublefloatE0M.AssertModel(models[21],_testData[33], false);
                        DoublefloatE0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        DoublefloatE0M.AssertModel(models[0],_testData[19], false);
                        DoublefloatE0M.AssertModel(models[1],_testData[20], false);
                        DoublefloatE0M.AssertModel(models[2],_testData[21], false);
                        DoublefloatE0M.AssertModel(models[3],_testData[22], false);
                        DoublefloatE0M.AssertModel(models[4],_testData[23], false);
                        DoublefloatE0M.AssertModel(models[5],_testData[24], false);
                        DoublefloatE0M.AssertModel(models[6],_testData[25], false);
                        DoublefloatE0M.AssertModel(models[7],_testData[26], false);
                        DoublefloatE0M.AssertModel(models[8],_testData[27], false);
                        DoublefloatE0M.AssertModel(models[9],_testData[28], false);
                        DoublefloatE0M.AssertModel(models[10],_testData[29], false);
                        DoublefloatE0M.AssertModel(models[11],_testData[30], false);
                        DoublefloatE0M.AssertModel(models[12],_testData[31], false);
                        DoublefloatE0M.AssertModel(models[13],_testData[32], false);
                        DoublefloatE0M.AssertModel(models[14],_testData[33], false);
                        DoublefloatE0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoublefloatE0M), typeof(FlatDoublefloatE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)),
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
            asPartInterface: typeof(IDoubleSingleTypefloat)),
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
            asPartInterface: typeof(IDoubleSingleTypefloat)),
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoublefloatE0M>();
                var models2 = new List<FlatDoublefloatE0M>();
                await((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloatE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoublefloatE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.doublefloate0m m
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloatE0M>();
                var firstItems2 = new List<FlatDoublefloatE0M>();
                var secondItems1 = new List<FlatDoublefloatE0M>();
                var secondItems2 = new List<FlatDoublefloatE0M>();
                await ((IDoubleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 114, query1, 161, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM dbo.doublefloate0m m
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloatE0M>();
                var firstItems2 = new List<FlatDoublefloatE0M>();
                var secondItems1 = new List<FlatDoublefloatE0M>();
                await ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 158, query1, 62, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[25],_testData[34], false);
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoublefloatE0M>();
                var models2 = new List<FlatDoublefloatE0M>();
                ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloatE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoublefloatE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.doublefloate0m m
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloatE0M>();
                var firstItems2 = new List<FlatDoublefloatE0M>();
                var secondItems1 = new List<FlatDoublefloatE0M>();
                var secondItems2 = new List<FlatDoublefloatE0M>();
                 ((IDoubleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 96, query1, 68, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM dbo.doublefloate0m m
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloatE0M>();
                var firstItems2 = new List<FlatDoublefloatE0M>();
                var secondItems1 = new List<FlatDoublefloatE0M>();
                 ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelBatch(connection, 175, query1, 161, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoublefloatE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)),
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
            asPartInterface: typeof(IDoubleSingleTypefloat)),
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
            asPartInterface: typeof(IDoubleSingleTypefloat)),
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloatE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.doublefloate0m m
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 125, query1, 81, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatDoublefloatE0M.AssertModel(models[0],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(models[1],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(models[2],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(models[3],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(models[4],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(models[5],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(models[6],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(models[7],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(models[8],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(models[9],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(models[10],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDoublefloatE0M.AssertModel(models[0],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(models[1],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(models[2],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(models[3],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(models[4],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(models[5],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(models[6],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(models[7],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(models[8],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(models[9],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(models[10],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(models[11],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(models[12],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(models[13],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(models[14],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(models[15],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(models[16],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(models[17],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(models[18],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(models[19],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(models[20],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(models[21],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(models[22],_testData[34], false);
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
FROM dbo.doublefloate0m m
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloatE0M>();
                var secondItems1 = new List<FlatDoublefloatE0M>();
                var secondItems2 = new List<FlatDoublefloatE0M>();
                await ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 146, query1, 94, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloatE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.doublefloate0m m
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelBatch(connection, 7, query1, 155, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatDoublefloatE0M.AssertModel(models[0],_testData[1], false);
                        FlatDoublefloatE0M.AssertModel(models[1],_testData[2], false);
                        FlatDoublefloatE0M.AssertModel(models[2],_testData[3], false);
                        FlatDoublefloatE0M.AssertModel(models[3],_testData[4], false);
                        FlatDoublefloatE0M.AssertModel(models[4],_testData[5], false);
                        FlatDoublefloatE0M.AssertModel(models[5],_testData[6], false);
                        FlatDoublefloatE0M.AssertModel(models[6],_testData[7], false);
                        FlatDoublefloatE0M.AssertModel(models[7],_testData[8], false);
                        FlatDoublefloatE0M.AssertModel(models[8],_testData[9], false);
                        FlatDoublefloatE0M.AssertModel(models[9],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(models[10],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(models[11],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(models[12],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(models[13],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(models[14],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(models[15],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(models[16],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(models[17],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(models[18],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(models[19],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(models[20],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(models[21],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(models[22],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(models[23],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(models[24],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(models[25],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(models[26],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(models[27],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(models[28],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(models[29],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(models[30],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(models[31],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(models[32],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatDoublefloatE0M.AssertModel(models[0],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(models[1],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(models[2],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(models[3],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(models[4],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(models[5],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(models[6],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(models[7],_testData[34], false);
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
FROM dbo.doublefloate0m m
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloatE0M>();
                var secondItems1 = new List<FlatDoublefloatE0M>();
                var secondItems2 = new List<FlatDoublefloatE0M>();
                 ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelBatch(connection, 94, query1, 7, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM dbo.doublefloate0m m
LEFT JOIN dbo.doublefloat0mi mi ON mi.id = m.doublefloat0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DoublefloatE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)),
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
            asPartInterface: typeof(IDoubleSingleTypefloat)),
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
                var models = await((IDoubleSingleTypefloat)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DoublefloatE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelBatchAsync(connection, 187, 155))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        DoublefloatE0M.AssertModel(models[0],_testData[33], false);
                        DoublefloatE0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        DoublefloatE0M.AssertModel(models[0],_testData[27], false);
                        DoublefloatE0M.AssertModel(models[1],_testData[28], false);
                        DoublefloatE0M.AssertModel(models[2],_testData[29], false);
                        DoublefloatE0M.AssertModel(models[3],_testData[30], false);
                        DoublefloatE0M.AssertModel(models[4],_testData[31], false);
                        DoublefloatE0M.AssertModel(models[5],_testData[32], false);
                        DoublefloatE0M.AssertModel(models[6],_testData[33], false);
                        DoublefloatE0M.AssertModel(models[7],_testData[34], false);
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
                var models = ((IDoubleSingleTypefloat)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DoublefloatE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelBatch(connection, 86, 7))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        DoublefloatE0M.AssertModel(models[0],_testData[13], false);
                        DoublefloatE0M.AssertModel(models[1],_testData[14], false);
                        DoublefloatE0M.AssertModel(models[2],_testData[15], false);
                        DoublefloatE0M.AssertModel(models[3],_testData[16], false);
                        DoublefloatE0M.AssertModel(models[4],_testData[17], false);
                        DoublefloatE0M.AssertModel(models[5],_testData[18], false);
                        DoublefloatE0M.AssertModel(models[6],_testData[19], false);
                        DoublefloatE0M.AssertModel(models[7],_testData[20], false);
                        DoublefloatE0M.AssertModel(models[8],_testData[21], false);
                        DoublefloatE0M.AssertModel(models[9],_testData[22], false);
                        DoublefloatE0M.AssertModel(models[10],_testData[23], false);
                        DoublefloatE0M.AssertModel(models[11],_testData[24], false);
                        DoublefloatE0M.AssertModel(models[12],_testData[25], false);
                        DoublefloatE0M.AssertModel(models[13],_testData[26], false);
                        DoublefloatE0M.AssertModel(models[14],_testData[27], false);
                        DoublefloatE0M.AssertModel(models[15],_testData[28], false);
                        DoublefloatE0M.AssertModel(models[16],_testData[29], false);
                        DoublefloatE0M.AssertModel(models[17],_testData[30], false);
                        DoublefloatE0M.AssertModel(models[18],_testData[31], false);
                        DoublefloatE0M.AssertModel(models[19],_testData[32], false);
                        DoublefloatE0M.AssertModel(models[20],_testData[33], false);
                        DoublefloatE0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        DoublefloatE0M.AssertModel(models[0],_testData[1], false);
                        DoublefloatE0M.AssertModel(models[1],_testData[2], false);
                        DoublefloatE0M.AssertModel(models[2],_testData[3], false);
                        DoublefloatE0M.AssertModel(models[3],_testData[4], false);
                        DoublefloatE0M.AssertModel(models[4],_testData[5], false);
                        DoublefloatE0M.AssertModel(models[5],_testData[6], false);
                        DoublefloatE0M.AssertModel(models[6],_testData[7], false);
                        DoublefloatE0M.AssertModel(models[7],_testData[8], false);
                        DoublefloatE0M.AssertModel(models[8],_testData[9], false);
                        DoublefloatE0M.AssertModel(models[9],_testData[10], false);
                        DoublefloatE0M.AssertModel(models[10],_testData[11], false);
                        DoublefloatE0M.AssertModel(models[11],_testData[12], false);
                        DoublefloatE0M.AssertModel(models[12],_testData[13], false);
                        DoublefloatE0M.AssertModel(models[13],_testData[14], false);
                        DoublefloatE0M.AssertModel(models[14],_testData[15], false);
                        DoublefloatE0M.AssertModel(models[15],_testData[16], false);
                        DoublefloatE0M.AssertModel(models[16],_testData[17], false);
                        DoublefloatE0M.AssertModel(models[17],_testData[18], false);
                        DoublefloatE0M.AssertModel(models[18],_testData[19], false);
                        DoublefloatE0M.AssertModel(models[19],_testData[20], false);
                        DoublefloatE0M.AssertModel(models[20],_testData[21], false);
                        DoublefloatE0M.AssertModel(models[21],_testData[22], false);
                        DoublefloatE0M.AssertModel(models[22],_testData[23], false);
                        DoublefloatE0M.AssertModel(models[23],_testData[24], false);
                        DoublefloatE0M.AssertModel(models[24],_testData[25], false);
                        DoublefloatE0M.AssertModel(models[25],_testData[26], false);
                        DoublefloatE0M.AssertModel(models[26],_testData[27], false);
                        DoublefloatE0M.AssertModel(models[27],_testData[28], false);
                        DoublefloatE0M.AssertModel(models[28],_testData[29], false);
                        DoublefloatE0M.AssertModel(models[29],_testData[30], false);
                        DoublefloatE0M.AssertModel(models[30],_testData[31], false);
                        DoublefloatE0M.AssertModel(models[31],_testData[32], false);
                        DoublefloatE0M.AssertModel(models[32],_testData[33], false);
                        DoublefloatE0M.AssertModel(models[33],_testData[34], false);
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
                await using var cmd = await ((IDoubleSingleTypefloat)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleSingleTypefloat)this).SetDbConnectionSelectModelParametrs(cmd, 57);
                var models = await ((IDoubleSingleTypefloat)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                DoublefloatE0M.AssertModel(models[0],_testData[8], false);
                DoublefloatE0M.AssertModel(models[1],_testData[9], false);
                DoublefloatE0M.AssertModel(models[2],_testData[10], false);
                DoublefloatE0M.AssertModel(models[3],_testData[11], false);
                DoublefloatE0M.AssertModel(models[4],_testData[12], false);
                DoublefloatE0M.AssertModel(models[5],_testData[13], false);
                DoublefloatE0M.AssertModel(models[6],_testData[14], false);
                DoublefloatE0M.AssertModel(models[7],_testData[15], false);
                DoublefloatE0M.AssertModel(models[8],_testData[16], false);
                DoublefloatE0M.AssertModel(models[9],_testData[17], false);
                DoublefloatE0M.AssertModel(models[10],_testData[18], false);
                DoublefloatE0M.AssertModel(models[11],_testData[19], false);
                DoublefloatE0M.AssertModel(models[12],_testData[20], false);
                DoublefloatE0M.AssertModel(models[13],_testData[21], false);
                DoublefloatE0M.AssertModel(models[14],_testData[22], false);
                DoublefloatE0M.AssertModel(models[15],_testData[23], false);
                DoublefloatE0M.AssertModel(models[16],_testData[24], false);
                DoublefloatE0M.AssertModel(models[17],_testData[25], false);
                DoublefloatE0M.AssertModel(models[18],_testData[26], false);
                DoublefloatE0M.AssertModel(models[19],_testData[27], false);
                DoublefloatE0M.AssertModel(models[20],_testData[28], false);
                DoublefloatE0M.AssertModel(models[21],_testData[29], false);
                DoublefloatE0M.AssertModel(models[22],_testData[30], false);
                DoublefloatE0M.AssertModel(models[23],_testData[31], false);
                DoublefloatE0M.AssertModel(models[24],_testData[32], false);
                DoublefloatE0M.AssertModel(models[25],_testData[33], false);
                DoublefloatE0M.AssertModel(models[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleSingleTypefloat)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleSingleTypefloat)this).SetDbConnectionSelectModelParametrs(cmd, 111);
                var models =  ((IDoubleSingleTypefloat)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                DoublefloatE0M.AssertModel(models[0],_testData[18], false);
                DoublefloatE0M.AssertModel(models[1],_testData[19], false);
                DoublefloatE0M.AssertModel(models[2],_testData[20], false);
                DoublefloatE0M.AssertModel(models[3],_testData[21], false);
                DoublefloatE0M.AssertModel(models[4],_testData[22], false);
                DoublefloatE0M.AssertModel(models[5],_testData[23], false);
                DoublefloatE0M.AssertModel(models[6],_testData[24], false);
                DoublefloatE0M.AssertModel(models[7],_testData[25], false);
                DoublefloatE0M.AssertModel(models[8],_testData[26], false);
                DoublefloatE0M.AssertModel(models[9],_testData[27], false);
                DoublefloatE0M.AssertModel(models[10],_testData[28], false);
                DoublefloatE0M.AssertModel(models[11],_testData[29], false);
                DoublefloatE0M.AssertModel(models[12],_testData[30], false);
                DoublefloatE0M.AssertModel(models[13],_testData[31], false);
                DoublefloatE0M.AssertModel(models[14],_testData[32], false);
                DoublefloatE0M.AssertModel(models[15],_testData[33], false);
                DoublefloatE0M.AssertModel(models[16],_testData[34], false);
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
FROM dbo.doublefloate0m m
LEFT JOIN dbo.doublefloat0mi mi ON mi.id = m.doublefloat0mi_id
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
            asPartInterface: typeof(IDoubleSingleTypefloat))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleSingleTypefloat)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.19070739905392298d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9765925333823662d)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.08641511833343318d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.139878100325468d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7338630314108646d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7718855255051417d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.42174606084272037d)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9381991831065005d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5374703812167567d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.2227601778472429d)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.910969977461252d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.23264530362439972d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8955786902359633d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.45741241686455714d)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9319866160142132d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.32448424922206d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9154802161395525d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.77710827315028d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4351991774996651d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3635945231470893d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7690826617037372d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.08076545060278861d)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8035009441075003d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7532355992595613d)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.561228345415845d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3778890273440212d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8661909705466155d)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2365361428952727d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.20554411743674506d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6745158227731973d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6113182649709867d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4257790456296384d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.1822739264903238d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.24595453524462163d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4000791385457456d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4360510729398742d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5171374206414503d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5016633031559051d)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7260967310279661d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6998398303051896d)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8437950020404547d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3807165416726427d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.448875754338652d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5270206144706164d)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.945946496233672d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8090189377808575d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.33542308705109114d)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7699032897225354d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.03736513237721961d)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9289109601900402d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.05517730442961455d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.07479692567828522d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9037923930216908d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5573263706728747d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4502364122488939d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9648003583390974d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3857951264055616d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.14302580584156754d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9876085872463869d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.022647446330694487d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((89)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5429592231223568d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4154775854104533d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((184)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.24593439310871357d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((94)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4745492521781307d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((187)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9574747738781296d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((190)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.21505460913261265d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((98)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9033137509357636d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5037739114267609d)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((193)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.43763476617816366d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5845750903033856d)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDoubleSingleTypefloat)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.19070739905392298d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9765925333823662d)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.08641511833343318d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.139878100325468d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7338630314108646d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7718855255051417d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.42174606084272037d)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9381991831065005d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5374703812167567d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.2227601778472429d)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.910969977461252d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.23264530362439972d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8955786902359633d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.45741241686455714d)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9319866160142132d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.32448424922206d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9154802161395525d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.77710827315028d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4351991774996651d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3635945231470893d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7690826617037372d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.08076545060278861d)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8035009441075003d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7532355992595613d)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.561228345415845d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3778890273440212d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8661909705466155d)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2365361428952727d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.20554411743674506d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6745158227731973d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6113182649709867d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4257790456296384d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.1822739264903238d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.24595453524462163d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4000791385457456d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4360510729398742d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5171374206414503d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5016633031559051d)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7260967310279661d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6998398303051896d)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8437950020404547d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3807165416726427d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.448875754338652d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5270206144706164d)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.945946496233672d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8090189377808575d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.33542308705109114d)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7699032897225354d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.03736513237721961d)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9289109601900402d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.05517730442961455d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.07479692567828522d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9037923930216908d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5573263706728747d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4502364122488939d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9648003583390974d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3857951264055616d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.14302580584156754d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9876085872463869d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.022647446330694487d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((89)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5429592231223568d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4154775854104533d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((184)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.24593439310871357d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((94)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4745492521781307d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((187)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9574747738781296d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((190)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.21505460913261265d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((98)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9033137509357636d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5037739114267609d)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((193)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.43763476617816366d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5845750903033856d)));

            }
        }

#endregion

    }
}

