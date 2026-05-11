

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
    Id = 3,
    Value = 6788665100289177437L,
    ModelInner = null,
    NullableValue = 1550481800453035858L,
},
            new Int64bigintE0M
{
    Id = 4,
    Value = 7468728613269395772L,
    ModelInner = new Int64bigintE0MI
{
    Id = 7,
    Value = 6186539866804394971L,
    NullableValue = 225641611264069048L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 12,
    Value = 2433620160102392325L,
    ModelInner = null,
    NullableValue = 8203363569587303260L,
},
            new Int64bigintE0M
{
    Id = 19,
    Value = 2897127041868411854L,
    ModelInner = new Int64bigintE0MI
{
    Id = 15,
    Value = 1054538338605442408L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 27,
    Value = 3538836581470824435L,
    ModelInner = null,
    NullableValue = 1112067984390231652L,
},
            new Int64bigintE0M
{
    Id = 30,
    Value = 3631253168204109619L,
    ModelInner = new Int64bigintE0MI
{
    Id = 24,
    Value = 6084506100081700339L,
    NullableValue = null,
},
    NullableValue = 6109315744183998292L,
},
            new Int64bigintE0M
{
    Id = 35,
    Value = 8731202304363440459L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 42,
    Value = 882083530997121592L,
    ModelInner = new Int64bigintE0MI
{
    Id = 30,
    Value = 2558603145111935078L,
    NullableValue = null,
},
    NullableValue = 4264855170946504604L,
},
            new Int64bigintE0M
{
    Id = 46,
    Value = 7681694394563368680L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 47,
    Value = 7593765687380071395L,
    ModelInner = new Int64bigintE0MI
{
    Id = 38,
    Value = 1178965193069832191L,
    NullableValue = 1283286673936756736L,
},
    NullableValue = 3271005489934220780L,
},
            new Int64bigintE0M
{
    Id = 50,
    Value = 7119851961422752043L,
    ModelInner = null,
    NullableValue = 7843025342831695835L,
},
            new Int64bigintE0M
{
    Id = 55,
    Value = 3615525943169813364L,
    ModelInner = new Int64bigintE0MI
{
    Id = 39,
    Value = 1580085670193439328L,
    NullableValue = 5140409749271433593L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 61,
    Value = 2145677561436190172L,
    ModelInner = null,
    NullableValue = 1742557325120692797L,
},
            new Int64bigintE0M
{
    Id = 70,
    Value = 1309298403245217324L,
    ModelInner = new Int64bigintE0MI
{
    Id = 43,
    Value = 1504578123475623258L,
    NullableValue = 5333573643294709292L,
},
    NullableValue = 5145616302952011915L,
},
            new Int64bigintE0M
{
    Id = 75,
    Value = 5279175769661081171L,
    ModelInner = null,
    NullableValue = 1740878602981421617L,
},
            new Int64bigintE0M
{
    Id = 78,
    Value = 4175231243690438512L,
    ModelInner = new Int64bigintE0MI
{
    Id = 48,
    Value = 268082490539060233L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 79,
    Value = 7161880532360608942L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 87,
    Value = 9084097193003342819L,
    ModelInner = new Int64bigintE0MI
{
    Id = 53,
    Value = 4104238884543084815L,
    NullableValue = null,
},
    NullableValue = 2030567628252825765L,
},
            new Int64bigintE0M
{
    Id = 94,
    Value = 1246770878915321845L,
    ModelInner = null,
    NullableValue = 6732605594903635594L,
},
            new Int64bigintE0M
{
    Id = 98,
    Value = 2171275991816093227L,
    ModelInner = new Int64bigintE0MI
{
    Id = 60,
    Value = 6808465413073473665L,
    NullableValue = 1651197338387852892L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 107,
    Value = 6040531506728917327L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 108,
    Value = 8165625157464272337L,
    ModelInner = new Int64bigintE0MI
{
    Id = 66,
    Value = 8048949074559823685L,
    NullableValue = 4065232288481472353L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 115,
    Value = 576554258229944110L,
    ModelInner = null,
    NullableValue = 7029837187883621832L,
},
            new Int64bigintE0M
{
    Id = 117,
    Value = 6589811548732566467L,
    ModelInner = new Int64bigintE0MI
{
    Id = 69,
    Value = 8940069480304181522L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 118,
    Value = 3314326191523512564L,
    ModelInner = null,
    NullableValue = 5602911801583895446L,
},
            new Int64bigintE0M
{
    Id = 122,
    Value = 8697168041519159936L,
    ModelInner = new Int64bigintE0MI
{
    Id = 78,
    Value = 1110339529614785529L,
    NullableValue = 8977589260021429811L,
},
    NullableValue = 3227031730009576196L,
},
            new Int64bigintE0M
{
    Id = 127,
    Value = 8991201231932157052L,
    ModelInner = null,
    NullableValue = 3987390370669808711L,
},
            new Int64bigintE0M
{
    Id = 132,
    Value = 7648286432830291852L,
    ModelInner = new Int64bigintE0MI
{
    Id = 85,
    Value = 2412208274369899337L,
    NullableValue = 3918272206604066386L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 136,
    Value = 1432891768478190060L,
    ModelInner = null,
    NullableValue = 7319322223486962989L,
},
            new Int64bigintE0M
{
    Id = 140,
    Value = 5381141265553802473L,
    ModelInner = new Int64bigintE0MI
{
    Id = 91,
    Value = 8407492616389214884L,
    NullableValue = 4852623019691233989L,
},
    NullableValue = 8427908015938374185L,
},
            new Int64bigintE0M
{
    Id = 148,
    Value = 7815194427486497770L,
    ModelInner = null,
    NullableValue = 8135879394512992557L,
},
            new Int64bigintE0M
{
    Id = 149,
    Value = 76248111395250239L,
    ModelInner = new Int64bigintE0MI
{
    Id = 96,
    Value = 3129525163452607995L,
    NullableValue = null,
},
    NullableValue = 8807236324839997331L,
},
            new Int64bigintE0M
{
    Id = 154,
    Value = 7264714563254025380L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 157,
    Value = 7294127482498388840L,
    ModelInner = new Int64bigintE0MI
{
    Id = 100,
    Value = 4933752072452516844L,
    NullableValue = 8857632994772170374L,
},
    NullableValue = 6426067229338922777L,
},
            new Int64bigintE0M
{
    Id = 166,
    Value = 5996961539124006558L,
    ModelInner = null,
    NullableValue = null,
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
                parametr1.Value = 47;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[34], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
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
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 136;
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
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[34], false);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
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
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[20],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[21],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[22],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[23],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[20],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[21],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[22],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 140;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[34], false);
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
                parametr1.Value = 3;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
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
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[34], false);
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
                parametr1.Value = 107;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[34], false);
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Int64bigintE0M.AssertModel(models[0],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Int64bigintE0M.AssertModel(models[0],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Int64bigintE0M.AssertModel(models[0],_testData[11], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[12], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[13], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[14], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[15], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[16], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[18],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[19],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[20],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[21],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[22],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[23],_testData[34], false);
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
                await ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 50, query1, 61, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[21],_testData[34], false);
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
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 122, query1, 79, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[34], false);
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
                 ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 136, query1, 117, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[34], false);
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
                 ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 148, query1, 3, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[33],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 94, query1, 61, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[20],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[21],_testData[34], false);
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
                await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 108, query1, 75, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[19],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 107, query1, 148, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[34], false);
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
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatch(connection, 27, query1, 127, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatchAsync(connection, 98, 154))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Int64bigintE0M.AssertModel(models[0],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Int64bigintE0M.AssertModel(models[0],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatch(connection, 55, 47))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 12);
                var models = await ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(32));

                Int64bigintE0M.AssertModel(models[0],_testData[3], false);
                Int64bigintE0M.AssertModel(models[1],_testData[4], false);
                Int64bigintE0M.AssertModel(models[2],_testData[5], false);
                Int64bigintE0M.AssertModel(models[3],_testData[6], false);
                Int64bigintE0M.AssertModel(models[4],_testData[7], false);
                Int64bigintE0M.AssertModel(models[5],_testData[8], false);
                Int64bigintE0M.AssertModel(models[6],_testData[9], false);
                Int64bigintE0M.AssertModel(models[7],_testData[10], false);
                Int64bigintE0M.AssertModel(models[8],_testData[11], false);
                Int64bigintE0M.AssertModel(models[9],_testData[12], false);
                Int64bigintE0M.AssertModel(models[10],_testData[13], false);
                Int64bigintE0M.AssertModel(models[11],_testData[14], false);
                Int64bigintE0M.AssertModel(models[12],_testData[15], false);
                Int64bigintE0M.AssertModel(models[13],_testData[16], false);
                Int64bigintE0M.AssertModel(models[14],_testData[17], false);
                Int64bigintE0M.AssertModel(models[15],_testData[18], false);
                Int64bigintE0M.AssertModel(models[16],_testData[19], false);
                Int64bigintE0M.AssertModel(models[17],_testData[20], false);
                Int64bigintE0M.AssertModel(models[18],_testData[21], false);
                Int64bigintE0M.AssertModel(models[19],_testData[22], false);
                Int64bigintE0M.AssertModel(models[20],_testData[23], false);
                Int64bigintE0M.AssertModel(models[21],_testData[24], false);
                Int64bigintE0M.AssertModel(models[22],_testData[25], false);
                Int64bigintE0M.AssertModel(models[23],_testData[26], false);
                Int64bigintE0M.AssertModel(models[24],_testData[27], false);
                Int64bigintE0M.AssertModel(models[25],_testData[28], false);
                Int64bigintE0M.AssertModel(models[26],_testData[29], false);
                Int64bigintE0M.AssertModel(models[27],_testData[30], false);
                Int64bigintE0M.AssertModel(models[28],_testData[31], false);
                Int64bigintE0M.AssertModel(models[29],_testData[32], false);
                Int64bigintE0M.AssertModel(models[30],_testData[33], false);
                Int64bigintE0M.AssertModel(models[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64SingleTypebigint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 79);
                var models =  ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));

                Int64bigintE0M.AssertModel(models[0],_testData[17], false);
                Int64bigintE0M.AssertModel(models[1],_testData[18], false);
                Int64bigintE0M.AssertModel(models[2],_testData[19], false);
                Int64bigintE0M.AssertModel(models[3],_testData[20], false);
                Int64bigintE0M.AssertModel(models[4],_testData[21], false);
                Int64bigintE0M.AssertModel(models[5],_testData[22], false);
                Int64bigintE0M.AssertModel(models[6],_testData[23], false);
                Int64bigintE0M.AssertModel(models[7],_testData[24], false);
                Int64bigintE0M.AssertModel(models[8],_testData[25], false);
                Int64bigintE0M.AssertModel(models[9],_testData[26], false);
                Int64bigintE0M.AssertModel(models[10],_testData[27], false);
                Int64bigintE0M.AssertModel(models[11],_testData[28], false);
                Int64bigintE0M.AssertModel(models[12],_testData[29], false);
                Int64bigintE0M.AssertModel(models[13],_testData[30], false);
                Int64bigintE0M.AssertModel(models[14],_testData[31], false);
                Int64bigintE0M.AssertModel(models[15],_testData[32], false);
                Int64bigintE0M.AssertModel(models[16],_testData[33], false);
                Int64bigintE0M.AssertModel(models[17],_testData[34], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6788665100289177437L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1550481800453035858L)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7468728613269395772L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6186539866804394971L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((225641611264069048L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2433620160102392325L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8203363569587303260L)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2897127041868411854L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1054538338605442408L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3538836581470824435L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1112067984390231652L)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3631253168204109619L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6084506100081700339L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((6109315744183998292L)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8731202304363440459L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((882083530997121592L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2558603145111935078L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((4264855170946504604L)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7681694394563368680L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7593765687380071395L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1178965193069832191L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((1283286673936756736L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3271005489934220780L)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7119851961422752043L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7843025342831695835L)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3615525943169813364L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1580085670193439328L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((5140409749271433593L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2145677561436190172L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1742557325120692797L)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1309298403245217324L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1504578123475623258L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((5333573643294709292L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5145616302952011915L)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5279175769661081171L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1740878602981421617L)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4175231243690438512L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((268082490539060233L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7161880532360608942L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9084097193003342819L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4104238884543084815L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((2030567628252825765L)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1246770878915321845L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6732605594903635594L)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2171275991816093227L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6808465413073473665L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((1651197338387852892L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6040531506728917327L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8165625157464272337L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8048949074559823685L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4065232288481472353L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((576554258229944110L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7029837187883621832L)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6589811548732566467L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8940069480304181522L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3314326191523512564L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5602911801583895446L)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8697168041519159936L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1110339529614785529L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8977589260021429811L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3227031730009576196L)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8991201231932157052L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3987390370669808711L)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7648286432830291852L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2412208274369899337L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((3918272206604066386L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1432891768478190060L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7319322223486962989L)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5381141265553802473L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8407492616389214884L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4852623019691233989L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8427908015938374185L)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7815194427486497770L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8135879394512992557L)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((76248111395250239L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((96)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3129525163452607995L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((8807236324839997331L)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7264714563254025380L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7294127482498388840L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((100)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4933752072452516844L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8857632994772170374L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6426067229338922777L)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5996961539124006558L)));//Value

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
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6788665100289177437L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1550481800453035858L)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7468728613269395772L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6186539866804394971L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((225641611264069048L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2433620160102392325L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8203363569587303260L)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2897127041868411854L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1054538338605442408L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3538836581470824435L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1112067984390231652L)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3631253168204109619L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6084506100081700339L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((6109315744183998292L)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8731202304363440459L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((882083530997121592L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2558603145111935078L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((4264855170946504604L)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7681694394563368680L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7593765687380071395L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1178965193069832191L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((1283286673936756736L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3271005489934220780L)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7119851961422752043L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7843025342831695835L)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3615525943169813364L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1580085670193439328L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((5140409749271433593L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2145677561436190172L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1742557325120692797L)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1309298403245217324L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1504578123475623258L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((5333573643294709292L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5145616302952011915L)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5279175769661081171L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1740878602981421617L)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4175231243690438512L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((268082490539060233L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7161880532360608942L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9084097193003342819L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4104238884543084815L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((2030567628252825765L)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1246770878915321845L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6732605594903635594L)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2171275991816093227L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6808465413073473665L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((1651197338387852892L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6040531506728917327L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8165625157464272337L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8048949074559823685L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4065232288481472353L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((576554258229944110L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7029837187883621832L)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6589811548732566467L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8940069480304181522L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3314326191523512564L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5602911801583895446L)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8697168041519159936L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1110339529614785529L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8977589260021429811L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3227031730009576196L)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8991201231932157052L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3987390370669808711L)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7648286432830291852L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2412208274369899337L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((3918272206604066386L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1432891768478190060L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7319322223486962989L)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5381141265553802473L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8407492616389214884L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4852623019691233989L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8427908015938374185L)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7815194427486497770L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8135879394512992557L)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((76248111395250239L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((96)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3129525163452607995L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((8807236324839997331L)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7264714563254025380L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7294127482498388840L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((100)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4933752072452516844L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8857632994772170374L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6426067229338922777L)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5996961539124006558L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

