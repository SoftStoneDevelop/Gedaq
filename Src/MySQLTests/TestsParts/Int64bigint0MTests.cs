

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
    Id = 7,
    Value = 832912862856737032L,
    ModelInner = null,
    NullableValue = 159158189556832737L,
},
            new Int64bigint0M
{
    Id = 8,
    Value = 8904178616201046826L,
    ModelInner = new Int64bigint0MI
{
    Id = 8,
    Value = 2856514272836444965L,
    NullableValue = 2800988748551286639L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 9,
    Value = 7151276436084680465L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 11,
    Value = 3744058719532306497L,
    ModelInner = new Int64bigint0MI
{
    Id = 17,
    Value = 3001211951505349591L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 15,
    Value = 6209506366907928422L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 18,
    Value = 1654595367786851472L,
    ModelInner = new Int64bigint0MI
{
    Id = 23,
    Value = 5821192942192536222L,
    NullableValue = null,
},
    NullableValue = 4558125641493682491L,
},
            new Int64bigint0M
{
    Id = 19,
    Value = 2480947241313957791L,
    ModelInner = null,
    NullableValue = 229982598827363691L,
},
            new Int64bigint0M
{
    Id = 23,
    Value = 3099740349262853820L,
    ModelInner = new Int64bigint0MI
{
    Id = 26,
    Value = 3641131019847692615L,
    NullableValue = 7778178480276672173L,
},
    NullableValue = 5168807221654036650L,
},
            new Int64bigint0M
{
    Id = 28,
    Value = 3521104971724513329L,
    ModelInner = null,
    NullableValue = 6381169994245912677L,
},
            new Int64bigint0M
{
    Id = 33,
    Value = 7352613532495182887L,
    ModelInner = new Int64bigint0MI
{
    Id = 33,
    Value = 5222521577217662778L,
    NullableValue = null,
},
    NullableValue = 2658693744403008542L,
},
            new Int64bigint0M
{
    Id = 40,
    Value = 1372087149691584148L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 41,
    Value = 8328719415089005138L,
    ModelInner = new Int64bigint0MI
{
    Id = 40,
    Value = 1832987599994453641L,
    NullableValue = null,
},
    NullableValue = 7296943505641715286L,
},
            new Int64bigint0M
{
    Id = 42,
    Value = 1768633198409434902L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 51,
    Value = 3920822122480602783L,
    ModelInner = new Int64bigint0MI
{
    Id = 45,
    Value = 6460885983597150196L,
    NullableValue = 2745178806309690524L,
},
    NullableValue = 4763090334690262750L,
},
            new Int64bigint0M
{
    Id = 59,
    Value = 2852876179075385755L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 62,
    Value = 3163708387437127319L,
    ModelInner = new Int64bigint0MI
{
    Id = 52,
    Value = 4956620589116344188L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 69,
    Value = 8545193823161654613L,
    ModelInner = null,
    NullableValue = 3931237962152200165L,
},
            new Int64bigint0M
{
    Id = 78,
    Value = 5147012236036236719L,
    ModelInner = new Int64bigint0MI
{
    Id = 61,
    Value = 6968327982167758800L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 82,
    Value = 7996842264117147121L,
    ModelInner = null,
    NullableValue = 2160000882166839490L,
},
            new Int64bigint0M
{
    Id = 85,
    Value = 1361720903194215988L,
    ModelInner = new Int64bigint0MI
{
    Id = 70,
    Value = 576677082996392374L,
    NullableValue = 2028978635552555571L,
},
    NullableValue = 1977358323086051479L,
},
            new Int64bigint0M
{
    Id = 93,
    Value = 7504240792998821671L,
    ModelInner = null,
    NullableValue = 5600959980623479998L,
},
            new Int64bigint0M
{
    Id = 96,
    Value = 4019535540097220711L,
    ModelInner = new Int64bigint0MI
{
    Id = 72,
    Value = 1445846315046658489L,
    NullableValue = null,
},
    NullableValue = 2282274307146101070L,
},
            new Int64bigint0M
{
    Id = 98,
    Value = 526130502967264072L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 102,
    Value = 2455644807455342781L,
    ModelInner = new Int64bigint0MI
{
    Id = 80,
    Value = 7261513123283094451L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 103,
    Value = 2970149906977642413L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 106,
    Value = 729837115164519867L,
    ModelInner = new Int64bigint0MI
{
    Id = 84,
    Value = 3704298273804617681L,
    NullableValue = 2684867214982348565L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 107,
    Value = 8987859802902522211L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 114,
    Value = 2849080351906059408L,
    ModelInner = new Int64bigint0MI
{
    Id = 87,
    Value = 6087841387866117029L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 122,
    Value = 4660805856529969158L,
    ModelInner = null,
    NullableValue = 2451880773584875605L,
},
            new Int64bigint0M
{
    Id = 131,
    Value = 547482686192393429L,
    ModelInner = new Int64bigint0MI
{
    Id = 94,
    Value = 6493604443583349649L,
    NullableValue = null,
},
    NullableValue = 7545068645040195616L,
},
            new Int64bigint0M
{
    Id = 140,
    Value = 7932201530533966918L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 142,
    Value = 3759599751132961606L,
    ModelInner = new Int64bigint0MI
{
    Id = 102,
    Value = 2680043039220144367L,
    NullableValue = null,
},
    NullableValue = 7240486887055164473L,
},
            new Int64bigint0M
{
    Id = 143,
    Value = 6010734898538833023L,
    ModelInner = null,
    NullableValue = 605947993190945L,
},
            new Int64bigint0M
{
    Id = 147,
    Value = 6727815033045532299L,
    ModelInner = new Int64bigint0MI
{
    Id = 106,
    Value = 1298910112363261163L,
    NullableValue = 2178805765972608859L,
},
    NullableValue = 2874970874130838763L,
},
            new Int64bigint0M
{
    Id = 151,
    Value = 8524836344572849746L,
    ModelInner = null,
    NullableValue = 8918253278169938706L,
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
                parametr1.Value = 140;
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
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 59;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[19],_testData[34], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
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
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 82;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[34], false);
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
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
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
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[34], false);
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
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
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(models[17],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(models[18],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(models[19],_testData[34], false);
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
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[34], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Int64bigint0M.AssertModel(models[0],_testData[28], false);
                        Int64bigint0M.AssertModel(models[1],_testData[29], false);
                        Int64bigint0M.AssertModel(models[2],_testData[30], false);
                        Int64bigint0M.AssertModel(models[3],_testData[31], false);
                        Int64bigint0M.AssertModel(models[4],_testData[32], false);
                        Int64bigint0M.AssertModel(models[5],_testData[33], false);
                        Int64bigint0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Int64bigint0M.AssertModel(models[0],_testData[25], false);
                        Int64bigint0M.AssertModel(models[1],_testData[26], false);
                        Int64bigint0M.AssertModel(models[2],_testData[27], false);
                        Int64bigint0M.AssertModel(models[3],_testData[28], false);
                        Int64bigint0M.AssertModel(models[4],_testData[29], false);
                        Int64bigint0M.AssertModel(models[5],_testData[30], false);
                        Int64bigint0M.AssertModel(models[6],_testData[31], false);
                        Int64bigint0M.AssertModel(models[7],_testData[32], false);
                        Int64bigint0M.AssertModel(models[8],_testData[33], false);
                        Int64bigint0M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Int64bigint0M.AssertModel(models[0],_testData[31], false);
                        Int64bigint0M.AssertModel(models[1],_testData[32], false);
                        Int64bigint0M.AssertModel(models[2],_testData[33], false);
                        Int64bigint0M.AssertModel(models[3],_testData[34], false);
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
                await ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 69, query1, 114, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[34], false);
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
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 102, query1, 85, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[34], false);
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
                 ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 98, query1, 96, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[34], false);
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
                 ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 8, query1, 15, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[29],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 11, query1, 122, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[17],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[18],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[19],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[20],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[21],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[22],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[23],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[24],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[25],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(models[26],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(models[27],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(models[28],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(models[29],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[34], false);
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
                await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 107, query1, 23, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 9, query1, 143, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[17],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[18],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[19],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[20],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[21],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[22],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[23],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[24],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[25],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[26],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(models[27],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(models[28],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(models[29],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(models[30],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(models[31],_testData[34], false);
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
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatch(connection, 85, query1, 28, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatchAsync(connection, 7, 78))
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
                        Assert.That(models, Has.Count.EqualTo(17));

                        Int64bigint0M.AssertModel(models[0],_testData[18], false);
                        Int64bigint0M.AssertModel(models[1],_testData[19], false);
                        Int64bigint0M.AssertModel(models[2],_testData[20], false);
                        Int64bigint0M.AssertModel(models[3],_testData[21], false);
                        Int64bigint0M.AssertModel(models[4],_testData[22], false);
                        Int64bigint0M.AssertModel(models[5],_testData[23], false);
                        Int64bigint0M.AssertModel(models[6],_testData[24], false);
                        Int64bigint0M.AssertModel(models[7],_testData[25], false);
                        Int64bigint0M.AssertModel(models[8],_testData[26], false);
                        Int64bigint0M.AssertModel(models[9],_testData[27], false);
                        Int64bigint0M.AssertModel(models[10],_testData[28], false);
                        Int64bigint0M.AssertModel(models[11],_testData[29], false);
                        Int64bigint0M.AssertModel(models[12],_testData[30], false);
                        Int64bigint0M.AssertModel(models[13],_testData[31], false);
                        Int64bigint0M.AssertModel(models[14],_testData[32], false);
                        Int64bigint0M.AssertModel(models[15],_testData[33], false);
                        Int64bigint0M.AssertModel(models[16],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatch(connection, 98, 11))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Int64bigint0M.AssertModel(models[0],_testData[23], false);
                        Int64bigint0M.AssertModel(models[1],_testData[24], false);
                        Int64bigint0M.AssertModel(models[2],_testData[25], false);
                        Int64bigint0M.AssertModel(models[3],_testData[26], false);
                        Int64bigint0M.AssertModel(models[4],_testData[27], false);
                        Int64bigint0M.AssertModel(models[5],_testData[28], false);
                        Int64bigint0M.AssertModel(models[6],_testData[29], false);
                        Int64bigint0M.AssertModel(models[7],_testData[30], false);
                        Int64bigint0M.AssertModel(models[8],_testData[31], false);
                        Int64bigint0M.AssertModel(models[9],_testData[32], false);
                        Int64bigint0M.AssertModel(models[10],_testData[33], false);
                        Int64bigint0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 8);
                var models = await ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(33));

                Int64bigint0M.AssertModel(models[0],_testData[2], false);
                Int64bigint0M.AssertModel(models[1],_testData[3], false);
                Int64bigint0M.AssertModel(models[2],_testData[4], false);
                Int64bigint0M.AssertModel(models[3],_testData[5], false);
                Int64bigint0M.AssertModel(models[4],_testData[6], false);
                Int64bigint0M.AssertModel(models[5],_testData[7], false);
                Int64bigint0M.AssertModel(models[6],_testData[8], false);
                Int64bigint0M.AssertModel(models[7],_testData[9], false);
                Int64bigint0M.AssertModel(models[8],_testData[10], false);
                Int64bigint0M.AssertModel(models[9],_testData[11], false);
                Int64bigint0M.AssertModel(models[10],_testData[12], false);
                Int64bigint0M.AssertModel(models[11],_testData[13], false);
                Int64bigint0M.AssertModel(models[12],_testData[14], false);
                Int64bigint0M.AssertModel(models[13],_testData[15], false);
                Int64bigint0M.AssertModel(models[14],_testData[16], false);
                Int64bigint0M.AssertModel(models[15],_testData[17], false);
                Int64bigint0M.AssertModel(models[16],_testData[18], false);
                Int64bigint0M.AssertModel(models[17],_testData[19], false);
                Int64bigint0M.AssertModel(models[18],_testData[20], false);
                Int64bigint0M.AssertModel(models[19],_testData[21], false);
                Int64bigint0M.AssertModel(models[20],_testData[22], false);
                Int64bigint0M.AssertModel(models[21],_testData[23], false);
                Int64bigint0M.AssertModel(models[22],_testData[24], false);
                Int64bigint0M.AssertModel(models[23],_testData[25], false);
                Int64bigint0M.AssertModel(models[24],_testData[26], false);
                Int64bigint0M.AssertModel(models[25],_testData[27], false);
                Int64bigint0M.AssertModel(models[26],_testData[28], false);
                Int64bigint0M.AssertModel(models[27],_testData[29], false);
                Int64bigint0M.AssertModel(models[28],_testData[30], false);
                Int64bigint0M.AssertModel(models[29],_testData[31], false);
                Int64bigint0M.AssertModel(models[30],_testData[32], false);
                Int64bigint0M.AssertModel(models[31],_testData[33], false);
                Int64bigint0M.AssertModel(models[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64SingleTypebigint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 96);
                var models =  ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommand(cmd);

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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((832912862856737032L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((159158189556832737L)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8904178616201046826L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2856514272836444965L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2800988748551286639L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7151276436084680465L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3744058719532306497L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3001211951505349591L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6209506366907928422L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1654595367786851472L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5821192942192536222L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((4558125641493682491L)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2480947241313957791L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((229982598827363691L)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3099740349262853820L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3641131019847692615L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((7778178480276672173L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5168807221654036650L)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3521104971724513329L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6381169994245912677L)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7352613532495182887L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5222521577217662778L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((2658693744403008542L)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1372087149691584148L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8328719415089005138L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1832987599994453641L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((7296943505641715286L)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1768633198409434902L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3920822122480602783L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6460885983597150196L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2745178806309690524L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4763090334690262750L)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2852876179075385755L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3163708387437127319L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4956620589116344188L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8545193823161654613L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3931237962152200165L)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5147012236036236719L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6968327982167758800L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7996842264117147121L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2160000882166839490L)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1361720903194215988L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((576677082996392374L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2028978635552555571L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1977358323086051479L)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7504240792998821671L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5600959980623479998L)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4019535540097220711L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1445846315046658489L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((2282274307146101070L)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((526130502967264072L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2455644807455342781L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7261513123283094451L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2970149906977642413L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((729837115164519867L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3704298273804617681L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2684867214982348565L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8987859802902522211L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2849080351906059408L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6087841387866117029L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4660805856529969158L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2451880773584875605L)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((547482686192393429L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((94)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6493604443583349649L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((7545068645040195616L)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7932201530533966918L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3759599751132961606L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((102)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2680043039220144367L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((7240486887055164473L)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6010734898538833023L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((605947993190945L)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6727815033045532299L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((106)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1298910112363261163L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2178805765972608859L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2874970874130838763L)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8524836344572849746L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8918253278169938706L)));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((832912862856737032L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((159158189556832737L)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8904178616201046826L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2856514272836444965L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2800988748551286639L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7151276436084680465L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3744058719532306497L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3001211951505349591L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6209506366907928422L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1654595367786851472L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5821192942192536222L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((4558125641493682491L)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2480947241313957791L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((229982598827363691L)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3099740349262853820L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3641131019847692615L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((7778178480276672173L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5168807221654036650L)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3521104971724513329L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6381169994245912677L)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7352613532495182887L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5222521577217662778L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((2658693744403008542L)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1372087149691584148L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8328719415089005138L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1832987599994453641L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((7296943505641715286L)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1768633198409434902L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3920822122480602783L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6460885983597150196L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2745178806309690524L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4763090334690262750L)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2852876179075385755L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3163708387437127319L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4956620589116344188L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8545193823161654613L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3931237962152200165L)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5147012236036236719L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6968327982167758800L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7996842264117147121L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2160000882166839490L)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1361720903194215988L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((576677082996392374L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2028978635552555571L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1977358323086051479L)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7504240792998821671L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5600959980623479998L)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4019535540097220711L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1445846315046658489L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((2282274307146101070L)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((526130502967264072L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2455644807455342781L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7261513123283094451L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2970149906977642413L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((729837115164519867L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3704298273804617681L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2684867214982348565L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8987859802902522211L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2849080351906059408L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6087841387866117029L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4660805856529969158L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2451880773584875605L)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((547482686192393429L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((94)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6493604443583349649L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((7545068645040195616L)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7932201530533966918L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3759599751132961606L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((102)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2680043039220144367L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((7240486887055164473L)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6010734898538833023L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((605947993190945L)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6727815033045532299L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((106)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1298910112363261163L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2178805765972608859L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2874970874130838763L)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8524836344572849746L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8918253278169938706L)));

            }
        }

#endregion

    }
}

