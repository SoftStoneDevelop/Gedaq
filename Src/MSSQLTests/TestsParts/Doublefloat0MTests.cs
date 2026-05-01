

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
    Id = 2,
    Value = 0.13062309009205508d,
    ModelInner = null,
    NullableValue = 0.966926863762426d,
},
            new Doublefloat0M
{
    Id = 3,
    Value = 0.6066152137933728d,
    ModelInner = new Doublefloat0MI
{
    Id = 1,
    Value = 0.08927217665064335d,
    NullableValue = null,
},
    NullableValue = 0.03967588572090697d,
},
            new Doublefloat0M
{
    Id = 4,
    Value = 0.15450578054320507d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 5,
    Value = 0.012316856584989821d,
    ModelInner = new Doublefloat0MI
{
    Id = 9,
    Value = 0.10509542366514169d,
    NullableValue = 0.46827804609193335d,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 8,
    Value = 0.17510830431190116d,
    ModelInner = null,
    NullableValue = 0.2364818402447204d,
},
            new Doublefloat0M
{
    Id = 11,
    Value = 0.14631442625771784d,
    ModelInner = new Doublefloat0MI
{
    Id = 16,
    Value = 0.6871112378516624d,
    NullableValue = null,
},
    NullableValue = 0.7354184100453018d,
},
            new Doublefloat0M
{
    Id = 20,
    Value = 0.3240749978535794d,
    ModelInner = null,
    NullableValue = 0.760419349540815d,
},
            new Doublefloat0M
{
    Id = 24,
    Value = 0.7567905588529025d,
    ModelInner = new Doublefloat0MI
{
    Id = 17,
    Value = 0.9486796267678873d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 32,
    Value = 0.9322092542889974d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 34,
    Value = 0.6408830729151339d,
    ModelInner = new Doublefloat0MI
{
    Id = 25,
    Value = 0.18107826344053946d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 40,
    Value = 0.7028096720710032d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 41,
    Value = 0.7546618552038776d,
    ModelInner = new Doublefloat0MI
{
    Id = 31,
    Value = 0.13352049105115393d,
    NullableValue = null,
},
    NullableValue = 0.8020173650363315d,
},
            new Doublefloat0M
{
    Id = 50,
    Value = 0.4178602626229937d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 54,
    Value = 0.7023240580976621d,
    ModelInner = new Doublefloat0MI
{
    Id = 36,
    Value = 0.08529769426634781d,
    NullableValue = 0.10964504134875175d,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 55,
    Value = 0.7486902410941924d,
    ModelInner = null,
    NullableValue = 0.7667904168614932d,
},
            new Doublefloat0M
{
    Id = 60,
    Value = 0.892330066939282d,
    ModelInner = new Doublefloat0MI
{
    Id = 39,
    Value = 0.7044716246143125d,
    NullableValue = null,
},
    NullableValue = 0.8485063229214229d,
},
            new Doublefloat0M
{
    Id = 62,
    Value = 0.5189135654131234d,
    ModelInner = null,
    NullableValue = 0.27899385361395534d,
},
            new Doublefloat0M
{
    Id = 64,
    Value = 0.9642183170772727d,
    ModelInner = new Doublefloat0MI
{
    Id = 48,
    Value = 0.6868925390055803d,
    NullableValue = 0.022007052994863163d,
},
    NullableValue = 0.12735441744738696d,
},
            new Doublefloat0M
{
    Id = 65,
    Value = 0.42236060676935516d,
    ModelInner = null,
    NullableValue = 0.8535768445223786d,
},
            new Doublefloat0M
{
    Id = 74,
    Value = 0.4423843408099606d,
    ModelInner = new Doublefloat0MI
{
    Id = 52,
    Value = 0.5070673736140549d,
    NullableValue = 0.849752081663039d,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 82,
    Value = 0.19689739565636266d,
    ModelInner = null,
    NullableValue = 0.6457267924988094d,
},
            new Doublefloat0M
{
    Id = 86,
    Value = 0.6481507571566784d,
    ModelInner = new Doublefloat0MI
{
    Id = 54,
    Value = 0.8639746589680486d,
    NullableValue = 0.6272767826896714d,
},
    NullableValue = 0.7958768047911904d,
},
            new Doublefloat0M
{
    Id = 90,
    Value = 0.3078969776074211d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 99,
    Value = 0.535658357274699d,
    ModelInner = new Doublefloat0MI
{
    Id = 62,
    Value = 0.5678783841562889d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 107,
    Value = 0.9092900782382819d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 113,
    Value = 0.8544992218005367d,
    ModelInner = new Doublefloat0MI
{
    Id = 69,
    Value = 0.05511721085590704d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 122,
    Value = 0.04300267749647335d,
    ModelInner = null,
    NullableValue = 0.41353538679594315d,
},
            new Doublefloat0M
{
    Id = 126,
    Value = 0.7870230375857751d,
    ModelInner = new Doublefloat0MI
{
    Id = 75,
    Value = 0.3653827051836608d,
    NullableValue = 0.5365188396894573d,
},
    NullableValue = 0.2745458364156017d,
},
            new Doublefloat0M
{
    Id = 135,
    Value = 0.057207044199324764d,
    ModelInner = null,
    NullableValue = 0.7219707795728525d,
},
            new Doublefloat0M
{
    Id = 137,
    Value = 0.9791250400311055d,
    ModelInner = new Doublefloat0MI
{
    Id = 81,
    Value = 0.9918964349950713d,
    NullableValue = 0.7382753808278016d,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 144,
    Value = 0.38896375627057556d,
    ModelInner = null,
    NullableValue = 0.12094039958847147d,
},
            new Doublefloat0M
{
    Id = 149,
    Value = 0.35677524184583054d,
    ModelInner = new Doublefloat0MI
{
    Id = 88,
    Value = 0.5741590675384746d,
    NullableValue = 0.5040159249911805d,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 150,
    Value = 0.7222794101657257d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 155,
    Value = 0.5731133985081779d,
    ModelInner = new Doublefloat0MI
{
    Id = 94,
    Value = 0.17846271441096595d,
    NullableValue = 0.13505233937845218d,
},
    NullableValue = 0.8983723839373918d,
},
            new Doublefloat0M
{
    Id = 156,
    Value = 0.8523549789823714d,
    ModelInner = null,
    NullableValue = 0.8179802701837218d,
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

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 32;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
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
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[18],_testData[34], false);
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
                parametr2.Value = 74;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[25],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
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
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(models[6],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(models[7],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(models[8],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(models[9],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(models[10],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[11],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[12],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[13],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[14],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(models[15],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(models[16],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(models[17],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(models[18],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[6],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(models[7],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(models[8],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(models[9],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(models[10],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[16],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
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
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(models[6],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(models[7],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(models[8],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(models[9],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(models[10],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(models[11],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(models[12],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(models[13],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(models[14],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(models[15],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(models[16],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(models[17],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[18],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[19],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[20],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[21],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(models[22],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(models[23],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(models[24],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(models[25],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

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
                        FlatDoublefloat0M.AssertModel(models[14],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(models[15],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(models[16],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(models[17],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
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
                        FlatDoublefloat0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[19],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Doublefloat0M.AssertModel(models[0],_testData[28], false);
                        Doublefloat0M.AssertModel(models[1],_testData[29], false);
                        Doublefloat0M.AssertModel(models[2],_testData[30], false);
                        Doublefloat0M.AssertModel(models[3],_testData[31], false);
                        Doublefloat0M.AssertModel(models[4],_testData[32], false);
                        Doublefloat0M.AssertModel(models[5],_testData[33], false);
                        Doublefloat0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Doublefloat0M.AssertModel(models[0],_testData[16], false);
                        Doublefloat0M.AssertModel(models[1],_testData[17], false);
                        Doublefloat0M.AssertModel(models[2],_testData[18], false);
                        Doublefloat0M.AssertModel(models[3],_testData[19], false);
                        Doublefloat0M.AssertModel(models[4],_testData[20], false);
                        Doublefloat0M.AssertModel(models[5],_testData[21], false);
                        Doublefloat0M.AssertModel(models[6],_testData[22], false);
                        Doublefloat0M.AssertModel(models[7],_testData[23], false);
                        Doublefloat0M.AssertModel(models[8],_testData[24], false);
                        Doublefloat0M.AssertModel(models[9],_testData[25], false);
                        Doublefloat0M.AssertModel(models[10],_testData[26], false);
                        Doublefloat0M.AssertModel(models[11],_testData[27], false);
                        Doublefloat0M.AssertModel(models[12],_testData[28], false);
                        Doublefloat0M.AssertModel(models[13],_testData[29], false);
                        Doublefloat0M.AssertModel(models[14],_testData[30], false);
                        Doublefloat0M.AssertModel(models[15],_testData[31], false);
                        Doublefloat0M.AssertModel(models[16],_testData[32], false);
                        Doublefloat0M.AssertModel(models[17],_testData[33], false);
                        Doublefloat0M.AssertModel(models[18],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Doublefloat0M.AssertModel(models[0],_testData[17], false);
                        Doublefloat0M.AssertModel(models[1],_testData[18], false);
                        Doublefloat0M.AssertModel(models[2],_testData[19], false);
                        Doublefloat0M.AssertModel(models[3],_testData[20], false);
                        Doublefloat0M.AssertModel(models[4],_testData[21], false);
                        Doublefloat0M.AssertModel(models[5],_testData[22], false);
                        Doublefloat0M.AssertModel(models[6],_testData[23], false);
                        Doublefloat0M.AssertModel(models[7],_testData[24], false);
                        Doublefloat0M.AssertModel(models[8],_testData[25], false);
                        Doublefloat0M.AssertModel(models[9],_testData[26], false);
                        Doublefloat0M.AssertModel(models[10],_testData[27], false);
                        Doublefloat0M.AssertModel(models[11],_testData[28], false);
                        Doublefloat0M.AssertModel(models[12],_testData[29], false);
                        Doublefloat0M.AssertModel(models[13],_testData[30], false);
                        Doublefloat0M.AssertModel(models[14],_testData[31], false);
                        Doublefloat0M.AssertModel(models[15],_testData[32], false);
                        Doublefloat0M.AssertModel(models[16],_testData[33], false);
                        Doublefloat0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Doublefloat0M.AssertModel(models[0],_testData[27], false);
                        Doublefloat0M.AssertModel(models[1],_testData[28], false);
                        Doublefloat0M.AssertModel(models[2],_testData[29], false);
                        Doublefloat0M.AssertModel(models[3],_testData[30], false);
                        Doublefloat0M.AssertModel(models[4],_testData[31], false);
                        Doublefloat0M.AssertModel(models[5],_testData[32], false);
                        Doublefloat0M.AssertModel(models[6],_testData[33], false);
                        Doublefloat0M.AssertModel(models[7],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
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
                await ((IDoubleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 62, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
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
                        FlatDoublefloat0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[22],_testData[34], false);
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
                await ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 8, query1, 149, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
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
                 ((IDoubleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 122, query1, 5, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[30],_testData[34], false);
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
                 ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelBatch(connection, 55, query1, 62, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
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
                        FlatDoublefloat0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[17],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IDoubleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 3, query1, 90, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[2], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[3], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[4], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[5], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(models[6],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(models[7],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(models[8],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(models[9],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(models[10],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(models[11],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(models[12],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(models[13],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(models[14],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(models[15],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(models[16],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(models[17],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(models[18],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(models[19],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(models[20],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(models[21],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(models[22],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(models[23],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[24],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[25],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[26],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[27],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(models[28],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(models[29],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(models[30],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(models[31],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[6],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(models[7],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(models[8],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(models[9],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(models[10],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(models[11],_testData[34], false);
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
                await ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 82, query1, 137, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((IDoubleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelBatch(connection, 144, query1, 2, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[1], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[2], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[3], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[4], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[5], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(models[6],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(models[7],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(models[8],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(models[9],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(models[10],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(models[11],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(models[12],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(models[13],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(models[14],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(models[15],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(models[16],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(models[17],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(models[18],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(models[19],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(models[20],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(models[21],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(models[22],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(models[23],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(models[24],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[25],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[26],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[27],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[28],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(models[29],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(models[30],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(models[31],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(models[32],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(models[33],_testData[34], false);
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
                 ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelBatch(connection, 54, query1, 126, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelBatchAsync(connection, 41, 82))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

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
                        Doublefloat0M.AssertModel(models[18],_testData[30], false);
                        Doublefloat0M.AssertModel(models[19],_testData[31], false);
                        Doublefloat0M.AssertModel(models[20],_testData[32], false);
                        Doublefloat0M.AssertModel(models[21],_testData[33], false);
                        Doublefloat0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Doublefloat0M.AssertModel(models[0],_testData[21], false);
                        Doublefloat0M.AssertModel(models[1],_testData[22], false);
                        Doublefloat0M.AssertModel(models[2],_testData[23], false);
                        Doublefloat0M.AssertModel(models[3],_testData[24], false);
                        Doublefloat0M.AssertModel(models[4],_testData[25], false);
                        Doublefloat0M.AssertModel(models[5],_testData[26], false);
                        Doublefloat0M.AssertModel(models[6],_testData[27], false);
                        Doublefloat0M.AssertModel(models[7],_testData[28], false);
                        Doublefloat0M.AssertModel(models[8],_testData[29], false);
                        Doublefloat0M.AssertModel(models[9],_testData[30], false);
                        Doublefloat0M.AssertModel(models[10],_testData[31], false);
                        Doublefloat0M.AssertModel(models[11],_testData[32], false);
                        Doublefloat0M.AssertModel(models[12],_testData[33], false);
                        Doublefloat0M.AssertModel(models[13],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelBatch(connection, 11, 82))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Doublefloat0M.AssertModel(models[0],_testData[6], false);
                        Doublefloat0M.AssertModel(models[1],_testData[7], false);
                        Doublefloat0M.AssertModel(models[2],_testData[8], false);
                        Doublefloat0M.AssertModel(models[3],_testData[9], false);
                        Doublefloat0M.AssertModel(models[4],_testData[10], false);
                        Doublefloat0M.AssertModel(models[5],_testData[11], false);
                        Doublefloat0M.AssertModel(models[6],_testData[12], false);
                        Doublefloat0M.AssertModel(models[7],_testData[13], false);
                        Doublefloat0M.AssertModel(models[8],_testData[14], false);
                        Doublefloat0M.AssertModel(models[9],_testData[15], false);
                        Doublefloat0M.AssertModel(models[10],_testData[16], false);
                        Doublefloat0M.AssertModel(models[11],_testData[17], false);
                        Doublefloat0M.AssertModel(models[12],_testData[18], false);
                        Doublefloat0M.AssertModel(models[13],_testData[19], false);
                        Doublefloat0M.AssertModel(models[14],_testData[20], false);
                        Doublefloat0M.AssertModel(models[15],_testData[21], false);
                        Doublefloat0M.AssertModel(models[16],_testData[22], false);
                        Doublefloat0M.AssertModel(models[17],_testData[23], false);
                        Doublefloat0M.AssertModel(models[18],_testData[24], false);
                        Doublefloat0M.AssertModel(models[19],_testData[25], false);
                        Doublefloat0M.AssertModel(models[20],_testData[26], false);
                        Doublefloat0M.AssertModel(models[21],_testData[27], false);
                        Doublefloat0M.AssertModel(models[22],_testData[28], false);
                        Doublefloat0M.AssertModel(models[23],_testData[29], false);
                        Doublefloat0M.AssertModel(models[24],_testData[30], false);
                        Doublefloat0M.AssertModel(models[25],_testData[31], false);
                        Doublefloat0M.AssertModel(models[26],_testData[32], false);
                        Doublefloat0M.AssertModel(models[27],_testData[33], false);
                        Doublefloat0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Doublefloat0M.AssertModel(models[0],_testData[21], false);
                        Doublefloat0M.AssertModel(models[1],_testData[22], false);
                        Doublefloat0M.AssertModel(models[2],_testData[23], false);
                        Doublefloat0M.AssertModel(models[3],_testData[24], false);
                        Doublefloat0M.AssertModel(models[4],_testData[25], false);
                        Doublefloat0M.AssertModel(models[5],_testData[26], false);
                        Doublefloat0M.AssertModel(models[6],_testData[27], false);
                        Doublefloat0M.AssertModel(models[7],_testData[28], false);
                        Doublefloat0M.AssertModel(models[8],_testData[29], false);
                        Doublefloat0M.AssertModel(models[9],_testData[30], false);
                        Doublefloat0M.AssertModel(models[10],_testData[31], false);
                        Doublefloat0M.AssertModel(models[11],_testData[32], false);
                        Doublefloat0M.AssertModel(models[12],_testData[33], false);
                        Doublefloat0M.AssertModel(models[13],_testData[34], false);
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
                ((IDoubleSingleTypefloat)this).SetDbConnectionSelectModelParametrs(cmd, 65);
                var models = await ((IDoubleSingleTypefloat)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(16));

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
                Doublefloat0M.AssertModel(models[11],_testData[30], false);
                Doublefloat0M.AssertModel(models[12],_testData[31], false);
                Doublefloat0M.AssertModel(models[13],_testData[32], false);
                Doublefloat0M.AssertModel(models[14],_testData[33], false);
                Doublefloat0M.AssertModel(models[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleSingleTypefloat)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleSingleTypefloat)this).SetDbConnectionSelectModelParametrs(cmd, 54);
                var models =  ((IDoubleSingleTypefloat)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                Doublefloat0M.AssertModel(models[0],_testData[14], false);
                Doublefloat0M.AssertModel(models[1],_testData[15], false);
                Doublefloat0M.AssertModel(models[2],_testData[16], false);
                Doublefloat0M.AssertModel(models[3],_testData[17], false);
                Doublefloat0M.AssertModel(models[4],_testData[18], false);
                Doublefloat0M.AssertModel(models[5],_testData[19], false);
                Doublefloat0M.AssertModel(models[6],_testData[20], false);
                Doublefloat0M.AssertModel(models[7],_testData[21], false);
                Doublefloat0M.AssertModel(models[8],_testData[22], false);
                Doublefloat0M.AssertModel(models[9],_testData[23], false);
                Doublefloat0M.AssertModel(models[10],_testData[24], false);
                Doublefloat0M.AssertModel(models[11],_testData[25], false);
                Doublefloat0M.AssertModel(models[12],_testData[26], false);
                Doublefloat0M.AssertModel(models[13],_testData[27], false);
                Doublefloat0M.AssertModel(models[14],_testData[28], false);
                Doublefloat0M.AssertModel(models[15],_testData[29], false);
                Doublefloat0M.AssertModel(models[16],_testData[30], false);
                Doublefloat0M.AssertModel(models[17],_testData[31], false);
                Doublefloat0M.AssertModel(models[18],_testData[32], false);
                Doublefloat0M.AssertModel(models[19],_testData[33], false);
                Doublefloat0M.AssertModel(models[20],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.13062309009205508d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.966926863762426d)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6066152137933728d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.08927217665064335d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.03967588572090697d)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.15450578054320507d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.012316856584989821d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.10509542366514169d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.46827804609193335d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.17510830431190116d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.2364818402447204d)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.14631442625771784d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6871112378516624d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7354184100453018d)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3240749978535794d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.760419349540815d)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7567905588529025d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9486796267678873d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9322092542889974d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6408830729151339d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.18107826344053946d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7028096720710032d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7546618552038776d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.13352049105115393d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8020173650363315d)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4178602626229937d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7023240580976621d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.08529769426634781d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.10964504134875175d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7486902410941924d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7667904168614932d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.892330066939282d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7044716246143125d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8485063229214229d)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5189135654131234d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.27899385361395534d)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9642183170772727d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6868925390055803d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.022007052994863163d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.12735441744738696d)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.42236060676935516d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8535768445223786d)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4423843408099606d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5070673736140549d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.849752081663039d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.19689739565636266d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6457267924988094d)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6481507571566784d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8639746589680486d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.6272767826896714d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7958768047911904d)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3078969776074211d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.535658357274699d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5678783841562889d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9092900782382819d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8544992218005367d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.05511721085590704d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.04300267749647335d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.41353538679594315d)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7870230375857751d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3653827051836608d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.5365188396894573d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.2745458364156017d)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.057207044199324764d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7219707795728525d)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9791250400311055d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9918964349950713d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7382753808278016d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.38896375627057556d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.12094039958847147d)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.35677524184583054d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5741590675384746d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.5040159249911805d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7222794101657257d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5731133985081779d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((94)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.17846271441096595d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.13505233937845218d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8983723839373918d)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8523549789823714d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8179802701837218d)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDoubleSingleTypefloat)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.13062309009205508d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.966926863762426d)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6066152137933728d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.08927217665064335d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.03967588572090697d)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.15450578054320507d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.012316856584989821d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.10509542366514169d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.46827804609193335d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.17510830431190116d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.2364818402447204d)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.14631442625771784d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6871112378516624d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7354184100453018d)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3240749978535794d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.760419349540815d)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7567905588529025d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9486796267678873d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9322092542889974d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6408830729151339d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.18107826344053946d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7028096720710032d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7546618552038776d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.13352049105115393d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8020173650363315d)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4178602626229937d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7023240580976621d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.08529769426634781d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.10964504134875175d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7486902410941924d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7667904168614932d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.892330066939282d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7044716246143125d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8485063229214229d)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5189135654131234d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.27899385361395534d)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9642183170772727d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6868925390055803d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.022007052994863163d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.12735441744738696d)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.42236060676935516d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8535768445223786d)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4423843408099606d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5070673736140549d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.849752081663039d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.19689739565636266d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6457267924988094d)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6481507571566784d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8639746589680486d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.6272767826896714d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7958768047911904d)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3078969776074211d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.535658357274699d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5678783841562889d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9092900782382819d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8544992218005367d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.05511721085590704d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.04300267749647335d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.41353538679594315d)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7870230375857751d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3653827051836608d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.5365188396894573d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.2745458364156017d)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.057207044199324764d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7219707795728525d)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9791250400311055d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9918964349950713d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7382753808278016d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.38896375627057556d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.12094039958847147d)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.35677524184583054d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5741590675384746d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.5040159249911805d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7222794101657257d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5731133985081779d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((94)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.17846271441096595d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.13505233937845218d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8983723839373918d)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8523549789823714d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8179802701837218d)));

            }
        }

#endregion

    }
}

