

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

        private readonly Doublefloat0M[] _testData = new Doublefloat0M[]
        {
            new Doublefloat0M
{
    Id = 5,
    Value = 0.2117335920603446d,
    ModelInner = null,
    NullableValue = 0.36210340333528157d,
},
            new Doublefloat0M
{
    Id = 14,
    Value = 0.09600148068932146d,
    ModelInner = new Doublefloat0MI
{
    Id = 3,
    Value = 0.18333715464702982d,
    NullableValue = 0.06888248968323007d,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 23,
    Value = 0.9555348388382068d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 29,
    Value = 0.24852356334873382d,
    ModelInner = new Doublefloat0MI
{
    Id = 12,
    Value = 0.7390343836270004d,
    NullableValue = 0.2591610520126306d,
},
    NullableValue = 0.09115339920406096d,
},
            new Doublefloat0M
{
    Id = 36,
    Value = 0.967126401107969d,
    ModelInner = null,
    NullableValue = 0.43051586622979343d,
},
            new Doublefloat0M
{
    Id = 45,
    Value = 0.7997012956555973d,
    ModelInner = new Doublefloat0MI
{
    Id = 19,
    Value = 0.33721050279681963d,
    NullableValue = null,
},
    NullableValue = 0.12283824935241394d,
},
            new Doublefloat0M
{
    Id = 46,
    Value = 0.411604833788914d,
    ModelInner = null,
    NullableValue = 0.5008878133945172d,
},
            new Doublefloat0M
{
    Id = 54,
    Value = 0.24450992033651675d,
    ModelInner = new Doublefloat0MI
{
    Id = 26,
    Value = 0.6116621303533012d,
    NullableValue = 0.09570828593096414d,
},
    NullableValue = 0.4055660980215423d,
},
            new Doublefloat0M
{
    Id = 60,
    Value = 0.704982970336718d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 62,
    Value = 0.841851684961843d,
    ModelInner = new Doublefloat0MI
{
    Id = 32,
    Value = 0.39649272536786384d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 66,
    Value = 0.6077292095042515d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 74,
    Value = 0.19421237864697638d,
    ModelInner = new Doublefloat0MI
{
    Id = 36,
    Value = 0.018694322426896948d,
    NullableValue = null,
},
    NullableValue = 0.22727986804330025d,
},
            new Doublefloat0M
{
    Id = 81,
    Value = 0.40449737696250554d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 89,
    Value = 0.5263666330204008d,
    ModelInner = new Doublefloat0MI
{
    Id = 40,
    Value = 0.09988506494294092d,
    NullableValue = null,
},
    NullableValue = 0.41192419973976624d,
},
            new Doublefloat0M
{
    Id = 98,
    Value = 0.8654902027677831d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 102,
    Value = 0.11264049943838117d,
    ModelInner = new Doublefloat0MI
{
    Id = 44,
    Value = 0.10347223395328276d,
    NullableValue = 0.09363235225751498d,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 103,
    Value = 0.515517029452298d,
    ModelInner = null,
    NullableValue = 0.44874779888480676d,
},
            new Doublefloat0M
{
    Id = 106,
    Value = 0.29534916855841586d,
    ModelInner = new Doublefloat0MI
{
    Id = 47,
    Value = 0.09971899941870666d,
    NullableValue = 0.02198731242343066d,
},
    NullableValue = 0.291767814879792d,
},
            new Doublefloat0M
{
    Id = 107,
    Value = 0.2819536251991591d,
    ModelInner = null,
    NullableValue = 0.7910779260662519d,
},
            new Doublefloat0M
{
    Id = 112,
    Value = 0.9766058844918198d,
    ModelInner = new Doublefloat0MI
{
    Id = 51,
    Value = 0.9844327308841585d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 118,
    Value = 0.18100242693579316d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 119,
    Value = 0.9332007535601005d,
    ModelInner = new Doublefloat0MI
{
    Id = 60,
    Value = 0.7873220006396019d,
    NullableValue = 0.421957019564006d,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 122,
    Value = 0.9979797807368088d,
    ModelInner = null,
    NullableValue = 0.9714057355997416d,
},
            new Doublefloat0M
{
    Id = 128,
    Value = 0.20722014266445177d,
    ModelInner = new Doublefloat0MI
{
    Id = 69,
    Value = 0.8611904224969957d,
    NullableValue = 0.9964094185373901d,
},
    NullableValue = 0.6619953931135798d,
},
            new Doublefloat0M
{
    Id = 134,
    Value = 0.21206259252853854d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 142,
    Value = 0.6832052795917628d,
    ModelInner = new Doublefloat0MI
{
    Id = 78,
    Value = 0.10562779700829428d,
    NullableValue = null,
},
    NullableValue = 0.09882018474438625d,
},
            new Doublefloat0M
{
    Id = 143,
    Value = 0.8268849936008142d,
    ModelInner = null,
    NullableValue = 0.6504211174592179d,
},
            new Doublefloat0M
{
    Id = 152,
    Value = 0.13868488546084767d,
    ModelInner = new Doublefloat0MI
{
    Id = 81,
    Value = 0.7766156460709945d,
    NullableValue = 0.9530235261119653d,
},
    NullableValue = 0.5537518810413231d,
},
            new Doublefloat0M
{
    Id = 159,
    Value = 0.9916164785455298d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 167,
    Value = 0.027344837074746664d,
    ModelInner = new Doublefloat0MI
{
    Id = 90,
    Value = 0.03855327561329569d,
    NullableValue = 0.20272860973951978d,
},
    NullableValue = 0.8247050494390507d,
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
                sqlDbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Double),
                parametrName: "value",
                methodParametrName: "value",
                sqlDbType: (System.Data.SqlDbType)(6)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                sqlDbType: (System.Data.SqlDbType)(6))
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

            }
        }

#endregion

#region InsertModel

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.doublefloat0m(
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
                sqlDbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Double), 
                parametrName: "value", 
                methodParametrName: "value", 
                sqlDbType: (System.Data.SqlDbType)(6)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                sqlDbType: (System.Data.SqlDbType)(6),
                nullable: true),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "doublefloat0mi_id", 
                methodParametrName: "doublefloat0mi_id", 
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
INSERT INTO dbo.doublefloat0m(
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

            }
        }

#endregion

#region Select Models

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoublefloat0M), typeof(FlatDoublefloat0M)],
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
FROM dbo.doublefloat0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoublefloat0M>();
                var models2 = new List<FlatDoublefloat0M>();
                await((IDoubleSingleTypefloat)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoublefloat0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.doublefloat0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoublefloat0M>();
                var models2 = new List<FlatDoublefloat0M>();
                ((IDoubleSingleTypefloat)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoublefloat0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoublefloat0M)],
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
FROM dbo.doublefloat0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoublefloat0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.doublefloat0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoublefloat0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.doublefloat0m m
LEFT JOIN dbo.doublefloat0mi mi ON mi.id = m.doublefloat0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Doublefloat0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doublefloat0M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doublefloat0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoublefloat0M), typeof(FlatDoublefloat0M)],
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
FROM dbo.doublefloat0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoublefloat0M>();
                var models2 = new List<FlatDoublefloat0M>();
                await((IDoubleSingleTypefloat)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoublefloat0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.doublefloat0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoublefloat0M>();
                var models2 = new List<FlatDoublefloat0M>();
                ((IDoubleSingleTypefloat)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoublefloat0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoublefloat0M)],
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
FROM dbo.doublefloat0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleSingleTypefloat)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoublefloat0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.doublefloat0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleSingleTypefloat)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoublefloat0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.doublefloat0m m
LEFT JOIN dbo.doublefloat0mi mi ON mi.id = m.doublefloat0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Doublefloat0M)],
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
                var models = await((IDoubleSingleTypefloat)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doublefloat0M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doublefloat0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoublefloat0M), typeof(FlatDoublefloat0M)],
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoublefloat0M>();
                var models2 = new List<FlatDoublefloat0M>();
                await((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoublefloat0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
FROM dbo.doublefloat0m m
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloat0M>();
                var firstItems2 = new List<FlatDoublefloat0M>();
                var secondItems1 = new List<FlatDoublefloat0M>();
                var secondItems2 = new List<FlatDoublefloat0M>();
                await ((IDoubleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[13],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
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
FROM dbo.doublefloat0m m
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloat0M>();
                var firstItems2 = new List<FlatDoublefloat0M>();
                var secondItems1 = new List<FlatDoublefloat0M>();
                await ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[29], false);
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoublefloat0M>();
                var models2 = new List<FlatDoublefloat0M>();
                ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoublefloat0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
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
FROM dbo.doublefloat0m m
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloat0M>();
                var firstItems2 = new List<FlatDoublefloat0M>();
                var secondItems1 = new List<FlatDoublefloat0M>();
                var secondItems2 = new List<FlatDoublefloat0M>();
                 ((IDoubleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
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
FROM dbo.doublefloat0m m
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloat0M>();
                var firstItems2 = new List<FlatDoublefloat0M>();
                var secondItems1 = new List<FlatDoublefloat0M>();
                 ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoublefloat0M)],
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
FROM dbo.doublefloat0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoublefloat0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.doublefloat0m m
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
FROM dbo.doublefloat0m m
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
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(models[6],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(models[7],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(models[8],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(models[9],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(models[10],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(models[11],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[12],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[13],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[14],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[1], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[2], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[3], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[4], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[5], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(models[6],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(models[7],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(models[8],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(models[9],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(models[10],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(models[11],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(models[12],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(models[13],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(models[14],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(models[15],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(models[16],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(models[17],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(models[18],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(models[19],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(models[20],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(models[21],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(models[22],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(models[23],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(models[24],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[25],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[26],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[27],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[28],_testData[29], false);
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.doublefloat0m m
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloat0M>();
                var secondItems1 = new List<FlatDoublefloat0M>();
                var secondItems2 = new List<FlatDoublefloat0M>();
                await ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[14],_testData[29], false);
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
FROM dbo.doublefloat0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoublefloat0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.doublefloat0m m
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
FROM dbo.doublefloat0m m
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
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[5], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(models[6],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(models[7],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(models[8],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(models[9],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(models[10],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(models[11],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(models[12],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(models[13],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(models[14],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(models[15],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(models[16],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(models[17],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(models[18],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(models[19],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(models[20],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[21],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[22],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[23],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[29], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.doublefloat0m m
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloat0M>();
                var secondItems1 = new List<FlatDoublefloat0M>();
                var secondItems2 = new List<FlatDoublefloat0M>();
                 ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[23],_testData[29], false);
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
FROM dbo.doublefloat0m m
LEFT JOIN dbo.doublefloat0mi mi ON mi.id = m.doublefloat0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Doublefloat0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doublefloat0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Doublefloat0M.AssertModel(models[0],_testData[2], false);
                        Doublefloat0M.AssertModel(models[1],_testData[3], false);
                        Doublefloat0M.AssertModel(models[2],_testData[4], false);
                        Doublefloat0M.AssertModel(models[3],_testData[5], false);
                        Doublefloat0M.AssertModel(models[4],_testData[6], false);
                        Doublefloat0M.AssertModel(models[5],_testData[7], false);
                        Doublefloat0M.AssertModel(models[6],_testData[8], false);
                        Doublefloat0M.AssertModel(models[7],_testData[9], false);
                        Doublefloat0M.AssertModel(models[8],_testData[10], false);
                        Doublefloat0M.AssertModel(models[9],_testData[11], false);
                        Doublefloat0M.AssertModel(models[10],_testData[12], false);
                        Doublefloat0M.AssertModel(models[11],_testData[13], false);
                        Doublefloat0M.AssertModel(models[12],_testData[14], false);
                        Doublefloat0M.AssertModel(models[13],_testData[15], false);
                        Doublefloat0M.AssertModel(models[14],_testData[16], false);
                        Doublefloat0M.AssertModel(models[15],_testData[17], false);
                        Doublefloat0M.AssertModel(models[16],_testData[18], false);
                        Doublefloat0M.AssertModel(models[17],_testData[19], false);
                        Doublefloat0M.AssertModel(models[18],_testData[20], false);
                        Doublefloat0M.AssertModel(models[19],_testData[21], false);
                        Doublefloat0M.AssertModel(models[20],_testData[22], false);
                        Doublefloat0M.AssertModel(models[21],_testData[23], false);
                        Doublefloat0M.AssertModel(models[22],_testData[24], false);
                        Doublefloat0M.AssertModel(models[23],_testData[25], false);
                        Doublefloat0M.AssertModel(models[24],_testData[26], false);
                        Doublefloat0M.AssertModel(models[25],_testData[27], false);
                        Doublefloat0M.AssertModel(models[26],_testData[28], false);
                        Doublefloat0M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Doublefloat0M.AssertModel(models[0],_testData[13], false);
                        Doublefloat0M.AssertModel(models[1],_testData[14], false);
                        Doublefloat0M.AssertModel(models[2],_testData[15], false);
                        Doublefloat0M.AssertModel(models[3],_testData[16], false);
                        Doublefloat0M.AssertModel(models[4],_testData[17], false);
                        Doublefloat0M.AssertModel(models[5],_testData[18], false);
                        Doublefloat0M.AssertModel(models[6],_testData[19], false);
                        Doublefloat0M.AssertModel(models[7],_testData[20], false);
                        Doublefloat0M.AssertModel(models[8],_testData[21], false);
                        Doublefloat0M.AssertModel(models[9],_testData[22], false);
                        Doublefloat0M.AssertModel(models[10],_testData[23], false);
                        Doublefloat0M.AssertModel(models[11],_testData[24], false);
                        Doublefloat0M.AssertModel(models[12],_testData[25], false);
                        Doublefloat0M.AssertModel(models[13],_testData[26], false);
                        Doublefloat0M.AssertModel(models[14],_testData[27], false);
                        Doublefloat0M.AssertModel(models[15],_testData[28], false);
                        Doublefloat0M.AssertModel(models[16],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doublefloat0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Doublefloat0M.AssertModel(models[0],_testData[2], false);
                        Doublefloat0M.AssertModel(models[1],_testData[3], false);
                        Doublefloat0M.AssertModel(models[2],_testData[4], false);
                        Doublefloat0M.AssertModel(models[3],_testData[5], false);
                        Doublefloat0M.AssertModel(models[4],_testData[6], false);
                        Doublefloat0M.AssertModel(models[5],_testData[7], false);
                        Doublefloat0M.AssertModel(models[6],_testData[8], false);
                        Doublefloat0M.AssertModel(models[7],_testData[9], false);
                        Doublefloat0M.AssertModel(models[8],_testData[10], false);
                        Doublefloat0M.AssertModel(models[9],_testData[11], false);
                        Doublefloat0M.AssertModel(models[10],_testData[12], false);
                        Doublefloat0M.AssertModel(models[11],_testData[13], false);
                        Doublefloat0M.AssertModel(models[12],_testData[14], false);
                        Doublefloat0M.AssertModel(models[13],_testData[15], false);
                        Doublefloat0M.AssertModel(models[14],_testData[16], false);
                        Doublefloat0M.AssertModel(models[15],_testData[17], false);
                        Doublefloat0M.AssertModel(models[16],_testData[18], false);
                        Doublefloat0M.AssertModel(models[17],_testData[19], false);
                        Doublefloat0M.AssertModel(models[18],_testData[20], false);
                        Doublefloat0M.AssertModel(models[19],_testData[21], false);
                        Doublefloat0M.AssertModel(models[20],_testData[22], false);
                        Doublefloat0M.AssertModel(models[21],_testData[23], false);
                        Doublefloat0M.AssertModel(models[22],_testData[24], false);
                        Doublefloat0M.AssertModel(models[23],_testData[25], false);
                        Doublefloat0M.AssertModel(models[24],_testData[26], false);
                        Doublefloat0M.AssertModel(models[25],_testData[27], false);
                        Doublefloat0M.AssertModel(models[26],_testData[28], false);
                        Doublefloat0M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Doublefloat0M.AssertModel(models[0],_testData[26], false);
                        Doublefloat0M.AssertModel(models[1],_testData[27], false);
                        Doublefloat0M.AssertModel(models[2],_testData[28], false);
                        Doublefloat0M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoublefloat0M), typeof(FlatDoublefloat0M)],
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoublefloat0M>();
                var models2 = new List<FlatDoublefloat0M>();
                await((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoublefloat0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.doublefloat0m m
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloat0M>();
                var firstItems2 = new List<FlatDoublefloat0M>();
                var secondItems1 = new List<FlatDoublefloat0M>();
                var secondItems2 = new List<FlatDoublefloat0M>();
                await ((IDoubleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 81, query1, 128, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[29], false);
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
FROM dbo.doublefloat0m m
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloat0M>();
                var firstItems2 = new List<FlatDoublefloat0M>();
                var secondItems1 = new List<FlatDoublefloat0M>();
                await ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 81, query1, 36, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[24],_testData[29], false);
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoublefloat0M>();
                var models2 = new List<FlatDoublefloat0M>();
                ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoublefloat0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.doublefloat0m m
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloat0M>();
                var firstItems2 = new List<FlatDoublefloat0M>();
                var secondItems1 = new List<FlatDoublefloat0M>();
                var secondItems2 = new List<FlatDoublefloat0M>();
                 ((IDoubleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 152, query1, 54, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[21],_testData[29], false);
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
FROM dbo.doublefloat0m m
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloat0M>();
                var firstItems2 = new List<FlatDoublefloat0M>();
                var secondItems1 = new List<FlatDoublefloat0M>();
                 ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelBatch(connection, 122, query1, 102, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoublefloat0M)],
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoublefloat0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.doublefloat0m m
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 98, query1, 81, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(models[6],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(models[7],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(models[8],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(models[9],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(models[10],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[11],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[12],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[13],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(models[6],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(models[7],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(models[8],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(models[9],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(models[10],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(models[11],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(models[12],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[13],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[14],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[15],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[16],_testData[29], false);
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
FROM dbo.doublefloat0m m
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloat0M>();
                var secondItems1 = new List<FlatDoublefloat0M>();
                var secondItems2 = new List<FlatDoublefloat0M>();
                await ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 119, query1, 106, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[11],_testData[29], false);
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoublefloat0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.doublefloat0m m
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelBatch(connection, 119, query1, 128, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[6],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[29], false);
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
FROM dbo.doublefloat0m m
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
FROM dbo.doublefloat0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloat0M>();
                var secondItems1 = new List<FlatDoublefloat0M>();
                var secondItems2 = new List<FlatDoublefloat0M>();
                 ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelBatch(connection, 119, query1, 14, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[27],_testData[29], false);
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
FROM dbo.doublefloat0m m
LEFT JOIN dbo.doublefloat0mi mi ON mi.id = m.doublefloat0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Doublefloat0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doublefloat0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelBatchAsync(connection, 128, 106))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Doublefloat0M.AssertModel(models[0],_testData[24], false);
                        Doublefloat0M.AssertModel(models[1],_testData[25], false);
                        Doublefloat0M.AssertModel(models[2],_testData[26], false);
                        Doublefloat0M.AssertModel(models[3],_testData[27], false);
                        Doublefloat0M.AssertModel(models[4],_testData[28], false);
                        Doublefloat0M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Doublefloat0M.AssertModel(models[0],_testData[18], false);
                        Doublefloat0M.AssertModel(models[1],_testData[19], false);
                        Doublefloat0M.AssertModel(models[2],_testData[20], false);
                        Doublefloat0M.AssertModel(models[3],_testData[21], false);
                        Doublefloat0M.AssertModel(models[4],_testData[22], false);
                        Doublefloat0M.AssertModel(models[5],_testData[23], false);
                        Doublefloat0M.AssertModel(models[6],_testData[24], false);
                        Doublefloat0M.AssertModel(models[7],_testData[25], false);
                        Doublefloat0M.AssertModel(models[8],_testData[26], false);
                        Doublefloat0M.AssertModel(models[9],_testData[27], false);
                        Doublefloat0M.AssertModel(models[10],_testData[28], false);
                        Doublefloat0M.AssertModel(models[11],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doublefloat0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelBatch(connection, 119, 128))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Doublefloat0M.AssertModel(models[0],_testData[22], false);
                        Doublefloat0M.AssertModel(models[1],_testData[23], false);
                        Doublefloat0M.AssertModel(models[2],_testData[24], false);
                        Doublefloat0M.AssertModel(models[3],_testData[25], false);
                        Doublefloat0M.AssertModel(models[4],_testData[26], false);
                        Doublefloat0M.AssertModel(models[5],_testData[27], false);
                        Doublefloat0M.AssertModel(models[6],_testData[28], false);
                        Doublefloat0M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Doublefloat0M.AssertModel(models[0],_testData[24], false);
                        Doublefloat0M.AssertModel(models[1],_testData[25], false);
                        Doublefloat0M.AssertModel(models[2],_testData[26], false);
                        Doublefloat0M.AssertModel(models[3],_testData[27], false);
                        Doublefloat0M.AssertModel(models[4],_testData[28], false);
                        Doublefloat0M.AssertModel(models[5],_testData[29], false);
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
                ((IDoubleSingleTypefloat)this).SetDbConnectionSelectModelParametrs(cmd, 122);
                var models = await ((IDoubleSingleTypefloat)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));
Doublefloat0M.AssertModel(models[0],_testData[23], false);Doublefloat0M.AssertModel(models[1],_testData[24], false);Doublefloat0M.AssertModel(models[2],_testData[25], false);Doublefloat0M.AssertModel(models[3],_testData[26], false);Doublefloat0M.AssertModel(models[4],_testData[27], false);Doublefloat0M.AssertModel(models[5],_testData[28], false);Doublefloat0M.AssertModel(models[6],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleSingleTypefloat)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleSingleTypefloat)this).SetDbConnectionSelectModelParametrs(cmd, 152);
                var models =  ((IDoubleSingleTypefloat)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
Doublefloat0M.AssertModel(models[0],_testData[28], false);Doublefloat0M.AssertModel(models[1],_testData[29], false);
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
FROM dbo.doublefloat0m m
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2117335920603446d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.36210340333528157d)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.09600148068932146d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.18333715464702982d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.06888248968323007d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9555348388382068d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.24852356334873382d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7390343836270004d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.2591610520126306d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.09115339920406096d)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.967126401107969d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.43051586622979343d)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7997012956555973d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.33721050279681963d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.12283824935241394d)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.411604833788914d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5008878133945172d)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.24450992033651675d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6116621303533012d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.09570828593096414d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4055660980215423d)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.704982970336718d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.841851684961843d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.39649272536786384d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6077292095042515d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.19421237864697638d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.018694322426896948d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.22727986804330025d)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.40449737696250554d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5263666330204008d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.09988506494294092d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.41192419973976624d)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8654902027677831d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.11264049943838117d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.10347223395328276d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.09363235225751498d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.515517029452298d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.44874779888480676d)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.29534916855841586d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.09971899941870666d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.02198731242343066d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.291767814879792d)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2819536251991591d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7910779260662519d)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9766058844918198d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9844327308841585d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.18100242693579316d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9332007535601005d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7873220006396019d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.421957019564006d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9979797807368088d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9714057355997416d)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.20722014266445177d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8611904224969957d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.9964094185373901d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6619953931135798d)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.21206259252853854d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6832052795917628d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.10562779700829428d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.09882018474438625d)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8268849936008142d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6504211174592179d)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.13868488546084767d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7766156460709945d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.9530235261119653d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5537518810413231d)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9916164785455298d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.027344837074746664d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.03855327561329569d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.20272860973951978d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8247050494390507d)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDoubleSingleTypefloat)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2117335920603446d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.36210340333528157d)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.09600148068932146d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.18333715464702982d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.06888248968323007d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9555348388382068d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.24852356334873382d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7390343836270004d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.2591610520126306d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.09115339920406096d)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.967126401107969d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.43051586622979343d)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7997012956555973d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.33721050279681963d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.12283824935241394d)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.411604833788914d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5008878133945172d)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.24450992033651675d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6116621303533012d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.09570828593096414d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4055660980215423d)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.704982970336718d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.841851684961843d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.39649272536786384d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6077292095042515d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.19421237864697638d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.018694322426896948d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.22727986804330025d)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.40449737696250554d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5263666330204008d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.09988506494294092d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.41192419973976624d)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8654902027677831d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.11264049943838117d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.10347223395328276d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.09363235225751498d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.515517029452298d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.44874779888480676d)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.29534916855841586d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.09971899941870666d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.02198731242343066d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.291767814879792d)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2819536251991591d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7910779260662519d)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9766058844918198d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9844327308841585d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.18100242693579316d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9332007535601005d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7873220006396019d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.421957019564006d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9979797807368088d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9714057355997416d)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.20722014266445177d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8611904224969957d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.9964094185373901d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6619953931135798d)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.21206259252853854d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6832052795917628d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.10562779700829428d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.09882018474438625d)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8268849936008142d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6504211174592179d)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.13868488546084767d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7766156460709945d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.9530235261119653d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5537518810413231d)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9916164785455298d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.027344837074746664d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.03855327561329569d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.20272860973951978d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8247050494390507d)));

            }
        }

#endregion

    }
}

