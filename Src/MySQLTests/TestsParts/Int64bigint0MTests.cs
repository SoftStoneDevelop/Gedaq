

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
    Id = 3,
    Value = 9036065239536434760L,
    ModelInner = null,
    NullableValue = 6176986580257322151L,
},
            new Int64bigint0M
{
    Id = 10,
    Value = 5090886085854831183L,
    ModelInner = new Int64bigint0MI
{
    Id = 9,
    Value = 8007980081869650792L,
    NullableValue = null,
},
    NullableValue = 5013119904117212243L,
},
            new Int64bigint0M
{
    Id = 17,
    Value = 100875876074730584L,
    ModelInner = null,
    NullableValue = 4183168088002841061L,
},
            new Int64bigint0M
{
    Id = 25,
    Value = 4675064376950280531L,
    ModelInner = new Int64bigint0MI
{
    Id = 15,
    Value = 2866538495758491387L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 29,
    Value = 7190554099876998828L,
    ModelInner = null,
    NullableValue = 2767782735669902548L,
},
            new Int64bigint0M
{
    Id = 33,
    Value = 6186165664162682157L,
    ModelInner = new Int64bigint0MI
{
    Id = 22,
    Value = 4439380537505752359L,
    NullableValue = 6008135808024293888L,
},
    NullableValue = 1724568204340613609L,
},
            new Int64bigint0M
{
    Id = 37,
    Value = 238791089742719893L,
    ModelInner = null,
    NullableValue = 1345959080442267152L,
},
            new Int64bigint0M
{
    Id = 41,
    Value = 6674958073552862763L,
    ModelInner = new Int64bigint0MI
{
    Id = 25,
    Value = 174738705398297642L,
    NullableValue = 2573519905107406944L,
},
    NullableValue = 8529162143032816886L,
},
            new Int64bigint0M
{
    Id = 47,
    Value = 4377491836437444286L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 52,
    Value = 3599325310681465949L,
    ModelInner = new Int64bigint0MI
{
    Id = 31,
    Value = 4039016787524206528L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 60,
    Value = 4888453184978223038L,
    ModelInner = null,
    NullableValue = 6733269502003316319L,
},
            new Int64bigint0M
{
    Id = 61,
    Value = 6217872162067104293L,
    ModelInner = new Int64bigint0MI
{
    Id = 33,
    Value = 7824086736307493829L,
    NullableValue = 609525909572501625L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 69,
    Value = 7194886990882869149L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 78,
    Value = 8654097154245609794L,
    ModelInner = new Int64bigint0MI
{
    Id = 35,
    Value = 2788697792660681399L,
    NullableValue = null,
},
    NullableValue = 4594424932187973935L,
},
            new Int64bigint0M
{
    Id = 81,
    Value = 6224075821429489962L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 89,
    Value = 4715855913717333849L,
    ModelInner = new Int64bigint0MI
{
    Id = 41,
    Value = 447576486799461712L,
    NullableValue = null,
},
    NullableValue = 42316627758417622L,
},
            new Int64bigint0M
{
    Id = 96,
    Value = 6799175733006075565L,
    ModelInner = null,
    NullableValue = 3142641448508157620L,
},
            new Int64bigint0M
{
    Id = 102,
    Value = 2879470988071521359L,
    ModelInner = new Int64bigint0MI
{
    Id = 43,
    Value = 4444753819676118376L,
    NullableValue = 3108534943996943109L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 103,
    Value = 1940946101017307973L,
    ModelInner = null,
    NullableValue = 5678098258862291336L,
},
            new Int64bigint0M
{
    Id = 110,
    Value = 5433576469848919449L,
    ModelInner = new Int64bigint0MI
{
    Id = 51,
    Value = 6708043079669877623L,
    NullableValue = null,
},
    NullableValue = 6763419618645107699L,
},
            new Int64bigint0M
{
    Id = 117,
    Value = 6832674103339599219L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 123,
    Value = 4134850726832694043L,
    ModelInner = new Int64bigint0MI
{
    Id = 57,
    Value = 4329128890918722374L,
    NullableValue = null,
},
    NullableValue = 7835577441044591842L,
},
            new Int64bigint0M
{
    Id = 125,
    Value = 8008475610822626863L,
    ModelInner = null,
    NullableValue = 6466274841079579161L,
},
            new Int64bigint0M
{
    Id = 127,
    Value = 2138138807173173316L,
    ModelInner = new Int64bigint0MI
{
    Id = 61,
    Value = 5918473568796433170L,
    NullableValue = null,
},
    NullableValue = 1412661418912347766L,
},
            new Int64bigint0M
{
    Id = 133,
    Value = 3603764876804991985L,
    ModelInner = null,
    NullableValue = 944349386248059297L,
},
            new Int64bigint0M
{
    Id = 139,
    Value = 3344710265663505728L,
    ModelInner = new Int64bigint0MI
{
    Id = 67,
    Value = 4553298430746252473L,
    NullableValue = null,
},
    NullableValue = 2582438998693517204L,
},
            new Int64bigint0M
{
    Id = 144,
    Value = 154660935423078094L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 149,
    Value = 292365296369006848L,
    ModelInner = new Int64bigint0MI
{
    Id = 76,
    Value = 1033715717122874818L,
    NullableValue = 2150245471681167328L,
},
    NullableValue = 3655267113692636192L,
},
            new Int64bigint0M
{
    Id = 151,
    Value = 5029794892876031671L,
    ModelInner = null,
    NullableValue = 4728283652757982781L,
},
            new Int64bigint0M
{
    Id = 160,
    Value = 6659387048465300899L,
    ModelInner = new Int64bigint0MI
{
    Id = 78,
    Value = 2079031867171543904L,
    NullableValue = 8236269324085801705L,
},
    NullableValue = 3491274286504592471L,
},
            new Int64bigint0M
{
    Id = 163,
    Value = 5615030501482559188L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 164,
    Value = 7689321741489197700L,
    ModelInner = new Int64bigint0MI
{
    Id = 82,
    Value = 1226662166435117460L,
    NullableValue = 3661976308341585572L,
},
    NullableValue = 2382743301751399272L,
},
            new Int64bigint0M
{
    Id = 172,
    Value = 3458308577893234679L,
    ModelInner = null,
    NullableValue = 4301437148732019869L,
},
            new Int64bigint0M
{
    Id = 179,
    Value = 2121633099081132574L,
    ModelInner = new Int64bigint0MI
{
    Id = 91,
    Value = 4321625954182708053L,
    NullableValue = 8583072867382692281L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 180,
    Value = 3706441629254749783L,
    ModelInner = null,
    NullableValue = 8433293149275900541L,
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
                parametr1.Value = 163;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[27],_testData[34], false);
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
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
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[22],_testData[34], false);
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
                parametr1.Value = 149;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 172;
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
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 78;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[34], false);
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
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
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[17],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[18],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[19],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[20],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[21],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[22],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[23],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(models[24],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(models[25],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(models[26],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(models[27],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[1], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[2], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[17],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[18],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[19],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[20],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[21],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[22],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[23],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[24],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[25],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[26],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[27],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[28],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(models[29],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(models[30],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(models[31],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(models[32],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 3;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[26],_testData[34], false);
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
                parametr1.Value = 3;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 164;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int64bigint0M.AssertModel(models[0],_testData[32], false);
                        Int64bigint0M.AssertModel(models[1],_testData[33], false);
                        Int64bigint0M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Int64bigint0M.AssertModel(models[0],_testData[22], false);
                        Int64bigint0M.AssertModel(models[1],_testData[23], false);
                        Int64bigint0M.AssertModel(models[2],_testData[24], false);
                        Int64bigint0M.AssertModel(models[3],_testData[25], false);
                        Int64bigint0M.AssertModel(models[4],_testData[26], false);
                        Int64bigint0M.AssertModel(models[5],_testData[27], false);
                        Int64bigint0M.AssertModel(models[6],_testData[28], false);
                        Int64bigint0M.AssertModel(models[7],_testData[29], false);
                        Int64bigint0M.AssertModel(models[8],_testData[30], false);
                        Int64bigint0M.AssertModel(models[9],_testData[31], false);
                        Int64bigint0M.AssertModel(models[10],_testData[32], false);
                        Int64bigint0M.AssertModel(models[11],_testData[33], false);
                        Int64bigint0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Int64bigint0M.AssertModel(models[0],_testData[10], false);
                        Int64bigint0M.AssertModel(models[1],_testData[11], false);
                        Int64bigint0M.AssertModel(models[2],_testData[12], false);
                        Int64bigint0M.AssertModel(models[3],_testData[13], false);
                        Int64bigint0M.AssertModel(models[4],_testData[14], false);
                        Int64bigint0M.AssertModel(models[5],_testData[15], false);
                        Int64bigint0M.AssertModel(models[6],_testData[16], false);
                        Int64bigint0M.AssertModel(models[7],_testData[17], false);
                        Int64bigint0M.AssertModel(models[8],_testData[18], false);
                        Int64bigint0M.AssertModel(models[9],_testData[19], false);
                        Int64bigint0M.AssertModel(models[10],_testData[20], false);
                        Int64bigint0M.AssertModel(models[11],_testData[21], false);
                        Int64bigint0M.AssertModel(models[12],_testData[22], false);
                        Int64bigint0M.AssertModel(models[13],_testData[23], false);
                        Int64bigint0M.AssertModel(models[14],_testData[24], false);
                        Int64bigint0M.AssertModel(models[15],_testData[25], false);
                        Int64bigint0M.AssertModel(models[16],_testData[26], false);
                        Int64bigint0M.AssertModel(models[17],_testData[27], false);
                        Int64bigint0M.AssertModel(models[18],_testData[28], false);
                        Int64bigint0M.AssertModel(models[19],_testData[29], false);
                        Int64bigint0M.AssertModel(models[20],_testData[30], false);
                        Int64bigint0M.AssertModel(models[21],_testData[31], false);
                        Int64bigint0M.AssertModel(models[22],_testData[32], false);
                        Int64bigint0M.AssertModel(models[23],_testData[33], false);
                        Int64bigint0M.AssertModel(models[24],_testData[34], false);
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
                await ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 29, query1, 102, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[34], false);
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
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 41, query1, 3, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[33],_testData[34], false);
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
                 ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 123, query1, 151, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[34], false);
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
                 ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 3, query1, 89, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 41, query1, 172, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[17],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[18],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[19],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[20],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[21],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(models[22],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(models[23],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(models[24],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(models[25],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[34], false);
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
                await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 164, query1, 110, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 60, query1, 103, query2))
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
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatch(connection, 160, query1, 133, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatchAsync(connection, 29, 117))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        Int64bigint0M.AssertModel(models[0],_testData[5], false);
                        Int64bigint0M.AssertModel(models[1],_testData[6], false);
                        Int64bigint0M.AssertModel(models[2],_testData[7], false);
                        Int64bigint0M.AssertModel(models[3],_testData[8], false);
                        Int64bigint0M.AssertModel(models[4],_testData[9], false);
                        Int64bigint0M.AssertModel(models[5],_testData[10], false);
                        Int64bigint0M.AssertModel(models[6],_testData[11], false);
                        Int64bigint0M.AssertModel(models[7],_testData[12], false);
                        Int64bigint0M.AssertModel(models[8],_testData[13], false);
                        Int64bigint0M.AssertModel(models[9],_testData[14], false);
                        Int64bigint0M.AssertModel(models[10],_testData[15], false);
                        Int64bigint0M.AssertModel(models[11],_testData[16], false);
                        Int64bigint0M.AssertModel(models[12],_testData[17], false);
                        Int64bigint0M.AssertModel(models[13],_testData[18], false);
                        Int64bigint0M.AssertModel(models[14],_testData[19], false);
                        Int64bigint0M.AssertModel(models[15],_testData[20], false);
                        Int64bigint0M.AssertModel(models[16],_testData[21], false);
                        Int64bigint0M.AssertModel(models[17],_testData[22], false);
                        Int64bigint0M.AssertModel(models[18],_testData[23], false);
                        Int64bigint0M.AssertModel(models[19],_testData[24], false);
                        Int64bigint0M.AssertModel(models[20],_testData[25], false);
                        Int64bigint0M.AssertModel(models[21],_testData[26], false);
                        Int64bigint0M.AssertModel(models[22],_testData[27], false);
                        Int64bigint0M.AssertModel(models[23],_testData[28], false);
                        Int64bigint0M.AssertModel(models[24],_testData[29], false);
                        Int64bigint0M.AssertModel(models[25],_testData[30], false);
                        Int64bigint0M.AssertModel(models[26],_testData[31], false);
                        Int64bigint0M.AssertModel(models[27],_testData[32], false);
                        Int64bigint0M.AssertModel(models[28],_testData[33], false);
                        Int64bigint0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Int64bigint0M.AssertModel(models[0],_testData[21], false);
                        Int64bigint0M.AssertModel(models[1],_testData[22], false);
                        Int64bigint0M.AssertModel(models[2],_testData[23], false);
                        Int64bigint0M.AssertModel(models[3],_testData[24], false);
                        Int64bigint0M.AssertModel(models[4],_testData[25], false);
                        Int64bigint0M.AssertModel(models[5],_testData[26], false);
                        Int64bigint0M.AssertModel(models[6],_testData[27], false);
                        Int64bigint0M.AssertModel(models[7],_testData[28], false);
                        Int64bigint0M.AssertModel(models[8],_testData[29], false);
                        Int64bigint0M.AssertModel(models[9],_testData[30], false);
                        Int64bigint0M.AssertModel(models[10],_testData[31], false);
                        Int64bigint0M.AssertModel(models[11],_testData[32], false);
                        Int64bigint0M.AssertModel(models[12],_testData[33], false);
                        Int64bigint0M.AssertModel(models[13],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatch(connection, 89, 123))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Int64bigint0M.AssertModel(models[0],_testData[16], false);
                        Int64bigint0M.AssertModel(models[1],_testData[17], false);
                        Int64bigint0M.AssertModel(models[2],_testData[18], false);
                        Int64bigint0M.AssertModel(models[3],_testData[19], false);
                        Int64bigint0M.AssertModel(models[4],_testData[20], false);
                        Int64bigint0M.AssertModel(models[5],_testData[21], false);
                        Int64bigint0M.AssertModel(models[6],_testData[22], false);
                        Int64bigint0M.AssertModel(models[7],_testData[23], false);
                        Int64bigint0M.AssertModel(models[8],_testData[24], false);
                        Int64bigint0M.AssertModel(models[9],_testData[25], false);
                        Int64bigint0M.AssertModel(models[10],_testData[26], false);
                        Int64bigint0M.AssertModel(models[11],_testData[27], false);
                        Int64bigint0M.AssertModel(models[12],_testData[28], false);
                        Int64bigint0M.AssertModel(models[13],_testData[29], false);
                        Int64bigint0M.AssertModel(models[14],_testData[30], false);
                        Int64bigint0M.AssertModel(models[15],_testData[31], false);
                        Int64bigint0M.AssertModel(models[16],_testData[32], false);
                        Int64bigint0M.AssertModel(models[17],_testData[33], false);
                        Int64bigint0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Int64bigint0M.AssertModel(models[0],_testData[22], false);
                        Int64bigint0M.AssertModel(models[1],_testData[23], false);
                        Int64bigint0M.AssertModel(models[2],_testData[24], false);
                        Int64bigint0M.AssertModel(models[3],_testData[25], false);
                        Int64bigint0M.AssertModel(models[4],_testData[26], false);
                        Int64bigint0M.AssertModel(models[5],_testData[27], false);
                        Int64bigint0M.AssertModel(models[6],_testData[28], false);
                        Int64bigint0M.AssertModel(models[7],_testData[29], false);
                        Int64bigint0M.AssertModel(models[8],_testData[30], false);
                        Int64bigint0M.AssertModel(models[9],_testData[31], false);
                        Int64bigint0M.AssertModel(models[10],_testData[32], false);
                        Int64bigint0M.AssertModel(models[11],_testData[33], false);
                        Int64bigint0M.AssertModel(models[12],_testData[34], false);
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
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 60);
                var models = await ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64SingleTypebigint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 25);
                var models =  ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(31));

                Int64bigint0M.AssertModel(models[0],_testData[4], false);
                Int64bigint0M.AssertModel(models[1],_testData[5], false);
                Int64bigint0M.AssertModel(models[2],_testData[6], false);
                Int64bigint0M.AssertModel(models[3],_testData[7], false);
                Int64bigint0M.AssertModel(models[4],_testData[8], false);
                Int64bigint0M.AssertModel(models[5],_testData[9], false);
                Int64bigint0M.AssertModel(models[6],_testData[10], false);
                Int64bigint0M.AssertModel(models[7],_testData[11], false);
                Int64bigint0M.AssertModel(models[8],_testData[12], false);
                Int64bigint0M.AssertModel(models[9],_testData[13], false);
                Int64bigint0M.AssertModel(models[10],_testData[14], false);
                Int64bigint0M.AssertModel(models[11],_testData[15], false);
                Int64bigint0M.AssertModel(models[12],_testData[16], false);
                Int64bigint0M.AssertModel(models[13],_testData[17], false);
                Int64bigint0M.AssertModel(models[14],_testData[18], false);
                Int64bigint0M.AssertModel(models[15],_testData[19], false);
                Int64bigint0M.AssertModel(models[16],_testData[20], false);
                Int64bigint0M.AssertModel(models[17],_testData[21], false);
                Int64bigint0M.AssertModel(models[18],_testData[22], false);
                Int64bigint0M.AssertModel(models[19],_testData[23], false);
                Int64bigint0M.AssertModel(models[20],_testData[24], false);
                Int64bigint0M.AssertModel(models[21],_testData[25], false);
                Int64bigint0M.AssertModel(models[22],_testData[26], false);
                Int64bigint0M.AssertModel(models[23],_testData[27], false);
                Int64bigint0M.AssertModel(models[24],_testData[28], false);
                Int64bigint0M.AssertModel(models[25],_testData[29], false);
                Int64bigint0M.AssertModel(models[26],_testData[30], false);
                Int64bigint0M.AssertModel(models[27],_testData[31], false);
                Int64bigint0M.AssertModel(models[28],_testData[32], false);
                Int64bigint0M.AssertModel(models[29],_testData[33], false);
                Int64bigint0M.AssertModel(models[30],_testData[34], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9036065239536434760L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6176986580257322151L)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5090886085854831183L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8007980081869650792L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((5013119904117212243L)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((100875876074730584L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4183168088002841061L)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4675064376950280531L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2866538495758491387L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7190554099876998828L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2767782735669902548L)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6186165664162682157L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4439380537505752359L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6008135808024293888L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1724568204340613609L)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((238791089742719893L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1345959080442267152L)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6674958073552862763L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((174738705398297642L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2573519905107406944L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8529162143032816886L)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4377491836437444286L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3599325310681465949L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4039016787524206528L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4888453184978223038L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6733269502003316319L)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6217872162067104293L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7824086736307493829L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((609525909572501625L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7194886990882869149L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8654097154245609794L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2788697792660681399L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((4594424932187973935L)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6224075821429489962L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4715855913717333849L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((447576486799461712L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((42316627758417622L)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6799175733006075565L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3142641448508157620L)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2879470988071521359L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4444753819676118376L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((3108534943996943109L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1940946101017307973L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5678098258862291336L)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5433576469848919449L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6708043079669877623L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((6763419618645107699L)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6832674103339599219L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4134850726832694043L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4329128890918722374L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((7835577441044591842L)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8008475610822626863L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6466274841079579161L)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2138138807173173316L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5918473568796433170L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((1412661418912347766L)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3603764876804991985L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((944349386248059297L)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3344710265663505728L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4553298430746252473L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((2582438998693517204L)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((154660935423078094L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((292365296369006848L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1033715717122874818L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2150245471681167328L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3655267113692636192L)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5029794892876031671L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4728283652757982781L)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6659387048465300899L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2079031867171543904L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8236269324085801705L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3491274286504592471L)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5615030501482559188L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7689321741489197700L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1226662166435117460L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((3661976308341585572L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2382743301751399272L)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3458308577893234679L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4301437148732019869L)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2121633099081132574L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4321625954182708053L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8583072867382692281L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((180)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3706441629254749783L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8433293149275900541L)));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9036065239536434760L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6176986580257322151L)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5090886085854831183L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8007980081869650792L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((5013119904117212243L)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((100875876074730584L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4183168088002841061L)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4675064376950280531L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2866538495758491387L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7190554099876998828L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2767782735669902548L)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6186165664162682157L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4439380537505752359L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6008135808024293888L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1724568204340613609L)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((238791089742719893L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1345959080442267152L)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6674958073552862763L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((174738705398297642L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2573519905107406944L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8529162143032816886L)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4377491836437444286L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3599325310681465949L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4039016787524206528L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4888453184978223038L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6733269502003316319L)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6217872162067104293L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7824086736307493829L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((609525909572501625L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7194886990882869149L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8654097154245609794L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2788697792660681399L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((4594424932187973935L)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6224075821429489962L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4715855913717333849L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((447576486799461712L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((42316627758417622L)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6799175733006075565L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3142641448508157620L)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2879470988071521359L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4444753819676118376L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((3108534943996943109L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1940946101017307973L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5678098258862291336L)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5433576469848919449L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6708043079669877623L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((6763419618645107699L)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6832674103339599219L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4134850726832694043L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4329128890918722374L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((7835577441044591842L)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8008475610822626863L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6466274841079579161L)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2138138807173173316L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5918473568796433170L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((1412661418912347766L)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3603764876804991985L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((944349386248059297L)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3344710265663505728L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4553298430746252473L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((2582438998693517204L)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((154660935423078094L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((292365296369006848L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1033715717122874818L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2150245471681167328L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3655267113692636192L)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5029794892876031671L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4728283652757982781L)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6659387048465300899L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2079031867171543904L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8236269324085801705L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3491274286504592471L)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5615030501482559188L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7689321741489197700L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1226662166435117460L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((3661976308341585572L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2382743301751399272L)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3458308577893234679L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4301437148732019869L)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2121633099081132574L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4321625954182708053L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8583072867382692281L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((180)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3706441629254749783L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8433293149275900541L)));

            }
        }

#endregion

    }
}

