

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
    internal partial interface IInt64SingleTypebigint
    {
    }
    
    internal partial class Int64SingleTypebigint : IInt64SingleTypebigint
    {


#region TestData

        private readonly Int64bigintE0M[] _testData = new Int64bigintE0M[]
        {
            new Int64bigintE0M
{
    Id = 1,
    Value = 20314249343425885L,
    ModelInner = null,
    NullableValue = 66918697049043845L,
},
            new Int64bigintE0M
{
    Id = 9,
    Value = 7154815983488469488L,
    ModelInner = new Int64bigintE0MI
{
    Id = 6,
    Value = 5769767926484126970L,
    NullableValue = null,
},
    NullableValue = 2529613196118791864L,
},
            new Int64bigintE0M
{
    Id = 15,
    Value = 1715469913499088995L,
    ModelInner = null,
    NullableValue = 5895881656869493756L,
},
            new Int64bigintE0M
{
    Id = 21,
    Value = 6591247728526029047L,
    ModelInner = new Int64bigintE0MI
{
    Id = 8,
    Value = 2829293278190669066L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 22,
    Value = 4113344310927753636L,
    ModelInner = null,
    NullableValue = 3354291314104068461L,
},
            new Int64bigintE0M
{
    Id = 23,
    Value = 9010624158181598534L,
    ModelInner = new Int64bigintE0MI
{
    Id = 16,
    Value = 2179404041121757687L,
    NullableValue = 6577197864138135953L,
},
    NullableValue = 5024743361922124356L,
},
            new Int64bigintE0M
{
    Id = 32,
    Value = 64435875280048159L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 37,
    Value = 5869260456640479366L,
    ModelInner = new Int64bigintE0MI
{
    Id = 23,
    Value = 6143158899667815297L,
    NullableValue = null,
},
    NullableValue = 6802044622225376559L,
},
            new Int64bigintE0M
{
    Id = 46,
    Value = 6575408757478508686L,
    ModelInner = null,
    NullableValue = 8474265743094435927L,
},
            new Int64bigintE0M
{
    Id = 50,
    Value = 8519713972500015041L,
    ModelInner = new Int64bigintE0MI
{
    Id = 24,
    Value = 2138791480292139245L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 58,
    Value = 1102203392213749515L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 63,
    Value = 4852878917106440758L,
    ModelInner = new Int64bigintE0MI
{
    Id = 31,
    Value = 3670500552556222573L,
    NullableValue = 7832043697969816004L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 68,
    Value = 2286616246193801625L,
    ModelInner = null,
    NullableValue = 6687068024334297770L,
},
            new Int64bigintE0M
{
    Id = 73,
    Value = 2615959935509207100L,
    ModelInner = new Int64bigintE0MI
{
    Id = 33,
    Value = 8276438951081182824L,
    NullableValue = 705752499800941662L,
},
    NullableValue = 869994047324775927L,
},
            new Int64bigintE0M
{
    Id = 75,
    Value = 8844638870104142704L,
    ModelInner = null,
    NullableValue = 6692769474593945154L,
},
            new Int64bigintE0M
{
    Id = 82,
    Value = 1078300791901340182L,
    ModelInner = new Int64bigintE0MI
{
    Id = 37,
    Value = 1954537161168565512L,
    NullableValue = 4496718483272659751L,
},
    NullableValue = 6136078300988261262L,
},
            new Int64bigintE0M
{
    Id = 88,
    Value = 214241666211747735L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 96,
    Value = 8892698859576019333L,
    ModelInner = new Int64bigintE0MI
{
    Id = 40,
    Value = 4066085791519980794L,
    NullableValue = null,
},
    NullableValue = 3259850928579725379L,
},
            new Int64bigintE0M
{
    Id = 105,
    Value = 8666197877587183572L,
    ModelInner = null,
    NullableValue = 7865691446310288007L,
},
            new Int64bigintE0M
{
    Id = 110,
    Value = 8563580406407615077L,
    ModelInner = new Int64bigintE0MI
{
    Id = 45,
    Value = 4926781301898934232L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 114,
    Value = 969356810010457519L,
    ModelInner = null,
    NullableValue = 2870284742526260602L,
},
            new Int64bigintE0M
{
    Id = 122,
    Value = 6254228868603392154L,
    ModelInner = new Int64bigintE0MI
{
    Id = 54,
    Value = 2849794168732477341L,
    NullableValue = 1930136326090540506L,
},
    NullableValue = 7507774536359048269L,
},
            new Int64bigintE0M
{
    Id = 130,
    Value = 865756344029536065L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 139,
    Value = 2781027132615947204L,
    ModelInner = new Int64bigintE0MI
{
    Id = 61,
    Value = 7967324968871775715L,
    NullableValue = 5772555311137867328L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 142,
    Value = 3616008798168945714L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 149,
    Value = 6940646775922561686L,
    ModelInner = new Int64bigintE0MI
{
    Id = 66,
    Value = 73042105682059986L,
    NullableValue = null,
},
    NullableValue = 4063130445695714882L,
},
            new Int64bigintE0M
{
    Id = 158,
    Value = 4155462625004524008L,
    ModelInner = null,
    NullableValue = 4365428341705172387L,
},
            new Int64bigintE0M
{
    Id = 164,
    Value = 1938052695693794237L,
    ModelInner = new Int64bigintE0MI
{
    Id = 70,
    Value = 7217857937245309686L,
    NullableValue = 2835531631661470479L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 172,
    Value = 1748128648602639611L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 174,
    Value = 3606747446712845408L,
    ModelInner = new Int64bigintE0MI
{
    Id = 71,
    Value = 6076639031436008975L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 177,
    Value = 7042083293661993034L,
    ModelInner = null,
    NullableValue = 6398428316698297471L,
},
            new Int64bigintE0M
{
    Id = 183,
    Value = 1592835744934197517L,
    ModelInner = new Int64bigintE0MI
{
    Id = 72,
    Value = 119128952855321798L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 192,
    Value = 3225109428382889452L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 196,
    Value = 6217354910090939482L,
    ModelInner = new Int64bigintE0MI
{
    Id = 81,
    Value = 4305857418115878382L,
    NullableValue = null,
},
    NullableValue = 1049962662110331380L,
},
            new Int64bigintE0M
{
    Id = 202,
    Value = 8728374895157654575L,
    ModelInner = null,
    NullableValue = 513017937574448473L,
},
        };

#endregion

#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.int64biginte0mi(
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
            asPartInterface: typeof(IInt64SingleTypebigint)), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int64),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (System.Data.SqlDbType)(0)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (System.Data.SqlDbType)(0))
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

                changedRows =  ((IInt64SingleTypebigint)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64SingleTypebigint)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt64SingleTypebigint)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.int64biginte0mi(
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
            asPartInterface: typeof(IInt64SingleTypebigint)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)12),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)12, 
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

                changedRows =  ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModel(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
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

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.int64biginte0m(
	id,
    value,
    nullablevalue,
    int64biginte0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int64biginte0mi_id
)
",
            methodName:"InsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id",
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int64), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.SqlDbType)(0)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.SqlDbType)(0),
                nullable: true),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int64biginte0mi_id", 
                methodParametrName: "int64biginte0mi_id", 
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

                changedRows =  ((IInt64SingleTypebigint)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64SingleTypebigint)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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

                changedRows = await ((IInt64SingleTypebigint)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.int64biginte0m(
	id,
    value,
    nullablevalue,
    int64biginte0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int64biginte0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int64), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)12),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)12,
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int64biginte0mi_id", 
                methodParametrName: "int64biginte0mi_id", 
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

                changedRows =  ((IInt64SingleTypebigint)this).DbConnectionInsertModel(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64SingleTypebigint)this).DbConnectionInsertModel(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
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

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintE0M), typeof(FlatInt64bigintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM dbo.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintE0M>();
                var models2 = new List<FlatInt64bigintE0M>();
                await((IInt64SingleTypebigint)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintE0M>();
                var models2 = new List<FlatInt64bigintE0M>();
                ((IInt64SingleTypebigint)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM dbo.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = await((IInt64SingleTypebigint)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = ((IInt64SingleTypebigint)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int64biginte0m m
LEFT JOIN dbo.int64biginte0mi mi ON mi.id = m.int64biginte0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
                var models = await((IInt64SingleTypebigint)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt64SingleTypebigint)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintE0M), typeof(FlatInt64bigintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM dbo.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintE0M>();
                var models2 = new List<FlatInt64bigintE0M>();
                await((IInt64SingleTypebigint)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintE0M>();
                var models2 = new List<FlatInt64bigintE0M>();
                ((IInt64SingleTypebigint)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM dbo.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64SingleTypebigint)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64SingleTypebigint)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int64biginte0m m
LEFT JOIN dbo.int64biginte0mi mi ON mi.id = m.int64biginte0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
                var models = await((IInt64SingleTypebigint)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt64SingleTypebigint)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintE0M), typeof(FlatInt64bigintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintE0M>();
                var models2 = new List<FlatInt64bigintE0M>();
                await((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 172;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 177;
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[34], false);
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintE0M>();
                var models2 = new List<FlatInt64bigintE0M>();
                ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 149;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 192;
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 174;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 1;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 174;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 164;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[34], false);
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
                parametr2.Value = 149;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM dbo.int64biginte0m m
LEFT JOIN dbo.int64biginte0mi mi ON mi.id = m.int64biginte0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
                var models = await((IInt64SingleTypebigint)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Int64bigintE0M.AssertModel(models[0],_testData[10], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[11], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[12], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[13], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[14], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[15], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[16], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[18],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[19],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[20],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[21],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[22],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[23],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Int64bigintE0M.AssertModel(models[0],_testData[15], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[16], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[18],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[19],_testData[34], false);
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
                var models = ((IInt64SingleTypebigint)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 164;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Int64bigintE0M.AssertModel(models[0],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Int64bigintE0M.AssertModel(models[0],_testData[13], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[14], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[15], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[16], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[18],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[19],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[20],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintE0M), typeof(FlatInt64bigintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintE0M>();
                var models2 = new List<FlatInt64bigintE0M>();
                await((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 21, query1, 177, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 149, query1, 192, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[34], false);
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintE0M>();
                var models2 = new List<FlatInt64bigintE0M>();
                ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 174, query1, 37, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 142, query1, 82, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 22, query1, 63, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[20],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[21],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[22],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[23],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[24],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[25],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[26],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[27],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[28],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[20],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[21],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[22],_testData[34], false);
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 122, query1, 15, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 1, query1, 1, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[1], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[2], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[3], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[20],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[21],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[22],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[23],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[24],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[25],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[26],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[27],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[28],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[29],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[30],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[31],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[32],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[1], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[2], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[3], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[20],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[21],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[22],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[23],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[24],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[25],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[26],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[27],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[28],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[29],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[30],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[31],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[32],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[33],_testData[34], false);
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatch(connection, 172, query1, 149, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM dbo.int64biginte0m m
LEFT JOIN dbo.int64biginte0mi mi ON mi.id = m.int64biginte0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int64bigintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
                var models = await((IInt64SingleTypebigint)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatchAsync(connection, 164, 63))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Int64bigintE0M.AssertModel(models[0],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        Int64bigintE0M.AssertModel(models[0],_testData[12], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[13], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[14], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[15], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[16], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[18],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[19],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[20],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[21],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[22],_testData[34], false);
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
                var models = ((IInt64SingleTypebigint)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatch(connection, 174, 105))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Int64bigintE0M.AssertModel(models[0],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Int64bigintE0M.AssertModel(models[0],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[34], false);
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
                await using var cmd = await ((IInt64SingleTypebigint)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 142);
                var models = await ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(10));

                Int64bigintE0M.AssertModel(models[0],_testData[25], false);
                Int64bigintE0M.AssertModel(models[1],_testData[26], false);
                Int64bigintE0M.AssertModel(models[2],_testData[27], false);
                Int64bigintE0M.AssertModel(models[3],_testData[28], false);
                Int64bigintE0M.AssertModel(models[4],_testData[29], false);
                Int64bigintE0M.AssertModel(models[5],_testData[30], false);
                Int64bigintE0M.AssertModel(models[6],_testData[31], false);
                Int64bigintE0M.AssertModel(models[7],_testData[32], false);
                Int64bigintE0M.AssertModel(models[8],_testData[33], false);
                Int64bigintE0M.AssertModel(models[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64SingleTypebigint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 22);
                var models =  ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(30));

                Int64bigintE0M.AssertModel(models[0],_testData[5], false);
                Int64bigintE0M.AssertModel(models[1],_testData[6], false);
                Int64bigintE0M.AssertModel(models[2],_testData[7], false);
                Int64bigintE0M.AssertModel(models[3],_testData[8], false);
                Int64bigintE0M.AssertModel(models[4],_testData[9], false);
                Int64bigintE0M.AssertModel(models[5],_testData[10], false);
                Int64bigintE0M.AssertModel(models[6],_testData[11], false);
                Int64bigintE0M.AssertModel(models[7],_testData[12], false);
                Int64bigintE0M.AssertModel(models[8],_testData[13], false);
                Int64bigintE0M.AssertModel(models[9],_testData[14], false);
                Int64bigintE0M.AssertModel(models[10],_testData[15], false);
                Int64bigintE0M.AssertModel(models[11],_testData[16], false);
                Int64bigintE0M.AssertModel(models[12],_testData[17], false);
                Int64bigintE0M.AssertModel(models[13],_testData[18], false);
                Int64bigintE0M.AssertModel(models[14],_testData[19], false);
                Int64bigintE0M.AssertModel(models[15],_testData[20], false);
                Int64bigintE0M.AssertModel(models[16],_testData[21], false);
                Int64bigintE0M.AssertModel(models[17],_testData[22], false);
                Int64bigintE0M.AssertModel(models[18],_testData[23], false);
                Int64bigintE0M.AssertModel(models[19],_testData[24], false);
                Int64bigintE0M.AssertModel(models[20],_testData[25], false);
                Int64bigintE0M.AssertModel(models[21],_testData[26], false);
                Int64bigintE0M.AssertModel(models[22],_testData[27], false);
                Int64bigintE0M.AssertModel(models[23],_testData[28], false);
                Int64bigintE0M.AssertModel(models[24],_testData[29], false);
                Int64bigintE0M.AssertModel(models[25],_testData[30], false);
                Int64bigintE0M.AssertModel(models[26],_testData[31], false);
                Int64bigintE0M.AssertModel(models[27],_testData[32], false);
                Int64bigintE0M.AssertModel(models[28],_testData[33], false);
                Int64bigintE0M.AssertModel(models[29],_testData[34], false);
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
FROM dbo.int64biginte0m m
LEFT JOIN dbo.int64biginte0mi mi ON mi.id = m.int64biginte0mi_id
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
            asPartInterface: typeof(IInt64SingleTypebigint))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64SingleTypebigint)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((20314249343425885L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((66918697049043845L)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7154815983488469488L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5769767926484126970L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((2529613196118791864L)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1715469913499088995L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5895881656869493756L)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6591247728526029047L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2829293278190669066L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4113344310927753636L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3354291314104068461L)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9010624158181598534L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2179404041121757687L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6577197864138135953L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5024743361922124356L)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((64435875280048159L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5869260456640479366L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6143158899667815297L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((6802044622225376559L)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6575408757478508686L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8474265743094435927L)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8519713972500015041L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2138791480292139245L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1102203392213749515L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4852878917106440758L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3670500552556222573L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((7832043697969816004L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2286616246193801625L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6687068024334297770L)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2615959935509207100L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8276438951081182824L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((705752499800941662L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((869994047324775927L)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8844638870104142704L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6692769474593945154L)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1078300791901340182L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1954537161168565512L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4496718483272659751L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6136078300988261262L)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((214241666211747735L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8892698859576019333L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4066085791519980794L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((3259850928579725379L)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8666197877587183572L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7865691446310288007L)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8563580406407615077L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4926781301898934232L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((969356810010457519L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2870284742526260602L)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6254228868603392154L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2849794168732477341L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((1930136326090540506L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7507774536359048269L)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((865756344029536065L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2781027132615947204L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7967324968871775715L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((5772555311137867328L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3616008798168945714L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6940646775922561686L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((73042105682059986L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((4063130445695714882L)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4155462625004524008L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4365428341705172387L)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1938052695693794237L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7217857937245309686L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2835531631661470479L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1748128648602639611L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3606747446712845408L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6076639031436008975L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7042083293661993034L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6398428316698297471L)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1592835744934197517L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((119128952855321798L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((192)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3225109428382889452L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((196)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6217354910090939482L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4305857418115878382L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((1049962662110331380L)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((202)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8728374895157654575L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((513017937574448473L)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt64SingleTypebigint)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((20314249343425885L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((66918697049043845L)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7154815983488469488L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5769767926484126970L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((2529613196118791864L)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1715469913499088995L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5895881656869493756L)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6591247728526029047L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2829293278190669066L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4113344310927753636L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3354291314104068461L)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9010624158181598534L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2179404041121757687L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6577197864138135953L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5024743361922124356L)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((64435875280048159L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5869260456640479366L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6143158899667815297L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((6802044622225376559L)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6575408757478508686L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8474265743094435927L)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8519713972500015041L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2138791480292139245L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1102203392213749515L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4852878917106440758L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3670500552556222573L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((7832043697969816004L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2286616246193801625L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6687068024334297770L)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2615959935509207100L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8276438951081182824L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((705752499800941662L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((869994047324775927L)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8844638870104142704L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6692769474593945154L)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1078300791901340182L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1954537161168565512L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4496718483272659751L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6136078300988261262L)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((214241666211747735L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8892698859576019333L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4066085791519980794L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((3259850928579725379L)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8666197877587183572L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7865691446310288007L)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8563580406407615077L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4926781301898934232L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((969356810010457519L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2870284742526260602L)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6254228868603392154L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2849794168732477341L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((1930136326090540506L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7507774536359048269L)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((865756344029536065L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2781027132615947204L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7967324968871775715L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((5772555311137867328L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3616008798168945714L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6940646775922561686L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((73042105682059986L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((4063130445695714882L)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4155462625004524008L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4365428341705172387L)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1938052695693794237L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7217857937245309686L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2835531631661470479L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1748128648602639611L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3606747446712845408L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6076639031436008975L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7042083293661993034L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6398428316698297471L)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1592835744934197517L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((119128952855321798L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((192)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3225109428382889452L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((196)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6217354910090939482L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4305857418115878382L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((1049962662110331380L)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((202)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8728374895157654575L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((513017937574448473L)));

            }
        }

#endregion

    }
}

