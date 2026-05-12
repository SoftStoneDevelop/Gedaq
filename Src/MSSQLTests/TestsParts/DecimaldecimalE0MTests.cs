

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

        private readonly DecimaldecimalE0M[] _testData = new DecimaldecimalE0M[]
        {
            new DecimaldecimalE0M
{
    Id = 8,
    Value = 0.664679286580577m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 14,
    Value = 0.809545081744866m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 5,
    Value = 0.221289399278423m,
    NullableValue = 0.902069904214991m,
},
    NullableValue = 0.00369236054257216m,
},
            new DecimaldecimalE0M
{
    Id = 22,
    Value = 0.643159703157704m,
    ModelInner = null,
    NullableValue = 0.417422373509401m,
},
            new DecimaldecimalE0M
{
    Id = 24,
    Value = 0.118152438147341m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 11,
    Value = 0.275284259604236m,
    NullableValue = null,
},
    NullableValue = 0.815218989984932m,
},
            new DecimaldecimalE0M
{
    Id = 30,
    Value = 0.466781345628435m,
    ModelInner = null,
    NullableValue = 0.346013374164657m,
},
            new DecimaldecimalE0M
{
    Id = 36,
    Value = 0.368572049853296m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 16,
    Value = 0.1978282360482m,
    NullableValue = 0.24461503965147m,
},
    NullableValue = 0.0150679124420322m,
},
            new DecimaldecimalE0M
{
    Id = 44,
    Value = 0.501531075745009m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 52,
    Value = 0.395442852650101m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 21,
    Value = 0.135129138109522m,
    NullableValue = 0.792288994634889m,
},
    NullableValue = 0.747131779455892m,
},
            new DecimaldecimalE0M
{
    Id = 61,
    Value = 0.801388719191716m,
    ModelInner = null,
    NullableValue = 0.428478700457089m,
},
            new DecimaldecimalE0M
{
    Id = 69,
    Value = 0.526404088226787m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 22,
    Value = 0.164154962615493m,
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 70,
    Value = 0.450500650155559m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 72,
    Value = 0.454746845233383m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 28,
    Value = 0.366867793625736m,
    NullableValue = 0.594977527271858m,
},
    NullableValue = 0.735869290307916m,
},
            new DecimaldecimalE0M
{
    Id = 80,
    Value = 0.8477000236171m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 81,
    Value = 0.374388684381868m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 32,
    Value = 0.51496703270735m,
    NullableValue = 0.385532520364574m,
},
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 87,
    Value = 0.893506132012891m,
    ModelInner = null,
    NullableValue = 0.687664585161808m,
},
            new DecimaldecimalE0M
{
    Id = 96,
    Value = 0.165847886236076m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 40,
    Value = 0.530925783076103m,
    NullableValue = 0.694971383414311m,
},
    NullableValue = 0.991330575815513m,
},
            new DecimaldecimalE0M
{
    Id = 103,
    Value = 0.810483426028348m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 112,
    Value = 0.0167816768749695m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 48,
    Value = 0.766273802165196m,
    NullableValue = 0.790541311778911m,
},
    NullableValue = 0.912109415244958m,
},
            new DecimaldecimalE0M
{
    Id = 117,
    Value = 0.08687259114652m,
    ModelInner = null,
    NullableValue = 0.38592239814231m,
},
            new DecimaldecimalE0M
{
    Id = 119,
    Value = 0.799559292501712m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 55,
    Value = 0.132191516667633m,
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 125,
    Value = 0.425011615648578m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 133,
    Value = 0.116673622573722m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 60,
    Value = 0.862384575729346m,
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 139,
    Value = 0.0737611924489409m,
    ModelInner = null,
    NullableValue = 0.100800681318584m,
},
            new DecimaldecimalE0M
{
    Id = 144,
    Value = 0.247696935960663m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 69,
    Value = 0.417582711685639m,
    NullableValue = 0.153919054686041m,
},
    NullableValue = 0.0844119454380974m,
},
            new DecimaldecimalE0M
{
    Id = 149,
    Value = 0.0280968649913869m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 154,
    Value = 0.0322481137115109m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 70,
    Value = 0.459445521712506m,
    NullableValue = 0.927135009130793m,
},
    NullableValue = 0.536198025092791m,
},
            new DecimaldecimalE0M
{
    Id = 157,
    Value = 0.914874933643394m,
    ModelInner = null,
    NullableValue = 0.350132621096608m,
},
            new DecimaldecimalE0M
{
    Id = 166,
    Value = 0.101586470498639m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 73,
    Value = 0.786168547331084m,
    NullableValue = null,
},
    NullableValue = 0.0549260433526679m,
},
            new DecimaldecimalE0M
{
    Id = 172,
    Value = 0.46490052855367m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 181,
    Value = 0.513775055492917m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 82,
    Value = 0.43986753698346m,
    NullableValue = null,
},
    NullableValue = 0.271758898601847m,
},
            new DecimaldecimalE0M
{
    Id = 184,
    Value = 0.211487560587492m,
    ModelInner = null,
    NullableValue = 0.2676459366235m,
},
            new DecimaldecimalE0M
{
    Id = 189,
    Value = 0.725266228911597m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 88,
    Value = 0.428444716797348m,
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 197,
    Value = 0.553852724538515m,
    ModelInner = null,
    NullableValue = 0.118713574300312m,
},
            new DecimaldecimalE0M
{
    Id = 204,
    Value = 0.863111522120303m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 97,
    Value = 0.527209270837808m,
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 213,
    Value = 0.638144042991039m,
    ModelInner = null,
    NullableValue = 0.491755966544144m,
},
        };

#endregion

#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.decimaldecimale0mi(
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
INSERT INTO dbo.decimaldecimale0mi(
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
INSERT INTO dbo.decimaldecimale0m(
	id,
    value,
    nullablevalue,
    decimaldecimale0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @decimaldecimale0mi_id
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
                parametrName: "decimaldecimale0mi_id", 
                methodParametrName: "decimaldecimale0mi_id", 
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
INSERT INTO dbo.decimaldecimale0m(
	id,
    value,
    nullablevalue,
    decimaldecimale0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @decimaldecimale0mi_id
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
                parametrName: "decimaldecimale0mi_id", 
                methodParametrName: "decimaldecimale0mi_id", 
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
            queryMapTypes: [typeof(FlatDecimaldecimalE0M), typeof(FlatDecimaldecimalE0M)],
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
FROM dbo.decimaldecimale0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimaldecimalE0M>();
                var models2 = new List<FlatDecimaldecimalE0M>();
                await((IDecimalSingleTypedecimal)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimalE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimaldecimalE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.decimaldecimale0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimaldecimalE0M>();
                var models2 = new List<FlatDecimaldecimalE0M>();
                ((IDecimalSingleTypedecimal)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimalE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimaldecimalE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimaldecimalE0M)],
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
FROM dbo.decimaldecimale0m m
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
                    FlatDecimaldecimalE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.decimaldecimale0m m
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
                    FlatDecimaldecimalE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.decimaldecimale0m m
LEFT JOIN dbo.decimaldecimale0mi mi ON mi.id = m.decimaldecimale0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DecimaldecimalE0M)],
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
                    DecimaldecimalE0M.AssertModel(models[i],_testData[i], false);
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
                    DecimaldecimalE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimaldecimalE0M), typeof(FlatDecimaldecimalE0M)],
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
FROM dbo.decimaldecimale0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimaldecimalE0M>();
                var models2 = new List<FlatDecimaldecimalE0M>();
                await((IDecimalSingleTypedecimal)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimalE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimaldecimalE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.decimaldecimale0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimaldecimalE0M>();
                var models2 = new List<FlatDecimaldecimalE0M>();
                ((IDecimalSingleTypedecimal)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimalE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimaldecimalE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimaldecimalE0M)],
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
FROM dbo.decimaldecimale0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalSingleTypedecimal)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimalE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.decimaldecimale0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalSingleTypedecimal)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimalE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.decimaldecimale0m m
LEFT JOIN dbo.decimaldecimale0mi mi ON mi.id = m.decimaldecimale0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DecimaldecimalE0M)],
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
                    DecimaldecimalE0M.AssertModel(models[i],_testData[i], false);
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
                    DecimaldecimalE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimaldecimalE0M), typeof(FlatDecimaldecimalE0M)],
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
FROM dbo.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimaldecimalE0M>();
                var models2 = new List<FlatDecimaldecimalE0M>();
                await((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimalE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimaldecimalE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 81;
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
FROM dbo.decimaldecimale0m m
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
FROM dbo.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimalE0M>();
                var firstItems2 = new List<FlatDecimaldecimalE0M>();
                var secondItems1 = new List<FlatDecimaldecimalE0M>();
                var secondItems2 = new List<FlatDecimaldecimalE0M>();
                await ((IDecimalSingleTypedecimal)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
FROM dbo.decimaldecimale0m m
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
FROM dbo.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimalE0M>();
                var firstItems2 = new List<FlatDecimaldecimalE0M>();
                var secondItems1 = new List<FlatDecimaldecimalE0M>();
                await ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM dbo.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimaldecimalE0M>();
                var models2 = new List<FlatDecimaldecimalE0M>();
                ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimalE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimaldecimalE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
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
FROM dbo.decimaldecimale0m m
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
FROM dbo.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimalE0M>();
                var firstItems2 = new List<FlatDecimaldecimalE0M>();
                var secondItems1 = new List<FlatDecimaldecimalE0M>();
                var secondItems2 = new List<FlatDecimaldecimalE0M>();
                 ((IDecimalSingleTypedecimal)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
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
FROM dbo.decimaldecimale0m m
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
FROM dbo.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimalE0M>();
                var firstItems2 = new List<FlatDecimaldecimalE0M>();
                var secondItems1 = new List<FlatDecimaldecimalE0M>();
                 ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[28],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimaldecimalE0M)],
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
FROM dbo.decimaldecimale0m m
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
                    FlatDecimaldecimalE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.decimaldecimale0m m
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
FROM dbo.decimaldecimale0m m
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
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatDecimaldecimalE0M.AssertModel(models[0],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(models[1],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(models[2],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(models[3],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(models[4],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(models[5],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(models[6],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(models[7],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(models[8],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(models[9],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(models[10],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(models[11],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(models[12],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(models[13],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatDecimaldecimalE0M.AssertModel(models[0],_testData[2], false);
                        FlatDecimaldecimalE0M.AssertModel(models[1],_testData[3], false);
                        FlatDecimaldecimalE0M.AssertModel(models[2],_testData[4], false);
                        FlatDecimaldecimalE0M.AssertModel(models[3],_testData[5], false);
                        FlatDecimaldecimalE0M.AssertModel(models[4],_testData[6], false);
                        FlatDecimaldecimalE0M.AssertModel(models[5],_testData[7], false);
                        FlatDecimaldecimalE0M.AssertModel(models[6],_testData[8], false);
                        FlatDecimaldecimalE0M.AssertModel(models[7],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(models[8],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(models[9],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(models[10],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(models[11],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(models[12],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(models[13],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(models[14],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(models[15],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(models[16],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(models[17],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(models[18],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(models[19],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(models[20],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(models[21],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(models[22],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(models[23],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(models[24],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(models[25],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(models[26],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(models[27],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(models[28],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(models[29],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(models[30],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(models[31],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.decimaldecimale0m m
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
FROM dbo.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimalE0M>();
                var secondItems1 = new List<FlatDecimaldecimalE0M>();
                var secondItems2 = new List<FlatDecimaldecimalE0M>();
                await ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM dbo.decimaldecimale0m m
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
                    FlatDecimaldecimalE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.decimaldecimale0m m
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
FROM dbo.decimaldecimale0m m
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
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatDecimaldecimalE0M.AssertModel(models[0],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(models[1],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(models[2],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(models[3],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(models[4],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(models[5],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(models[6],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(models[7],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(models[8],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(models[9],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(models[10],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(models[11],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(models[12],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatDecimaldecimalE0M.AssertModel(models[0],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(models[1],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(models[2],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(models[3],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(models[4],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(models[5],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(models[6],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(models[7],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(models[8],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(models[9],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(models[10],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(models[11],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.decimaldecimale0m m
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
FROM dbo.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimalE0M>();
                var secondItems1 = new List<FlatDecimaldecimalE0M>();
                var secondItems2 = new List<FlatDecimaldecimalE0M>();
                 ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM dbo.decimaldecimale0m m
LEFT JOIN dbo.decimaldecimale0mi mi ON mi.id = m.decimaldecimale0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DecimaldecimalE0M)],
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
                    DecimaldecimalE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        DecimaldecimalE0M.AssertModel(models[0],_testData[18], false);
                        DecimaldecimalE0M.AssertModel(models[1],_testData[19], false);
                        DecimaldecimalE0M.AssertModel(models[2],_testData[20], false);
                        DecimaldecimalE0M.AssertModel(models[3],_testData[21], false);
                        DecimaldecimalE0M.AssertModel(models[4],_testData[22], false);
                        DecimaldecimalE0M.AssertModel(models[5],_testData[23], false);
                        DecimaldecimalE0M.AssertModel(models[6],_testData[24], false);
                        DecimaldecimalE0M.AssertModel(models[7],_testData[25], false);
                        DecimaldecimalE0M.AssertModel(models[8],_testData[26], false);
                        DecimaldecimalE0M.AssertModel(models[9],_testData[27], false);
                        DecimaldecimalE0M.AssertModel(models[10],_testData[28], false);
                        DecimaldecimalE0M.AssertModel(models[11],_testData[29], false);
                        DecimaldecimalE0M.AssertModel(models[12],_testData[30], false);
                        DecimaldecimalE0M.AssertModel(models[13],_testData[31], false);
                        DecimaldecimalE0M.AssertModel(models[14],_testData[32], false);
                        DecimaldecimalE0M.AssertModel(models[15],_testData[33], false);
                        DecimaldecimalE0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        DecimaldecimalE0M.AssertModel(models[0],_testData[20], false);
                        DecimaldecimalE0M.AssertModel(models[1],_testData[21], false);
                        DecimaldecimalE0M.AssertModel(models[2],_testData[22], false);
                        DecimaldecimalE0M.AssertModel(models[3],_testData[23], false);
                        DecimaldecimalE0M.AssertModel(models[4],_testData[24], false);
                        DecimaldecimalE0M.AssertModel(models[5],_testData[25], false);
                        DecimaldecimalE0M.AssertModel(models[6],_testData[26], false);
                        DecimaldecimalE0M.AssertModel(models[7],_testData[27], false);
                        DecimaldecimalE0M.AssertModel(models[8],_testData[28], false);
                        DecimaldecimalE0M.AssertModel(models[9],_testData[29], false);
                        DecimaldecimalE0M.AssertModel(models[10],_testData[30], false);
                        DecimaldecimalE0M.AssertModel(models[11],_testData[31], false);
                        DecimaldecimalE0M.AssertModel(models[12],_testData[32], false);
                        DecimaldecimalE0M.AssertModel(models[13],_testData[33], false);
                        DecimaldecimalE0M.AssertModel(models[14],_testData[34], false);
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
                    DecimaldecimalE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 189;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        DecimaldecimalE0M.AssertModel(models[0],_testData[32], false);
                        DecimaldecimalE0M.AssertModel(models[1],_testData[33], false);
                        DecimaldecimalE0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        DecimaldecimalE0M.AssertModel(models[0],_testData[10], false);
                        DecimaldecimalE0M.AssertModel(models[1],_testData[11], false);
                        DecimaldecimalE0M.AssertModel(models[2],_testData[12], false);
                        DecimaldecimalE0M.AssertModel(models[3],_testData[13], false);
                        DecimaldecimalE0M.AssertModel(models[4],_testData[14], false);
                        DecimaldecimalE0M.AssertModel(models[5],_testData[15], false);
                        DecimaldecimalE0M.AssertModel(models[6],_testData[16], false);
                        DecimaldecimalE0M.AssertModel(models[7],_testData[17], false);
                        DecimaldecimalE0M.AssertModel(models[8],_testData[18], false);
                        DecimaldecimalE0M.AssertModel(models[9],_testData[19], false);
                        DecimaldecimalE0M.AssertModel(models[10],_testData[20], false);
                        DecimaldecimalE0M.AssertModel(models[11],_testData[21], false);
                        DecimaldecimalE0M.AssertModel(models[12],_testData[22], false);
                        DecimaldecimalE0M.AssertModel(models[13],_testData[23], false);
                        DecimaldecimalE0M.AssertModel(models[14],_testData[24], false);
                        DecimaldecimalE0M.AssertModel(models[15],_testData[25], false);
                        DecimaldecimalE0M.AssertModel(models[16],_testData[26], false);
                        DecimaldecimalE0M.AssertModel(models[17],_testData[27], false);
                        DecimaldecimalE0M.AssertModel(models[18],_testData[28], false);
                        DecimaldecimalE0M.AssertModel(models[19],_testData[29], false);
                        DecimaldecimalE0M.AssertModel(models[20],_testData[30], false);
                        DecimaldecimalE0M.AssertModel(models[21],_testData[31], false);
                        DecimaldecimalE0M.AssertModel(models[22],_testData[32], false);
                        DecimaldecimalE0M.AssertModel(models[23],_testData[33], false);
                        DecimaldecimalE0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimaldecimalE0M), typeof(FlatDecimaldecimalE0M)],
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
FROM dbo.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimaldecimalE0M>();
                var models2 = new List<FlatDecimaldecimalE0M>();
                await((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimalE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimaldecimalE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.decimaldecimale0m m
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
FROM dbo.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimalE0M>();
                var firstItems2 = new List<FlatDecimaldecimalE0M>();
                var secondItems1 = new List<FlatDecimaldecimalE0M>();
                var secondItems2 = new List<FlatDecimaldecimalE0M>();
                await ((IDecimalSingleTypedecimal)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 172, query1, 181, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM dbo.decimaldecimale0m m
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
FROM dbo.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimalE0M>();
                var firstItems2 = new List<FlatDecimaldecimalE0M>();
                var secondItems1 = new List<FlatDecimaldecimalE0M>();
                await ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 197, query1, 80, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[21],_testData[34], false);
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
FROM dbo.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimaldecimalE0M>();
                var models2 = new List<FlatDecimaldecimalE0M>();
                ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimalE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimaldecimalE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.decimaldecimale0m m
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
FROM dbo.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimalE0M>();
                var firstItems2 = new List<FlatDecimaldecimalE0M>();
                var secondItems1 = new List<FlatDecimaldecimalE0M>();
                var secondItems2 = new List<FlatDecimaldecimalE0M>();
                 ((IDecimalSingleTypedecimal)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 87, query1, 61, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM dbo.decimaldecimale0m m
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
FROM dbo.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimalE0M>();
                var firstItems2 = new List<FlatDecimaldecimalE0M>();
                var secondItems1 = new List<FlatDecimaldecimalE0M>();
                 ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelBatch(connection, 14, query1, 24, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[30],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimaldecimalE0M)],
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
FROM dbo.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimalE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.decimaldecimale0m m
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
FROM dbo.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 144, query1, 70, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDecimaldecimalE0M.AssertModel(models[0],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(models[1],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(models[2],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(models[3],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(models[4],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(models[5],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(models[6],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(models[7],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(models[8],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(models[9],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatDecimaldecimalE0M.AssertModel(models[0],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(models[1],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(models[2],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(models[3],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(models[4],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(models[5],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(models[6],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(models[7],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(models[8],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(models[9],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(models[10],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(models[11],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(models[12],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(models[13],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(models[14],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(models[15],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(models[16],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(models[17],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(models[18],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(models[19],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(models[20],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(models[21],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(models[22],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(models[23],_testData[34], false);
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
FROM dbo.decimaldecimale0m m
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
FROM dbo.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimalE0M>();
                var secondItems1 = new List<FlatDecimaldecimalE0M>();
                var secondItems2 = new List<FlatDecimaldecimalE0M>();
                await ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 24, query1, 103, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM dbo.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimalE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.decimaldecimale0m m
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
FROM dbo.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionSTDynQuerySelectModelBatch(connection, 172, query1, 96, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatDecimaldecimalE0M.AssertModel(models[0],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(models[1],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(models[2],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(models[3],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(models[4],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDecimaldecimalE0M.AssertModel(models[0],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(models[1],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(models[2],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(models[3],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(models[4],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(models[5],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(models[6],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(models[7],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(models[8],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(models[9],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(models[10],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(models[11],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(models[12],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(models[13],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(models[14],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(models[15],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(models[16],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(models[17],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(models[18],_testData[34], false);
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
FROM dbo.decimaldecimale0m m
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
FROM dbo.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimalE0M>();
                var secondItems1 = new List<FlatDecimaldecimalE0M>();
                var secondItems2 = new List<FlatDecimaldecimalE0M>();
                 ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelBatch(connection, 181, query1, 14, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM dbo.decimaldecimale0m m
LEFT JOIN dbo.decimaldecimale0mi mi ON mi.id = m.decimaldecimale0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DecimaldecimalE0M)],
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
                    DecimaldecimalE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelBatchAsync(connection, 139, 181))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        DecimaldecimalE0M.AssertModel(models[0],_testData[23], false);
                        DecimaldecimalE0M.AssertModel(models[1],_testData[24], false);
                        DecimaldecimalE0M.AssertModel(models[2],_testData[25], false);
                        DecimaldecimalE0M.AssertModel(models[3],_testData[26], false);
                        DecimaldecimalE0M.AssertModel(models[4],_testData[27], false);
                        DecimaldecimalE0M.AssertModel(models[5],_testData[28], false);
                        DecimaldecimalE0M.AssertModel(models[6],_testData[29], false);
                        DecimaldecimalE0M.AssertModel(models[7],_testData[30], false);
                        DecimaldecimalE0M.AssertModel(models[8],_testData[31], false);
                        DecimaldecimalE0M.AssertModel(models[9],_testData[32], false);
                        DecimaldecimalE0M.AssertModel(models[10],_testData[33], false);
                        DecimaldecimalE0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        DecimaldecimalE0M.AssertModel(models[0],_testData[30], false);
                        DecimaldecimalE0M.AssertModel(models[1],_testData[31], false);
                        DecimaldecimalE0M.AssertModel(models[2],_testData[32], false);
                        DecimaldecimalE0M.AssertModel(models[3],_testData[33], false);
                        DecimaldecimalE0M.AssertModel(models[4],_testData[34], false);
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
                    DecimaldecimalE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelBatch(connection, 52, 52))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        DecimaldecimalE0M.AssertModel(models[0],_testData[8], false);
                        DecimaldecimalE0M.AssertModel(models[1],_testData[9], false);
                        DecimaldecimalE0M.AssertModel(models[2],_testData[10], false);
                        DecimaldecimalE0M.AssertModel(models[3],_testData[11], false);
                        DecimaldecimalE0M.AssertModel(models[4],_testData[12], false);
                        DecimaldecimalE0M.AssertModel(models[5],_testData[13], false);
                        DecimaldecimalE0M.AssertModel(models[6],_testData[14], false);
                        DecimaldecimalE0M.AssertModel(models[7],_testData[15], false);
                        DecimaldecimalE0M.AssertModel(models[8],_testData[16], false);
                        DecimaldecimalE0M.AssertModel(models[9],_testData[17], false);
                        DecimaldecimalE0M.AssertModel(models[10],_testData[18], false);
                        DecimaldecimalE0M.AssertModel(models[11],_testData[19], false);
                        DecimaldecimalE0M.AssertModel(models[12],_testData[20], false);
                        DecimaldecimalE0M.AssertModel(models[13],_testData[21], false);
                        DecimaldecimalE0M.AssertModel(models[14],_testData[22], false);
                        DecimaldecimalE0M.AssertModel(models[15],_testData[23], false);
                        DecimaldecimalE0M.AssertModel(models[16],_testData[24], false);
                        DecimaldecimalE0M.AssertModel(models[17],_testData[25], false);
                        DecimaldecimalE0M.AssertModel(models[18],_testData[26], false);
                        DecimaldecimalE0M.AssertModel(models[19],_testData[27], false);
                        DecimaldecimalE0M.AssertModel(models[20],_testData[28], false);
                        DecimaldecimalE0M.AssertModel(models[21],_testData[29], false);
                        DecimaldecimalE0M.AssertModel(models[22],_testData[30], false);
                        DecimaldecimalE0M.AssertModel(models[23],_testData[31], false);
                        DecimaldecimalE0M.AssertModel(models[24],_testData[32], false);
                        DecimaldecimalE0M.AssertModel(models[25],_testData[33], false);
                        DecimaldecimalE0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        DecimaldecimalE0M.AssertModel(models[0],_testData[8], false);
                        DecimaldecimalE0M.AssertModel(models[1],_testData[9], false);
                        DecimaldecimalE0M.AssertModel(models[2],_testData[10], false);
                        DecimaldecimalE0M.AssertModel(models[3],_testData[11], false);
                        DecimaldecimalE0M.AssertModel(models[4],_testData[12], false);
                        DecimaldecimalE0M.AssertModel(models[5],_testData[13], false);
                        DecimaldecimalE0M.AssertModel(models[6],_testData[14], false);
                        DecimaldecimalE0M.AssertModel(models[7],_testData[15], false);
                        DecimaldecimalE0M.AssertModel(models[8],_testData[16], false);
                        DecimaldecimalE0M.AssertModel(models[9],_testData[17], false);
                        DecimaldecimalE0M.AssertModel(models[10],_testData[18], false);
                        DecimaldecimalE0M.AssertModel(models[11],_testData[19], false);
                        DecimaldecimalE0M.AssertModel(models[12],_testData[20], false);
                        DecimaldecimalE0M.AssertModel(models[13],_testData[21], false);
                        DecimaldecimalE0M.AssertModel(models[14],_testData[22], false);
                        DecimaldecimalE0M.AssertModel(models[15],_testData[23], false);
                        DecimaldecimalE0M.AssertModel(models[16],_testData[24], false);
                        DecimaldecimalE0M.AssertModel(models[17],_testData[25], false);
                        DecimaldecimalE0M.AssertModel(models[18],_testData[26], false);
                        DecimaldecimalE0M.AssertModel(models[19],_testData[27], false);
                        DecimaldecimalE0M.AssertModel(models[20],_testData[28], false);
                        DecimaldecimalE0M.AssertModel(models[21],_testData[29], false);
                        DecimaldecimalE0M.AssertModel(models[22],_testData[30], false);
                        DecimaldecimalE0M.AssertModel(models[23],_testData[31], false);
                        DecimaldecimalE0M.AssertModel(models[24],_testData[32], false);
                        DecimaldecimalE0M.AssertModel(models[25],_testData[33], false);
                        DecimaldecimalE0M.AssertModel(models[26],_testData[34], false);
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
                ((IDecimalSingleTypedecimal)this).SetDbConnectionSelectModelParametrs(cmd, 125);
                var models = await ((IDecimalSingleTypedecimal)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(14));

                DecimaldecimalE0M.AssertModel(models[0],_testData[21], false);
                DecimaldecimalE0M.AssertModel(models[1],_testData[22], false);
                DecimaldecimalE0M.AssertModel(models[2],_testData[23], false);
                DecimaldecimalE0M.AssertModel(models[3],_testData[24], false);
                DecimaldecimalE0M.AssertModel(models[4],_testData[25], false);
                DecimaldecimalE0M.AssertModel(models[5],_testData[26], false);
                DecimaldecimalE0M.AssertModel(models[6],_testData[27], false);
                DecimaldecimalE0M.AssertModel(models[7],_testData[28], false);
                DecimaldecimalE0M.AssertModel(models[8],_testData[29], false);
                DecimaldecimalE0M.AssertModel(models[9],_testData[30], false);
                DecimaldecimalE0M.AssertModel(models[10],_testData[31], false);
                DecimaldecimalE0M.AssertModel(models[11],_testData[32], false);
                DecimaldecimalE0M.AssertModel(models[12],_testData[33], false);
                DecimaldecimalE0M.AssertModel(models[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalSingleTypedecimal)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalSingleTypedecimal)this).SetDbConnectionSelectModelParametrs(cmd, 72);
                var models =  ((IDecimalSingleTypedecimal)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                DecimaldecimalE0M.AssertModel(models[0],_testData[12], false);
                DecimaldecimalE0M.AssertModel(models[1],_testData[13], false);
                DecimaldecimalE0M.AssertModel(models[2],_testData[14], false);
                DecimaldecimalE0M.AssertModel(models[3],_testData[15], false);
                DecimaldecimalE0M.AssertModel(models[4],_testData[16], false);
                DecimaldecimalE0M.AssertModel(models[5],_testData[17], false);
                DecimaldecimalE0M.AssertModel(models[6],_testData[18], false);
                DecimaldecimalE0M.AssertModel(models[7],_testData[19], false);
                DecimaldecimalE0M.AssertModel(models[8],_testData[20], false);
                DecimaldecimalE0M.AssertModel(models[9],_testData[21], false);
                DecimaldecimalE0M.AssertModel(models[10],_testData[22], false);
                DecimaldecimalE0M.AssertModel(models[11],_testData[23], false);
                DecimaldecimalE0M.AssertModel(models[12],_testData[24], false);
                DecimaldecimalE0M.AssertModel(models[13],_testData[25], false);
                DecimaldecimalE0M.AssertModel(models[14],_testData[26], false);
                DecimaldecimalE0M.AssertModel(models[15],_testData[27], false);
                DecimaldecimalE0M.AssertModel(models[16],_testData[28], false);
                DecimaldecimalE0M.AssertModel(models[17],_testData[29], false);
                DecimaldecimalE0M.AssertModel(models[18],_testData[30], false);
                DecimaldecimalE0M.AssertModel(models[19],_testData[31], false);
                DecimaldecimalE0M.AssertModel(models[20],_testData[32], false);
                DecimaldecimalE0M.AssertModel(models[21],_testData[33], false);
                DecimaldecimalE0M.AssertModel(models[22],_testData[34], false);
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
FROM dbo.decimaldecimale0m m
LEFT JOIN dbo.decimaldecimale0mi mi ON mi.id = m.decimaldecimale0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.664679286580577m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.809545081744866m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.221289399278423m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.902069904214991m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.00369236054257216m)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.643159703157704m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.417422373509401m)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.118152438147341m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.275284259604236m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.815218989984932m)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.466781345628435m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.346013374164657m)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.368572049853296m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.1978282360482m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.24461503965147m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0150679124420322m)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.501531075745009m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.395442852650101m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.135129138109522m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.792288994634889m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.747131779455892m)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.801388719191716m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.428478700457089m)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.526404088226787m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.164154962615493m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.450500650155559m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.454746845233383m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.366867793625736m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.594977527271858m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.735869290307916m)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.8477000236171m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.374388684381868m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.51496703270735m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.385532520364574m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.893506132012891m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.687664585161808m)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.165847886236076m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.530925783076103m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.694971383414311m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.991330575815513m)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.810483426028348m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0167816768749695m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.766273802165196m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.790541311778911m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.912109415244958m)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.08687259114652m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.38592239814231m)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.799559292501712m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.132191516667633m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.425011615648578m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.116673622573722m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.862384575729346m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0737611924489409m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.100800681318584m)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.247696935960663m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.417582711685639m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.153919054686041m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0844119454380974m)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0280968649913869m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0322481137115109m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.459445521712506m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.927135009130793m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.536198025092791m)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.914874933643394m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.350132621096608m)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.101586470498639m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.786168547331084m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0549260433526679m)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.46490052855367m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((181)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.513775055492917m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.43986753698346m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.271758898601847m)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((184)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.211487560587492m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.2676459366235m)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((189)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.725266228911597m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.428444716797348m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((197)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.553852724538515m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.118713574300312m)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((204)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.863111522120303m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((97)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.527209270837808m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((213)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.638144042991039m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.491755966544144m)));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.664679286580577m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.809545081744866m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.221289399278423m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.902069904214991m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.00369236054257216m)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.643159703157704m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.417422373509401m)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.118152438147341m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.275284259604236m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.815218989984932m)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.466781345628435m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.346013374164657m)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.368572049853296m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.1978282360482m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.24461503965147m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0150679124420322m)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.501531075745009m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.395442852650101m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.135129138109522m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.792288994634889m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.747131779455892m)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.801388719191716m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.428478700457089m)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.526404088226787m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.164154962615493m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.450500650155559m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.454746845233383m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.366867793625736m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.594977527271858m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.735869290307916m)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.8477000236171m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.374388684381868m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.51496703270735m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.385532520364574m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.893506132012891m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.687664585161808m)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.165847886236076m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.530925783076103m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.694971383414311m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.991330575815513m)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.810483426028348m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0167816768749695m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.766273802165196m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.790541311778911m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.912109415244958m)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.08687259114652m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.38592239814231m)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.799559292501712m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.132191516667633m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.425011615648578m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.116673622573722m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.862384575729346m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0737611924489409m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.100800681318584m)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.247696935960663m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.417582711685639m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.153919054686041m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0844119454380974m)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0280968649913869m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0322481137115109m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.459445521712506m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.927135009130793m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.536198025092791m)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.914874933643394m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.350132621096608m)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.101586470498639m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.786168547331084m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0549260433526679m)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.46490052855367m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((181)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.513775055492917m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.43986753698346m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.271758898601847m)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((184)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.211487560587492m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.2676459366235m)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((189)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.725266228911597m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.428444716797348m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((197)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.553852724538515m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.118713574300312m)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((204)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.863111522120303m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((97)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.527209270837808m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((213)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.638144042991039m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.491755966544144m)));

            }
        }

#endregion

    }
}

