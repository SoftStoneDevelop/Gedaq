

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
    Id = 3,
    Value = 0.00170133970709219m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 10,
    Value = 0.910857198137428m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 7,
    Value = 0.490070175522401m,
    NullableValue = 0.439141494108556m,
},
    NullableValue = 0.211323397426438m,
},
            new Decimaldecimal0M
{
    Id = 17,
    Value = 0.275954586090415m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 26,
    Value = 0.556532974133574m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 9,
    Value = 0.476584256609877m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 30,
    Value = 0.264665877704341m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 39,
    Value = 0.945306435006255m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 12,
    Value = 0.390400517940193m,
    NullableValue = 0.572575590063m,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 42,
    Value = 0.588132654141701m,
    ModelInner = null,
    NullableValue = 0.0901260056097004m,
},
            new Decimaldecimal0M
{
    Id = 50,
    Value = 0.0150545968783398m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 19,
    Value = 0.341534391357243m,
    NullableValue = null,
},
    NullableValue = 0.490219565266304m,
},
            new Decimaldecimal0M
{
    Id = 52,
    Value = 0.267157302500326m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 58,
    Value = 0.869166269865673m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 21,
    Value = 0.846079442544226m,
    NullableValue = 0.616343801548026m,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 63,
    Value = 0.303789636577982m,
    ModelInner = null,
    NullableValue = 0.924058018933692m,
},
            new Decimaldecimal0M
{
    Id = 71,
    Value = 0.670269251877671m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 25,
    Value = 0.285839392255111m,
    NullableValue = 0.305299402533818m,
},
    NullableValue = 0.955619148900079m,
},
            new Decimaldecimal0M
{
    Id = 76,
    Value = 0.59648644049674m,
    ModelInner = null,
    NullableValue = 0.727388925260626m,
},
            new Decimaldecimal0M
{
    Id = 80,
    Value = 0.224451449330876m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 30,
    Value = 0.24087492635693m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 89,
    Value = 0.400706285280354m,
    ModelInner = null,
    NullableValue = 0.893922922368336m,
},
            new Decimaldecimal0M
{
    Id = 90,
    Value = 0.626458843627398m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 32,
    Value = 0.879388758058443m,
    NullableValue = null,
},
    NullableValue = 0.391009260935169m,
},
            new Decimaldecimal0M
{
    Id = 98,
    Value = 0.151810747671246m,
    ModelInner = null,
    NullableValue = 0.151771656591779m,
},
            new Decimaldecimal0M
{
    Id = 101,
    Value = 0.954071065587355m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 34,
    Value = 0.96332800934929m,
    NullableValue = null,
},
    NullableValue = 0.639720093468017m,
},
            new Decimaldecimal0M
{
    Id = 105,
    Value = 0.183685237022683m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 110,
    Value = 0.239788451234421m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 37,
    Value = 0.791773064573143m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 115,
    Value = 0.657144324291077m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 116,
    Value = 0.961049331235188m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 41,
    Value = 0.719461042536242m,
    NullableValue = null,
},
    NullableValue = 0.0627827106396515m,
},
            new Decimaldecimal0M
{
    Id = 124,
    Value = 0.483262150041507m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 128,
    Value = 0.685339867842069m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 48,
    Value = 0.825469754195631m,
    NullableValue = 0.860064117595416m,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 137,
    Value = 0.640928808541592m,
    ModelInner = null,
    NullableValue = 0.0336048501120151m,
},
            new Decimaldecimal0M
{
    Id = 141,
    Value = 0.373683692447729m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 52,
    Value = 0.109517222772477m,
    NullableValue = 0.429655510874545m,
},
    NullableValue = 0.503730940165859m,
},
            new Decimaldecimal0M
{
    Id = 145,
    Value = 0.268436086003683m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 152,
    Value = 0.975064743077321m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 54,
    Value = 0.595647648131855m,
    NullableValue = 0.824692280244283m,
},
    NullableValue = 0.627886956738438m,
},
            new Decimaldecimal0M
{
    Id = 155,
    Value = 0.935066537928934m,
    ModelInner = null,
    NullableValue = 0.613473199941985m,
},
            new Decimaldecimal0M
{
    Id = 157,
    Value = 0.407487368177582m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 61,
    Value = 0.367219246701233m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 163,
    Value = 0.296613785693119m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 164,
    Value = 0.636060922603352m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 70,
    Value = 0.0993976385122644m,
    NullableValue = 0.319149395957292m,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 170,
    Value = 0.553820690463634m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 172,
    Value = 0.958904304358966m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 76,
    Value = 0.742201881293256m,
    NullableValue = null,
},
    NullableValue = 0.874613593325443m,
},
            new Decimaldecimal0M
{
    Id = 177,
    Value = 0.297044484899791m,
    ModelInner = null,
    NullableValue = null,
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
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Decimal),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (System.Data.SqlDbType)(5)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (System.Data.SqlDbType)(5))
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

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
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
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Decimal), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.SqlDbType)(5)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.SqlDbType)(5),
                nullable: true),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "decimaldecimal0mi_id", 
                methodParametrName: "decimaldecimal0mi_id", 
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

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
FROM dbo.decimaldecimal0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimaldecimal0M>();
                var models2 = new List<FlatDecimaldecimal0M>();
                await((IDecimalSingleTypedecimal)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
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
FROM dbo.decimaldecimal0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalSingleTypedecimal)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var models = await((IDecimalSingleTypedecimal)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[25],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 157;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
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
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(models[2],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(models[3],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(models[4],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(models[5],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(models[6],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(models[7],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(models[8],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(models[9],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(models[10],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(models[11],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(models[12],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(models[13],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(models[14],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(models[15],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(models[16],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(models[17],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(models[18],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(models[19],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(models[20],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(models[21],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(models[22],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

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
                        FlatDecimaldecimal0M.AssertModel(models[11],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(models[12],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(models[13],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(models[14],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[12],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
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
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(models[2],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(models[3],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(models[4],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(models[5],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(models[6],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(models[7],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(models[8],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(models[9],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(models[10],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(models[11],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(models[2],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(models[3],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(models[4],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(models[5],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(models[6],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(models[7],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(models[8],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(models[9],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(models[10],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(models[11],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 137;
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
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 164;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Decimaldecimal0M.AssertModel(models[0],_testData[32], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[33], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Decimaldecimal0M.AssertModel(models[0],_testData[26], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[27], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[28], false);
                        Decimaldecimal0M.AssertModel(models[3],_testData[29], false);
                        Decimaldecimal0M.AssertModel(models[4],_testData[30], false);
                        Decimaldecimal0M.AssertModel(models[5],_testData[31], false);
                        Decimaldecimal0M.AssertModel(models[6],_testData[32], false);
                        Decimaldecimal0M.AssertModel(models[7],_testData[33], false);
                        Decimaldecimal0M.AssertModel(models[8],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 157;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Decimaldecimal0M.AssertModel(models[0],_testData[23], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[24], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[25], false);
                        Decimaldecimal0M.AssertModel(models[3],_testData[26], false);
                        Decimaldecimal0M.AssertModel(models[4],_testData[27], false);
                        Decimaldecimal0M.AssertModel(models[5],_testData[28], false);
                        Decimaldecimal0M.AssertModel(models[6],_testData[29], false);
                        Decimaldecimal0M.AssertModel(models[7],_testData[30], false);
                        Decimaldecimal0M.AssertModel(models[8],_testData[31], false);
                        Decimaldecimal0M.AssertModel(models[9],_testData[32], false);
                        Decimaldecimal0M.AssertModel(models[10],_testData[33], false);
                        Decimaldecimal0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Decimaldecimal0M.AssertModel(models[0],_testData[30], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[31], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[32], false);
                        Decimaldecimal0M.AssertModel(models[3],_testData[33], false);
                        Decimaldecimal0M.AssertModel(models[4],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
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
                await ((IDecimalSingleTypedecimal)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 71, query1, 42, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
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
                        FlatDecimaldecimal0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
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
                        FlatDecimaldecimal0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[27],_testData[34], false);
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
                await ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 128, query1, 128, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
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
                 ((IDecimalSingleTypedecimal)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 105, query1, 105, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[15],_testData[34], false);
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
                 ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelBatch(connection, 163, query1, 145, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 145, query1, 63, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(models[2],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(models[3],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(models[4],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(models[5],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(models[6],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(models[2],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(models[3],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(models[4],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(models[5],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(models[6],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(models[7],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(models[8],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(models[9],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(models[10],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(models[11],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(models[12],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(models[13],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(models[14],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(models[15],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(models[16],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(models[17],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(models[18],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(models[19],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(models[20],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(models[21],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(models[22],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(models[23],_testData[34], false);
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
                await ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 63, query1, 26, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
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
                        FlatDecimaldecimal0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[30],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionSTDynQuerySelectModelBatch(connection, 71, query1, 71, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

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
                        FlatDecimaldecimal0M.AssertModel(models[18],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(models[19],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(models[20],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(models[21],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

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
                        FlatDecimaldecimal0M.AssertModel(models[18],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(models[19],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(models[20],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(models[21],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(models[22],_testData[34], false);
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
                 ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelBatch(connection, 152, query1, 110, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[14],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelBatchAsync(connection, 152, 80))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Decimaldecimal0M.AssertModel(models[0],_testData[28], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[29], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[30], false);
                        Decimaldecimal0M.AssertModel(models[3],_testData[31], false);
                        Decimaldecimal0M.AssertModel(models[4],_testData[32], false);
                        Decimaldecimal0M.AssertModel(models[5],_testData[33], false);
                        Decimaldecimal0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Decimaldecimal0M.AssertModel(models[0],_testData[14], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[15], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[16], false);
                        Decimaldecimal0M.AssertModel(models[3],_testData[17], false);
                        Decimaldecimal0M.AssertModel(models[4],_testData[18], false);
                        Decimaldecimal0M.AssertModel(models[5],_testData[19], false);
                        Decimaldecimal0M.AssertModel(models[6],_testData[20], false);
                        Decimaldecimal0M.AssertModel(models[7],_testData[21], false);
                        Decimaldecimal0M.AssertModel(models[8],_testData[22], false);
                        Decimaldecimal0M.AssertModel(models[9],_testData[23], false);
                        Decimaldecimal0M.AssertModel(models[10],_testData[24], false);
                        Decimaldecimal0M.AssertModel(models[11],_testData[25], false);
                        Decimaldecimal0M.AssertModel(models[12],_testData[26], false);
                        Decimaldecimal0M.AssertModel(models[13],_testData[27], false);
                        Decimaldecimal0M.AssertModel(models[14],_testData[28], false);
                        Decimaldecimal0M.AssertModel(models[15],_testData[29], false);
                        Decimaldecimal0M.AssertModel(models[16],_testData[30], false);
                        Decimaldecimal0M.AssertModel(models[17],_testData[31], false);
                        Decimaldecimal0M.AssertModel(models[18],_testData[32], false);
                        Decimaldecimal0M.AssertModel(models[19],_testData[33], false);
                        Decimaldecimal0M.AssertModel(models[20],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelBatch(connection, 170, 98))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Decimaldecimal0M.AssertModel(models[0],_testData[33], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

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
                        Decimaldecimal0M.AssertModel(models[13],_testData[30], false);
                        Decimaldecimal0M.AssertModel(models[14],_testData[31], false);
                        Decimaldecimal0M.AssertModel(models[15],_testData[32], false);
                        Decimaldecimal0M.AssertModel(models[16],_testData[33], false);
                        Decimaldecimal0M.AssertModel(models[17],_testData[34], false);
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
                ((IDecimalSingleTypedecimal)this).SetDbConnectionSelectModelParametrs(cmd, 152);
                var models = await ((IDecimalSingleTypedecimal)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                Decimaldecimal0M.AssertModel(models[0],_testData[28], false);
                Decimaldecimal0M.AssertModel(models[1],_testData[29], false);
                Decimaldecimal0M.AssertModel(models[2],_testData[30], false);
                Decimaldecimal0M.AssertModel(models[3],_testData[31], false);
                Decimaldecimal0M.AssertModel(models[4],_testData[32], false);
                Decimaldecimal0M.AssertModel(models[5],_testData[33], false);
                Decimaldecimal0M.AssertModel(models[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalSingleTypedecimal)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalSingleTypedecimal)this).SetDbConnectionSelectModelParametrs(cmd, 63);
                var models =  ((IDecimalSingleTypedecimal)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

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
                Decimaldecimal0M.AssertModel(models[19],_testData[30], false);
                Decimaldecimal0M.AssertModel(models[20],_testData[31], false);
                Decimaldecimal0M.AssertModel(models[21],_testData[32], false);
                Decimaldecimal0M.AssertModel(models[22],_testData[33], false);
                Decimaldecimal0M.AssertModel(models[23],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.00170133970709219m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.910857198137428m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.490070175522401m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.439141494108556m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.211323397426438m)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.275954586090415m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.556532974133574m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.476584256609877m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.264665877704341m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.945306435006255m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.390400517940193m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.572575590063m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.588132654141701m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0901260056097004m)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0150545968783398m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.341534391357243m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.490219565266304m)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.267157302500326m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.869166269865673m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.846079442544226m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.616343801548026m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.303789636577982m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.924058018933692m)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.670269251877671m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.285839392255111m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.305299402533818m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.955619148900079m)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.59648644049674m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.727388925260626m)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.224451449330876m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.24087492635693m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.400706285280354m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.893922922368336m)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.626458843627398m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.879388758058443m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.391009260935169m)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.151810747671246m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.151771656591779m)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.954071065587355m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.96332800934929m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.639720093468017m)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.183685237022683m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.239788451234421m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.791773064573143m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.657144324291077m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.961049331235188m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.719461042536242m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0627827106396515m)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.483262150041507m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.685339867842069m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.825469754195631m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.860064117595416m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.640928808541592m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0336048501120151m)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.373683692447729m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.109517222772477m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.429655510874545m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.503730940165859m)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.268436086003683m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.975064743077321m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.595647648131855m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.824692280244283m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.627886956738438m)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.935066537928934m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.613473199941985m)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.407487368177582m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.367219246701233m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.296613785693119m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.636060922603352m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.0993976385122644m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.319149395957292m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.553820690463634m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.958904304358966m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.742201881293256m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.874613593325443m)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.297044484899791m)));//Value

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
                var models =  ((IDecimalSingleTypedecimal)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.00170133970709219m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.910857198137428m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.490070175522401m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.439141494108556m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.211323397426438m)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.275954586090415m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.556532974133574m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.476584256609877m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.264665877704341m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.945306435006255m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.390400517940193m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.572575590063m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.588132654141701m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0901260056097004m)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0150545968783398m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.341534391357243m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.490219565266304m)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.267157302500326m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.869166269865673m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.846079442544226m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.616343801548026m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.303789636577982m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.924058018933692m)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.670269251877671m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.285839392255111m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.305299402533818m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.955619148900079m)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.59648644049674m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.727388925260626m)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.224451449330876m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.24087492635693m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.400706285280354m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.893922922368336m)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.626458843627398m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.879388758058443m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.391009260935169m)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.151810747671246m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.151771656591779m)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.954071065587355m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.96332800934929m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.639720093468017m)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.183685237022683m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.239788451234421m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.791773064573143m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.657144324291077m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.961049331235188m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.719461042536242m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0627827106396515m)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.483262150041507m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.685339867842069m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.825469754195631m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.860064117595416m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.640928808541592m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0336048501120151m)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.373683692447729m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.109517222772477m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.429655510874545m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.503730940165859m)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.268436086003683m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.975064743077321m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.595647648131855m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.824692280244283m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.627886956738438m)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.935066537928934m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.613473199941985m)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.407487368177582m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.367219246701233m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.296613785693119m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.636060922603352m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.0993976385122644m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.319149395957292m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.553820690463634m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.958904304358966m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.742201881293256m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.874613593325443m)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.297044484899791m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

