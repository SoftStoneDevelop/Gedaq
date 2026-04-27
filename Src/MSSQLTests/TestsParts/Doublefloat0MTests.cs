

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
    Id = 3,
    Value = 0.9231286589176656d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 6,
    Value = 0.1056614925547733d,
    ModelInner = new Doublefloat0MI
{
    Id = 6,
    Value = 0.5572473282519018d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 10,
    Value = 0.6680771891876646d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 17,
    Value = 0.9965587320930357d,
    ModelInner = new Doublefloat0MI
{
    Id = 9,
    Value = 0.29542100139571215d,
    NullableValue = null,
},
    NullableValue = 0.5128657793173534d,
},
            new Doublefloat0M
{
    Id = 25,
    Value = 0.8094001558824863d,
    ModelInner = null,
    NullableValue = 0.9579271781384471d,
},
            new Doublefloat0M
{
    Id = 32,
    Value = 0.9241476954526072d,
    ModelInner = new Doublefloat0MI
{
    Id = 12,
    Value = 0.8657781308633946d,
    NullableValue = 0.7188363489963505d,
},
    NullableValue = 0.6680599274695961d,
},
            new Doublefloat0M
{
    Id = 38,
    Value = 0.41695259074603486d,
    ModelInner = null,
    NullableValue = 0.710592827796236d,
},
            new Doublefloat0M
{
    Id = 41,
    Value = 0.8936573814923777d,
    ModelInner = new Doublefloat0MI
{
    Id = 15,
    Value = 0.24913733993542397d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 46,
    Value = 0.008279556914647879d,
    ModelInner = null,
    NullableValue = 0.2757539557807863d,
},
            new Doublefloat0M
{
    Id = 53,
    Value = 0.9299831194300474d,
    ModelInner = new Doublefloat0MI
{
    Id = 17,
    Value = 0.08426050369213145d,
    NullableValue = null,
},
    NullableValue = 0.9184381418440698d,
},
            new Doublefloat0M
{
    Id = 59,
    Value = 0.5349843935720603d,
    ModelInner = null,
    NullableValue = 0.5033967419370687d,
},
            new Doublefloat0M
{
    Id = 66,
    Value = 0.8006299188303837d,
    ModelInner = new Doublefloat0MI
{
    Id = 21,
    Value = 0.05084512904054628d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 70,
    Value = 0.8499457032889325d,
    ModelInner = null,
    NullableValue = 0.9084841820878496d,
},
            new Doublefloat0M
{
    Id = 76,
    Value = 0.16064938328681067d,
    ModelInner = new Doublefloat0MI
{
    Id = 24,
    Value = 0.05423999867107199d,
    NullableValue = 0.8295985920220225d,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 81,
    Value = 0.9842316404630009d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 89,
    Value = 0.9876218913927199d,
    ModelInner = new Doublefloat0MI
{
    Id = 27,
    Value = 0.2201801251266149d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 94,
    Value = 0.6400711192127623d,
    ModelInner = null,
    NullableValue = 0.47256913321599847d,
},
            new Doublefloat0M
{
    Id = 100,
    Value = 0.9551293323253647d,
    ModelInner = new Doublefloat0MI
{
    Id = 33,
    Value = 0.30018210416390767d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 107,
    Value = 0.06403420625503398d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 111,
    Value = 0.2691225513183686d,
    ModelInner = new Doublefloat0MI
{
    Id = 35,
    Value = 0.4830165783316801d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 118,
    Value = 0.48391431861200085d,
    ModelInner = null,
    NullableValue = 0.4779451323338654d,
},
            new Doublefloat0M
{
    Id = 119,
    Value = 0.7351431250706906d,
    ModelInner = new Doublefloat0MI
{
    Id = 44,
    Value = 0.36970427268902906d,
    NullableValue = 0.6868518423830976d,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 123,
    Value = 0.38103899074362957d,
    ModelInner = null,
    NullableValue = 0.6959710132852028d,
},
            new Doublefloat0M
{
    Id = 127,
    Value = 0.2996230264910483d,
    ModelInner = new Doublefloat0MI
{
    Id = 53,
    Value = 0.8145804494889891d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 128,
    Value = 0.053857868386359975d,
    ModelInner = null,
    NullableValue = 0.876685031781493d,
},
            new Doublefloat0M
{
    Id = 129,
    Value = 0.5171669562074316d,
    ModelInner = new Doublefloat0MI
{
    Id = 59,
    Value = 0.9754544704822387d,
    NullableValue = 0.7911344694490478d,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 137,
    Value = 0.09414537965307845d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 139,
    Value = 0.2991761467085611d,
    ModelInner = new Doublefloat0MI
{
    Id = 62,
    Value = 0.9454687229363513d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 144,
    Value = 0.9820517793801599d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 149,
    Value = 0.43824987277404126d,
    ModelInner = new Doublefloat0MI
{
    Id = 63,
    Value = 0.7257649068704402d,
    NullableValue = null,
},
    NullableValue = 0.018542564902232384d,
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[29], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[21],_testData[29], false);
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
                parametr2.Value = 59;
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
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(models[6],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(models[7],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(models[8],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(models[9],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[10],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[11],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[12],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(models[6],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(models[7],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(models[8],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(models[9],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(models[10],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(models[11],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(models[12],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(models[13],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(models[14],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[15],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[16],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[17],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[18],_testData[29], false);
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
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[29], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(models[6],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(models[7],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[8],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[9],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[10],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[29], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[29], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Doublefloat0M.AssertModel(models[0],_testData[15], false);
                        Doublefloat0M.AssertModel(models[1],_testData[16], false);
                        Doublefloat0M.AssertModel(models[2],_testData[17], false);
                        Doublefloat0M.AssertModel(models[3],_testData[18], false);
                        Doublefloat0M.AssertModel(models[4],_testData[19], false);
                        Doublefloat0M.AssertModel(models[5],_testData[20], false);
                        Doublefloat0M.AssertModel(models[6],_testData[21], false);
                        Doublefloat0M.AssertModel(models[7],_testData[22], false);
                        Doublefloat0M.AssertModel(models[8],_testData[23], false);
                        Doublefloat0M.AssertModel(models[9],_testData[24], false);
                        Doublefloat0M.AssertModel(models[10],_testData[25], false);
                        Doublefloat0M.AssertModel(models[11],_testData[26], false);
                        Doublefloat0M.AssertModel(models[12],_testData[27], false);
                        Doublefloat0M.AssertModel(models[13],_testData[28], false);
                        Doublefloat0M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Doublefloat0M.AssertModel(models[0],_testData[12], false);
                        Doublefloat0M.AssertModel(models[1],_testData[13], false);
                        Doublefloat0M.AssertModel(models[2],_testData[14], false);
                        Doublefloat0M.AssertModel(models[3],_testData[15], false);
                        Doublefloat0M.AssertModel(models[4],_testData[16], false);
                        Doublefloat0M.AssertModel(models[5],_testData[17], false);
                        Doublefloat0M.AssertModel(models[6],_testData[18], false);
                        Doublefloat0M.AssertModel(models[7],_testData[19], false);
                        Doublefloat0M.AssertModel(models[8],_testData[20], false);
                        Doublefloat0M.AssertModel(models[9],_testData[21], false);
                        Doublefloat0M.AssertModel(models[10],_testData[22], false);
                        Doublefloat0M.AssertModel(models[11],_testData[23], false);
                        Doublefloat0M.AssertModel(models[12],_testData[24], false);
                        Doublefloat0M.AssertModel(models[13],_testData[25], false);
                        Doublefloat0M.AssertModel(models[14],_testData[26], false);
                        Doublefloat0M.AssertModel(models[15],_testData[27], false);
                        Doublefloat0M.AssertModel(models[16],_testData[28], false);
                        Doublefloat0M.AssertModel(models[17],_testData[29], false);
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Doublefloat0M.AssertModel(models[0],_testData[12], false);
                        Doublefloat0M.AssertModel(models[1],_testData[13], false);
                        Doublefloat0M.AssertModel(models[2],_testData[14], false);
                        Doublefloat0M.AssertModel(models[3],_testData[15], false);
                        Doublefloat0M.AssertModel(models[4],_testData[16], false);
                        Doublefloat0M.AssertModel(models[5],_testData[17], false);
                        Doublefloat0M.AssertModel(models[6],_testData[18], false);
                        Doublefloat0M.AssertModel(models[7],_testData[19], false);
                        Doublefloat0M.AssertModel(models[8],_testData[20], false);
                        Doublefloat0M.AssertModel(models[9],_testData[21], false);
                        Doublefloat0M.AssertModel(models[10],_testData[22], false);
                        Doublefloat0M.AssertModel(models[11],_testData[23], false);
                        Doublefloat0M.AssertModel(models[12],_testData[24], false);
                        Doublefloat0M.AssertModel(models[13],_testData[25], false);
                        Doublefloat0M.AssertModel(models[14],_testData[26], false);
                        Doublefloat0M.AssertModel(models[15],_testData[27], false);
                        Doublefloat0M.AssertModel(models[16],_testData[28], false);
                        Doublefloat0M.AssertModel(models[17],_testData[29], false);
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
                await ((IDoubleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 41, query1, 66, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[17],_testData[29], false);
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
                await ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 10, query1, 139, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[29], false);
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
                 ((IDoubleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 119, query1, 70, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[16],_testData[29], false);
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
                 ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelBatch(connection, 129, query1, 70, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[29], false);
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
                foreach(var batchResult in await ((IDoubleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 46, query1, 119, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(models[6],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(models[7],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(models[8],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(models[9],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(models[10],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(models[11],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(models[12],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(models[13],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(models[14],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(models[15],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(models[16],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[17],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[18],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[19],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 100, query1, 107, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[10],_testData[29], false);
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
                foreach(var batchResult in  ((IDoubleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelBatch(connection, 111, query1, 76, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[6],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[7],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[8],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                 ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelBatch(connection, 38, query1, 25, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[24],_testData[29], false);
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
                foreach(var batchResult in await ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelBatchAsync(connection, 70, 107))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Doublefloat0M.AssertModel(models[0],_testData[19], false);
                        Doublefloat0M.AssertModel(models[1],_testData[20], false);
                        Doublefloat0M.AssertModel(models[2],_testData[21], false);
                        Doublefloat0M.AssertModel(models[3],_testData[22], false);
                        Doublefloat0M.AssertModel(models[4],_testData[23], false);
                        Doublefloat0M.AssertModel(models[5],_testData[24], false);
                        Doublefloat0M.AssertModel(models[6],_testData[25], false);
                        Doublefloat0M.AssertModel(models[7],_testData[26], false);
                        Doublefloat0M.AssertModel(models[8],_testData[27], false);
                        Doublefloat0M.AssertModel(models[9],_testData[28], false);
                        Doublefloat0M.AssertModel(models[10],_testData[29], false);
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
                foreach(var batchResult in  ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelBatch(connection, 70, 123))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Doublefloat0M.AssertModel(models[0],_testData[23], false);
                        Doublefloat0M.AssertModel(models[1],_testData[24], false);
                        Doublefloat0M.AssertModel(models[2],_testData[25], false);
                        Doublefloat0M.AssertModel(models[3],_testData[26], false);
                        Doublefloat0M.AssertModel(models[4],_testData[27], false);
                        Doublefloat0M.AssertModel(models[5],_testData[28], false);
                        Doublefloat0M.AssertModel(models[6],_testData[29], false);
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
                ((IDoubleSingleTypefloat)this).SetDbConnectionSelectModelParametrs(cmd, 139);
                var models = await ((IDoubleSingleTypefloat)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
Doublefloat0M.AssertModel(models[0],_testData[28], false);Doublefloat0M.AssertModel(models[1],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleSingleTypefloat)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleSingleTypefloat)this).SetDbConnectionSelectModelParametrs(cmd, 76);
                var models =  ((IDoubleSingleTypefloat)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
Doublefloat0M.AssertModel(models[0],_testData[14], false);Doublefloat0M.AssertModel(models[1],_testData[15], false);Doublefloat0M.AssertModel(models[2],_testData[16], false);Doublefloat0M.AssertModel(models[3],_testData[17], false);Doublefloat0M.AssertModel(models[4],_testData[18], false);Doublefloat0M.AssertModel(models[5],_testData[19], false);Doublefloat0M.AssertModel(models[6],_testData[20], false);Doublefloat0M.AssertModel(models[7],_testData[21], false);Doublefloat0M.AssertModel(models[8],_testData[22], false);Doublefloat0M.AssertModel(models[9],_testData[23], false);Doublefloat0M.AssertModel(models[10],_testData[24], false);Doublefloat0M.AssertModel(models[11],_testData[25], false);Doublefloat0M.AssertModel(models[12],_testData[26], false);Doublefloat0M.AssertModel(models[13],_testData[27], false);Doublefloat0M.AssertModel(models[14],_testData[28], false);Doublefloat0M.AssertModel(models[15],_testData[29], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9231286589176656d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.1056614925547733d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5572473282519018d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6680771891876646d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9965587320930357d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.29542100139571215d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5128657793173534d)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8094001558824863d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9579271781384471d)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9241476954526072d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8657781308633946d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7188363489963505d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6680599274695961d)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.41695259074603486d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.710592827796236d)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8936573814923777d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.24913733993542397d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.008279556914647879d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.2757539557807863d)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9299831194300474d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.08426050369213145d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9184381418440698d)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5349843935720603d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5033967419370687d)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8006299188303837d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.05084512904054628d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8499457032889325d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9084841820878496d)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.16064938328681067d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.05423999867107199d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.8295985920220225d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9842316404630009d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9876218913927199d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.2201801251266149d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6400711192127623d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.47256913321599847d)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9551293323253647d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.30018210416390767d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.06403420625503398d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2691225513183686d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4830165783316801d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.48391431861200085d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4779451323338654d)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7351431250706906d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.36970427268902906d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.6868518423830976d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.38103899074362957d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6959710132852028d)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2996230264910483d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8145804494889891d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.053857868386359975d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.876685031781493d)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5171669562074316d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9754544704822387d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7911344694490478d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.09414537965307845d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2991761467085611d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9454687229363513d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9820517793801599d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.43824987277404126d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7257649068704402d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.018542564902232384d)));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9231286589176656d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.1056614925547733d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5572473282519018d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6680771891876646d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9965587320930357d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.29542100139571215d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5128657793173534d)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8094001558824863d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9579271781384471d)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9241476954526072d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8657781308633946d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7188363489963505d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6680599274695961d)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.41695259074603486d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.710592827796236d)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8936573814923777d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.24913733993542397d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.008279556914647879d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.2757539557807863d)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9299831194300474d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.08426050369213145d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9184381418440698d)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5349843935720603d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5033967419370687d)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8006299188303837d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.05084512904054628d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8499457032889325d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9084841820878496d)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.16064938328681067d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.05423999867107199d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.8295985920220225d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9842316404630009d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9876218913927199d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.2201801251266149d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6400711192127623d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.47256913321599847d)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9551293323253647d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.30018210416390767d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.06403420625503398d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2691225513183686d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4830165783316801d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.48391431861200085d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4779451323338654d)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7351431250706906d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.36970427268902906d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.6868518423830976d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.38103899074362957d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6959710132852028d)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2996230264910483d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8145804494889891d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.053857868386359975d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.876685031781493d)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5171669562074316d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9754544704822387d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7911344694490478d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.09414537965307845d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2991761467085611d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9454687229363513d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9820517793801599d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.43824987277404126d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7257649068704402d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.018542564902232384d)));

            }
        }

#endregion

    }
}

