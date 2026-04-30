

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

        private readonly Int64bigint0M[] _testData = new Int64bigint0M[]
        {
            new Int64bigint0M
{
    Id = 3,
    Value = 2943092955462950364L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 4,
    Value = 29899714850278769L,
    ModelInner = new Int64bigint0MI
{
    Id = 4,
    Value = 5875327420251101419L,
    NullableValue = 61981539174864047L,
},
    NullableValue = 6975299997562556016L,
},
            new Int64bigint0M
{
    Id = 13,
    Value = 5671197003070644108L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 21,
    Value = 5244420286642404228L,
    ModelInner = new Int64bigint0MI
{
    Id = 7,
    Value = 5924344771667708809L,
    NullableValue = null,
},
    NullableValue = 8751280554530205626L,
},
            new Int64bigint0M
{
    Id = 23,
    Value = 5801358627068703606L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 32,
    Value = 8917475046329345154L,
    ModelInner = new Int64bigint0MI
{
    Id = 10,
    Value = 3021298490369996960L,
    NullableValue = null,
},
    NullableValue = 1821772464340354789L,
},
            new Int64bigint0M
{
    Id = 37,
    Value = 3256054030681010636L,
    ModelInner = null,
    NullableValue = 1217111657560664118L,
},
            new Int64bigint0M
{
    Id = 43,
    Value = 9087284402497319403L,
    ModelInner = new Int64bigint0MI
{
    Id = 13,
    Value = 6717993549970599974L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 44,
    Value = 6331599576067833277L,
    ModelInner = null,
    NullableValue = 8918446430961216164L,
},
            new Int64bigint0M
{
    Id = 45,
    Value = 1113800841226540778L,
    ModelInner = new Int64bigint0MI
{
    Id = 19,
    Value = 8434169211422191470L,
    NullableValue = null,
},
    NullableValue = 809299290286137568L,
},
            new Int64bigint0M
{
    Id = 54,
    Value = 1710989926827222378L,
    ModelInner = null,
    NullableValue = 6144607225961052803L,
},
            new Int64bigint0M
{
    Id = 62,
    Value = 1518592691476010224L,
    ModelInner = new Int64bigint0MI
{
    Id = 23,
    Value = 3148096566896814064L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 66,
    Value = 9129028077492581989L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 75,
    Value = 1993147826096849752L,
    ModelInner = new Int64bigint0MI
{
    Id = 24,
    Value = 8805626150336104850L,
    NullableValue = 7715741880373285144L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 80,
    Value = 3513570123688318582L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 87,
    Value = 267371395406824521L,
    ModelInner = new Int64bigint0MI
{
    Id = 26,
    Value = 8691528293242053677L,
    NullableValue = 2098462512102534858L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 92,
    Value = 1099643136539713196L,
    ModelInner = null,
    NullableValue = 7707637222555995462L,
},
            new Int64bigint0M
{
    Id = 94,
    Value = 727218367112227293L,
    ModelInner = new Int64bigint0MI
{
    Id = 31,
    Value = 5458650674697535196L,
    NullableValue = null,
},
    NullableValue = 601340903435261983L,
},
            new Int64bigint0M
{
    Id = 97,
    Value = 2269809816006749302L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 103,
    Value = 2616679355134227814L,
    ModelInner = new Int64bigint0MI
{
    Id = 32,
    Value = 6593438429175197092L,
    NullableValue = 935237115818776116L,
},
    NullableValue = 550084136588605439L,
},
            new Int64bigint0M
{
    Id = 106,
    Value = 6820692794175147793L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 115,
    Value = 6023484888726590278L,
    ModelInner = new Int64bigint0MI
{
    Id = 41,
    Value = 6945884288880316764L,
    NullableValue = 734216940366386461L,
},
    NullableValue = 5883911912407268989L,
},
            new Int64bigint0M
{
    Id = 124,
    Value = 3125175972232050823L,
    ModelInner = null,
    NullableValue = 2706153054297444409L,
},
            new Int64bigint0M
{
    Id = 126,
    Value = 7238069137593096134L,
    ModelInner = new Int64bigint0MI
{
    Id = 46,
    Value = 2548025044480881663L,
    NullableValue = 4285225540838506829L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 130,
    Value = 3196741835344006360L,
    ModelInner = null,
    NullableValue = 7593961551329931238L,
},
            new Int64bigint0M
{
    Id = 131,
    Value = 1019916071842069225L,
    ModelInner = new Int64bigint0MI
{
    Id = 52,
    Value = 1786443222958284244L,
    NullableValue = 9004451668197528445L,
},
    NullableValue = 1386565760297643512L,
},
            new Int64bigint0M
{
    Id = 136,
    Value = 5871540237475321980L,
    ModelInner = null,
    NullableValue = 7780341097431354547L,
},
            new Int64bigint0M
{
    Id = 140,
    Value = 4433253402242320639L,
    ModelInner = new Int64bigint0MI
{
    Id = 54,
    Value = 2568661652491480923L,
    NullableValue = 5403951384720700767L,
},
    NullableValue = 8992451593075869596L,
},
            new Int64bigint0M
{
    Id = 147,
    Value = 6561775036841824189L,
    ModelInner = null,
    NullableValue = 5909663169358637L,
},
            new Int64bigint0M
{
    Id = 148,
    Value = 4759587559359645616L,
    ModelInner = new Int64bigint0MI
{
    Id = 63,
    Value = 1201252758960629829L,
    NullableValue = 4502796743087190238L,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.int64bigint0mi(
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
INSERT INTO dbo.int64bigint0mi(
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

            }
        }

#endregion

#region InsertModel

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.int64bigint0m(
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
                parametrName: "int64bigint0mi_id", 
                methodParametrName: "int64bigint0mi_id", 
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
INSERT INTO dbo.int64bigint0m(
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
                parametrName: "int64bigint0mi_id", 
                methodParametrName: "int64bigint0mi_id", 
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

            }
        }

#endregion

#region Select Models

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigint0M), typeof(FlatInt64bigint0M)],
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
FROM dbo.int64bigint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                await((IInt64SingleTypebigint)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
FROM dbo.int64bigint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                ((IInt64SingleTypebigint)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigint0M)],
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
FROM dbo.int64bigint0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
FROM dbo.int64bigint0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int64bigint0m m
LEFT JOIN dbo.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigint0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = ((IInt64SingleTypebigint)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigint0M), typeof(FlatInt64bigint0M)],
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
FROM dbo.int64bigint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                await((IInt64SingleTypebigint)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
FROM dbo.int64bigint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                ((IInt64SingleTypebigint)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigint0M)],
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
FROM dbo.int64bigint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64SingleTypebigint)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
FROM dbo.int64bigint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64SingleTypebigint)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int64bigint0m m
LEFT JOIN dbo.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigint0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
FROM dbo.int64bigint0m m
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
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
FROM dbo.int64bigint0m m
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
FROM dbo.int64bigint0m m
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
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
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
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
FROM dbo.int64bigint0m m
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
FROM dbo.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
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
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[26],_testData[29], false);
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
FROM dbo.int64bigint0m m
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
FROM dbo.int64bigint0m m
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
FROM dbo.int64bigint0m m
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
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
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
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
FROM dbo.int64bigint0m m
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
FROM dbo.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[29], false);
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
FROM dbo.int64bigint0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 103;
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
FROM dbo.int64bigint0m m
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
FROM dbo.int64bigint0m m
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
                        Assert.That(models, Has.Count.EqualTo(10));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[29], false);
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
                parametr1.Value = 75;
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
FROM dbo.int64bigint0m m
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
FROM dbo.int64bigint0m m
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
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
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
FROM dbo.int64bigint0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int64bigint0m m
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
FROM dbo.int64bigint0m m
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[29], false);
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
                parametr1.Value = 103;
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
FROM dbo.int64bigint0m m
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
FROM dbo.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
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
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[29], false);
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
FROM dbo.int64bigint0m m
LEFT JOIN dbo.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 13;
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
                        Assert.That(models, Has.Count.EqualTo(27));

                        Int64bigint0M.AssertModel(models[0],_testData[3], false);
                        Int64bigint0M.AssertModel(models[1],_testData[4], false);
                        Int64bigint0M.AssertModel(models[2],_testData[5], false);
                        Int64bigint0M.AssertModel(models[3],_testData[6], false);
                        Int64bigint0M.AssertModel(models[4],_testData[7], false);
                        Int64bigint0M.AssertModel(models[5],_testData[8], false);
                        Int64bigint0M.AssertModel(models[6],_testData[9], false);
                        Int64bigint0M.AssertModel(models[7],_testData[10], false);
                        Int64bigint0M.AssertModel(models[8],_testData[11], false);
                        Int64bigint0M.AssertModel(models[9],_testData[12], false);
                        Int64bigint0M.AssertModel(models[10],_testData[13], false);
                        Int64bigint0M.AssertModel(models[11],_testData[14], false);
                        Int64bigint0M.AssertModel(models[12],_testData[15], false);
                        Int64bigint0M.AssertModel(models[13],_testData[16], false);
                        Int64bigint0M.AssertModel(models[14],_testData[17], false);
                        Int64bigint0M.AssertModel(models[15],_testData[18], false);
                        Int64bigint0M.AssertModel(models[16],_testData[19], false);
                        Int64bigint0M.AssertModel(models[17],_testData[20], false);
                        Int64bigint0M.AssertModel(models[18],_testData[21], false);
                        Int64bigint0M.AssertModel(models[19],_testData[22], false);
                        Int64bigint0M.AssertModel(models[20],_testData[23], false);
                        Int64bigint0M.AssertModel(models[21],_testData[24], false);
                        Int64bigint0M.AssertModel(models[22],_testData[25], false);
                        Int64bigint0M.AssertModel(models[23],_testData[26], false);
                        Int64bigint0M.AssertModel(models[24],_testData[27], false);
                        Int64bigint0M.AssertModel(models[25],_testData[28], false);
                        Int64bigint0M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Int64bigint0M.AssertModel(models[0],_testData[20], false);
                        Int64bigint0M.AssertModel(models[1],_testData[21], false);
                        Int64bigint0M.AssertModel(models[2],_testData[22], false);
                        Int64bigint0M.AssertModel(models[3],_testData[23], false);
                        Int64bigint0M.AssertModel(models[4],_testData[24], false);
                        Int64bigint0M.AssertModel(models[5],_testData[25], false);
                        Int64bigint0M.AssertModel(models[6],_testData[26], false);
                        Int64bigint0M.AssertModel(models[7],_testData[27], false);
                        Int64bigint0M.AssertModel(models[8],_testData[28], false);
                        Int64bigint0M.AssertModel(models[9],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Int64bigint0M.AssertModel(models[0],_testData[20], false);
                        Int64bigint0M.AssertModel(models[1],_testData[21], false);
                        Int64bigint0M.AssertModel(models[2],_testData[22], false);
                        Int64bigint0M.AssertModel(models[3],_testData[23], false);
                        Int64bigint0M.AssertModel(models[4],_testData[24], false);
                        Int64bigint0M.AssertModel(models[5],_testData[25], false);
                        Int64bigint0M.AssertModel(models[6],_testData[26], false);
                        Int64bigint0M.AssertModel(models[7],_testData[27], false);
                        Int64bigint0M.AssertModel(models[8],_testData[28], false);
                        Int64bigint0M.AssertModel(models[9],_testData[29], false);
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
FROM dbo.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                await((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
FROM dbo.int64bigint0m m
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
FROM dbo.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 87, query1, 3, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[28],_testData[29], false);
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
FROM dbo.int64bigint0m m
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
FROM dbo.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 21, query1, 44, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[29], false);
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
FROM dbo.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
FROM dbo.int64bigint0m m
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
FROM dbo.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 32, query1, 32, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
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
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[23],_testData[29], false);
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
FROM dbo.int64bigint0m m
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
FROM dbo.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 37, query1, 126, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
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
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[29], false);
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
FROM dbo.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
FROM dbo.int64bigint0m m
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
FROM dbo.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 130, query1, 130, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[29], false);
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
FROM dbo.int64bigint0m m
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
FROM dbo.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 62, query1, 4, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
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
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
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
FROM dbo.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
FROM dbo.int64bigint0m m
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
FROM dbo.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 4, query1, 4, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[2], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[17],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[18],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[19],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[20],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[21],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[22],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[23],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[24],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[25],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[26],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[2], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[17],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[18],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[19],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[20],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[21],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[22],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[23],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[24],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[25],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[26],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[27],_testData[29], false);
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
FROM dbo.int64bigint0m m
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
FROM dbo.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatch(connection, 43, query1, 44, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
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
FROM dbo.int64bigint0m m
LEFT JOIN dbo.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatchAsync(connection, 54, 37))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatch(connection, 3, 75))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

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
Int64bigint0M.AssertModel(models[0],_testData[22], false);Int64bigint0M.AssertModel(models[1],_testData[23], false);Int64bigint0M.AssertModel(models[2],_testData[24], false);Int64bigint0M.AssertModel(models[3],_testData[25], false);Int64bigint0M.AssertModel(models[4],_testData[26], false);Int64bigint0M.AssertModel(models[5],_testData[27], false);Int64bigint0M.AssertModel(models[6],_testData[28], false);Int64bigint0M.AssertModel(models[7],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64SingleTypebigint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 62);
                var models =  ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
Int64bigint0M.AssertModel(models[0],_testData[12], false);Int64bigint0M.AssertModel(models[1],_testData[13], false);Int64bigint0M.AssertModel(models[2],_testData[14], false);Int64bigint0M.AssertModel(models[3],_testData[15], false);Int64bigint0M.AssertModel(models[4],_testData[16], false);Int64bigint0M.AssertModel(models[5],_testData[17], false);Int64bigint0M.AssertModel(models[6],_testData[18], false);Int64bigint0M.AssertModel(models[7],_testData[19], false);Int64bigint0M.AssertModel(models[8],_testData[20], false);Int64bigint0M.AssertModel(models[9],_testData[21], false);Int64bigint0M.AssertModel(models[10],_testData[22], false);Int64bigint0M.AssertModel(models[11],_testData[23], false);Int64bigint0M.AssertModel(models[12],_testData[24], false);Int64bigint0M.AssertModel(models[13],_testData[25], false);Int64bigint0M.AssertModel(models[14],_testData[26], false);Int64bigint0M.AssertModel(models[15],_testData[27], false);Int64bigint0M.AssertModel(models[16],_testData[28], false);Int64bigint0M.AssertModel(models[17],_testData[29], false);
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
FROM dbo.int64bigint0m m
LEFT JOIN dbo.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2943092955462950364L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((29899714850278769L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5875327420251101419L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((61981539174864047L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6975299997562556016L)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5671197003070644108L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5244420286642404228L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5924344771667708809L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((8751280554530205626L)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5801358627068703606L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8917475046329345154L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3021298490369996960L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((1821772464340354789L)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3256054030681010636L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1217111657560664118L)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9087284402497319403L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6717993549970599974L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6331599576067833277L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8918446430961216164L)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1113800841226540778L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8434169211422191470L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((809299290286137568L)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1710989926827222378L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6144607225961052803L)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1518592691476010224L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3148096566896814064L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9129028077492581989L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1993147826096849752L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8805626150336104850L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((7715741880373285144L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3513570123688318582L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((267371395406824521L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8691528293242053677L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2098462512102534858L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1099643136539713196L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7707637222555995462L)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((727218367112227293L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5458650674697535196L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((601340903435261983L)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2269809816006749302L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2616679355134227814L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6593438429175197092L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((935237115818776116L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((550084136588605439L)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6820692794175147793L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6023484888726590278L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6945884288880316764L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((734216940366386461L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5883911912407268989L)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3125175972232050823L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2706153054297444409L)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7238069137593096134L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2548025044480881663L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4285225540838506829L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3196741835344006360L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7593961551329931238L)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1019916071842069225L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1786443222958284244L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((9004451668197528445L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1386565760297643512L)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5871540237475321980L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7780341097431354547L)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4433253402242320639L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2568661652491480923L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((5403951384720700767L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8992451593075869596L)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6561775036841824189L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5909663169358637L)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4759587559359645616L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1201252758960629829L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4502796743087190238L)));//InnerModel.NullableValue

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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2943092955462950364L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((29899714850278769L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5875327420251101419L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((61981539174864047L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6975299997562556016L)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5671197003070644108L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5244420286642404228L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5924344771667708809L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((8751280554530205626L)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5801358627068703606L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8917475046329345154L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3021298490369996960L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((1821772464340354789L)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3256054030681010636L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1217111657560664118L)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9087284402497319403L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6717993549970599974L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6331599576067833277L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8918446430961216164L)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1113800841226540778L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8434169211422191470L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((809299290286137568L)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1710989926827222378L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6144607225961052803L)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1518592691476010224L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3148096566896814064L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9129028077492581989L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1993147826096849752L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8805626150336104850L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((7715741880373285144L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3513570123688318582L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((267371395406824521L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8691528293242053677L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2098462512102534858L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1099643136539713196L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7707637222555995462L)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((727218367112227293L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5458650674697535196L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((601340903435261983L)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2269809816006749302L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2616679355134227814L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6593438429175197092L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((935237115818776116L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((550084136588605439L)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6820692794175147793L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6023484888726590278L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6945884288880316764L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((734216940366386461L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5883911912407268989L)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3125175972232050823L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2706153054297444409L)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7238069137593096134L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2548025044480881663L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4285225540838506829L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3196741835344006360L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7593961551329931238L)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1019916071842069225L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1786443222958284244L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((9004451668197528445L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1386565760297643512L)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5871540237475321980L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7780341097431354547L)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4433253402242320639L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2568661652491480923L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((5403951384720700767L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8992451593075869596L)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6561775036841824189L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5909663169358637L)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4759587559359645616L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1201252758960629829L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4502796743087190238L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

