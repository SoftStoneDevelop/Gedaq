

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
    internal partial interface IDoubleSingleTypedouble
    {
    }
    
    internal partial class DoubleSingleTypedouble : IDoubleSingleTypedouble
    {


#region TestData

        private readonly Doubledouble0M[] _testData = new Doubledouble0M[]
        {
            new Doubledouble0M
{
    Id = 2,
    Value = 0.9846222833451315d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 7,
    Value = 0.5450041058372586d,
    ModelInner = new Doubledouble0MI
{
    Id = 3,
    Value = 0.2049291853567119d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 14,
    Value = 0.06996671050241954d,
    ModelInner = null,
    NullableValue = 0.6916806173639118d,
},
            new Doubledouble0M
{
    Id = 19,
    Value = 0.8953294253602977d,
    ModelInner = new Doubledouble0MI
{
    Id = 8,
    Value = 0.8558228990573897d,
    NullableValue = 0.5251359198945239d,
},
    NullableValue = 0.4134744209277186d,
},
            new Doubledouble0M
{
    Id = 20,
    Value = 0.07231994517761897d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 24,
    Value = 0.31739775636819234d,
    ModelInner = new Doubledouble0MI
{
    Id = 11,
    Value = 0.1673376059817666d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 33,
    Value = 0.2944113697597357d,
    ModelInner = null,
    NullableValue = 0.3983634365251527d,
},
            new Doubledouble0M
{
    Id = 39,
    Value = 0.8504663578423682d,
    ModelInner = new Doubledouble0MI
{
    Id = 15,
    Value = 0.4701117506551866d,
    NullableValue = 0.16431658371847557d,
},
    NullableValue = 0.445173253451132d,
},
            new Doubledouble0M
{
    Id = 40,
    Value = 0.8932335702332185d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 48,
    Value = 0.14023855013866404d,
    ModelInner = new Doubledouble0MI
{
    Id = 24,
    Value = 0.06246419175616347d,
    NullableValue = null,
},
    NullableValue = 0.06789737713986466d,
},
            new Doubledouble0M
{
    Id = 54,
    Value = 0.48144000467010073d,
    ModelInner = null,
    NullableValue = 0.4607373924943593d,
},
            new Doubledouble0M
{
    Id = 60,
    Value = 0.6844561442132823d,
    ModelInner = new Doubledouble0MI
{
    Id = 33,
    Value = 0.07307206140577893d,
    NullableValue = 0.4444274591929599d,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 61,
    Value = 0.6440043311240408d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 64,
    Value = 0.9488194504483253d,
    ModelInner = new Doubledouble0MI
{
    Id = 34,
    Value = 0.07396676061357943d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 69,
    Value = 0.615955229995316d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 73,
    Value = 0.14362284104801537d,
    ModelInner = new Doubledouble0MI
{
    Id = 42,
    Value = 0.6077396334849884d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 78,
    Value = 0.7039902129695818d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 79,
    Value = 0.623295195954171d,
    ModelInner = new Doubledouble0MI
{
    Id = 43,
    Value = 0.4474412889552519d,
    NullableValue = 0.898652033476324d,
},
    NullableValue = 0.5403495956196551d,
},
            new Doubledouble0M
{
    Id = 80,
    Value = 0.6334896577543138d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 82,
    Value = 0.8849615991458033d,
    ModelInner = new Doubledouble0MI
{
    Id = 44,
    Value = 0.4408552637810508d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 83,
    Value = 0.6759488603046468d,
    ModelInner = null,
    NullableValue = 0.8009216578510832d,
},
            new Doubledouble0M
{
    Id = 91,
    Value = 0.13157961826453912d,
    ModelInner = new Doubledouble0MI
{
    Id = 51,
    Value = 0.5630837262766961d,
    NullableValue = 0.9325028362004973d,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 94,
    Value = 0.03162677530486835d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 97,
    Value = 0.49972409845853816d,
    ModelInner = new Doubledouble0MI
{
    Id = 60,
    Value = 0.46687328644176307d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 103,
    Value = 0.31604747061455296d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 107,
    Value = 0.2985724293982661d,
    ModelInner = new Doubledouble0MI
{
    Id = 64,
    Value = 0.3475705803516679d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 110,
    Value = 0.5671724793324538d,
    ModelInner = null,
    NullableValue = 0.49897669627833774d,
},
            new Doubledouble0M
{
    Id = 117,
    Value = 0.006379170453560068d,
    ModelInner = new Doubledouble0MI
{
    Id = 72,
    Value = 0.6351911349255582d,
    NullableValue = 0.04055298173659305d,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 124,
    Value = 0.4005844283051625d,
    ModelInner = null,
    NullableValue = 0.6491785306493202d,
},
            new Doubledouble0M
{
    Id = 125,
    Value = 0.3228527188011793d,
    ModelInner = new Doubledouble0MI
{
    Id = 76,
    Value = 0.17069540923770932d,
    NullableValue = 0.15557032667961457d,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 126,
    Value = 0.6156132447865755d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 131,
    Value = 0.2250107484682261d,
    ModelInner = new Doubledouble0MI
{
    Id = 84,
    Value = 0.2696039624163422d,
    NullableValue = 0.14665499043727448d,
},
    NullableValue = 0.027513626671332392d,
},
            new Doubledouble0M
{
    Id = 138,
    Value = 0.0700219959353875d,
    ModelInner = null,
    NullableValue = 0.6289300429096777d,
},
            new Doubledouble0M
{
    Id = 146,
    Value = 0.07396321110112092d,
    ModelInner = new Doubledouble0MI
{
    Id = 89,
    Value = 0.9045669715734357d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 147,
    Value = 0.305075017427456d,
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.doubledouble0mi(
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
            asPartInterface: typeof(IDoubleSingleTypedouble)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Double),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (MySqlConnector.MySqlDbType)(5)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (MySqlConnector.MySqlDbType)(5))]
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

                changedRows =  ((IDoubleSingleTypedouble)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleSingleTypedouble)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleSingleTypedouble)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.doubledouble0mi(
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
            asPartInterface: typeof(IDoubleSingleTypedouble)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Double), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(8)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(8), 
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

                changedRows =  ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModel(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.doubledouble0m(
	id,
    value,
    nullablevalue,
    doubledouble0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @doubledouble0mi_id
)
",
            methodName:"InsertModel",
            sourceType: SourceType.MySqlConnection,
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Double), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (MySqlConnector.MySqlDbType)(5)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (MySqlConnector.MySqlDbType)(5),
                nullable: true),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "doubledouble0mi_id", 
                methodParametrName: "doubledouble0mi_id", 
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

                changedRows =  ((IDoubleSingleTypedouble)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleSingleTypedouble)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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

                changedRows = await ((IDoubleSingleTypedouble)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.doubledouble0m(
	id,
    value,
    nullablevalue,
    doubledouble0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @doubledouble0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Double), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(8)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(8),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "doubledouble0mi_id", 
                methodParametrName: "doubledouble0mi_id", 
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

                changedRows =  ((IDoubleSingleTypedouble)this).DbConnectionInsertModel(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleSingleTypedouble)this).DbConnectionInsertModel(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
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

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble0M), typeof(FlatDoubledouble0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
FROM gedaqtests.doubledouble0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble0M>();
                var models2 = new List<FlatDoubledouble0M>();
                await((IDoubleSingleTypedouble)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.doubledouble0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble0M>();
                var models2 = new List<FlatDoubledouble0M>();
                ((IDoubleSingleTypedouble)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
FROM gedaqtests.doubledouble0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = await((IDoubleSingleTypedouble)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.doubledouble0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = ((IDoubleSingleTypedouble)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.doubledouble0m m
LEFT JOIN gedaqtests.doubledouble0mi mi ON mi.id = m.doubledouble0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
                var models = await((IDoubleSingleTypedouble)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDoubleSingleTypedouble)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble0M), typeof(FlatDoubledouble0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
FROM gedaqtests.doubledouble0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble0M>();
                var models2 = new List<FlatDoubledouble0M>();
                await((IDoubleSingleTypedouble)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.doubledouble0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble0M>();
                var models2 = new List<FlatDoubledouble0M>();
                ((IDoubleSingleTypedouble)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
FROM gedaqtests.doubledouble0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleSingleTypedouble)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.doubledouble0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleSingleTypedouble)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.doubledouble0m m
LEFT JOIN gedaqtests.doubledouble0mi mi ON mi.id = m.doubledouble0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Doubledouble0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
                var models = await((IDoubleSingleTypedouble)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDoubleSingleTypedouble)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble0M), typeof(FlatDoubledouble0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble0M>();
                var models2 = new List<FlatDoubledouble0M>();
                await((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble0M>();
                var firstItems2 = new List<FlatDoubledouble0M>();
                var secondItems1 = new List<FlatDoubledouble0M>();
                var secondItems2 = new List<FlatDoubledouble0M>();
                await ((IDoubleSingleTypedouble)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 78;
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble0M>();
                var firstItems2 = new List<FlatDoubledouble0M>();
                var secondItems1 = new List<FlatDoubledouble0M>();
                await ((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[34], false);
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble0M>();
                var models2 = new List<FlatDoubledouble0M>();
                ((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble0M>();
                var firstItems2 = new List<FlatDoubledouble0M>();
                var secondItems1 = new List<FlatDoubledouble0M>();
                var secondItems2 = new List<FlatDoubledouble0M>();
                 ((IDoubleSingleTypedouble)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble0M>();
                var firstItems2 = new List<FlatDoubledouble0M>();
                var secondItems1 = new List<FlatDoubledouble0M>();
                 ((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[18],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypedouble)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(models[6],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(models[7],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(models[8],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(models[9],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(models[10],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(models[11],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(models[12],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(models[13],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble0M>();
                var secondItems1 = new List<FlatDoubledouble0M>();
                var secondItems2 = new List<FlatDoubledouble0M>();
                await ((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypedouble)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(models[6],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(models[7],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(models[8],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(models[9],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(models[10],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(models[11],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(models[12],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(models[13],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(models[14],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(models[15],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(models[16],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(models[17],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(models[18],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(models[19],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(models[20],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(models[21],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(models[6],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(models[7],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(models[8],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(models[9],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(models[10],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(models[11],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble0M>();
                var secondItems1 = new List<FlatDoubledouble0M>();
                var secondItems2 = new List<FlatDoubledouble0M>();
                 ((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM gedaqtests.doubledouble0m m
LEFT JOIN gedaqtests.doubledouble0mi mi ON mi.id = m.doubledouble0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
                var models = await((IDoubleSingleTypedouble)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypedouble)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Doubledouble0M.AssertModel(models[0],_testData[29], false);
                        Doubledouble0M.AssertModel(models[1],_testData[30], false);
                        Doubledouble0M.AssertModel(models[2],_testData[31], false);
                        Doubledouble0M.AssertModel(models[3],_testData[32], false);
                        Doubledouble0M.AssertModel(models[4],_testData[33], false);
                        Doubledouble0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Doubledouble0M.AssertModel(models[0],_testData[9], false);
                        Doubledouble0M.AssertModel(models[1],_testData[10], false);
                        Doubledouble0M.AssertModel(models[2],_testData[11], false);
                        Doubledouble0M.AssertModel(models[3],_testData[12], false);
                        Doubledouble0M.AssertModel(models[4],_testData[13], false);
                        Doubledouble0M.AssertModel(models[5],_testData[14], false);
                        Doubledouble0M.AssertModel(models[6],_testData[15], false);
                        Doubledouble0M.AssertModel(models[7],_testData[16], false);
                        Doubledouble0M.AssertModel(models[8],_testData[17], false);
                        Doubledouble0M.AssertModel(models[9],_testData[18], false);
                        Doubledouble0M.AssertModel(models[10],_testData[19], false);
                        Doubledouble0M.AssertModel(models[11],_testData[20], false);
                        Doubledouble0M.AssertModel(models[12],_testData[21], false);
                        Doubledouble0M.AssertModel(models[13],_testData[22], false);
                        Doubledouble0M.AssertModel(models[14],_testData[23], false);
                        Doubledouble0M.AssertModel(models[15],_testData[24], false);
                        Doubledouble0M.AssertModel(models[16],_testData[25], false);
                        Doubledouble0M.AssertModel(models[17],_testData[26], false);
                        Doubledouble0M.AssertModel(models[18],_testData[27], false);
                        Doubledouble0M.AssertModel(models[19],_testData[28], false);
                        Doubledouble0M.AssertModel(models[20],_testData[29], false);
                        Doubledouble0M.AssertModel(models[21],_testData[30], false);
                        Doubledouble0M.AssertModel(models[22],_testData[31], false);
                        Doubledouble0M.AssertModel(models[23],_testData[32], false);
                        Doubledouble0M.AssertModel(models[24],_testData[33], false);
                        Doubledouble0M.AssertModel(models[25],_testData[34], false);
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
                var models = ((IDoubleSingleTypedouble)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypedouble)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Doubledouble0M.AssertModel(models[0],_testData[1], false);
                        Doubledouble0M.AssertModel(models[1],_testData[2], false);
                        Doubledouble0M.AssertModel(models[2],_testData[3], false);
                        Doubledouble0M.AssertModel(models[3],_testData[4], false);
                        Doubledouble0M.AssertModel(models[4],_testData[5], false);
                        Doubledouble0M.AssertModel(models[5],_testData[6], false);
                        Doubledouble0M.AssertModel(models[6],_testData[7], false);
                        Doubledouble0M.AssertModel(models[7],_testData[8], false);
                        Doubledouble0M.AssertModel(models[8],_testData[9], false);
                        Doubledouble0M.AssertModel(models[9],_testData[10], false);
                        Doubledouble0M.AssertModel(models[10],_testData[11], false);
                        Doubledouble0M.AssertModel(models[11],_testData[12], false);
                        Doubledouble0M.AssertModel(models[12],_testData[13], false);
                        Doubledouble0M.AssertModel(models[13],_testData[14], false);
                        Doubledouble0M.AssertModel(models[14],_testData[15], false);
                        Doubledouble0M.AssertModel(models[15],_testData[16], false);
                        Doubledouble0M.AssertModel(models[16],_testData[17], false);
                        Doubledouble0M.AssertModel(models[17],_testData[18], false);
                        Doubledouble0M.AssertModel(models[18],_testData[19], false);
                        Doubledouble0M.AssertModel(models[19],_testData[20], false);
                        Doubledouble0M.AssertModel(models[20],_testData[21], false);
                        Doubledouble0M.AssertModel(models[21],_testData[22], false);
                        Doubledouble0M.AssertModel(models[22],_testData[23], false);
                        Doubledouble0M.AssertModel(models[23],_testData[24], false);
                        Doubledouble0M.AssertModel(models[24],_testData[25], false);
                        Doubledouble0M.AssertModel(models[25],_testData[26], false);
                        Doubledouble0M.AssertModel(models[26],_testData[27], false);
                        Doubledouble0M.AssertModel(models[27],_testData[28], false);
                        Doubledouble0M.AssertModel(models[28],_testData[29], false);
                        Doubledouble0M.AssertModel(models[29],_testData[30], false);
                        Doubledouble0M.AssertModel(models[30],_testData[31], false);
                        Doubledouble0M.AssertModel(models[31],_testData[32], false);
                        Doubledouble0M.AssertModel(models[32],_testData[33], false);
                        Doubledouble0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Doubledouble0M.AssertModel(models[0],_testData[17], false);
                        Doubledouble0M.AssertModel(models[1],_testData[18], false);
                        Doubledouble0M.AssertModel(models[2],_testData[19], false);
                        Doubledouble0M.AssertModel(models[3],_testData[20], false);
                        Doubledouble0M.AssertModel(models[4],_testData[21], false);
                        Doubledouble0M.AssertModel(models[5],_testData[22], false);
                        Doubledouble0M.AssertModel(models[6],_testData[23], false);
                        Doubledouble0M.AssertModel(models[7],_testData[24], false);
                        Doubledouble0M.AssertModel(models[8],_testData[25], false);
                        Doubledouble0M.AssertModel(models[9],_testData[26], false);
                        Doubledouble0M.AssertModel(models[10],_testData[27], false);
                        Doubledouble0M.AssertModel(models[11],_testData[28], false);
                        Doubledouble0M.AssertModel(models[12],_testData[29], false);
                        Doubledouble0M.AssertModel(models[13],_testData[30], false);
                        Doubledouble0M.AssertModel(models[14],_testData[31], false);
                        Doubledouble0M.AssertModel(models[15],_testData[32], false);
                        Doubledouble0M.AssertModel(models[16],_testData[33], false);
                        Doubledouble0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble0M), typeof(FlatDoubledouble0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble0M>();
                var models2 = new List<FlatDoubledouble0M>();
                await((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble0M>();
                var firstItems2 = new List<FlatDoubledouble0M>();
                var secondItems1 = new List<FlatDoubledouble0M>();
                var secondItems2 = new List<FlatDoubledouble0M>();
                await ((IDoubleSingleTypedouble)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 94, query1, 33, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble0M>();
                var firstItems2 = new List<FlatDoubledouble0M>();
                var secondItems1 = new List<FlatDoubledouble0M>();
                await ((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 73, query1, 117, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[34], false);
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble0M>();
                var models2 = new List<FlatDoubledouble0M>();
                ((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble0M>();
                var firstItems2 = new List<FlatDoubledouble0M>();
                var secondItems1 = new List<FlatDoubledouble0M>();
                var secondItems2 = new List<FlatDoubledouble0M>();
                 ((IDoubleSingleTypedouble)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 82, query1, 69, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble0M>();
                var firstItems2 = new List<FlatDoubledouble0M>();
                var secondItems1 = new List<FlatDoubledouble0M>();
                 ((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModelBatch(connection, 19, query1, 20, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[29],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypedouble)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 97, query1, 2, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(models[6],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(models[7],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(models[8],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(models[9],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[1], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[2], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[3], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(models[6],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(models[7],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(models[8],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(models[9],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(models[10],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(models[11],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(models[12],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(models[13],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(models[14],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(models[15],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(models[16],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(models[17],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(models[18],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(models[19],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(models[20],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(models[21],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(models[22],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(models[23],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(models[24],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(models[25],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(models[26],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(models[27],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(models[28],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(models[29],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(models[30],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(models[31],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(models[32],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(models[33],_testData[34], false);
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble0M>();
                var secondItems1 = new List<FlatDoubledouble0M>();
                var secondItems2 = new List<FlatDoubledouble0M>();
                await ((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 83, query1, 60, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypedouble)this).DbConnectionSTDynQuerySelectModelBatch(connection, 124, query1, 126, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[34], false);
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble0M>();
                var secondItems1 = new List<FlatDoubledouble0M>();
                var secondItems2 = new List<FlatDoubledouble0M>();
                 ((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModelBatch(connection, 54, query1, 19, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM gedaqtests.doubledouble0m m
LEFT JOIN gedaqtests.doubledouble0mi mi ON mi.id = m.doubledouble0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Doubledouble0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
                var models = await((IDoubleSingleTypedouble)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleSingleTypedouble)this).DbConnectionSTSelectModelBatchAsync(connection, 69, 61))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Doubledouble0M.AssertModel(models[0],_testData[15], false);
                        Doubledouble0M.AssertModel(models[1],_testData[16], false);
                        Doubledouble0M.AssertModel(models[2],_testData[17], false);
                        Doubledouble0M.AssertModel(models[3],_testData[18], false);
                        Doubledouble0M.AssertModel(models[4],_testData[19], false);
                        Doubledouble0M.AssertModel(models[5],_testData[20], false);
                        Doubledouble0M.AssertModel(models[6],_testData[21], false);
                        Doubledouble0M.AssertModel(models[7],_testData[22], false);
                        Doubledouble0M.AssertModel(models[8],_testData[23], false);
                        Doubledouble0M.AssertModel(models[9],_testData[24], false);
                        Doubledouble0M.AssertModel(models[10],_testData[25], false);
                        Doubledouble0M.AssertModel(models[11],_testData[26], false);
                        Doubledouble0M.AssertModel(models[12],_testData[27], false);
                        Doubledouble0M.AssertModel(models[13],_testData[28], false);
                        Doubledouble0M.AssertModel(models[14],_testData[29], false);
                        Doubledouble0M.AssertModel(models[15],_testData[30], false);
                        Doubledouble0M.AssertModel(models[16],_testData[31], false);
                        Doubledouble0M.AssertModel(models[17],_testData[32], false);
                        Doubledouble0M.AssertModel(models[18],_testData[33], false);
                        Doubledouble0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Doubledouble0M.AssertModel(models[0],_testData[13], false);
                        Doubledouble0M.AssertModel(models[1],_testData[14], false);
                        Doubledouble0M.AssertModel(models[2],_testData[15], false);
                        Doubledouble0M.AssertModel(models[3],_testData[16], false);
                        Doubledouble0M.AssertModel(models[4],_testData[17], false);
                        Doubledouble0M.AssertModel(models[5],_testData[18], false);
                        Doubledouble0M.AssertModel(models[6],_testData[19], false);
                        Doubledouble0M.AssertModel(models[7],_testData[20], false);
                        Doubledouble0M.AssertModel(models[8],_testData[21], false);
                        Doubledouble0M.AssertModel(models[9],_testData[22], false);
                        Doubledouble0M.AssertModel(models[10],_testData[23], false);
                        Doubledouble0M.AssertModel(models[11],_testData[24], false);
                        Doubledouble0M.AssertModel(models[12],_testData[25], false);
                        Doubledouble0M.AssertModel(models[13],_testData[26], false);
                        Doubledouble0M.AssertModel(models[14],_testData[27], false);
                        Doubledouble0M.AssertModel(models[15],_testData[28], false);
                        Doubledouble0M.AssertModel(models[16],_testData[29], false);
                        Doubledouble0M.AssertModel(models[17],_testData[30], false);
                        Doubledouble0M.AssertModel(models[18],_testData[31], false);
                        Doubledouble0M.AssertModel(models[19],_testData[32], false);
                        Doubledouble0M.AssertModel(models[20],_testData[33], false);
                        Doubledouble0M.AssertModel(models[21],_testData[34], false);
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
                var models = ((IDoubleSingleTypedouble)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleSingleTypedouble)this).DbConnectionSTSelectModelBatch(connection, 69, 138))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Doubledouble0M.AssertModel(models[0],_testData[15], false);
                        Doubledouble0M.AssertModel(models[1],_testData[16], false);
                        Doubledouble0M.AssertModel(models[2],_testData[17], false);
                        Doubledouble0M.AssertModel(models[3],_testData[18], false);
                        Doubledouble0M.AssertModel(models[4],_testData[19], false);
                        Doubledouble0M.AssertModel(models[5],_testData[20], false);
                        Doubledouble0M.AssertModel(models[6],_testData[21], false);
                        Doubledouble0M.AssertModel(models[7],_testData[22], false);
                        Doubledouble0M.AssertModel(models[8],_testData[23], false);
                        Doubledouble0M.AssertModel(models[9],_testData[24], false);
                        Doubledouble0M.AssertModel(models[10],_testData[25], false);
                        Doubledouble0M.AssertModel(models[11],_testData[26], false);
                        Doubledouble0M.AssertModel(models[12],_testData[27], false);
                        Doubledouble0M.AssertModel(models[13],_testData[28], false);
                        Doubledouble0M.AssertModel(models[14],_testData[29], false);
                        Doubledouble0M.AssertModel(models[15],_testData[30], false);
                        Doubledouble0M.AssertModel(models[16],_testData[31], false);
                        Doubledouble0M.AssertModel(models[17],_testData[32], false);
                        Doubledouble0M.AssertModel(models[18],_testData[33], false);
                        Doubledouble0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Doubledouble0M.AssertModel(models[0],_testData[33], false);
                        Doubledouble0M.AssertModel(models[1],_testData[34], false);
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
                await using var cmd = await ((IDoubleSingleTypedouble)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleSingleTypedouble)this).SetDbConnectionSelectModelParametrs(cmd, 20);
                var models = await ((IDoubleSingleTypedouble)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(30));

                Doubledouble0M.AssertModel(models[0],_testData[5], false);
                Doubledouble0M.AssertModel(models[1],_testData[6], false);
                Doubledouble0M.AssertModel(models[2],_testData[7], false);
                Doubledouble0M.AssertModel(models[3],_testData[8], false);
                Doubledouble0M.AssertModel(models[4],_testData[9], false);
                Doubledouble0M.AssertModel(models[5],_testData[10], false);
                Doubledouble0M.AssertModel(models[6],_testData[11], false);
                Doubledouble0M.AssertModel(models[7],_testData[12], false);
                Doubledouble0M.AssertModel(models[8],_testData[13], false);
                Doubledouble0M.AssertModel(models[9],_testData[14], false);
                Doubledouble0M.AssertModel(models[10],_testData[15], false);
                Doubledouble0M.AssertModel(models[11],_testData[16], false);
                Doubledouble0M.AssertModel(models[12],_testData[17], false);
                Doubledouble0M.AssertModel(models[13],_testData[18], false);
                Doubledouble0M.AssertModel(models[14],_testData[19], false);
                Doubledouble0M.AssertModel(models[15],_testData[20], false);
                Doubledouble0M.AssertModel(models[16],_testData[21], false);
                Doubledouble0M.AssertModel(models[17],_testData[22], false);
                Doubledouble0M.AssertModel(models[18],_testData[23], false);
                Doubledouble0M.AssertModel(models[19],_testData[24], false);
                Doubledouble0M.AssertModel(models[20],_testData[25], false);
                Doubledouble0M.AssertModel(models[21],_testData[26], false);
                Doubledouble0M.AssertModel(models[22],_testData[27], false);
                Doubledouble0M.AssertModel(models[23],_testData[28], false);
                Doubledouble0M.AssertModel(models[24],_testData[29], false);
                Doubledouble0M.AssertModel(models[25],_testData[30], false);
                Doubledouble0M.AssertModel(models[26],_testData[31], false);
                Doubledouble0M.AssertModel(models[27],_testData[32], false);
                Doubledouble0M.AssertModel(models[28],_testData[33], false);
                Doubledouble0M.AssertModel(models[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleSingleTypedouble)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleSingleTypedouble)this).SetDbConnectionSelectModelParametrs(cmd, 117);
                var models =  ((IDoubleSingleTypedouble)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                Doubledouble0M.AssertModel(models[0],_testData[28], false);
                Doubledouble0M.AssertModel(models[1],_testData[29], false);
                Doubledouble0M.AssertModel(models[2],_testData[30], false);
                Doubledouble0M.AssertModel(models[3],_testData[31], false);
                Doubledouble0M.AssertModel(models[4],_testData[32], false);
                Doubledouble0M.AssertModel(models[5],_testData[33], false);
                Doubledouble0M.AssertModel(models[6],_testData[34], false);
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
FROM gedaqtests.doubledouble0m m
LEFT JOIN gedaqtests.doubledouble0mi mi ON mi.id = m.doubledouble0mi_id
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
            asPartInterface: typeof(IDoubleSingleTypedouble))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleSingleTypedouble)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9846222833451315d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5450041058372586d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.2049291853567119d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.06996671050241954d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6916806173639118d)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8953294253602977d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8558228990573897d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.5251359198945239d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4134744209277186d)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.07231994517761897d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.31739775636819234d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.1673376059817666d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2944113697597357d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3983634365251527d)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8504663578423682d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4701117506551866d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.16431658371847557d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.445173253451132d)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8932335702332185d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.14023855013866404d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.06246419175616347d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.06789737713986466d)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.48144000467010073d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4607373924943593d)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6844561442132823d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.07307206140577893d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.4444274591929599d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6440043311240408d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9488194504483253d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.07396676061357943d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.615955229995316d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.14362284104801537d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6077396334849884d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7039902129695818d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.623295195954171d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4474412889552519d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.898652033476324d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5403495956196551d)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6334896577543138d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8849615991458033d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4408552637810508d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6759488603046468d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8009216578510832d)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.13157961826453912d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5630837262766961d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.9325028362004973d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.03162677530486835d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.49972409845853816d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.46687328644176307d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.31604747061455296d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2985724293982661d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3475705803516679d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5671724793324538d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.49897669627833774d)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.006379170453560068d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6351911349255582d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.04055298173659305d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4005844283051625d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6491785306493202d)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3228527188011793d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.17069540923770932d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.15557032667961457d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6156132447865755d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2250107484682261d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.2696039624163422d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.14665499043727448d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.027513626671332392d)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.0700219959353875d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6289300429096777d)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.07396321110112092d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((89)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9045669715734357d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.305075017427456d)));//Value

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
                var models =  ((IDoubleSingleTypedouble)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9846222833451315d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5450041058372586d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.2049291853567119d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.06996671050241954d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6916806173639118d)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8953294253602977d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8558228990573897d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.5251359198945239d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4134744209277186d)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.07231994517761897d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.31739775636819234d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.1673376059817666d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2944113697597357d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3983634365251527d)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8504663578423682d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4701117506551866d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.16431658371847557d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.445173253451132d)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8932335702332185d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.14023855013866404d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.06246419175616347d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.06789737713986466d)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.48144000467010073d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4607373924943593d)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6844561442132823d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.07307206140577893d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.4444274591929599d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6440043311240408d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9488194504483253d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.07396676061357943d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.615955229995316d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.14362284104801537d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6077396334849884d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7039902129695818d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.623295195954171d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4474412889552519d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.898652033476324d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5403495956196551d)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6334896577543138d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8849615991458033d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4408552637810508d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6759488603046468d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8009216578510832d)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.13157961826453912d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5630837262766961d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.9325028362004973d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.03162677530486835d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.49972409845853816d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.46687328644176307d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.31604747061455296d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2985724293982661d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3475705803516679d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5671724793324538d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.49897669627833774d)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.006379170453560068d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6351911349255582d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.04055298173659305d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4005844283051625d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6491785306493202d)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3228527188011793d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.17069540923770932d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.15557032667961457d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6156132447865755d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2250107484682261d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.2696039624163422d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.14665499043727448d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.027513626671332392d)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.0700219959353875d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6289300429096777d)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.07396321110112092d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((89)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9045669715734357d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.305075017427456d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

