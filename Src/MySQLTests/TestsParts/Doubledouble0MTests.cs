

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
    Id = 5,
    Value = 0.15520261403135827d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 7,
    Value = 0.12430631596633568d,
    ModelInner = new Doubledouble0MI
{
    Id = 7,
    Value = 0.1660124229802834d,
    NullableValue = null,
},
    NullableValue = 0.15132511530273174d,
},
            new Doubledouble0M
{
    Id = 15,
    Value = 0.1977048419431049d,
    ModelInner = null,
    NullableValue = 0.3549916998211936d,
},
            new Doubledouble0M
{
    Id = 23,
    Value = 0.08125068965532145d,
    ModelInner = new Doubledouble0MI
{
    Id = 13,
    Value = 0.8675035751115253d,
    NullableValue = 0.04931332466585847d,
},
    NullableValue = 0.5758210962884014d,
},
            new Doubledouble0M
{
    Id = 27,
    Value = 0.2799514939539961d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 30,
    Value = 0.4410667009396314d,
    ModelInner = new Doubledouble0MI
{
    Id = 18,
    Value = 0.1505110707822146d,
    NullableValue = null,
},
    NullableValue = 0.36064376395114117d,
},
            new Doubledouble0M
{
    Id = 36,
    Value = 0.684291337097973d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 39,
    Value = 0.9067214241844963d,
    ModelInner = new Doubledouble0MI
{
    Id = 19,
    Value = 0.2245918191136742d,
    NullableValue = null,
},
    NullableValue = 0.9200550493994117d,
},
            new Doubledouble0M
{
    Id = 40,
    Value = 0.33280928149437294d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 44,
    Value = 0.05587141578051069d,
    ModelInner = new Doubledouble0MI
{
    Id = 27,
    Value = 0.6349253181966059d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 53,
    Value = 0.040877077517235016d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 55,
    Value = 0.4681654236260073d,
    ModelInner = new Doubledouble0MI
{
    Id = 30,
    Value = 0.5691366224707471d,
    NullableValue = null,
},
    NullableValue = 0.32376373562414107d,
},
            new Doubledouble0M
{
    Id = 60,
    Value = 0.9411779832434418d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 63,
    Value = 0.6677627947491634d,
    ModelInner = new Doubledouble0MI
{
    Id = 34,
    Value = 0.05233521007474873d,
    NullableValue = 0.30586932186672156d,
},
    NullableValue = 0.9166577746439116d,
},
            new Doubledouble0M
{
    Id = 68,
    Value = 0.8962534772057651d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 73,
    Value = 0.7807209698091376d,
    ModelInner = new Doubledouble0MI
{
    Id = 35,
    Value = 0.1902849916981456d,
    NullableValue = 0.21077477529696842d,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 79,
    Value = 0.9919318298409313d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 88,
    Value = 0.6414873394047891d,
    ModelInner = new Doubledouble0MI
{
    Id = 41,
    Value = 0.657303646924171d,
    NullableValue = 0.4265261145604682d,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 95,
    Value = 0.10462237566340538d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 97,
    Value = 0.78743183732808d,
    ModelInner = new Doubledouble0MI
{
    Id = 45,
    Value = 0.4430533085673769d,
    NullableValue = 0.7205146381733151d,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 100,
    Value = 0.4810902615036089d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 106,
    Value = 0.7906204830612497d,
    ModelInner = new Doubledouble0MI
{
    Id = 46,
    Value = 0.32099744445147627d,
    NullableValue = 0.3841217309291127d,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 107,
    Value = 0.9160330818071597d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 111,
    Value = 0.8714584407900846d,
    ModelInner = new Doubledouble0MI
{
    Id = 54,
    Value = 0.4277005197152478d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 120,
    Value = 0.47618362371063705d,
    ModelInner = null,
    NullableValue = 0.6973009250464255d,
},
            new Doubledouble0M
{
    Id = 126,
    Value = 0.39526845287131174d,
    ModelInner = new Doubledouble0MI
{
    Id = 59,
    Value = 0.6700143546158925d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 132,
    Value = 0.7530313900123555d,
    ModelInner = null,
    NullableValue = 0.5113653834675702d,
},
            new Doubledouble0M
{
    Id = 136,
    Value = 0.4955979184284107d,
    ModelInner = new Doubledouble0MI
{
    Id = 63,
    Value = 0.33161860844336954d,
    NullableValue = 0.4608397835707352d,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 139,
    Value = 0.16341554457661056d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 146,
    Value = 0.13270925307345627d,
    ModelInner = new Doubledouble0MI
{
    Id = 71,
    Value = 0.36427260001762607d,
    NullableValue = null,
},
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[19],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 55;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[28],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 30;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
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
                foreach(var batchResult in await ((IDoubleSingleTypedouble)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(models[6],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(models[7],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 132;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[21],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
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
                foreach(var batchResult in  ((IDoubleSingleTypedouble)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[3], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(models[6],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(models[7],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(models[8],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(models[9],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(models[10],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(models[11],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(models[12],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(models[13],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(models[14],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(models[15],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(models[16],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(models[17],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(models[18],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(models[19],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(models[20],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(models[21],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(models[22],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(models[23],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(models[24],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(models[25],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(models[6],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(models[7],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(models[8],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(models[9],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(models[10],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(models[11],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(models[12],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(models[13],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(models[14],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(models[15],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(models[16],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(models[17],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(models[18],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(models[19],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(models[20],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[25],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDoubleSingleTypedouble)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Doubledouble0M.AssertModel(models[0],_testData[12], false);
                        Doubledouble0M.AssertModel(models[1],_testData[13], false);
                        Doubledouble0M.AssertModel(models[2],_testData[14], false);
                        Doubledouble0M.AssertModel(models[3],_testData[15], false);
                        Doubledouble0M.AssertModel(models[4],_testData[16], false);
                        Doubledouble0M.AssertModel(models[5],_testData[17], false);
                        Doubledouble0M.AssertModel(models[6],_testData[18], false);
                        Doubledouble0M.AssertModel(models[7],_testData[19], false);
                        Doubledouble0M.AssertModel(models[8],_testData[20], false);
                        Doubledouble0M.AssertModel(models[9],_testData[21], false);
                        Doubledouble0M.AssertModel(models[10],_testData[22], false);
                        Doubledouble0M.AssertModel(models[11],_testData[23], false);
                        Doubledouble0M.AssertModel(models[12],_testData[24], false);
                        Doubledouble0M.AssertModel(models[13],_testData[25], false);
                        Doubledouble0M.AssertModel(models[14],_testData[26], false);
                        Doubledouble0M.AssertModel(models[15],_testData[27], false);
                        Doubledouble0M.AssertModel(models[16],_testData[28], false);
                        Doubledouble0M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Doubledouble0M.AssertModel(models[0],_testData[25], false);
                        Doubledouble0M.AssertModel(models[1],_testData[26], false);
                        Doubledouble0M.AssertModel(models[2],_testData[27], false);
                        Doubledouble0M.AssertModel(models[3],_testData[28], false);
                        Doubledouble0M.AssertModel(models[4],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IDoubleSingleTypedouble)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Doubledouble0M.AssertModel(models[0],_testData[3], false);
                        Doubledouble0M.AssertModel(models[1],_testData[4], false);
                        Doubledouble0M.AssertModel(models[2],_testData[5], false);
                        Doubledouble0M.AssertModel(models[3],_testData[6], false);
                        Doubledouble0M.AssertModel(models[4],_testData[7], false);
                        Doubledouble0M.AssertModel(models[5],_testData[8], false);
                        Doubledouble0M.AssertModel(models[6],_testData[9], false);
                        Doubledouble0M.AssertModel(models[7],_testData[10], false);
                        Doubledouble0M.AssertModel(models[8],_testData[11], false);
                        Doubledouble0M.AssertModel(models[9],_testData[12], false);
                        Doubledouble0M.AssertModel(models[10],_testData[13], false);
                        Doubledouble0M.AssertModel(models[11],_testData[14], false);
                        Doubledouble0M.AssertModel(models[12],_testData[15], false);
                        Doubledouble0M.AssertModel(models[13],_testData[16], false);
                        Doubledouble0M.AssertModel(models[14],_testData[17], false);
                        Doubledouble0M.AssertModel(models[15],_testData[18], false);
                        Doubledouble0M.AssertModel(models[16],_testData[19], false);
                        Doubledouble0M.AssertModel(models[17],_testData[20], false);
                        Doubledouble0M.AssertModel(models[18],_testData[21], false);
                        Doubledouble0M.AssertModel(models[19],_testData[22], false);
                        Doubledouble0M.AssertModel(models[20],_testData[23], false);
                        Doubledouble0M.AssertModel(models[21],_testData[24], false);
                        Doubledouble0M.AssertModel(models[22],_testData[25], false);
                        Doubledouble0M.AssertModel(models[23],_testData[26], false);
                        Doubledouble0M.AssertModel(models[24],_testData[27], false);
                        Doubledouble0M.AssertModel(models[25],_testData[28], false);
                        Doubledouble0M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Doubledouble0M.AssertModel(models[0],_testData[6], false);
                        Doubledouble0M.AssertModel(models[1],_testData[7], false);
                        Doubledouble0M.AssertModel(models[2],_testData[8], false);
                        Doubledouble0M.AssertModel(models[3],_testData[9], false);
                        Doubledouble0M.AssertModel(models[4],_testData[10], false);
                        Doubledouble0M.AssertModel(models[5],_testData[11], false);
                        Doubledouble0M.AssertModel(models[6],_testData[12], false);
                        Doubledouble0M.AssertModel(models[7],_testData[13], false);
                        Doubledouble0M.AssertModel(models[8],_testData[14], false);
                        Doubledouble0M.AssertModel(models[9],_testData[15], false);
                        Doubledouble0M.AssertModel(models[10],_testData[16], false);
                        Doubledouble0M.AssertModel(models[11],_testData[17], false);
                        Doubledouble0M.AssertModel(models[12],_testData[18], false);
                        Doubledouble0M.AssertModel(models[13],_testData[19], false);
                        Doubledouble0M.AssertModel(models[14],_testData[20], false);
                        Doubledouble0M.AssertModel(models[15],_testData[21], false);
                        Doubledouble0M.AssertModel(models[16],_testData[22], false);
                        Doubledouble0M.AssertModel(models[17],_testData[23], false);
                        Doubledouble0M.AssertModel(models[18],_testData[24], false);
                        Doubledouble0M.AssertModel(models[19],_testData[25], false);
                        Doubledouble0M.AssertModel(models[20],_testData[26], false);
                        Doubledouble0M.AssertModel(models[21],_testData[27], false);
                        Doubledouble0M.AssertModel(models[22],_testData[28], false);
                        Doubledouble0M.AssertModel(models[23],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
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
                await ((IDoubleSingleTypedouble)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 73, query1, 23, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
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
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[25],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                await ((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 53, query1, 55, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
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
                 ((IDoubleSingleTypedouble)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 100, query1, 136, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                 ((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModelBatch(connection, 55, query1, 120, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                foreach(var batchResult in await ((IDoubleSingleTypedouble)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 23, query1, 107, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(models[6],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(models[7],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(models[8],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(models[9],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(models[10],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(models[11],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(models[12],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(models[13],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(models[14],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(models[15],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(models[16],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(models[17],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(models[18],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(models[19],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(models[20],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(models[21],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(models[22],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(models[23],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(models[24],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(models[6],_testData[29], false);
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
                int resultIndex = 0;
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
                await ((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 63, query1, 23, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[25],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                foreach(var batchResult in  ((IDoubleSingleTypedouble)this).DbConnectionSTDynQuerySelectModelBatch(connection, 55, query1, 7, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[2], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[3], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(models[6],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(models[7],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(models[8],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(models[9],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(models[10],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(models[11],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(models[12],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(models[13],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(models[14],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(models[15],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(models[16],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(models[17],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(models[18],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(models[19],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(models[20],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(models[21],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(models[22],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(models[23],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(models[24],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(models[25],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(models[26],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(models[27],_testData[29], false);
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
                int resultIndex = 0;
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
                 ((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModelBatch(connection, 126, query1, 7, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[27],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IDoubleSingleTypedouble)this).DbConnectionSTSelectModelBatchAsync(connection, 132, 97))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Doubledouble0M.AssertModel(models[0],_testData[27], false);
                        Doubledouble0M.AssertModel(models[1],_testData[28], false);
                        Doubledouble0M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Doubledouble0M.AssertModel(models[0],_testData[20], false);
                        Doubledouble0M.AssertModel(models[1],_testData[21], false);
                        Doubledouble0M.AssertModel(models[2],_testData[22], false);
                        Doubledouble0M.AssertModel(models[3],_testData[23], false);
                        Doubledouble0M.AssertModel(models[4],_testData[24], false);
                        Doubledouble0M.AssertModel(models[5],_testData[25], false);
                        Doubledouble0M.AssertModel(models[6],_testData[26], false);
                        Doubledouble0M.AssertModel(models[7],_testData[27], false);
                        Doubledouble0M.AssertModel(models[8],_testData[28], false);
                        Doubledouble0M.AssertModel(models[9],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IDoubleSingleTypedouble)this).DbConnectionSTSelectModelBatch(connection, 120, 60))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Doubledouble0M.AssertModel(models[0],_testData[25], false);
                        Doubledouble0M.AssertModel(models[1],_testData[26], false);
                        Doubledouble0M.AssertModel(models[2],_testData[27], false);
                        Doubledouble0M.AssertModel(models[3],_testData[28], false);
                        Doubledouble0M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

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
                ((IDoubleSingleTypedouble)this).SetDbConnectionSelectModelParametrs(cmd, 39);
                var models = await ((IDoubleSingleTypedouble)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
Doubledouble0M.AssertModel(models[0],_testData[8], false);Doubledouble0M.AssertModel(models[1],_testData[9], false);Doubledouble0M.AssertModel(models[2],_testData[10], false);Doubledouble0M.AssertModel(models[3],_testData[11], false);Doubledouble0M.AssertModel(models[4],_testData[12], false);Doubledouble0M.AssertModel(models[5],_testData[13], false);Doubledouble0M.AssertModel(models[6],_testData[14], false);Doubledouble0M.AssertModel(models[7],_testData[15], false);Doubledouble0M.AssertModel(models[8],_testData[16], false);Doubledouble0M.AssertModel(models[9],_testData[17], false);Doubledouble0M.AssertModel(models[10],_testData[18], false);Doubledouble0M.AssertModel(models[11],_testData[19], false);Doubledouble0M.AssertModel(models[12],_testData[20], false);Doubledouble0M.AssertModel(models[13],_testData[21], false);Doubledouble0M.AssertModel(models[14],_testData[22], false);Doubledouble0M.AssertModel(models[15],_testData[23], false);Doubledouble0M.AssertModel(models[16],_testData[24], false);Doubledouble0M.AssertModel(models[17],_testData[25], false);Doubledouble0M.AssertModel(models[18],_testData[26], false);Doubledouble0M.AssertModel(models[19],_testData[27], false);Doubledouble0M.AssertModel(models[20],_testData[28], false);Doubledouble0M.AssertModel(models[21],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleSingleTypedouble)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleSingleTypedouble)this).SetDbConnectionSelectModelParametrs(cmd, 107);
                var models =  ((IDoubleSingleTypedouble)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));
Doubledouble0M.AssertModel(models[0],_testData[23], false);Doubledouble0M.AssertModel(models[1],_testData[24], false);Doubledouble0M.AssertModel(models[2],_testData[25], false);Doubledouble0M.AssertModel(models[3],_testData[26], false);Doubledouble0M.AssertModel(models[4],_testData[27], false);Doubledouble0M.AssertModel(models[5],_testData[28], false);Doubledouble0M.AssertModel(models[6],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.15520261403135827d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.12430631596633568d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.1660124229802834d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.15132511530273174d)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.1977048419431049d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3549916998211936d)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.08125068965532145d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8675035751115253d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.04931332466585847d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5758210962884014d)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2799514939539961d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4410667009396314d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.1505110707822146d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.36064376395114117d)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.684291337097973d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9067214241844963d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.2245918191136742d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9200550493994117d)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.33280928149437294d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.05587141578051069d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6349253181966059d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.040877077517235016d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4681654236260073d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5691366224707471d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.32376373562414107d)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9411779832434418d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6677627947491634d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.05233521007474873d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.30586932186672156d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9166577746439116d)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8962534772057651d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7807209698091376d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.1902849916981456d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.21077477529696842d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9919318298409313d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6414873394047891d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.657303646924171d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.4265261145604682d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.10462237566340538d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.78743183732808d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4430533085673769d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7205146381733151d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4810902615036089d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7906204830612497d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.32099744445147627d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.3841217309291127d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9160330818071597d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8714584407900846d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4277005197152478d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.47618362371063705d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6973009250464255d)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.39526845287131174d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6700143546158925d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7530313900123555d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5113653834675702d)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4955979184284107d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.33161860844336954d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.4608397835707352d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.16341554457661056d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.13270925307345627d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.36427260001762607d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.15520261403135827d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.12430631596633568d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.1660124229802834d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.15132511530273174d)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.1977048419431049d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3549916998211936d)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.08125068965532145d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8675035751115253d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.04931332466585847d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5758210962884014d)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2799514939539961d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4410667009396314d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.1505110707822146d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.36064376395114117d)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.684291337097973d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9067214241844963d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.2245918191136742d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9200550493994117d)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.33280928149437294d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.05587141578051069d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6349253181966059d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.040877077517235016d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4681654236260073d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5691366224707471d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.32376373562414107d)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9411779832434418d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6677627947491634d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.05233521007474873d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.30586932186672156d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9166577746439116d)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8962534772057651d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7807209698091376d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.1902849916981456d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.21077477529696842d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9919318298409313d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6414873394047891d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.657303646924171d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.4265261145604682d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.10462237566340538d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.78743183732808d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4430533085673769d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7205146381733151d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4810902615036089d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7906204830612497d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.32099744445147627d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.3841217309291127d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9160330818071597d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8714584407900846d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4277005197152478d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.47618362371063705d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6973009250464255d)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.39526845287131174d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6700143546158925d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7530313900123555d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5113653834675702d)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4955979184284107d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.33161860844336954d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.4608397835707352d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.16341554457661056d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.13270925307345627d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.36427260001762607d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

