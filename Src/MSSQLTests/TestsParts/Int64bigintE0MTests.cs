

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
    Id = 8,
    Value = 2715012814481434625L,
    ModelInner = null,
    NullableValue = 1875007000369554981L,
},
            new Int64bigintE0M
{
    Id = 11,
    Value = 4609270478909870853L,
    ModelInner = new Int64bigintE0MI
{
    Id = 3,
    Value = 1606962241877792383L,
    NullableValue = 8338766414534520756L,
},
    NullableValue = 4394246355771453169L,
},
            new Int64bigintE0M
{
    Id = 16,
    Value = 2791758578582613716L,
    ModelInner = null,
    NullableValue = 4477508720881325908L,
},
            new Int64bigintE0M
{
    Id = 19,
    Value = 8726737460779731070L,
    ModelInner = new Int64bigintE0MI
{
    Id = 10,
    Value = 2249511474578654636L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 21,
    Value = 2089050658247631165L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 29,
    Value = 7976336792340668653L,
    ModelInner = new Int64bigintE0MI
{
    Id = 16,
    Value = 647925112333791253L,
    NullableValue = null,
},
    NullableValue = 8902767935383220234L,
},
            new Int64bigintE0M
{
    Id = 32,
    Value = 6735849354680086496L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 36,
    Value = 2136360491030450520L,
    ModelInner = new Int64bigintE0MI
{
    Id = 19,
    Value = 5528540917346243092L,
    NullableValue = 3168818168795309320L,
},
    NullableValue = 8555269781804573203L,
},
            new Int64bigintE0M
{
    Id = 40,
    Value = 2042389179939817536L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 43,
    Value = 1653079578193732584L,
    ModelInner = new Int64bigintE0MI
{
    Id = 20,
    Value = 1265577242211830762L,
    NullableValue = 2211056762699939509L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 49,
    Value = 4643992960763042977L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 57,
    Value = 512765020361761274L,
    ModelInner = new Int64bigintE0MI
{
    Id = 29,
    Value = 1595567501327451955L,
    NullableValue = 9146598164191249245L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 62,
    Value = 6248833202299830395L,
    ModelInner = null,
    NullableValue = 3276966073395851407L,
},
            new Int64bigintE0M
{
    Id = 64,
    Value = 2424691873401984579L,
    ModelInner = new Int64bigintE0MI
{
    Id = 32,
    Value = 870882824067970427L,
    NullableValue = null,
},
    NullableValue = 4549210392332349622L,
},
            new Int64bigintE0M
{
    Id = 67,
    Value = 7492089248457307956L,
    ModelInner = null,
    NullableValue = 4115630107090160047L,
},
            new Int64bigintE0M
{
    Id = 72,
    Value = 4939662286290309731L,
    ModelInner = new Int64bigintE0MI
{
    Id = 40,
    Value = 834706950109412303L,
    NullableValue = 6127796803391875427L,
},
    NullableValue = 8976358471758634523L,
},
            new Int64bigintE0M
{
    Id = 79,
    Value = 2032148168866026091L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 81,
    Value = 6643185856618761566L,
    ModelInner = new Int64bigintE0MI
{
    Id = 44,
    Value = 3998948449772188627L,
    NullableValue = null,
},
    NullableValue = 3962810288628168230L,
},
            new Int64bigintE0M
{
    Id = 85,
    Value = 6751001293522890899L,
    ModelInner = null,
    NullableValue = 1065221293533965541L,
},
            new Int64bigintE0M
{
    Id = 86,
    Value = 8162878656802104760L,
    ModelInner = new Int64bigintE0MI
{
    Id = 53,
    Value = 8655520706259191579L,
    NullableValue = null,
},
    NullableValue = 6219330166460719376L,
},
            new Int64bigintE0M
{
    Id = 89,
    Value = 7870213538324491652L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 96,
    Value = 5050142599023384849L,
    ModelInner = new Int64bigintE0MI
{
    Id = 54,
    Value = 4343890112594548286L,
    NullableValue = 26391470576736611L,
},
    NullableValue = 8980904822490098747L,
},
            new Int64bigintE0M
{
    Id = 97,
    Value = 6487358172511144173L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 101,
    Value = 6883038249612989120L,
    ModelInner = new Int64bigintE0MI
{
    Id = 61,
    Value = 772126192591962379L,
    NullableValue = 8370529628914627764L,
},
    NullableValue = 6208572358819734609L,
},
            new Int64bigintE0M
{
    Id = 106,
    Value = 2588770226039038833L,
    ModelInner = null,
    NullableValue = 2216575508574284175L,
},
            new Int64bigintE0M
{
    Id = 113,
    Value = 1532323094268170702L,
    ModelInner = new Int64bigintE0MI
{
    Id = 64,
    Value = 140080779167512770L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 115,
    Value = 5997997077969023892L,
    ModelInner = null,
    NullableValue = 6560295475377401357L,
},
            new Int64bigintE0M
{
    Id = 120,
    Value = 6288940723961568778L,
    ModelInner = new Int64bigintE0MI
{
    Id = 67,
    Value = 2585378219713155997L,
    NullableValue = 968558024739887684L,
},
    NullableValue = 4186701334092408832L,
},
            new Int64bigintE0M
{
    Id = 123,
    Value = 7277495838699460582L,
    ModelInner = null,
    NullableValue = 8681248077271684889L,
},
            new Int64bigintE0M
{
    Id = 126,
    Value = 615837007766754965L,
    ModelInner = new Int64bigintE0MI
{
    Id = 69,
    Value = 9114418744456885472L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 130,
    Value = 2527560798567675547L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 132,
    Value = 4299896175357038444L,
    ModelInner = new Int64bigintE0MI
{
    Id = 78,
    Value = 1579379975872717604L,
    NullableValue = 4179615406894162739L,
},
    NullableValue = 589883602216298610L,
},
            new Int64bigintE0M
{
    Id = 136,
    Value = 4575217513422558316L,
    ModelInner = null,
    NullableValue = 4036490446406751431L,
},
            new Int64bigintE0M
{
    Id = 144,
    Value = 3569306158756013947L,
    ModelInner = new Int64bigintE0MI
{
    Id = 82,
    Value = 1909557437832781102L,
    NullableValue = 7540760161011703370L,
},
    NullableValue = 8935326872470723577L,
},
            new Int64bigintE0M
{
    Id = 147,
    Value = 6293359872868885903L,
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
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[31],_testData[34], false);
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[34], false);
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
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[2], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[3], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[20],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[21],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[22],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[23],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[24],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[25],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[26],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[27],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[28],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[29],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[30],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[31],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[3], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[20],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[21],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[22],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[23],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[24],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[25],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[26],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[27],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[28],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[29],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[30],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[34], false);
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
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
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
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[2], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[3], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[20],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[21],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[22],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[23],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[24],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[25],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[26],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[27],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[28],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[29],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[30],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[31],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[32],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[29],_testData[34], false);
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Int64bigintE0M.AssertModel(models[0],_testData[4], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[5], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[6], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[7], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[8], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[9], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[10], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[11], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[12], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[13], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[14], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[15], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[16], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[18],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[19],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[20],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[21],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[22],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[23],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[24],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[25],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[26],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[27],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[28],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[29],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        Int64bigintE0M.AssertModel(models[0],_testData[2], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[3], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[4], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[5], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[6], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[7], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[8], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[9], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[10], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[11], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[12], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[13], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[14], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[15], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[16], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[18],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[19],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[20],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[21],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[22],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[23],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[24],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[25],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[26],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[27],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[28],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[29],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[30],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[31],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Int64bigintE0M.AssertModel(models[0],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[34], false);
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
                await ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 85, query1, 21, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[29],_testData[34], false);
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
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 126, query1, 32, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[27],_testData[34], false);
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
                 ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 115, query1, 126, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[34], false);
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
                 ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 19, query1, 62, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 85, query1, 36, query2))
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
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[20],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[21],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[22],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[23],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[24],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[25],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[26],_testData[34], false);
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
                await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 32, query1, 72, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[18],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 97, query1, 19, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[20],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[21],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[22],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[23],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[24],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[25],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[26],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[27],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[28],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[29],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[30],_testData[34], false);
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
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatch(connection, 81, query1, 86, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatchAsync(connection, 115, 106))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Int64bigintE0M.AssertModel(models[0],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatch(connection, 21, 101))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Int64bigintE0M.AssertModel(models[0],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[34], false);
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
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 115);
                var models = await ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                Int64bigintE0M.AssertModel(models[0],_testData[27], false);
                Int64bigintE0M.AssertModel(models[1],_testData[28], false);
                Int64bigintE0M.AssertModel(models[2],_testData[29], false);
                Int64bigintE0M.AssertModel(models[3],_testData[30], false);
                Int64bigintE0M.AssertModel(models[4],_testData[31], false);
                Int64bigintE0M.AssertModel(models[5],_testData[32], false);
                Int64bigintE0M.AssertModel(models[6],_testData[33], false);
                Int64bigintE0M.AssertModel(models[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64SingleTypebigint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 67);
                var models =  ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommand(cmd);

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
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2715012814481434625L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1875007000369554981L)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4609270478909870853L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1606962241877792383L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8338766414534520756L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4394246355771453169L)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2791758578582613716L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4477508720881325908L)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8726737460779731070L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2249511474578654636L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2089050658247631165L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7976336792340668653L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((647925112333791253L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((8902767935383220234L)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6735849354680086496L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2136360491030450520L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5528540917346243092L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((3168818168795309320L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8555269781804573203L)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2042389179939817536L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1653079578193732584L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1265577242211830762L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2211056762699939509L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4643992960763042977L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((512765020361761274L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1595567501327451955L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((9146598164191249245L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6248833202299830395L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3276966073395851407L)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2424691873401984579L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((870882824067970427L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((4549210392332349622L)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7492089248457307956L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4115630107090160047L)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4939662286290309731L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((834706950109412303L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6127796803391875427L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8976358471758634523L)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2032148168866026091L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6643185856618761566L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3998948449772188627L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((3962810288628168230L)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6751001293522890899L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1065221293533965541L)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8162878656802104760L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8655520706259191579L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((6219330166460719376L)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7870213538324491652L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5050142599023384849L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4343890112594548286L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((26391470576736611L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8980904822490098747L)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6487358172511144173L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6883038249612989120L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((772126192591962379L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8370529628914627764L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6208572358819734609L)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2588770226039038833L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2216575508574284175L)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1532323094268170702L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((140080779167512770L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5997997077969023892L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6560295475377401357L)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6288940723961568778L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2585378219713155997L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((968558024739887684L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4186701334092408832L)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7277495838699460582L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8681248077271684889L)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((615837007766754965L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((9114418744456885472L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2527560798567675547L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4299896175357038444L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1579379975872717604L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4179615406894162739L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((589883602216298610L)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4575217513422558316L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4036490446406751431L)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3569306158756013947L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1909557437832781102L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((7540760161011703370L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8935326872470723577L)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6293359872868885903L)));//Value

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
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2715012814481434625L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1875007000369554981L)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4609270478909870853L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1606962241877792383L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8338766414534520756L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4394246355771453169L)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2791758578582613716L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4477508720881325908L)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8726737460779731070L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2249511474578654636L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2089050658247631165L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7976336792340668653L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((647925112333791253L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((8902767935383220234L)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6735849354680086496L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2136360491030450520L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5528540917346243092L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((3168818168795309320L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8555269781804573203L)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2042389179939817536L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1653079578193732584L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1265577242211830762L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2211056762699939509L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4643992960763042977L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((512765020361761274L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1595567501327451955L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((9146598164191249245L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6248833202299830395L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3276966073395851407L)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2424691873401984579L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((870882824067970427L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((4549210392332349622L)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7492089248457307956L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4115630107090160047L)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4939662286290309731L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((834706950109412303L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6127796803391875427L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8976358471758634523L)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2032148168866026091L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6643185856618761566L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3998948449772188627L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((3962810288628168230L)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6751001293522890899L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1065221293533965541L)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8162878656802104760L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8655520706259191579L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((6219330166460719376L)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7870213538324491652L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5050142599023384849L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4343890112594548286L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((26391470576736611L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8980904822490098747L)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6487358172511144173L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6883038249612989120L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((772126192591962379L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8370529628914627764L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6208572358819734609L)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2588770226039038833L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2216575508574284175L)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1532323094268170702L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((140080779167512770L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5997997077969023892L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6560295475377401357L)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6288940723961568778L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2585378219713155997L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((968558024739887684L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4186701334092408832L)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7277495838699460582L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8681248077271684889L)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((615837007766754965L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((9114418744456885472L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2527560798567675547L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4299896175357038444L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1579379975872717604L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4179615406894162739L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((589883602216298610L)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4575217513422558316L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4036490446406751431L)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3569306158756013947L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1909557437832781102L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((7540760161011703370L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8935326872470723577L)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6293359872868885903L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

