

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
    Id = 6,
    Value = 0.7360326822246214d,
    ModelInner = null,
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 12,
    Value = 0.487734533794529d,
    ModelInner = new DoublefloatE0MI
{
    Id = 6,
    Value = 0.611566330555157d,
    NullableValue = null,
},
    NullableValue = 0.2325261415787383d,
},
            new DoublefloatE0M
{
    Id = 21,
    Value = 0.3241250092640906d,
    ModelInner = null,
    NullableValue = 0.9547911922127427d,
},
            new DoublefloatE0M
{
    Id = 29,
    Value = 0.11647210955623588d,
    ModelInner = new DoublefloatE0MI
{
    Id = 8,
    Value = 0.958373657549579d,
    NullableValue = null,
},
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 33,
    Value = 0.14385290802141104d,
    ModelInner = null,
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 38,
    Value = 0.8108583276360963d,
    ModelInner = new DoublefloatE0MI
{
    Id = 15,
    Value = 0.4773180279181999d,
    NullableValue = 0.7672781389569467d,
},
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 41,
    Value = 0.33788544231850315d,
    ModelInner = null,
    NullableValue = 0.7831228812049955d,
},
            new DoublefloatE0M
{
    Id = 44,
    Value = 0.45377614799678345d,
    ModelInner = new DoublefloatE0MI
{
    Id = 24,
    Value = 0.25880704886091677d,
    NullableValue = 0.5938726197837149d,
},
    NullableValue = 0.8499332534509518d,
},
            new DoublefloatE0M
{
    Id = 47,
    Value = 0.3589616454668242d,
    ModelInner = null,
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 52,
    Value = 0.2528727553337573d,
    ModelInner = new DoublefloatE0MI
{
    Id = 30,
    Value = 0.7494609013741902d,
    NullableValue = null,
},
    NullableValue = 0.9421840804425071d,
},
            new DoublefloatE0M
{
    Id = 59,
    Value = 0.9376550999939167d,
    ModelInner = null,
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 64,
    Value = 0.8092900198960825d,
    ModelInner = new DoublefloatE0MI
{
    Id = 35,
    Value = 0.48292229412695153d,
    NullableValue = 0.7838247712843174d,
},
    NullableValue = 0.12475389639361578d,
},
            new DoublefloatE0M
{
    Id = 66,
    Value = 0.5105975962962278d,
    ModelInner = null,
    NullableValue = 0.8224480231671868d,
},
            new DoublefloatE0M
{
    Id = 73,
    Value = 0.07528942066755107d,
    ModelInner = new DoublefloatE0MI
{
    Id = 43,
    Value = 0.7641379423338641d,
    NullableValue = 0.6320876884705896d,
},
    NullableValue = 0.8161893717954003d,
},
            new DoublefloatE0M
{
    Id = 82,
    Value = 0.2983093026916458d,
    ModelInner = null,
    NullableValue = 0.8032240146773615d,
},
            new DoublefloatE0M
{
    Id = 89,
    Value = 0.6074058496828008d,
    ModelInner = new DoublefloatE0MI
{
    Id = 46,
    Value = 0.11589115765843438d,
    NullableValue = null,
},
    NullableValue = 0.7998890676367787d,
},
            new DoublefloatE0M
{
    Id = 93,
    Value = 0.47451849589754214d,
    ModelInner = null,
    NullableValue = 0.7238708445554864d,
},
            new DoublefloatE0M
{
    Id = 97,
    Value = 0.5598978038222516d,
    ModelInner = new DoublefloatE0MI
{
    Id = 53,
    Value = 0.374397293914734d,
    NullableValue = 0.10588752380993649d,
},
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 106,
    Value = 0.12242829046345749d,
    ModelInner = null,
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 107,
    Value = 0.9691363096248673d,
    ModelInner = new DoublefloatE0MI
{
    Id = 54,
    Value = 0.746575715927375d,
    NullableValue = null,
},
    NullableValue = 0.5962947305322698d,
},
            new DoublefloatE0M
{
    Id = 114,
    Value = 0.6492999282322635d,
    ModelInner = null,
    NullableValue = 0.039467963528479144d,
},
            new DoublefloatE0M
{
    Id = 120,
    Value = 0.042070858532650135d,
    ModelInner = new DoublefloatE0MI
{
    Id = 56,
    Value = 0.35620262789605117d,
    NullableValue = 0.9555838978117892d,
},
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 123,
    Value = 0.1802268437597715d,
    ModelInner = null,
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 131,
    Value = 0.8195735750109142d,
    ModelInner = new DoublefloatE0MI
{
    Id = 64,
    Value = 0.7218716261442045d,
    NullableValue = 0.024333657392412333d,
},
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 139,
    Value = 0.7936352148095169d,
    ModelInner = null,
    NullableValue = 0.47053239543368486d,
},
            new DoublefloatE0M
{
    Id = 140,
    Value = 0.29160940106479527d,
    ModelInner = new DoublefloatE0MI
{
    Id = 69,
    Value = 0.8800630501787424d,
    NullableValue = 0.13090199354895116d,
},
    NullableValue = 0.23552776859177205d,
},
            new DoublefloatE0M
{
    Id = 145,
    Value = 0.8307839409636883d,
    ModelInner = null,
    NullableValue = 0.5649073732133624d,
},
            new DoublefloatE0M
{
    Id = 154,
    Value = 0.07597918829870443d,
    ModelInner = new DoublefloatE0MI
{
    Id = 73,
    Value = 0.8556012440300871d,
    NullableValue = null,
},
    NullableValue = 0.2020370465113368d,
},
            new DoublefloatE0M
{
    Id = 160,
    Value = 0.4347216043312485d,
    ModelInner = null,
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 163,
    Value = 0.9673473671943278d,
    ModelInner = new DoublefloatE0MI
{
    Id = 74,
    Value = 0.8345981937536205d,
    NullableValue = null,
},
    NullableValue = 0.20354746873960505d,
},
            new DoublefloatE0M
{
    Id = 171,
    Value = 0.1398867911749463d,
    ModelInner = null,
    NullableValue = 0.31253183097733916d,
},
            new DoublefloatE0M
{
    Id = 177,
    Value = 0.10847623367995252d,
    ModelInner = new DoublefloatE0MI
{
    Id = 80,
    Value = 0.9195471853857003d,
    NullableValue = null,
},
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 179,
    Value = 0.334205610978647d,
    ModelInner = null,
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 185,
    Value = 0.9043658639639672d,
    ModelInner = new DoublefloatE0MI
{
    Id = 81,
    Value = 0.4107921675632187d,
    NullableValue = null,
},
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 187,
    Value = 0.2378912577376644d,
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[22],_testData[34], false);
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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 163;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[24],_testData[34], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
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
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatDoublefloatE0M.AssertModel(models[0],_testData[1], false);
                        FlatDoublefloatE0M.AssertModel(models[1],_testData[2], false);
                        FlatDoublefloatE0M.AssertModel(models[2],_testData[3], false);
                        FlatDoublefloatE0M.AssertModel(models[3],_testData[4], false);
                        FlatDoublefloatE0M.AssertModel(models[4],_testData[5], false);
                        FlatDoublefloatE0M.AssertModel(models[5],_testData[6], false);
                        FlatDoublefloatE0M.AssertModel(models[6],_testData[7], false);
                        FlatDoublefloatE0M.AssertModel(models[7],_testData[8], false);
                        FlatDoublefloatE0M.AssertModel(models[8],_testData[9], false);
                        FlatDoublefloatE0M.AssertModel(models[9],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(models[10],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(models[11],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(models[12],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(models[13],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(models[14],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(models[15],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(models[16],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(models[17],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(models[18],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(models[19],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(models[20],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(models[21],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(models[22],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(models[23],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(models[24],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(models[25],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(models[26],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(models[27],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(models[28],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(models[29],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(models[30],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(models[31],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(models[32],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDoublefloatE0M.AssertModel(models[0],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(models[1],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(models[2],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(models[3],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(models[4],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(models[5],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(models[6],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(models[7],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(models[8],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(models[9],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(models[10],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(models[11],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(models[12],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(models[13],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(models[14],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(models[15],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(models[16],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 33;
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
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[11],_testData[34], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 163;
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

                    if(resultIndex == 2)
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[19],_testData[34], false);
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
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        DoublefloatE0M.AssertModel(models[0],_testData[29], false);
                        DoublefloatE0M.AssertModel(models[1],_testData[30], false);
                        DoublefloatE0M.AssertModel(models[2],_testData[31], false);
                        DoublefloatE0M.AssertModel(models[3],_testData[32], false);
                        DoublefloatE0M.AssertModel(models[4],_testData[33], false);
                        DoublefloatE0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        DoublefloatE0M.AssertModel(models[0],_testData[1], false);
                        DoublefloatE0M.AssertModel(models[1],_testData[2], false);
                        DoublefloatE0M.AssertModel(models[2],_testData[3], false);
                        DoublefloatE0M.AssertModel(models[3],_testData[4], false);
                        DoublefloatE0M.AssertModel(models[4],_testData[5], false);
                        DoublefloatE0M.AssertModel(models[5],_testData[6], false);
                        DoublefloatE0M.AssertModel(models[6],_testData[7], false);
                        DoublefloatE0M.AssertModel(models[7],_testData[8], false);
                        DoublefloatE0M.AssertModel(models[8],_testData[9], false);
                        DoublefloatE0M.AssertModel(models[9],_testData[10], false);
                        DoublefloatE0M.AssertModel(models[10],_testData[11], false);
                        DoublefloatE0M.AssertModel(models[11],_testData[12], false);
                        DoublefloatE0M.AssertModel(models[12],_testData[13], false);
                        DoublefloatE0M.AssertModel(models[13],_testData[14], false);
                        DoublefloatE0M.AssertModel(models[14],_testData[15], false);
                        DoublefloatE0M.AssertModel(models[15],_testData[16], false);
                        DoublefloatE0M.AssertModel(models[16],_testData[17], false);
                        DoublefloatE0M.AssertModel(models[17],_testData[18], false);
                        DoublefloatE0M.AssertModel(models[18],_testData[19], false);
                        DoublefloatE0M.AssertModel(models[19],_testData[20], false);
                        DoublefloatE0M.AssertModel(models[20],_testData[21], false);
                        DoublefloatE0M.AssertModel(models[21],_testData[22], false);
                        DoublefloatE0M.AssertModel(models[22],_testData[23], false);
                        DoublefloatE0M.AssertModel(models[23],_testData[24], false);
                        DoublefloatE0M.AssertModel(models[24],_testData[25], false);
                        DoublefloatE0M.AssertModel(models[25],_testData[26], false);
                        DoublefloatE0M.AssertModel(models[26],_testData[27], false);
                        DoublefloatE0M.AssertModel(models[27],_testData[28], false);
                        DoublefloatE0M.AssertModel(models[28],_testData[29], false);
                        DoublefloatE0M.AssertModel(models[29],_testData[30], false);
                        DoublefloatE0M.AssertModel(models[30],_testData[31], false);
                        DoublefloatE0M.AssertModel(models[31],_testData[32], false);
                        DoublefloatE0M.AssertModel(models[32],_testData[33], false);
                        DoublefloatE0M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        DoublefloatE0M.AssertModel(models[0],_testData[3], false);
                        DoublefloatE0M.AssertModel(models[1],_testData[4], false);
                        DoublefloatE0M.AssertModel(models[2],_testData[5], false);
                        DoublefloatE0M.AssertModel(models[3],_testData[6], false);
                        DoublefloatE0M.AssertModel(models[4],_testData[7], false);
                        DoublefloatE0M.AssertModel(models[5],_testData[8], false);
                        DoublefloatE0M.AssertModel(models[6],_testData[9], false);
                        DoublefloatE0M.AssertModel(models[7],_testData[10], false);
                        DoublefloatE0M.AssertModel(models[8],_testData[11], false);
                        DoublefloatE0M.AssertModel(models[9],_testData[12], false);
                        DoublefloatE0M.AssertModel(models[10],_testData[13], false);
                        DoublefloatE0M.AssertModel(models[11],_testData[14], false);
                        DoublefloatE0M.AssertModel(models[12],_testData[15], false);
                        DoublefloatE0M.AssertModel(models[13],_testData[16], false);
                        DoublefloatE0M.AssertModel(models[14],_testData[17], false);
                        DoublefloatE0M.AssertModel(models[15],_testData[18], false);
                        DoublefloatE0M.AssertModel(models[16],_testData[19], false);
                        DoublefloatE0M.AssertModel(models[17],_testData[20], false);
                        DoublefloatE0M.AssertModel(models[18],_testData[21], false);
                        DoublefloatE0M.AssertModel(models[19],_testData[22], false);
                        DoublefloatE0M.AssertModel(models[20],_testData[23], false);
                        DoublefloatE0M.AssertModel(models[21],_testData[24], false);
                        DoublefloatE0M.AssertModel(models[22],_testData[25], false);
                        DoublefloatE0M.AssertModel(models[23],_testData[26], false);
                        DoublefloatE0M.AssertModel(models[24],_testData[27], false);
                        DoublefloatE0M.AssertModel(models[25],_testData[28], false);
                        DoublefloatE0M.AssertModel(models[26],_testData[29], false);
                        DoublefloatE0M.AssertModel(models[27],_testData[30], false);
                        DoublefloatE0M.AssertModel(models[28],_testData[31], false);
                        DoublefloatE0M.AssertModel(models[29],_testData[32], false);
                        DoublefloatE0M.AssertModel(models[30],_testData[33], false);
                        DoublefloatE0M.AssertModel(models[31],_testData[34], false);
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
                await ((IDoubleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 44, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[27],_testData[34], false);
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
                await ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 89, query1, 139, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[9],_testData[34], false);
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
                 ((IDoubleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 139, query1, 106, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[15],_testData[34], false);
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
                 ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelBatch(connection, 107, query1, 139, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[9],_testData[34], false);
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
                foreach(var batchResult in await ((IDoubleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 177, query1, 33, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatDoublefloatE0M.AssertModel(models[0],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(models[1],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatDoublefloatE0M.AssertModel(models[0],_testData[5], false);
                        FlatDoublefloatE0M.AssertModel(models[1],_testData[6], false);
                        FlatDoublefloatE0M.AssertModel(models[2],_testData[7], false);
                        FlatDoublefloatE0M.AssertModel(models[3],_testData[8], false);
                        FlatDoublefloatE0M.AssertModel(models[4],_testData[9], false);
                        FlatDoublefloatE0M.AssertModel(models[5],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(models[6],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(models[7],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(models[8],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(models[9],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(models[10],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(models[11],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(models[12],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(models[13],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(models[14],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(models[15],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(models[16],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(models[17],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(models[18],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(models[19],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(models[20],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(models[21],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(models[22],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(models[23],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(models[24],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(models[25],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(models[26],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(models[27],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(models[28],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(models[29],_testData[34], false);
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
                await ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 123, query1, 177, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[11],_testData[34], false);
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
                foreach(var batchResult in  ((IDoubleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelBatch(connection, 179, query1, 41, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDoublefloatE0M.AssertModel(models[0],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatDoublefloatE0M.AssertModel(models[0],_testData[7], false);
                        FlatDoublefloatE0M.AssertModel(models[1],_testData[8], false);
                        FlatDoublefloatE0M.AssertModel(models[2],_testData[9], false);
                        FlatDoublefloatE0M.AssertModel(models[3],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(models[4],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(models[5],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(models[6],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(models[7],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(models[8],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(models[9],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(models[10],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(models[11],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(models[12],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(models[13],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(models[14],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(models[15],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(models[16],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(models[17],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(models[18],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(models[19],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(models[20],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(models[21],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(models[22],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(models[23],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(models[24],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(models[25],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(models[26],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(models[27],_testData[34], false);
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
                 ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelBatch(connection, 52, query1, 123, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[11],_testData[34], false);
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
                foreach(var batchResult in await ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelBatchAsync(connection, 154, 73))
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
                        Assert.That(models, Has.Count.EqualTo(21));

                        DoublefloatE0M.AssertModel(models[0],_testData[14], false);
                        DoublefloatE0M.AssertModel(models[1],_testData[15], false);
                        DoublefloatE0M.AssertModel(models[2],_testData[16], false);
                        DoublefloatE0M.AssertModel(models[3],_testData[17], false);
                        DoublefloatE0M.AssertModel(models[4],_testData[18], false);
                        DoublefloatE0M.AssertModel(models[5],_testData[19], false);
                        DoublefloatE0M.AssertModel(models[6],_testData[20], false);
                        DoublefloatE0M.AssertModel(models[7],_testData[21], false);
                        DoublefloatE0M.AssertModel(models[8],_testData[22], false);
                        DoublefloatE0M.AssertModel(models[9],_testData[23], false);
                        DoublefloatE0M.AssertModel(models[10],_testData[24], false);
                        DoublefloatE0M.AssertModel(models[11],_testData[25], false);
                        DoublefloatE0M.AssertModel(models[12],_testData[26], false);
                        DoublefloatE0M.AssertModel(models[13],_testData[27], false);
                        DoublefloatE0M.AssertModel(models[14],_testData[28], false);
                        DoublefloatE0M.AssertModel(models[15],_testData[29], false);
                        DoublefloatE0M.AssertModel(models[16],_testData[30], false);
                        DoublefloatE0M.AssertModel(models[17],_testData[31], false);
                        DoublefloatE0M.AssertModel(models[18],_testData[32], false);
                        DoublefloatE0M.AssertModel(models[19],_testData[33], false);
                        DoublefloatE0M.AssertModel(models[20],_testData[34], false);
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
                foreach(var batchResult in  ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelBatch(connection, 33, 123))
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        DoublefloatE0M.AssertModel(models[0],_testData[23], false);
                        DoublefloatE0M.AssertModel(models[1],_testData[24], false);
                        DoublefloatE0M.AssertModel(models[2],_testData[25], false);
                        DoublefloatE0M.AssertModel(models[3],_testData[26], false);
                        DoublefloatE0M.AssertModel(models[4],_testData[27], false);
                        DoublefloatE0M.AssertModel(models[5],_testData[28], false);
                        DoublefloatE0M.AssertModel(models[6],_testData[29], false);
                        DoublefloatE0M.AssertModel(models[7],_testData[30], false);
                        DoublefloatE0M.AssertModel(models[8],_testData[31], false);
                        DoublefloatE0M.AssertModel(models[9],_testData[32], false);
                        DoublefloatE0M.AssertModel(models[10],_testData[33], false);
                        DoublefloatE0M.AssertModel(models[11],_testData[34], false);
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
                ((IDoubleSingleTypefloat)this).SetDbConnectionSelectModelParametrs(cmd, 73);
                var models = await ((IDoubleSingleTypefloat)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                DoublefloatE0M.AssertModel(models[0],_testData[14], false);
                DoublefloatE0M.AssertModel(models[1],_testData[15], false);
                DoublefloatE0M.AssertModel(models[2],_testData[16], false);
                DoublefloatE0M.AssertModel(models[3],_testData[17], false);
                DoublefloatE0M.AssertModel(models[4],_testData[18], false);
                DoublefloatE0M.AssertModel(models[5],_testData[19], false);
                DoublefloatE0M.AssertModel(models[6],_testData[20], false);
                DoublefloatE0M.AssertModel(models[7],_testData[21], false);
                DoublefloatE0M.AssertModel(models[8],_testData[22], false);
                DoublefloatE0M.AssertModel(models[9],_testData[23], false);
                DoublefloatE0M.AssertModel(models[10],_testData[24], false);
                DoublefloatE0M.AssertModel(models[11],_testData[25], false);
                DoublefloatE0M.AssertModel(models[12],_testData[26], false);
                DoublefloatE0M.AssertModel(models[13],_testData[27], false);
                DoublefloatE0M.AssertModel(models[14],_testData[28], false);
                DoublefloatE0M.AssertModel(models[15],_testData[29], false);
                DoublefloatE0M.AssertModel(models[16],_testData[30], false);
                DoublefloatE0M.AssertModel(models[17],_testData[31], false);
                DoublefloatE0M.AssertModel(models[18],_testData[32], false);
                DoublefloatE0M.AssertModel(models[19],_testData[33], false);
                DoublefloatE0M.AssertModel(models[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleSingleTypefloat)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleSingleTypefloat)this).SetDbConnectionSelectModelParametrs(cmd, 120);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7360326822246214d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.487734533794529d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.611566330555157d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.2325261415787383d)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3241250092640906d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9547911922127427d)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.11647210955623588d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.958373657549579d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.14385290802141104d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8108583276360963d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4773180279181999d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7672781389569467d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.33788544231850315d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7831228812049955d)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.45377614799678345d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.25880704886091677d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.5938726197837149d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8499332534509518d)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3589616454668242d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2528727553337573d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7494609013741902d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9421840804425071d)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9376550999939167d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8092900198960825d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.48292229412695153d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7838247712843174d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.12475389639361578d)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5105975962962278d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8224480231671868d)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.07528942066755107d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7641379423338641d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.6320876884705896d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8161893717954003d)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2983093026916458d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8032240146773615d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6074058496828008d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.11589115765843438d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7998890676367787d)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.47451849589754214d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7238708445554864d)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5598978038222516d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.374397293914734d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.10588752380993649d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.12242829046345749d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9691363096248673d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.746575715927375d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5962947305322698d)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6492999282322635d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.039467963528479144d)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.042070858532650135d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.35620262789605117d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.9555838978117892d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.1802268437597715d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8195735750109142d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7218716261442045d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.024333657392412333d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7936352148095169d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.47053239543368486d)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.29160940106479527d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8800630501787424d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.13090199354895116d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.23552776859177205d)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8307839409636883d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5649073732133624d)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.07597918829870443d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8556012440300871d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.2020370465113368d)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4347216043312485d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9673473671943278d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8345981937536205d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.20354746873960505d)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.1398867911749463d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.31253183097733916d)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.10847623367995252d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9195471853857003d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.334205610978647d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((185)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9043658639639672d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4107921675632187d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((187)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2378912577376644d)));//Value

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
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7360326822246214d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.487734533794529d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.611566330555157d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.2325261415787383d)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3241250092640906d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9547911922127427d)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.11647210955623588d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.958373657549579d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.14385290802141104d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8108583276360963d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4773180279181999d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7672781389569467d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.33788544231850315d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7831228812049955d)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.45377614799678345d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.25880704886091677d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.5938726197837149d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8499332534509518d)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3589616454668242d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2528727553337573d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7494609013741902d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9421840804425071d)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9376550999939167d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8092900198960825d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.48292229412695153d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7838247712843174d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.12475389639361578d)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5105975962962278d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8224480231671868d)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.07528942066755107d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7641379423338641d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.6320876884705896d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8161893717954003d)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2983093026916458d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8032240146773615d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6074058496828008d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.11589115765843438d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7998890676367787d)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.47451849589754214d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7238708445554864d)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5598978038222516d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.374397293914734d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.10588752380993649d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.12242829046345749d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9691363096248673d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.746575715927375d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5962947305322698d)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6492999282322635d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.039467963528479144d)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.042070858532650135d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.35620262789605117d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.9555838978117892d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.1802268437597715d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8195735750109142d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7218716261442045d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.024333657392412333d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7936352148095169d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.47053239543368486d)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.29160940106479527d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8800630501787424d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.13090199354895116d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.23552776859177205d)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8307839409636883d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5649073732133624d)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.07597918829870443d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8556012440300871d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.2020370465113368d)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4347216043312485d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9673473671943278d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8345981937536205d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.20354746873960505d)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.1398867911749463d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.31253183097733916d)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.10847623367995252d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9195471853857003d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.334205610978647d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((185)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9043658639639672d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4107921675632187d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((187)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2378912577376644d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

