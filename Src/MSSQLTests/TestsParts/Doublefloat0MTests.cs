

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
    Id = 1,
    Value = 0.33815342456965225d,
    ModelInner = null,
    NullableValue = 0.810738967985414d,
},
            new Doublefloat0M
{
    Id = 4,
    Value = 0.3376796477580237d,
    ModelInner = new Doublefloat0MI
{
    Id = 5,
    Value = 0.03695740744326914d,
    NullableValue = 0.09486688786535713d,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 13,
    Value = 0.06122415113399704d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 17,
    Value = 0.18379351460629945d,
    ModelInner = new Doublefloat0MI
{
    Id = 12,
    Value = 0.6515100154597996d,
    NullableValue = null,
},
    NullableValue = 0.5390136199566972d,
},
            new Doublefloat0M
{
    Id = 20,
    Value = 0.7462032017889317d,
    ModelInner = null,
    NullableValue = 0.016624622244440723d,
},
            new Doublefloat0M
{
    Id = 29,
    Value = 0.10302807057464292d,
    ModelInner = new Doublefloat0MI
{
    Id = 18,
    Value = 0.24487341889552194d,
    NullableValue = 0.44619132407837636d,
},
    NullableValue = 0.4382926254776256d,
},
            new Doublefloat0M
{
    Id = 38,
    Value = 0.4820301966716478d,
    ModelInner = null,
    NullableValue = 0.6132828332100015d,
},
            new Doublefloat0M
{
    Id = 47,
    Value = 0.03933137495202743d,
    ModelInner = new Doublefloat0MI
{
    Id = 21,
    Value = 0.09684261543225547d,
    NullableValue = 0.09390218276696194d,
},
    NullableValue = 0.3654482218881111d,
},
            new Doublefloat0M
{
    Id = 52,
    Value = 0.8276564813813341d,
    ModelInner = null,
    NullableValue = 0.9143700874015493d,
},
            new Doublefloat0M
{
    Id = 58,
    Value = 0.9147589535882729d,
    ModelInner = new Doublefloat0MI
{
    Id = 27,
    Value = 0.9876264996478474d,
    NullableValue = 0.41921341249028576d,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 66,
    Value = 0.20326067806723835d,
    ModelInner = null,
    NullableValue = 0.3722034240779585d,
},
            new Doublefloat0M
{
    Id = 74,
    Value = 0.9161362819651974d,
    ModelInner = new Doublefloat0MI
{
    Id = 28,
    Value = 0.10264954437324236d,
    NullableValue = 0.9987832394991086d,
},
    NullableValue = 0.8977459317471039d,
},
            new Doublefloat0M
{
    Id = 81,
    Value = 0.14617657620649793d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 90,
    Value = 0.4517230633226237d,
    ModelInner = new Doublefloat0MI
{
    Id = 30,
    Value = 0.6316508381679288d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 97,
    Value = 0.21663307509250684d,
    ModelInner = null,
    NullableValue = 0.032503209145632095d,
},
            new Doublefloat0M
{
    Id = 98,
    Value = 0.023408168254039574d,
    ModelInner = new Doublefloat0MI
{
    Id = 36,
    Value = 0.05616231769485214d,
    NullableValue = null,
},
    NullableValue = 0.6734670818835661d,
},
            new Doublefloat0M
{
    Id = 107,
    Value = 0.009931378738660679d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 109,
    Value = 0.7045272479283303d,
    ModelInner = new Doublefloat0MI
{
    Id = 41,
    Value = 0.009541321336780206d,
    NullableValue = 0.0018740640216005078d,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 116,
    Value = 0.5118971293098455d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 124,
    Value = 0.5899059489594715d,
    ModelInner = new Doublefloat0MI
{
    Id = 43,
    Value = 0.02476593076559963d,
    NullableValue = 0.3281390442850203d,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 130,
    Value = 0.6145878511699095d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 137,
    Value = 0.9471503043443293d,
    ModelInner = new Doublefloat0MI
{
    Id = 51,
    Value = 0.525716245435963d,
    NullableValue = 0.5667008257624225d,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 144,
    Value = 0.6982397414284852d,
    ModelInner = null,
    NullableValue = 0.40321298139186335d,
},
            new Doublefloat0M
{
    Id = 149,
    Value = 0.5513252762425649d,
    ModelInner = new Doublefloat0MI
{
    Id = 53,
    Value = 0.4719966792678212d,
    NullableValue = 0.9195982307700864d,
},
    NullableValue = 0.29429272748192337d,
},
            new Doublefloat0M
{
    Id = 155,
    Value = 0.40902549125012067d,
    ModelInner = null,
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 157,
    Value = 0.05772336601479222d,
    ModelInner = new Doublefloat0MI
{
    Id = 59,
    Value = 0.4573658285460851d,
    NullableValue = 0.20009781154035156d,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 161,
    Value = 0.5364213018393349d,
    ModelInner = null,
    NullableValue = 0.9119872256927536d,
},
            new Doublefloat0M
{
    Id = 170,
    Value = 0.6003596691927834d,
    ModelInner = new Doublefloat0MI
{
    Id = 64,
    Value = 0.16972812960034522d,
    NullableValue = null,
},
    NullableValue = 0.3509031950353376d,
},
            new Doublefloat0M
{
    Id = 179,
    Value = 0.5646204818250794d,
    ModelInner = null,
    NullableValue = 0.5304520516094763d,
},
            new Doublefloat0M
{
    Id = 180,
    Value = 0.2825100720891952d,
    ModelInner = new Doublefloat0MI
{
    Id = 68,
    Value = 0.7587538520270702d,
    NullableValue = 0.14635164429425496d,
},
    NullableValue = 0.5732157467161247d,
},
            new Doublefloat0M
{
    Id = 181,
    Value = 0.5372214820395005d,
    ModelInner = null,
    NullableValue = 0.9356984605875169d,
},
            new Doublefloat0M
{
    Id = 186,
    Value = 0.27769155614551d,
    ModelInner = new Doublefloat0MI
{
    Id = 77,
    Value = 0.21674011624159562d,
    NullableValue = null,
},
    NullableValue = 0.5023617778456817d,
},
            new Doublefloat0M
{
    Id = 194,
    Value = 0.7931327450679073d,
    ModelInner = null,
    NullableValue = 0.9805572327036719d,
},
            new Doublefloat0M
{
    Id = 202,
    Value = 0.648173418791902d,
    ModelInner = new Doublefloat0MI
{
    Id = 86,
    Value = 0.7825446411818444d,
    NullableValue = 0.7803016707917293d,
},
    NullableValue = null,
},
            new Doublefloat0M
{
    Id = 206,
    Value = 0.8979827652085988d,
    ModelInner = null,
    NullableValue = 0.8606576753298996d,
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
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
                        FlatDoublefloat0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
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
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[28],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 97;
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
                 ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[22],_testData[34], false);
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
                parametr1.Value = 29;
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
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(models[6],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(models[7],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(models[8],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(models[9],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(models[10],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(models[11],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(models[12],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(models[13],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(models[14],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(models[15],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(models[16],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(models[17],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(models[18],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(models[19],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[20],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[21],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[22],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[23],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(models[24],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(models[25],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(models[26],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(models[27],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(models[6],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[7],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[8],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[9],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[10],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(models[11],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(models[12],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(models[13],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(models[14],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
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
                        FlatDoublefloat0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[29],_testData[34], false);
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
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 179;
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
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(models[6],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(models[7],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(models[8],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(models[9],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(models[10],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(models[11],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(models[12],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(models[13],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[14],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[15],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[16],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[17],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(models[18],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(models[19],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(models[20],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(models[21],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 170;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[25],_testData[34], false);
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Doublefloat0M.AssertModel(models[0],_testData[20], false);
                        Doublefloat0M.AssertModel(models[1],_testData[21], false);
                        Doublefloat0M.AssertModel(models[2],_testData[22], false);
                        Doublefloat0M.AssertModel(models[3],_testData[23], false);
                        Doublefloat0M.AssertModel(models[4],_testData[24], false);
                        Doublefloat0M.AssertModel(models[5],_testData[25], false);
                        Doublefloat0M.AssertModel(models[6],_testData[26], false);
                        Doublefloat0M.AssertModel(models[7],_testData[27], false);
                        Doublefloat0M.AssertModel(models[8],_testData[28], false);
                        Doublefloat0M.AssertModel(models[9],_testData[29], false);
                        Doublefloat0M.AssertModel(models[10],_testData[30], false);
                        Doublefloat0M.AssertModel(models[11],_testData[31], false);
                        Doublefloat0M.AssertModel(models[12],_testData[32], false);
                        Doublefloat0M.AssertModel(models[13],_testData[33], false);
                        Doublefloat0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 186;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Doublefloat0M.AssertModel(models[0],_testData[32], false);
                        Doublefloat0M.AssertModel(models[1],_testData[33], false);
                        Doublefloat0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Doublefloat0M.AssertModel(models[0],_testData[20], false);
                        Doublefloat0M.AssertModel(models[1],_testData[21], false);
                        Doublefloat0M.AssertModel(models[2],_testData[22], false);
                        Doublefloat0M.AssertModel(models[3],_testData[23], false);
                        Doublefloat0M.AssertModel(models[4],_testData[24], false);
                        Doublefloat0M.AssertModel(models[5],_testData[25], false);
                        Doublefloat0M.AssertModel(models[6],_testData[26], false);
                        Doublefloat0M.AssertModel(models[7],_testData[27], false);
                        Doublefloat0M.AssertModel(models[8],_testData[28], false);
                        Doublefloat0M.AssertModel(models[9],_testData[29], false);
                        Doublefloat0M.AssertModel(models[10],_testData[30], false);
                        Doublefloat0M.AssertModel(models[11],_testData[31], false);
                        Doublefloat0M.AssertModel(models[12],_testData[32], false);
                        Doublefloat0M.AssertModel(models[13],_testData[33], false);
                        Doublefloat0M.AssertModel(models[14],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                await ((IDoubleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 98, query1, 180, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[18],_testData[34], false);
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
                await ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 186, query1, 186, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[2],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloat0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                 ((IDoubleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 137, query1, 4, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
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
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[32],_testData[34], false);
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
                 ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelBatch(connection, 137, query1, 161, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
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
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[34], false);
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
                foreach(var batchResult in await ((IDoubleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 194, query1, 1, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[34], false);
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
                await ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 149, query1, 179, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[34], false);
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
                foreach(var batchResult in  ((IDoubleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelBatch(connection, 116, query1, 17, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(models[6],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[7],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[8],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[9],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[10],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(models[11],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(models[12],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(models[13],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(models[14],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatDoublefloat0M.AssertModel(models[0],_testData[4], false);
                        FlatDoublefloat0M.AssertModel(models[1],_testData[5], false);
                        FlatDoublefloat0M.AssertModel(models[2],_testData[6], false);
                        FlatDoublefloat0M.AssertModel(models[3],_testData[7], false);
                        FlatDoublefloat0M.AssertModel(models[4],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(models[5],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(models[6],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(models[7],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(models[8],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(models[9],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(models[10],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(models[11],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(models[12],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(models[13],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(models[14],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(models[15],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(models[16],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(models[17],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(models[18],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(models[19],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(models[20],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(models[21],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(models[22],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(models[23],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(models[24],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(models[25],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(models[26],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(models[27],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(models[28],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(models[29],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(models[30],_testData[34], false);
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
                 ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelBatch(connection, 47, query1, 155, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatDoublefloat0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatDoublefloat0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatDoublefloat0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatDoublefloat0M.AssertModel(secondItems2[9],_testData[34], false);
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
                foreach(var batchResult in await ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelBatchAsync(connection, 179, 149))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Doublefloat0M.AssertModel(models[0],_testData[29], false);
                        Doublefloat0M.AssertModel(models[1],_testData[30], false);
                        Doublefloat0M.AssertModel(models[2],_testData[31], false);
                        Doublefloat0M.AssertModel(models[3],_testData[32], false);
                        Doublefloat0M.AssertModel(models[4],_testData[33], false);
                        Doublefloat0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Doublefloat0M.AssertModel(models[0],_testData[24], false);
                        Doublefloat0M.AssertModel(models[1],_testData[25], false);
                        Doublefloat0M.AssertModel(models[2],_testData[26], false);
                        Doublefloat0M.AssertModel(models[3],_testData[27], false);
                        Doublefloat0M.AssertModel(models[4],_testData[28], false);
                        Doublefloat0M.AssertModel(models[5],_testData[29], false);
                        Doublefloat0M.AssertModel(models[6],_testData[30], false);
                        Doublefloat0M.AssertModel(models[7],_testData[31], false);
                        Doublefloat0M.AssertModel(models[8],_testData[32], false);
                        Doublefloat0M.AssertModel(models[9],_testData[33], false);
                        Doublefloat0M.AssertModel(models[10],_testData[34], false);
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
                foreach(var batchResult in  ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelBatch(connection, 179, 13))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Doublefloat0M.AssertModel(models[0],_testData[29], false);
                        Doublefloat0M.AssertModel(models[1],_testData[30], false);
                        Doublefloat0M.AssertModel(models[2],_testData[31], false);
                        Doublefloat0M.AssertModel(models[3],_testData[32], false);
                        Doublefloat0M.AssertModel(models[4],_testData[33], false);
                        Doublefloat0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        Doublefloat0M.AssertModel(models[0],_testData[3], false);
                        Doublefloat0M.AssertModel(models[1],_testData[4], false);
                        Doublefloat0M.AssertModel(models[2],_testData[5], false);
                        Doublefloat0M.AssertModel(models[3],_testData[6], false);
                        Doublefloat0M.AssertModel(models[4],_testData[7], false);
                        Doublefloat0M.AssertModel(models[5],_testData[8], false);
                        Doublefloat0M.AssertModel(models[6],_testData[9], false);
                        Doublefloat0M.AssertModel(models[7],_testData[10], false);
                        Doublefloat0M.AssertModel(models[8],_testData[11], false);
                        Doublefloat0M.AssertModel(models[9],_testData[12], false);
                        Doublefloat0M.AssertModel(models[10],_testData[13], false);
                        Doublefloat0M.AssertModel(models[11],_testData[14], false);
                        Doublefloat0M.AssertModel(models[12],_testData[15], false);
                        Doublefloat0M.AssertModel(models[13],_testData[16], false);
                        Doublefloat0M.AssertModel(models[14],_testData[17], false);
                        Doublefloat0M.AssertModel(models[15],_testData[18], false);
                        Doublefloat0M.AssertModel(models[16],_testData[19], false);
                        Doublefloat0M.AssertModel(models[17],_testData[20], false);
                        Doublefloat0M.AssertModel(models[18],_testData[21], false);
                        Doublefloat0M.AssertModel(models[19],_testData[22], false);
                        Doublefloat0M.AssertModel(models[20],_testData[23], false);
                        Doublefloat0M.AssertModel(models[21],_testData[24], false);
                        Doublefloat0M.AssertModel(models[22],_testData[25], false);
                        Doublefloat0M.AssertModel(models[23],_testData[26], false);
                        Doublefloat0M.AssertModel(models[24],_testData[27], false);
                        Doublefloat0M.AssertModel(models[25],_testData[28], false);
                        Doublefloat0M.AssertModel(models[26],_testData[29], false);
                        Doublefloat0M.AssertModel(models[27],_testData[30], false);
                        Doublefloat0M.AssertModel(models[28],_testData[31], false);
                        Doublefloat0M.AssertModel(models[29],_testData[32], false);
                        Doublefloat0M.AssertModel(models[30],_testData[33], false);
                        Doublefloat0M.AssertModel(models[31],_testData[34], false);
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
                ((IDoubleSingleTypefloat)this).SetDbConnectionSelectModelParametrs(cmd, 186);
                var models = await ((IDoubleSingleTypefloat)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(3));
Doublefloat0M.AssertModel(models[0],_testData[32], false);Doublefloat0M.AssertModel(models[1],_testData[33], false);Doublefloat0M.AssertModel(models[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleSingleTypefloat)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleSingleTypefloat)this).SetDbConnectionSelectModelParametrs(cmd, 170);
                var models =  ((IDoubleSingleTypefloat)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));
Doublefloat0M.AssertModel(models[0],_testData[28], false);Doublefloat0M.AssertModel(models[1],_testData[29], false);Doublefloat0M.AssertModel(models[2],_testData[30], false);Doublefloat0M.AssertModel(models[3],_testData[31], false);Doublefloat0M.AssertModel(models[4],_testData[32], false);Doublefloat0M.AssertModel(models[5],_testData[33], false);Doublefloat0M.AssertModel(models[6],_testData[34], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.33815342456965225d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.810738967985414d)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3376796477580237d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.03695740744326914d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.09486688786535713d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.06122415113399704d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.18379351460629945d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6515100154597996d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5390136199566972d)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7462032017889317d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.016624622244440723d)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.10302807057464292d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.24487341889552194d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.44619132407837636d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4382926254776256d)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4820301966716478d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6132828332100015d)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.03933137495202743d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.09684261543225547d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.09390218276696194d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3654482218881111d)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8276564813813341d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9143700874015493d)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9147589535882729d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9876264996478474d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.41921341249028576d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.20326067806723835d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3722034240779585d)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9161362819651974d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.10264954437324236d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.9987832394991086d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8977459317471039d)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.14617657620649793d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4517230633226237d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6316508381679288d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.21663307509250684d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.032503209145632095d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.023408168254039574d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.05616231769485214d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6734670818835661d)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.009931378738660679d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7045272479283303d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.009541321336780206d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.0018740640216005078d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5118971293098455d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5899059489594715d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.02476593076559963d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.3281390442850203d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6145878511699095d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9471503043443293d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.525716245435963d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.5667008257624225d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6982397414284852d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.40321298139186335d)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5513252762425649d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4719966792678212d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.9195982307700864d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.29429272748192337d)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.40902549125012067d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.05772336601479222d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4573658285460851d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.20009781154035156d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5364213018393349d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9119872256927536d)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6003596691927834d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.16972812960034522d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3509031950353376d)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5646204818250794d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5304520516094763d)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((180)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2825100720891952d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7587538520270702d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.14635164429425496d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5732157467161247d)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((181)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5372214820395005d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9356984605875169d)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((186)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.27769155614551d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.21674011624159562d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5023617778456817d)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((194)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7931327450679073d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9805572327036719d)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((202)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.648173418791902d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7825446411818444d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7803016707917293d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((206)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8979827652085988d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8606576753298996d)));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.33815342456965225d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.810738967985414d)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3376796477580237d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.03695740744326914d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.09486688786535713d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.06122415113399704d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.18379351460629945d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6515100154597996d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5390136199566972d)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7462032017889317d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.016624622244440723d)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.10302807057464292d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.24487341889552194d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.44619132407837636d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4382926254776256d)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4820301966716478d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6132828332100015d)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.03933137495202743d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.09684261543225547d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.09390218276696194d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3654482218881111d)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8276564813813341d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9143700874015493d)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9147589535882729d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9876264996478474d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.41921341249028576d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.20326067806723835d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3722034240779585d)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9161362819651974d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.10264954437324236d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.9987832394991086d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8977459317471039d)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.14617657620649793d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4517230633226237d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6316508381679288d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.21663307509250684d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.032503209145632095d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.023408168254039574d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.05616231769485214d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6734670818835661d)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.009931378738660679d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7045272479283303d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.009541321336780206d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.0018740640216005078d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5118971293098455d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5899059489594715d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.02476593076559963d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.3281390442850203d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6145878511699095d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9471503043443293d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.525716245435963d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.5667008257624225d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6982397414284852d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.40321298139186335d)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5513252762425649d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4719966792678212d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.9195982307700864d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.29429272748192337d)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.40902549125012067d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.05772336601479222d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4573658285460851d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.20009781154035156d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5364213018393349d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9119872256927536d)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6003596691927834d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.16972812960034522d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3509031950353376d)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5646204818250794d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5304520516094763d)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((180)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2825100720891952d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7587538520270702d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.14635164429425496d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5732157467161247d)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((181)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5372214820395005d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9356984605875169d)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((186)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.27769155614551d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.21674011624159562d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5023617778456817d)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((194)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7931327450679073d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9805572327036719d)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((202)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.648173418791902d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7825446411818444d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7803016707917293d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((206)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8979827652085988d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8606576753298996d)));

            }
        }

#endregion

    }
}

