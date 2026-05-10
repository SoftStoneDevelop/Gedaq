

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
    internal partial interface IInt64SingleTypebigint
    {
    }
    
    internal partial class Int64SingleTypebigint : IInt64SingleTypebigint
    {


#region TestData

        private readonly Int64bigint0M[] _testData = new Int64bigint0M[]
        {
            new Int64bigint0M
{
    Id = 1,
    Value = 6220497954288008300L,
    ModelInner = null,
    NullableValue = 2228909869927602868L,
},
            new Int64bigint0M
{
    Id = 5,
    Value = 4618510688200149045L,
    ModelInner = new Int64bigint0MI
{
    Id = 7,
    Value = 2708864493483217117L,
    NullableValue = 2337845561051138432L,
},
    NullableValue = 6442004786957005204L,
},
            new Int64bigint0M
{
    Id = 11,
    Value = 1682357377921632494L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 12,
    Value = 3124298832564632303L,
    ModelInner = new Int64bigint0MI
{
    Id = 11,
    Value = 2274668880551334769L,
    NullableValue = 4893043806150524427L,
},
    NullableValue = 443337094008190855L,
},
            new Int64bigint0M
{
    Id = 19,
    Value = 4985164667156657692L,
    ModelInner = null,
    NullableValue = 5995511692497813803L,
},
            new Int64bigint0M
{
    Id = 20,
    Value = 593817918565261511L,
    ModelInner = new Int64bigint0MI
{
    Id = 16,
    Value = 3274595084289171396L,
    NullableValue = null,
},
    NullableValue = 24625731373223623L,
},
            new Int64bigint0M
{
    Id = 29,
    Value = 2944997167256769137L,
    ModelInner = null,
    NullableValue = 8230931709225704942L,
},
            new Int64bigint0M
{
    Id = 37,
    Value = 2408958189550046795L,
    ModelInner = new Int64bigint0MI
{
    Id = 18,
    Value = 4015183813478762569L,
    NullableValue = null,
},
    NullableValue = 6192983961948170846L,
},
            new Int64bigint0M
{
    Id = 39,
    Value = 4644156446092640488L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 44,
    Value = 3156915632496833451L,
    ModelInner = new Int64bigint0MI
{
    Id = 27,
    Value = 5143013971148423318L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 48,
    Value = 2579231090213607354L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 54,
    Value = 1371263545248383338L,
    ModelInner = new Int64bigint0MI
{
    Id = 32,
    Value = 3555510771357433242L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 58,
    Value = 2106002024943597362L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 66,
    Value = 1135953919880665508L,
    ModelInner = new Int64bigint0MI
{
    Id = 37,
    Value = 737024132437208476L,
    NullableValue = 4245670799162712962L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 70,
    Value = 3868204290655133702L,
    ModelInner = null,
    NullableValue = 1354318438839599903L,
},
            new Int64bigint0M
{
    Id = 79,
    Value = 2086268773232034739L,
    ModelInner = new Int64bigint0MI
{
    Id = 39,
    Value = 5589315050592268322L,
    NullableValue = 5887755383440340985L,
},
    NullableValue = 2818972174364099646L,
},
            new Int64bigint0M
{
    Id = 80,
    Value = 7417301168399992923L,
    ModelInner = null,
    NullableValue = 5159299930525768815L,
},
            new Int64bigint0M
{
    Id = 83,
    Value = 4651167642849792894L,
    ModelInner = new Int64bigint0MI
{
    Id = 48,
    Value = 6957812577829291546L,
    NullableValue = null,
},
    NullableValue = 1737333781539936057L,
},
            new Int64bigint0M
{
    Id = 89,
    Value = 6157687725057609324L,
    ModelInner = null,
    NullableValue = 6270732356221895056L,
},
            new Int64bigint0M
{
    Id = 91,
    Value = 5620902100726617495L,
    ModelInner = new Int64bigint0MI
{
    Id = 50,
    Value = 902305772499018045L,
    NullableValue = 2886259507775717469L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 97,
    Value = 3365600833261499215L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 102,
    Value = 7724128383944894912L,
    ModelInner = new Int64bigint0MI
{
    Id = 52,
    Value = 8068239443576312467L,
    NullableValue = null,
},
    NullableValue = 7727804753892964578L,
},
            new Int64bigint0M
{
    Id = 110,
    Value = 2740638460257358020L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 113,
    Value = 115832676899048315L,
    ModelInner = new Int64bigint0MI
{
    Id = 57,
    Value = 3491286612870078740L,
    NullableValue = 2724615698737385575L,
},
    NullableValue = 1885242025173963965L,
},
            new Int64bigint0M
{
    Id = 117,
    Value = 3996329941014009990L,
    ModelInner = null,
    NullableValue = 1464981410229910187L,
},
            new Int64bigint0M
{
    Id = 125,
    Value = 567537468095134681L,
    ModelInner = new Int64bigint0MI
{
    Id = 61,
    Value = 3273883482058416923L,
    NullableValue = 5772975248785766427L,
},
    NullableValue = 8767591161305189629L,
},
            new Int64bigint0M
{
    Id = 130,
    Value = 4412646149855975227L,
    ModelInner = null,
    NullableValue = 1963881284986430046L,
},
            new Int64bigint0M
{
    Id = 136,
    Value = 8271675572788934258L,
    ModelInner = new Int64bigint0MI
{
    Id = 69,
    Value = 407902160886125728L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 144,
    Value = 5333592459073534034L,
    ModelInner = null,
    NullableValue = 6975112253907285112L,
},
            new Int64bigint0M
{
    Id = 153,
    Value = 822085343928630377L,
    ModelInner = new Int64bigint0MI
{
    Id = 75,
    Value = 1056858045123979049L,
    NullableValue = 3393147797423407741L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 161,
    Value = 932440529196547361L,
    ModelInner = null,
    NullableValue = 7410001719040160751L,
},
            new Int64bigint0M
{
    Id = 170,
    Value = 1576335951090430729L,
    ModelInner = new Int64bigint0MI
{
    Id = 80,
    Value = 8006392406715501913L,
    NullableValue = null,
},
    NullableValue = 3534949724118848203L,
},
            new Int64bigint0M
{
    Id = 179,
    Value = 875012620085036172L,
    ModelInner = null,
    NullableValue = 8405820143261975237L,
},
            new Int64bigint0M
{
    Id = 184,
    Value = 8722320103611288112L,
    ModelInner = new Int64bigint0MI
{
    Id = 86,
    Value = 8351067405968229761L,
    NullableValue = null,
},
    NullableValue = 8132867949860369442L,
},
            new Int64bigint0M
{
    Id = 191,
    Value = 242908145539293198L,
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int64bigint0mi(
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
            asPartInterface: typeof(IInt64SingleTypebigint)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int64),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (MySqlConnector.MySqlDbType)(8)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (MySqlConnector.MySqlDbType)(8))]
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
INSERT INTO gedaqtests.int64bigint0mi(
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
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(12)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(12), 
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

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int64bigint0m(
	id,
    value,
    nullablevalue,
    int64bigint0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int64bigint0mi_id
)
",
            methodName:"InsertModel",
            sourceType: SourceType.MySqlConnection,
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int64), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (MySqlConnector.MySqlDbType)(8)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (MySqlConnector.MySqlDbType)(8),
                nullable: true),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int64bigint0mi_id", 
                methodParametrName: "int64bigint0mi_id", 
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
INSERT INTO gedaqtests.int64bigint0m(
	id,
    value,
    nullablevalue,
    int64bigint0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int64bigint0mi_id
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
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int64), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(12)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(12),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int64bigint0mi_id", 
                methodParametrName: "int64bigint0mi_id", 
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

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigint0M), typeof(FlatInt64bigint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM gedaqtests.int64bigint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                await((IInt64SingleTypebigint)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigint0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.int64bigint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                ((IInt64SingleTypebigint)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM gedaqtests.int64bigint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = await((IInt64SingleTypebigint)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int64bigint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = ((IInt64SingleTypebigint)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int64bigint0m m
LEFT JOIN gedaqtests.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
                var models = await((IInt64SingleTypebigint)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt64SingleTypebigint)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigint0M), typeof(FlatInt64bigint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM gedaqtests.int64bigint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                await((IInt64SingleTypebigint)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigint0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.int64bigint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                ((IInt64SingleTypebigint)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM gedaqtests.int64bigint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64SingleTypebigint)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int64bigint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64SingleTypebigint)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int64bigint0m m
LEFT JOIN gedaqtests.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
                var models = await((IInt64SingleTypebigint)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
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
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigint0M), typeof(FlatInt64bigint0M)],
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                await((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigint0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 117;
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[34], false);
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigint0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[27],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigint0M)],
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
FROM gedaqtests.int64bigint0m m
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
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 58;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
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
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(models[17],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(models[18],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(models[19],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(models[20],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM gedaqtests.int64bigint0m m
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
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 48;
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
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
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[17],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[18],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(models[19],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(models[20],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(models[21],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(models[22],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM gedaqtests.int64bigint0m m
LEFT JOIN gedaqtests.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int64bigint0M)],
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
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Int64bigint0M.AssertModel(models[0],_testData[15], false);
                        Int64bigint0M.AssertModel(models[1],_testData[16], false);
                        Int64bigint0M.AssertModel(models[2],_testData[17], false);
                        Int64bigint0M.AssertModel(models[3],_testData[18], false);
                        Int64bigint0M.AssertModel(models[4],_testData[19], false);
                        Int64bigint0M.AssertModel(models[5],_testData[20], false);
                        Int64bigint0M.AssertModel(models[6],_testData[21], false);
                        Int64bigint0M.AssertModel(models[7],_testData[22], false);
                        Int64bigint0M.AssertModel(models[8],_testData[23], false);
                        Int64bigint0M.AssertModel(models[9],_testData[24], false);
                        Int64bigint0M.AssertModel(models[10],_testData[25], false);
                        Int64bigint0M.AssertModel(models[11],_testData[26], false);
                        Int64bigint0M.AssertModel(models[12],_testData[27], false);
                        Int64bigint0M.AssertModel(models[13],_testData[28], false);
                        Int64bigint0M.AssertModel(models[14],_testData[29], false);
                        Int64bigint0M.AssertModel(models[15],_testData[30], false);
                        Int64bigint0M.AssertModel(models[16],_testData[31], false);
                        Int64bigint0M.AssertModel(models[17],_testData[32], false);
                        Int64bigint0M.AssertModel(models[18],_testData[33], false);
                        Int64bigint0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Int64bigint0M.AssertModel(models[0],_testData[7], false);
                        Int64bigint0M.AssertModel(models[1],_testData[8], false);
                        Int64bigint0M.AssertModel(models[2],_testData[9], false);
                        Int64bigint0M.AssertModel(models[3],_testData[10], false);
                        Int64bigint0M.AssertModel(models[4],_testData[11], false);
                        Int64bigint0M.AssertModel(models[5],_testData[12], false);
                        Int64bigint0M.AssertModel(models[6],_testData[13], false);
                        Int64bigint0M.AssertModel(models[7],_testData[14], false);
                        Int64bigint0M.AssertModel(models[8],_testData[15], false);
                        Int64bigint0M.AssertModel(models[9],_testData[16], false);
                        Int64bigint0M.AssertModel(models[10],_testData[17], false);
                        Int64bigint0M.AssertModel(models[11],_testData[18], false);
                        Int64bigint0M.AssertModel(models[12],_testData[19], false);
                        Int64bigint0M.AssertModel(models[13],_testData[20], false);
                        Int64bigint0M.AssertModel(models[14],_testData[21], false);
                        Int64bigint0M.AssertModel(models[15],_testData[22], false);
                        Int64bigint0M.AssertModel(models[16],_testData[23], false);
                        Int64bigint0M.AssertModel(models[17],_testData[24], false);
                        Int64bigint0M.AssertModel(models[18],_testData[25], false);
                        Int64bigint0M.AssertModel(models[19],_testData[26], false);
                        Int64bigint0M.AssertModel(models[20],_testData[27], false);
                        Int64bigint0M.AssertModel(models[21],_testData[28], false);
                        Int64bigint0M.AssertModel(models[22],_testData[29], false);
                        Int64bigint0M.AssertModel(models[23],_testData[30], false);
                        Int64bigint0M.AssertModel(models[24],_testData[31], false);
                        Int64bigint0M.AssertModel(models[25],_testData[32], false);
                        Int64bigint0M.AssertModel(models[26],_testData[33], false);
                        Int64bigint0M.AssertModel(models[27],_testData[34], false);
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
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 161;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Int64bigint0M.AssertModel(models[0],_testData[9], false);
                        Int64bigint0M.AssertModel(models[1],_testData[10], false);
                        Int64bigint0M.AssertModel(models[2],_testData[11], false);
                        Int64bigint0M.AssertModel(models[3],_testData[12], false);
                        Int64bigint0M.AssertModel(models[4],_testData[13], false);
                        Int64bigint0M.AssertModel(models[5],_testData[14], false);
                        Int64bigint0M.AssertModel(models[6],_testData[15], false);
                        Int64bigint0M.AssertModel(models[7],_testData[16], false);
                        Int64bigint0M.AssertModel(models[8],_testData[17], false);
                        Int64bigint0M.AssertModel(models[9],_testData[18], false);
                        Int64bigint0M.AssertModel(models[10],_testData[19], false);
                        Int64bigint0M.AssertModel(models[11],_testData[20], false);
                        Int64bigint0M.AssertModel(models[12],_testData[21], false);
                        Int64bigint0M.AssertModel(models[13],_testData[22], false);
                        Int64bigint0M.AssertModel(models[14],_testData[23], false);
                        Int64bigint0M.AssertModel(models[15],_testData[24], false);
                        Int64bigint0M.AssertModel(models[16],_testData[25], false);
                        Int64bigint0M.AssertModel(models[17],_testData[26], false);
                        Int64bigint0M.AssertModel(models[18],_testData[27], false);
                        Int64bigint0M.AssertModel(models[19],_testData[28], false);
                        Int64bigint0M.AssertModel(models[20],_testData[29], false);
                        Int64bigint0M.AssertModel(models[21],_testData[30], false);
                        Int64bigint0M.AssertModel(models[22],_testData[31], false);
                        Int64bigint0M.AssertModel(models[23],_testData[32], false);
                        Int64bigint0M.AssertModel(models[24],_testData[33], false);
                        Int64bigint0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Int64bigint0M.AssertModel(models[0],_testData[31], false);
                        Int64bigint0M.AssertModel(models[1],_testData[32], false);
                        Int64bigint0M.AssertModel(models[2],_testData[33], false);
                        Int64bigint0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigint0M), typeof(FlatInt64bigint0M)],
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
            dbType: (System.Data.DbType)(11))]
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                await((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigint0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 153, query1, 44, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 136, query1, 102, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[34], false);
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigint0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 20, query1, 66, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 110, query1, 29, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[27],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigint0M)],
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
            dbType: (System.Data.DbType)(11))]
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 125, query1, 91, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[34], false);
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 80, query1, 54, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 89, query1, 48, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[17],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[18],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(models[19],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(models[20],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(models[21],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(models[22],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(models[23],_testData[34], false);
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatch(connection, 44, query1, 79, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM gedaqtests.int64bigint0m m
LEFT JOIN gedaqtests.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int64bigint0M)],
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
            dbType: (System.Data.DbType)(11))]
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
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatchAsync(connection, 48, 161))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Int64bigint0M.AssertModel(models[0],_testData[11], false);
                        Int64bigint0M.AssertModel(models[1],_testData[12], false);
                        Int64bigint0M.AssertModel(models[2],_testData[13], false);
                        Int64bigint0M.AssertModel(models[3],_testData[14], false);
                        Int64bigint0M.AssertModel(models[4],_testData[15], false);
                        Int64bigint0M.AssertModel(models[5],_testData[16], false);
                        Int64bigint0M.AssertModel(models[6],_testData[17], false);
                        Int64bigint0M.AssertModel(models[7],_testData[18], false);
                        Int64bigint0M.AssertModel(models[8],_testData[19], false);
                        Int64bigint0M.AssertModel(models[9],_testData[20], false);
                        Int64bigint0M.AssertModel(models[10],_testData[21], false);
                        Int64bigint0M.AssertModel(models[11],_testData[22], false);
                        Int64bigint0M.AssertModel(models[12],_testData[23], false);
                        Int64bigint0M.AssertModel(models[13],_testData[24], false);
                        Int64bigint0M.AssertModel(models[14],_testData[25], false);
                        Int64bigint0M.AssertModel(models[15],_testData[26], false);
                        Int64bigint0M.AssertModel(models[16],_testData[27], false);
                        Int64bigint0M.AssertModel(models[17],_testData[28], false);
                        Int64bigint0M.AssertModel(models[18],_testData[29], false);
                        Int64bigint0M.AssertModel(models[19],_testData[30], false);
                        Int64bigint0M.AssertModel(models[20],_testData[31], false);
                        Int64bigint0M.AssertModel(models[21],_testData[32], false);
                        Int64bigint0M.AssertModel(models[22],_testData[33], false);
                        Int64bigint0M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Int64bigint0M.AssertModel(models[0],_testData[31], false);
                        Int64bigint0M.AssertModel(models[1],_testData[32], false);
                        Int64bigint0M.AssertModel(models[2],_testData[33], false);
                        Int64bigint0M.AssertModel(models[3],_testData[34], false);
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
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatch(connection, 37, 66))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Int64bigint0M.AssertModel(models[0],_testData[8], false);
                        Int64bigint0M.AssertModel(models[1],_testData[9], false);
                        Int64bigint0M.AssertModel(models[2],_testData[10], false);
                        Int64bigint0M.AssertModel(models[3],_testData[11], false);
                        Int64bigint0M.AssertModel(models[4],_testData[12], false);
                        Int64bigint0M.AssertModel(models[5],_testData[13], false);
                        Int64bigint0M.AssertModel(models[6],_testData[14], false);
                        Int64bigint0M.AssertModel(models[7],_testData[15], false);
                        Int64bigint0M.AssertModel(models[8],_testData[16], false);
                        Int64bigint0M.AssertModel(models[9],_testData[17], false);
                        Int64bigint0M.AssertModel(models[10],_testData[18], false);
                        Int64bigint0M.AssertModel(models[11],_testData[19], false);
                        Int64bigint0M.AssertModel(models[12],_testData[20], false);
                        Int64bigint0M.AssertModel(models[13],_testData[21], false);
                        Int64bigint0M.AssertModel(models[14],_testData[22], false);
                        Int64bigint0M.AssertModel(models[15],_testData[23], false);
                        Int64bigint0M.AssertModel(models[16],_testData[24], false);
                        Int64bigint0M.AssertModel(models[17],_testData[25], false);
                        Int64bigint0M.AssertModel(models[18],_testData[26], false);
                        Int64bigint0M.AssertModel(models[19],_testData[27], false);
                        Int64bigint0M.AssertModel(models[20],_testData[28], false);
                        Int64bigint0M.AssertModel(models[21],_testData[29], false);
                        Int64bigint0M.AssertModel(models[22],_testData[30], false);
                        Int64bigint0M.AssertModel(models[23],_testData[31], false);
                        Int64bigint0M.AssertModel(models[24],_testData[32], false);
                        Int64bigint0M.AssertModel(models[25],_testData[33], false);
                        Int64bigint0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Int64bigint0M.AssertModel(models[0],_testData[14], false);
                        Int64bigint0M.AssertModel(models[1],_testData[15], false);
                        Int64bigint0M.AssertModel(models[2],_testData[16], false);
                        Int64bigint0M.AssertModel(models[3],_testData[17], false);
                        Int64bigint0M.AssertModel(models[4],_testData[18], false);
                        Int64bigint0M.AssertModel(models[5],_testData[19], false);
                        Int64bigint0M.AssertModel(models[6],_testData[20], false);
                        Int64bigint0M.AssertModel(models[7],_testData[21], false);
                        Int64bigint0M.AssertModel(models[8],_testData[22], false);
                        Int64bigint0M.AssertModel(models[9],_testData[23], false);
                        Int64bigint0M.AssertModel(models[10],_testData[24], false);
                        Int64bigint0M.AssertModel(models[11],_testData[25], false);
                        Int64bigint0M.AssertModel(models[12],_testData[26], false);
                        Int64bigint0M.AssertModel(models[13],_testData[27], false);
                        Int64bigint0M.AssertModel(models[14],_testData[28], false);
                        Int64bigint0M.AssertModel(models[15],_testData[29], false);
                        Int64bigint0M.AssertModel(models[16],_testData[30], false);
                        Int64bigint0M.AssertModel(models[17],_testData[31], false);
                        Int64bigint0M.AssertModel(models[18],_testData[32], false);
                        Int64bigint0M.AssertModel(models[19],_testData[33], false);
                        Int64bigint0M.AssertModel(models[20],_testData[34], false);
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
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 1);
                var models = await ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

                Int64bigint0M.AssertModel(models[0],_testData[1], false);
                Int64bigint0M.AssertModel(models[1],_testData[2], false);
                Int64bigint0M.AssertModel(models[2],_testData[3], false);
                Int64bigint0M.AssertModel(models[3],_testData[4], false);
                Int64bigint0M.AssertModel(models[4],_testData[5], false);
                Int64bigint0M.AssertModel(models[5],_testData[6], false);
                Int64bigint0M.AssertModel(models[6],_testData[7], false);
                Int64bigint0M.AssertModel(models[7],_testData[8], false);
                Int64bigint0M.AssertModel(models[8],_testData[9], false);
                Int64bigint0M.AssertModel(models[9],_testData[10], false);
                Int64bigint0M.AssertModel(models[10],_testData[11], false);
                Int64bigint0M.AssertModel(models[11],_testData[12], false);
                Int64bigint0M.AssertModel(models[12],_testData[13], false);
                Int64bigint0M.AssertModel(models[13],_testData[14], false);
                Int64bigint0M.AssertModel(models[14],_testData[15], false);
                Int64bigint0M.AssertModel(models[15],_testData[16], false);
                Int64bigint0M.AssertModel(models[16],_testData[17], false);
                Int64bigint0M.AssertModel(models[17],_testData[18], false);
                Int64bigint0M.AssertModel(models[18],_testData[19], false);
                Int64bigint0M.AssertModel(models[19],_testData[20], false);
                Int64bigint0M.AssertModel(models[20],_testData[21], false);
                Int64bigint0M.AssertModel(models[21],_testData[22], false);
                Int64bigint0M.AssertModel(models[22],_testData[23], false);
                Int64bigint0M.AssertModel(models[23],_testData[24], false);
                Int64bigint0M.AssertModel(models[24],_testData[25], false);
                Int64bigint0M.AssertModel(models[25],_testData[26], false);
                Int64bigint0M.AssertModel(models[26],_testData[27], false);
                Int64bigint0M.AssertModel(models[27],_testData[28], false);
                Int64bigint0M.AssertModel(models[28],_testData[29], false);
                Int64bigint0M.AssertModel(models[29],_testData[30], false);
                Int64bigint0M.AssertModel(models[30],_testData[31], false);
                Int64bigint0M.AssertModel(models[31],_testData[32], false);
                Int64bigint0M.AssertModel(models[32],_testData[33], false);
                Int64bigint0M.AssertModel(models[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64SingleTypebigint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 136);
                var models =  ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                Int64bigint0M.AssertModel(models[0],_testData[28], false);
                Int64bigint0M.AssertModel(models[1],_testData[29], false);
                Int64bigint0M.AssertModel(models[2],_testData[30], false);
                Int64bigint0M.AssertModel(models[3],_testData[31], false);
                Int64bigint0M.AssertModel(models[4],_testData[32], false);
                Int64bigint0M.AssertModel(models[5],_testData[33], false);
                Int64bigint0M.AssertModel(models[6],_testData[34], false);
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
FROM gedaqtests.int64bigint0m m
LEFT JOIN gedaqtests.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
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
                Assert.That((System.Int64)model[1], Is.EqualTo((6220497954288008300L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2228909869927602868L)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4618510688200149045L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2708864493483217117L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2337845561051138432L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6442004786957005204L)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1682357377921632494L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3124298832564632303L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2274668880551334769L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4893043806150524427L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((443337094008190855L)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4985164667156657692L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5995511692497813803L)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((593817918565261511L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3274595084289171396L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((24625731373223623L)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2944997167256769137L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8230931709225704942L)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2408958189550046795L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4015183813478762569L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((6192983961948170846L)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4644156446092640488L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3156915632496833451L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5143013971148423318L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2579231090213607354L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1371263545248383338L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3555510771357433242L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2106002024943597362L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1135953919880665508L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((737024132437208476L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4245670799162712962L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3868204290655133702L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1354318438839599903L)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2086268773232034739L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5589315050592268322L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((5887755383440340985L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2818972174364099646L)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7417301168399992923L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5159299930525768815L)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4651167642849792894L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6957812577829291546L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((1737333781539936057L)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6157687725057609324L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6270732356221895056L)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5620902100726617495L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((902305772499018045L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2886259507775717469L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3365600833261499215L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7724128383944894912L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8068239443576312467L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((7727804753892964578L)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2740638460257358020L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((115832676899048315L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3491286612870078740L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2724615698737385575L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1885242025173963965L)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3996329941014009990L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1464981410229910187L)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((567537468095134681L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3273883482058416923L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((5772975248785766427L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8767591161305189629L)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4412646149855975227L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1963881284986430046L)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8271675572788934258L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((407902160886125728L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5333592459073534034L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6975112253907285112L)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((822085343928630377L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1056858045123979049L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((3393147797423407741L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((932440529196547361L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7410001719040160751L)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1576335951090430729L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8006392406715501913L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((3534949724118848203L)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((875012620085036172L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8405820143261975237L)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((184)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8722320103611288112L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8351067405968229761L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((8132867949860369442L)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((191)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((242908145539293198L)));//Value

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
                var models =  ((IInt64SingleTypebigint)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6220497954288008300L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2228909869927602868L)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4618510688200149045L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2708864493483217117L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2337845561051138432L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6442004786957005204L)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1682357377921632494L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3124298832564632303L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2274668880551334769L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4893043806150524427L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((443337094008190855L)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4985164667156657692L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5995511692497813803L)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((593817918565261511L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3274595084289171396L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((24625731373223623L)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2944997167256769137L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8230931709225704942L)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2408958189550046795L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4015183813478762569L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((6192983961948170846L)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4644156446092640488L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3156915632496833451L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5143013971148423318L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2579231090213607354L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1371263545248383338L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3555510771357433242L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2106002024943597362L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1135953919880665508L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((737024132437208476L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4245670799162712962L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3868204290655133702L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1354318438839599903L)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2086268773232034739L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5589315050592268322L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((5887755383440340985L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2818972174364099646L)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7417301168399992923L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5159299930525768815L)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4651167642849792894L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6957812577829291546L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((1737333781539936057L)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6157687725057609324L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6270732356221895056L)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5620902100726617495L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((902305772499018045L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2886259507775717469L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3365600833261499215L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7724128383944894912L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8068239443576312467L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((7727804753892964578L)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2740638460257358020L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((115832676899048315L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3491286612870078740L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2724615698737385575L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1885242025173963965L)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3996329941014009990L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1464981410229910187L)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((567537468095134681L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3273883482058416923L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((5772975248785766427L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8767591161305189629L)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4412646149855975227L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1963881284986430046L)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8271675572788934258L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((407902160886125728L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5333592459073534034L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6975112253907285112L)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((822085343928630377L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1056858045123979049L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((3393147797423407741L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((932440529196547361L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7410001719040160751L)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1576335951090430729L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8006392406715501913L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((3534949724118848203L)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((875012620085036172L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8405820143261975237L)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((184)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8722320103611288112L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8351067405968229761L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((8132867949860369442L)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((191)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((242908145539293198L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

