

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

        private readonly DoublefloatE0M[] _testData = new DoublefloatE0M[]
        {
            new DoublefloatE0M
{
    Id = 2,
    Value = 0.08654527464141304d,
    ModelInner = null,
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 8,
    Value = 0.20595592477316493d,
    ModelInner = new DoublefloatE0MI
{
    Id = 6,
    Value = 0.9527577907059139d,
    NullableValue = 0.8272227603012803d,
},
    NullableValue = 0.32403926153961926d,
},
            new DoublefloatE0M
{
    Id = 10,
    Value = 0.2532271173385354d,
    ModelInner = null,
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 14,
    Value = 0.9167640135453751d,
    ModelInner = new DoublefloatE0MI
{
    Id = 10,
    Value = 0.3059901473789405d,
    NullableValue = 0.02769580135924332d,
},
    NullableValue = 0.22270677699666297d,
},
            new DoublefloatE0M
{
    Id = 21,
    Value = 0.007730444016505578d,
    ModelInner = null,
    NullableValue = 0.45552409072539835d,
},
            new DoublefloatE0M
{
    Id = 23,
    Value = 0.5824210591772058d,
    ModelInner = new DoublefloatE0MI
{
    Id = 18,
    Value = 0.07468991877393594d,
    NullableValue = 0.30465941773992633d,
},
    NullableValue = 0.9690826617506224d,
},
            new DoublefloatE0M
{
    Id = 29,
    Value = 0.11659857606784085d,
    ModelInner = null,
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 35,
    Value = 0.23393967914440295d,
    ModelInner = new DoublefloatE0MI
{
    Id = 25,
    Value = 0.3789967853034575d,
    NullableValue = 0.43057444895996144d,
},
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 43,
    Value = 0.8190310341441059d,
    ModelInner = null,
    NullableValue = 0.7569692128367882d,
},
            new DoublefloatE0M
{
    Id = 52,
    Value = 0.46271273313283123d,
    ModelInner = new DoublefloatE0MI
{
    Id = 32,
    Value = 0.23597932035390168d,
    NullableValue = null,
},
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 59,
    Value = 0.5377505922026485d,
    ModelInner = null,
    NullableValue = 0.8843752271054168d,
},
            new DoublefloatE0M
{
    Id = 62,
    Value = 0.7912618295473426d,
    ModelInner = new DoublefloatE0MI
{
    Id = 33,
    Value = 0.29557310158368066d,
    NullableValue = 0.9219349574133581d,
},
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 65,
    Value = 0.5194105153736532d,
    ModelInner = null,
    NullableValue = 0.7496457620568765d,
},
            new DoublefloatE0M
{
    Id = 69,
    Value = 0.7596439786522067d,
    ModelInner = new DoublefloatE0MI
{
    Id = 37,
    Value = 0.3964760804386682d,
    NullableValue = null,
},
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 76,
    Value = 0.5679643668342333d,
    ModelInner = null,
    NullableValue = 0.7827793351658662d,
},
            new DoublefloatE0M
{
    Id = 80,
    Value = 0.6966822632269802d,
    ModelInner = new DoublefloatE0MI
{
    Id = 46,
    Value = 0.8975977068589289d,
    NullableValue = null,
},
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 85,
    Value = 0.2843943191146051d,
    ModelInner = null,
    NullableValue = 0.8384684312886564d,
},
            new DoublefloatE0M
{
    Id = 94,
    Value = 0.4770297151124794d,
    ModelInner = new DoublefloatE0MI
{
    Id = 48,
    Value = 0.7890218572547528d,
    NullableValue = null,
},
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 95,
    Value = 0.9046175810994408d,
    ModelInner = null,
    NullableValue = 0.7721989545084988d,
},
            new DoublefloatE0M
{
    Id = 104,
    Value = 0.33564584232238315d,
    ModelInner = new DoublefloatE0MI
{
    Id = 57,
    Value = 0.5281287230721375d,
    NullableValue = null,
},
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 110,
    Value = 0.4823321586276089d,
    ModelInner = null,
    NullableValue = 0.3141908092480211d,
},
            new DoublefloatE0M
{
    Id = 112,
    Value = 0.6032833567243717d,
    ModelInner = new DoublefloatE0MI
{
    Id = 59,
    Value = 0.09645541310060335d,
    NullableValue = 0.8631554414832189d,
},
    NullableValue = 0.7116732707148271d,
},
            new DoublefloatE0M
{
    Id = 120,
    Value = 0.13293498523486347d,
    ModelInner = null,
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 126,
    Value = 0.2887210350831785d,
    ModelInner = new DoublefloatE0MI
{
    Id = 65,
    Value = 0.8112795519085008d,
    NullableValue = null,
},
    NullableValue = 0.8776462836187044d,
},
            new DoublefloatE0M
{
    Id = 129,
    Value = 0.9526793603596655d,
    ModelInner = null,
    NullableValue = 0.2486911177612987d,
},
            new DoublefloatE0M
{
    Id = 135,
    Value = 0.18200173150027998d,
    ModelInner = new DoublefloatE0MI
{
    Id = 69,
    Value = 0.4015987553506227d,
    NullableValue = 0.32256156720017204d,
},
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 138,
    Value = 0.7021779714770666d,
    ModelInner = null,
    NullableValue = 0.49240734290709853d,
},
            new DoublefloatE0M
{
    Id = 144,
    Value = 0.7916209792513227d,
    ModelInner = new DoublefloatE0MI
{
    Id = 74,
    Value = 0.8872616231565653d,
    NullableValue = 0.017568615675436883d,
},
    NullableValue = 0.9420040224248228d,
},
            new DoublefloatE0M
{
    Id = 151,
    Value = 0.524034783696693d,
    ModelInner = null,
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 153,
    Value = 0.7771013810013737d,
    ModelInner = new DoublefloatE0MI
{
    Id = 76,
    Value = 0.058273610918810226d,
    NullableValue = 0.8715299643918638d,
},
    NullableValue = 0.10569821526029399d,
},
            new DoublefloatE0M
{
    Id = 159,
    Value = 0.07981690195143076d,
    ModelInner = null,
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 163,
    Value = 0.33126403616945976d,
    ModelInner = new DoublefloatE0MI
{
    Id = 78,
    Value = 0.9512073206989338d,
    NullableValue = 0.6129879060199902d,
},
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 169,
    Value = 0.8866224259536658d,
    ModelInner = null,
    NullableValue = 0.860026193502413d,
},
            new DoublefloatE0M
{
    Id = 174,
    Value = 0.8692859844137129d,
    ModelInner = new DoublefloatE0MI
{
    Id = 85,
    Value = 0.23073112570488097d,
    NullableValue = 0.837677982399178d,
},
    NullableValue = 0.9660966269757573d,
},
            new DoublefloatE0M
{
    Id = 183,
    Value = 0.6234502263765435d,
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.doublefloate0mi(
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
INSERT INTO dbo.doublefloate0mi(
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
INSERT INTO dbo.doublefloate0m(
	id,
    value,
    nullablevalue,
    doublefloate0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @doublefloate0mi_id
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
                parametrName: "doublefloate0mi_id", 
                methodParametrName: "doublefloate0mi_id", 
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
INSERT INTO dbo.doublefloate0m(
	id,
    value,
    nullablevalue,
    doublefloate0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @doublefloate0mi_id
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
                parametrName: "doublefloate0mi_id", 
                methodParametrName: "doublefloate0mi_id", 
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
            queryMapTypes: [typeof(FlatDoublefloatE0M), typeof(FlatDoublefloatE0M)],
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
FROM dbo.doublefloate0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoublefloatE0M>();
                var models2 = new List<FlatDoublefloatE0M>();
                await((IDoubleSingleTypefloat)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloatE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoublefloatE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.doublefloate0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoublefloatE0M>();
                var models2 = new List<FlatDoublefloatE0M>();
                ((IDoubleSingleTypefloat)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloatE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoublefloatE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoublefloatE0M)],
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
FROM dbo.doublefloate0m m
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
                    FlatDoublefloatE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.doublefloate0m m
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
                    FlatDoublefloatE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.doublefloate0m m
LEFT JOIN dbo.doublefloate0mi mi ON mi.id = m.doublefloate0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DoublefloatE0M)],
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
                    DoublefloatE0M.AssertModel(models[i],_testData[i], false);
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
                    DoublefloatE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoublefloatE0M), typeof(FlatDoublefloatE0M)],
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
FROM dbo.doublefloate0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoublefloatE0M>();
                var models2 = new List<FlatDoublefloatE0M>();
                await((IDoubleSingleTypefloat)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloatE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoublefloatE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.doublefloate0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoublefloatE0M>();
                var models2 = new List<FlatDoublefloatE0M>();
                ((IDoubleSingleTypefloat)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloatE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoublefloatE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoublefloatE0M)],
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
FROM dbo.doublefloate0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleSingleTypefloat)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloatE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.doublefloate0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleSingleTypefloat)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloatE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.doublefloate0m m
LEFT JOIN dbo.doublefloate0mi mi ON mi.id = m.doublefloate0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DoublefloatE0M)],
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
                    DoublefloatE0M.AssertModel(models[i],_testData[i], false);
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
                    DoublefloatE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoublefloatE0M), typeof(FlatDoublefloatE0M)],
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoublefloatE0M>();
                var models2 = new List<FlatDoublefloatE0M>();
                await((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloatE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoublefloatE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
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
FROM dbo.doublefloate0m m
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloatE0M>();
                var firstItems2 = new List<FlatDoublefloatE0M>();
                var secondItems1 = new List<FlatDoublefloatE0M>();
                var secondItems2 = new List<FlatDoublefloatE0M>();
                await ((IDoubleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 43;
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
FROM dbo.doublefloate0m m
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloatE0M>();
                var firstItems2 = new List<FlatDoublefloatE0M>();
                var secondItems1 = new List<FlatDoublefloatE0M>();
                await ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[30],_testData[34], false);
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoublefloatE0M>();
                var models2 = new List<FlatDoublefloatE0M>();
                ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloatE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoublefloatE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
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
FROM dbo.doublefloate0m m
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloatE0M>();
                var firstItems2 = new List<FlatDoublefloatE0M>();
                var secondItems1 = new List<FlatDoublefloatE0M>();
                var secondItems2 = new List<FlatDoublefloatE0M>();
                 ((IDoubleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
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
FROM dbo.doublefloate0m m
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloatE0M>();
                var firstItems2 = new List<FlatDoublefloatE0M>();
                var secondItems1 = new List<FlatDoublefloatE0M>();
                 ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[11],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoublefloatE0M)],
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
FROM dbo.doublefloate0m m
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
                    FlatDoublefloatE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 112;
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
FROM dbo.doublefloate0m m
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
FROM dbo.doublefloate0m m
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
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatDoublefloatE0M.AssertModel(models[0],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(models[1],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(models[2],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(models[3],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(models[4],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(models[5],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(models[6],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(models[7],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(models[8],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(models[9],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(models[10],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(models[11],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatDoublefloatE0M.AssertModel(models[0],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(models[1],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(models[2],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(models[3],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(models[4],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(models[5],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(models[6],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(models[7],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(models[8],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(models[9],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(models[10],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(models[11],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(models[12],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(models[13],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(models[14],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(models[15],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(models[16],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(models[17],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(models[18],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(models[19],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(models[20],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(models[21],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(models[22],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.doublefloate0m m
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloatE0M>();
                var secondItems1 = new List<FlatDoublefloatE0M>();
                var secondItems2 = new List<FlatDoublefloatE0M>();
                await ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM dbo.doublefloate0m m
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
                    FlatDoublefloatE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 153;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.doublefloate0m m
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
FROM dbo.doublefloate0m m
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
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatDoublefloatE0M.AssertModel(models[0],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(models[1],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(models[2],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(models[3],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDoublefloatE0M.AssertModel(models[0],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(models[1],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(models[2],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(models[3],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(models[4],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(models[5],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(models[6],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(models[7],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(models[8],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(models[9],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(models[10],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(models[11],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(models[12],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(models[13],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(models[14],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(models[15],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(models[16],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(models[17],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(models[18],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(models[19],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 159;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.doublefloate0m m
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloatE0M>();
                var secondItems1 = new List<FlatDoublefloatE0M>();
                var secondItems2 = new List<FlatDoublefloatE0M>();
                 ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM dbo.doublefloate0m m
LEFT JOIN dbo.doublefloate0mi mi ON mi.id = m.doublefloate0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DoublefloatE0M)],
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
                    DoublefloatE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        DoublefloatE0M.AssertModel(models[0],_testData[5], false);
                        DoublefloatE0M.AssertModel(models[1],_testData[6], false);
                        DoublefloatE0M.AssertModel(models[2],_testData[7], false);
                        DoublefloatE0M.AssertModel(models[3],_testData[8], false);
                        DoublefloatE0M.AssertModel(models[4],_testData[9], false);
                        DoublefloatE0M.AssertModel(models[5],_testData[10], false);
                        DoublefloatE0M.AssertModel(models[6],_testData[11], false);
                        DoublefloatE0M.AssertModel(models[7],_testData[12], false);
                        DoublefloatE0M.AssertModel(models[8],_testData[13], false);
                        DoublefloatE0M.AssertModel(models[9],_testData[14], false);
                        DoublefloatE0M.AssertModel(models[10],_testData[15], false);
                        DoublefloatE0M.AssertModel(models[11],_testData[16], false);
                        DoublefloatE0M.AssertModel(models[12],_testData[17], false);
                        DoublefloatE0M.AssertModel(models[13],_testData[18], false);
                        DoublefloatE0M.AssertModel(models[14],_testData[19], false);
                        DoublefloatE0M.AssertModel(models[15],_testData[20], false);
                        DoublefloatE0M.AssertModel(models[16],_testData[21], false);
                        DoublefloatE0M.AssertModel(models[17],_testData[22], false);
                        DoublefloatE0M.AssertModel(models[18],_testData[23], false);
                        DoublefloatE0M.AssertModel(models[19],_testData[24], false);
                        DoublefloatE0M.AssertModel(models[20],_testData[25], false);
                        DoublefloatE0M.AssertModel(models[21],_testData[26], false);
                        DoublefloatE0M.AssertModel(models[22],_testData[27], false);
                        DoublefloatE0M.AssertModel(models[23],_testData[28], false);
                        DoublefloatE0M.AssertModel(models[24],_testData[29], false);
                        DoublefloatE0M.AssertModel(models[25],_testData[30], false);
                        DoublefloatE0M.AssertModel(models[26],_testData[31], false);
                        DoublefloatE0M.AssertModel(models[27],_testData[32], false);
                        DoublefloatE0M.AssertModel(models[28],_testData[33], false);
                        DoublefloatE0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        DoublefloatE0M.AssertModel(models[0],_testData[28], false);
                        DoublefloatE0M.AssertModel(models[1],_testData[29], false);
                        DoublefloatE0M.AssertModel(models[2],_testData[30], false);
                        DoublefloatE0M.AssertModel(models[3],_testData[31], false);
                        DoublefloatE0M.AssertModel(models[4],_testData[32], false);
                        DoublefloatE0M.AssertModel(models[5],_testData[33], false);
                        DoublefloatE0M.AssertModel(models[6],_testData[34], false);
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
                    DoublefloatE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 144;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 159;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        DoublefloatE0M.AssertModel(models[0],_testData[28], false);
                        DoublefloatE0M.AssertModel(models[1],_testData[29], false);
                        DoublefloatE0M.AssertModel(models[2],_testData[30], false);
                        DoublefloatE0M.AssertModel(models[3],_testData[31], false);
                        DoublefloatE0M.AssertModel(models[4],_testData[32], false);
                        DoublefloatE0M.AssertModel(models[5],_testData[33], false);
                        DoublefloatE0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        DoublefloatE0M.AssertModel(models[0],_testData[31], false);
                        DoublefloatE0M.AssertModel(models[1],_testData[32], false);
                        DoublefloatE0M.AssertModel(models[2],_testData[33], false);
                        DoublefloatE0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoublefloatE0M), typeof(FlatDoublefloatE0M)],
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoublefloatE0M>();
                var models2 = new List<FlatDoublefloatE0M>();
                await((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloatE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoublefloatE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.doublefloate0m m
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloatE0M>();
                var firstItems2 = new List<FlatDoublefloatE0M>();
                var secondItems1 = new List<FlatDoublefloatE0M>();
                var secondItems2 = new List<FlatDoublefloatE0M>();
                await ((IDoubleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 163, query1, 163, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM dbo.doublefloate0m m
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloatE0M>();
                var firstItems2 = new List<FlatDoublefloatE0M>();
                var secondItems1 = new List<FlatDoublefloatE0M>();
                await ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 65, query1, 10, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[31],_testData[34], false);
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoublefloatE0M>();
                var models2 = new List<FlatDoublefloatE0M>();
                ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloatE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoublefloatE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.doublefloate0m m
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloatE0M>();
                var firstItems2 = new List<FlatDoublefloatE0M>();
                var secondItems1 = new List<FlatDoublefloatE0M>();
                var secondItems2 = new List<FlatDoublefloatE0M>();
                 ((IDoubleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 129, query1, 76, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM dbo.doublefloate0m m
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloatE0M>();
                var firstItems2 = new List<FlatDoublefloatE0M>();
                var secondItems1 = new List<FlatDoublefloatE0M>();
                 ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelBatch(connection, 62, query1, 138, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoublefloatE0M)],
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloatE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.doublefloate0m m
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 69, query1, 10, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDoublefloatE0M.AssertModel(models[0],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(models[1],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(models[2],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(models[3],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(models[4],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(models[5],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(models[6],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(models[7],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(models[8],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(models[9],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(models[10],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(models[11],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(models[12],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(models[13],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(models[14],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(models[15],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(models[16],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(models[17],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(models[18],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(models[19],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatDoublefloatE0M.AssertModel(models[0],_testData[3], false);
                        FlatDoublefloatE0M.AssertModel(models[1],_testData[4], false);
                        FlatDoublefloatE0M.AssertModel(models[2],_testData[5], false);
                        FlatDoublefloatE0M.AssertModel(models[3],_testData[6], false);
                        FlatDoublefloatE0M.AssertModel(models[4],_testData[7], false);
                        FlatDoublefloatE0M.AssertModel(models[5],_testData[8], false);
                        FlatDoublefloatE0M.AssertModel(models[6],_testData[9], false);
                        FlatDoublefloatE0M.AssertModel(models[7],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(models[8],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(models[9],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(models[10],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(models[11],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(models[12],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(models[13],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(models[14],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(models[15],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(models[16],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(models[17],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(models[18],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(models[19],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(models[20],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(models[21],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(models[22],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(models[23],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(models[24],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(models[25],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(models[26],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(models[27],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(models[28],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(models[29],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(models[30],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(models[31],_testData[34], false);
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
FROM dbo.doublefloate0m m
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloatE0M>();
                var secondItems1 = new List<FlatDoublefloatE0M>();
                var secondItems2 = new List<FlatDoublefloatE0M>();
                await ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 10, query1, 110, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoublefloatE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.doublefloate0m m
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelBatch(connection, 104, query1, 126, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatDoublefloatE0M.AssertModel(models[0],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(models[1],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(models[2],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(models[3],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(models[4],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(models[5],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(models[6],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(models[7],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(models[8],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(models[9],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(models[10],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(models[11],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(models[12],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(models[13],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDoublefloatE0M.AssertModel(models[0],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(models[1],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(models[2],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(models[3],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(models[4],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(models[5],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(models[6],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(models[7],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(models[8],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(models[9],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(models[10],_testData[34], false);
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
FROM dbo.doublefloate0m m
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
FROM dbo.doublefloate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoublefloatE0M>();
                var secondItems1 = new List<FlatDoublefloatE0M>();
                var secondItems2 = new List<FlatDoublefloatE0M>();
                 ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelBatch(connection, 112, query1, 35, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM dbo.doublefloate0m m
LEFT JOIN dbo.doublefloate0mi mi ON mi.id = m.doublefloate0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DoublefloatE0M)],
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
                    DoublefloatE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelBatchAsync(connection, 80, 8))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        DoublefloatE0M.AssertModel(models[0],_testData[16], false);
                        DoublefloatE0M.AssertModel(models[1],_testData[17], false);
                        DoublefloatE0M.AssertModel(models[2],_testData[18], false);
                        DoublefloatE0M.AssertModel(models[3],_testData[19], false);
                        DoublefloatE0M.AssertModel(models[4],_testData[20], false);
                        DoublefloatE0M.AssertModel(models[5],_testData[21], false);
                        DoublefloatE0M.AssertModel(models[6],_testData[22], false);
                        DoublefloatE0M.AssertModel(models[7],_testData[23], false);
                        DoublefloatE0M.AssertModel(models[8],_testData[24], false);
                        DoublefloatE0M.AssertModel(models[9],_testData[25], false);
                        DoublefloatE0M.AssertModel(models[10],_testData[26], false);
                        DoublefloatE0M.AssertModel(models[11],_testData[27], false);
                        DoublefloatE0M.AssertModel(models[12],_testData[28], false);
                        DoublefloatE0M.AssertModel(models[13],_testData[29], false);
                        DoublefloatE0M.AssertModel(models[14],_testData[30], false);
                        DoublefloatE0M.AssertModel(models[15],_testData[31], false);
                        DoublefloatE0M.AssertModel(models[16],_testData[32], false);
                        DoublefloatE0M.AssertModel(models[17],_testData[33], false);
                        DoublefloatE0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        DoublefloatE0M.AssertModel(models[0],_testData[2], false);
                        DoublefloatE0M.AssertModel(models[1],_testData[3], false);
                        DoublefloatE0M.AssertModel(models[2],_testData[4], false);
                        DoublefloatE0M.AssertModel(models[3],_testData[5], false);
                        DoublefloatE0M.AssertModel(models[4],_testData[6], false);
                        DoublefloatE0M.AssertModel(models[5],_testData[7], false);
                        DoublefloatE0M.AssertModel(models[6],_testData[8], false);
                        DoublefloatE0M.AssertModel(models[7],_testData[9], false);
                        DoublefloatE0M.AssertModel(models[8],_testData[10], false);
                        DoublefloatE0M.AssertModel(models[9],_testData[11], false);
                        DoublefloatE0M.AssertModel(models[10],_testData[12], false);
                        DoublefloatE0M.AssertModel(models[11],_testData[13], false);
                        DoublefloatE0M.AssertModel(models[12],_testData[14], false);
                        DoublefloatE0M.AssertModel(models[13],_testData[15], false);
                        DoublefloatE0M.AssertModel(models[14],_testData[16], false);
                        DoublefloatE0M.AssertModel(models[15],_testData[17], false);
                        DoublefloatE0M.AssertModel(models[16],_testData[18], false);
                        DoublefloatE0M.AssertModel(models[17],_testData[19], false);
                        DoublefloatE0M.AssertModel(models[18],_testData[20], false);
                        DoublefloatE0M.AssertModel(models[19],_testData[21], false);
                        DoublefloatE0M.AssertModel(models[20],_testData[22], false);
                        DoublefloatE0M.AssertModel(models[21],_testData[23], false);
                        DoublefloatE0M.AssertModel(models[22],_testData[24], false);
                        DoublefloatE0M.AssertModel(models[23],_testData[25], false);
                        DoublefloatE0M.AssertModel(models[24],_testData[26], false);
                        DoublefloatE0M.AssertModel(models[25],_testData[27], false);
                        DoublefloatE0M.AssertModel(models[26],_testData[28], false);
                        DoublefloatE0M.AssertModel(models[27],_testData[29], false);
                        DoublefloatE0M.AssertModel(models[28],_testData[30], false);
                        DoublefloatE0M.AssertModel(models[29],_testData[31], false);
                        DoublefloatE0M.AssertModel(models[30],_testData[32], false);
                        DoublefloatE0M.AssertModel(models[31],_testData[33], false);
                        DoublefloatE0M.AssertModel(models[32],_testData[34], false);
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
                    DoublefloatE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelBatch(connection, 23, 95))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        DoublefloatE0M.AssertModel(models[0],_testData[6], false);
                        DoublefloatE0M.AssertModel(models[1],_testData[7], false);
                        DoublefloatE0M.AssertModel(models[2],_testData[8], false);
                        DoublefloatE0M.AssertModel(models[3],_testData[9], false);
                        DoublefloatE0M.AssertModel(models[4],_testData[10], false);
                        DoublefloatE0M.AssertModel(models[5],_testData[11], false);
                        DoublefloatE0M.AssertModel(models[6],_testData[12], false);
                        DoublefloatE0M.AssertModel(models[7],_testData[13], false);
                        DoublefloatE0M.AssertModel(models[8],_testData[14], false);
                        DoublefloatE0M.AssertModel(models[9],_testData[15], false);
                        DoublefloatE0M.AssertModel(models[10],_testData[16], false);
                        DoublefloatE0M.AssertModel(models[11],_testData[17], false);
                        DoublefloatE0M.AssertModel(models[12],_testData[18], false);
                        DoublefloatE0M.AssertModel(models[13],_testData[19], false);
                        DoublefloatE0M.AssertModel(models[14],_testData[20], false);
                        DoublefloatE0M.AssertModel(models[15],_testData[21], false);
                        DoublefloatE0M.AssertModel(models[16],_testData[22], false);
                        DoublefloatE0M.AssertModel(models[17],_testData[23], false);
                        DoublefloatE0M.AssertModel(models[18],_testData[24], false);
                        DoublefloatE0M.AssertModel(models[19],_testData[25], false);
                        DoublefloatE0M.AssertModel(models[20],_testData[26], false);
                        DoublefloatE0M.AssertModel(models[21],_testData[27], false);
                        DoublefloatE0M.AssertModel(models[22],_testData[28], false);
                        DoublefloatE0M.AssertModel(models[23],_testData[29], false);
                        DoublefloatE0M.AssertModel(models[24],_testData[30], false);
                        DoublefloatE0M.AssertModel(models[25],_testData[31], false);
                        DoublefloatE0M.AssertModel(models[26],_testData[32], false);
                        DoublefloatE0M.AssertModel(models[27],_testData[33], false);
                        DoublefloatE0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        DoublefloatE0M.AssertModel(models[0],_testData[19], false);
                        DoublefloatE0M.AssertModel(models[1],_testData[20], false);
                        DoublefloatE0M.AssertModel(models[2],_testData[21], false);
                        DoublefloatE0M.AssertModel(models[3],_testData[22], false);
                        DoublefloatE0M.AssertModel(models[4],_testData[23], false);
                        DoublefloatE0M.AssertModel(models[5],_testData[24], false);
                        DoublefloatE0M.AssertModel(models[6],_testData[25], false);
                        DoublefloatE0M.AssertModel(models[7],_testData[26], false);
                        DoublefloatE0M.AssertModel(models[8],_testData[27], false);
                        DoublefloatE0M.AssertModel(models[9],_testData[28], false);
                        DoublefloatE0M.AssertModel(models[10],_testData[29], false);
                        DoublefloatE0M.AssertModel(models[11],_testData[30], false);
                        DoublefloatE0M.AssertModel(models[12],_testData[31], false);
                        DoublefloatE0M.AssertModel(models[13],_testData[32], false);
                        DoublefloatE0M.AssertModel(models[14],_testData[33], false);
                        DoublefloatE0M.AssertModel(models[15],_testData[34], false);
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
                ((IDoubleSingleTypefloat)this).SetDbConnectionSelectModelParametrs(cmd, 126);
                var models = await ((IDoubleSingleTypefloat)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                DoublefloatE0M.AssertModel(models[0],_testData[24], false);
                DoublefloatE0M.AssertModel(models[1],_testData[25], false);
                DoublefloatE0M.AssertModel(models[2],_testData[26], false);
                DoublefloatE0M.AssertModel(models[3],_testData[27], false);
                DoublefloatE0M.AssertModel(models[4],_testData[28], false);
                DoublefloatE0M.AssertModel(models[5],_testData[29], false);
                DoublefloatE0M.AssertModel(models[6],_testData[30], false);
                DoublefloatE0M.AssertModel(models[7],_testData[31], false);
                DoublefloatE0M.AssertModel(models[8],_testData[32], false);
                DoublefloatE0M.AssertModel(models[9],_testData[33], false);
                DoublefloatE0M.AssertModel(models[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleSingleTypefloat)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleSingleTypefloat)this).SetDbConnectionSelectModelParametrs(cmd, 112);
                var models =  ((IDoubleSingleTypefloat)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                DoublefloatE0M.AssertModel(models[0],_testData[22], false);
                DoublefloatE0M.AssertModel(models[1],_testData[23], false);
                DoublefloatE0M.AssertModel(models[2],_testData[24], false);
                DoublefloatE0M.AssertModel(models[3],_testData[25], false);
                DoublefloatE0M.AssertModel(models[4],_testData[26], false);
                DoublefloatE0M.AssertModel(models[5],_testData[27], false);
                DoublefloatE0M.AssertModel(models[6],_testData[28], false);
                DoublefloatE0M.AssertModel(models[7],_testData[29], false);
                DoublefloatE0M.AssertModel(models[8],_testData[30], false);
                DoublefloatE0M.AssertModel(models[9],_testData[31], false);
                DoublefloatE0M.AssertModel(models[10],_testData[32], false);
                DoublefloatE0M.AssertModel(models[11],_testData[33], false);
                DoublefloatE0M.AssertModel(models[12],_testData[34], false);
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
FROM dbo.doublefloate0m m
LEFT JOIN dbo.doublefloate0mi mi ON mi.id = m.doublefloate0mi_id
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
                Assert.That((System.Double)model[1], Is.EqualTo((0.08654527464141304d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.20595592477316493d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9527577907059139d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.8272227603012803d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.32403926153961926d)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2532271173385354d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9167640135453751d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3059901473789405d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.02769580135924332d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.22270677699666297d)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.007730444016505578d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.45552409072539835d)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5824210591772058d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.07468991877393594d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.30465941773992633d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9690826617506224d)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.11659857606784085d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.23393967914440295d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3789967853034575d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.43057444895996144d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8190310341441059d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7569692128367882d)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.46271273313283123d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.23597932035390168d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5377505922026485d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8843752271054168d)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7912618295473426d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.29557310158368066d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.9219349574133581d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5194105153736532d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7496457620568765d)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7596439786522067d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3964760804386682d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5679643668342333d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7827793351658662d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6966822632269802d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8975977068589289d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2843943191146051d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8384684312886564d)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4770297151124794d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7890218572547528d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9046175810994408d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7721989545084988d)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.33564584232238315d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5281287230721375d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4823321586276089d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3141908092480211d)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6032833567243717d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.09645541310060335d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.8631554414832189d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7116732707148271d)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.13293498523486347d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2887210350831785d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8112795519085008d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8776462836187044d)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9526793603596655d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.2486911177612987d)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.18200173150027998d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4015987553506227d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.32256156720017204d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7021779714770666d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.49240734290709853d)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7916209792513227d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8872616231565653d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.017568615675436883d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9420040224248228d)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.524034783696693d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7771013810013737d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.058273610918810226d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.8715299643918638d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.10569821526029399d)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.07981690195143076d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.33126403616945976d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9512073206989338d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.6129879060199902d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8866224259536658d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.860026193502413d)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8692859844137129d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.23073112570488097d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.837677982399178d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9660966269757573d)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6234502263765435d)));//Value

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
                var models =  ((IDoubleSingleTypefloat)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.08654527464141304d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.20595592477316493d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9527577907059139d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.8272227603012803d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.32403926153961926d)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2532271173385354d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9167640135453751d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3059901473789405d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.02769580135924332d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.22270677699666297d)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.007730444016505578d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.45552409072539835d)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5824210591772058d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.07468991877393594d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.30465941773992633d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9690826617506224d)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.11659857606784085d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.23393967914440295d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3789967853034575d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.43057444895996144d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8190310341441059d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7569692128367882d)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.46271273313283123d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.23597932035390168d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5377505922026485d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8843752271054168d)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7912618295473426d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.29557310158368066d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.9219349574133581d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5194105153736532d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7496457620568765d)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7596439786522067d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3964760804386682d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5679643668342333d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7827793351658662d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6966822632269802d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8975977068589289d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2843943191146051d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8384684312886564d)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4770297151124794d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7890218572547528d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9046175810994408d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7721989545084988d)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.33564584232238315d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5281287230721375d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4823321586276089d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3141908092480211d)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6032833567243717d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.09645541310060335d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.8631554414832189d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7116732707148271d)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.13293498523486347d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2887210350831785d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8112795519085008d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8776462836187044d)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9526793603596655d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.2486911177612987d)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.18200173150027998d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4015987553506227d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.32256156720017204d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7021779714770666d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.49240734290709853d)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7916209792513227d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8872616231565653d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.017568615675436883d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9420040224248228d)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.524034783696693d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7771013810013737d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.058273610918810226d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.8715299643918638d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.10569821526029399d)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.07981690195143076d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.33126403616945976d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9512073206989338d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.6129879060199902d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8866224259536658d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.860026193502413d)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8692859844137129d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.23073112570488097d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.837677982399178d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9660966269757573d)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6234502263765435d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

