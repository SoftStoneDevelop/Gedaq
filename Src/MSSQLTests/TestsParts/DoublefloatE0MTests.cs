

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
    Id = 9,
    Value = 0.7955696369298852d,
    ModelInner = null,
    NullableValue = 0.04294807809084322d,
},
            new DoublefloatE0M
{
    Id = 13,
    Value = 0.17965533853058258d,
    ModelInner = new DoublefloatE0MI
{
    Id = 3,
    Value = 0.7675066026950557d,
    NullableValue = 0.0192621032800373d,
},
    NullableValue = 0.32624711725980426d,
},
            new DoublefloatE0M
{
    Id = 17,
    Value = 0.680322971354499d,
    ModelInner = null,
    NullableValue = 0.9146816301079538d,
},
            new DoublefloatE0M
{
    Id = 24,
    Value = 0.6751994496658122d,
    ModelInner = new DoublefloatE0MI
{
    Id = 10,
    Value = 0.4719459934814716d,
    NullableValue = 0.15960353297044982d,
},
    NullableValue = 0.3802262243630493d,
},
            new DoublefloatE0M
{
    Id = 32,
    Value = 0.15815316627094234d,
    ModelInner = null,
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 34,
    Value = 0.7426369222016302d,
    ModelInner = new DoublefloatE0MI
{
    Id = 13,
    Value = 0.5542258264090845d,
    NullableValue = null,
},
    NullableValue = 0.22530246399097953d,
},
            new DoublefloatE0M
{
    Id = 38,
    Value = 0.7402440826743512d,
    ModelInner = null,
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 47,
    Value = 0.5400957666002771d,
    ModelInner = new DoublefloatE0MI
{
    Id = 20,
    Value = 0.035215923457613485d,
    NullableValue = 0.9384995943077363d,
},
    NullableValue = 0.39304519714834296d,
},
            new DoublefloatE0M
{
    Id = 55,
    Value = 0.6184982681063492d,
    ModelInner = null,
    NullableValue = 0.005547358116870904d,
},
            new DoublefloatE0M
{
    Id = 57,
    Value = 0.670025279678871d,
    ModelInner = new DoublefloatE0MI
{
    Id = 22,
    Value = 0.9811759596992109d,
    NullableValue = 0.34425973791612063d,
},
    NullableValue = 0.8295038725626892d,
},
            new DoublefloatE0M
{
    Id = 59,
    Value = 0.7128409346872652d,
    ModelInner = null,
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 68,
    Value = 0.1690853187940401d,
    ModelInner = new DoublefloatE0MI
{
    Id = 27,
    Value = 0.33644289203269984d,
    NullableValue = null,
},
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 76,
    Value = 0.5064661010054698d,
    ModelInner = null,
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 79,
    Value = 0.08926258736882864d,
    ModelInner = new DoublefloatE0MI
{
    Id = 32,
    Value = 0.9660686762746973d,
    NullableValue = 0.058618912979671034d,
},
    NullableValue = 0.4871779194077228d,
},
            new DoublefloatE0M
{
    Id = 81,
    Value = 0.5733680808260481d,
    ModelInner = null,
    NullableValue = 0.8682468419069032d,
},
            new DoublefloatE0M
{
    Id = 82,
    Value = 0.7489219982823887d,
    ModelInner = new DoublefloatE0MI
{
    Id = 39,
    Value = 0.6764747910812743d,
    NullableValue = 0.31256878560689794d,
},
    NullableValue = 0.8243991007598489d,
},
            new DoublefloatE0M
{
    Id = 84,
    Value = 0.886641274468366d,
    ModelInner = null,
    NullableValue = 0.42731670267153d,
},
            new DoublefloatE0M
{
    Id = 89,
    Value = 0.17307853237375315d,
    ModelInner = new DoublefloatE0MI
{
    Id = 40,
    Value = 0.3742462438721107d,
    NullableValue = 0.37398622181530883d,
},
    NullableValue = 0.6733843987827399d,
},
            new DoublefloatE0M
{
    Id = 92,
    Value = 0.8585097666545968d,
    ModelInner = null,
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 95,
    Value = 0.5140394580498386d,
    ModelInner = new DoublefloatE0MI
{
    Id = 42,
    Value = 0.2133385304601071d,
    NullableValue = 0.265392294942256d,
},
    NullableValue = 0.7180049727076319d,
},
            new DoublefloatE0M
{
    Id = 100,
    Value = 0.9069909725014202d,
    ModelInner = null,
    NullableValue = 0.13156080638054368d,
},
            new DoublefloatE0M
{
    Id = 101,
    Value = 0.05929746407999281d,
    ModelInner = new DoublefloatE0MI
{
    Id = 48,
    Value = 0.745876979798983d,
    NullableValue = 0.6066274270816725d,
},
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 102,
    Value = 0.7532393411347746d,
    ModelInner = null,
    NullableValue = 0.23148653459204027d,
},
            new DoublefloatE0M
{
    Id = 105,
    Value = 0.36627416050644457d,
    ModelInner = new DoublefloatE0MI
{
    Id = 57,
    Value = 0.9726475798450294d,
    NullableValue = 0.3932978890142439d,
},
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 107,
    Value = 0.3031388382815805d,
    ModelInner = null,
    NullableValue = 0.33707093322528203d,
},
            new DoublefloatE0M
{
    Id = 115,
    Value = 0.8202595104477076d,
    ModelInner = new DoublefloatE0MI
{
    Id = 61,
    Value = 0.12093705036449398d,
    NullableValue = 0.21870822299016957d,
},
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 120,
    Value = 0.19317950867706457d,
    ModelInner = null,
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 129,
    Value = 0.20433864123334922d,
    ModelInner = new DoublefloatE0MI
{
    Id = 67,
    Value = 0.3439375748024246d,
    NullableValue = 0.6236037406802062d,
},
    NullableValue = 0.41362796474998187d,
},
            new DoublefloatE0M
{
    Id = 135,
    Value = 0.4327713951220482d,
    ModelInner = null,
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 136,
    Value = 0.7017061582480816d,
    ModelInner = new DoublefloatE0MI
{
    Id = 72,
    Value = 0.5724159172129106d,
    NullableValue = null,
},
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 139,
    Value = 0.76315420486481d,
    ModelInner = null,
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 148,
    Value = 0.9601001480357906d,
    ModelInner = new DoublefloatE0MI
{
    Id = 75,
    Value = 0.5141718528670015d,
    NullableValue = 0.6927703382914394d,
},
    NullableValue = 0.35098054376184484d,
},
            new DoublefloatE0M
{
    Id = 153,
    Value = 0.1446749416202433d,
    ModelInner = null,
    NullableValue = 0.47597718926727983d,
},
            new DoublefloatE0M
{
    Id = 155,
    Value = 0.028994999638270236d,
    ModelInner = new DoublefloatE0MI
{
    Id = 77,
    Value = 0.9063659139108964d,
    NullableValue = null,
},
    NullableValue = null,
},
            new DoublefloatE0M
{
    Id = 157,
    Value = 0.7471531211032252d,
    ModelInner = null,
    NullableValue = 0.1883734208419946d,
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
                parametr1.Value = 115;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[28],_testData[34], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(firstItems2[28],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
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
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[18],_testData[34], false);
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
                parametr1.Value = 89;
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
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatDoublefloatE0M.AssertModel(models[0],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(models[1],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(models[2],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(models[3],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(models[4],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(models[5],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(models[6],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(models[7],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(models[8],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(models[9],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(models[10],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(models[11],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(models[12],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(models[13],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(models[14],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(models[15],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatDoublefloatE0M.AssertModel(models[0],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(models[1],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(models[2],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(models[3],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(models[4],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(models[5],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(models[6],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(models[7],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(models[8],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(models[9],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(models[10],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(models[11],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(models[12],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(models[13],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(models[14],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(models[15],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[31],_testData[34], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
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
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatDoublefloatE0M.AssertModel(models[0],_testData[2], false);
                        FlatDoublefloatE0M.AssertModel(models[1],_testData[3], false);
                        FlatDoublefloatE0M.AssertModel(models[2],_testData[4], false);
                        FlatDoublefloatE0M.AssertModel(models[3],_testData[5], false);
                        FlatDoublefloatE0M.AssertModel(models[4],_testData[6], false);
                        FlatDoublefloatE0M.AssertModel(models[5],_testData[7], false);
                        FlatDoublefloatE0M.AssertModel(models[6],_testData[8], false);
                        FlatDoublefloatE0M.AssertModel(models[7],_testData[9], false);
                        FlatDoublefloatE0M.AssertModel(models[8],_testData[10], false);
                        FlatDoublefloatE0M.AssertModel(models[9],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(models[10],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(models[11],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(models[12],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(models[13],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(models[14],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(models[15],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(models[16],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(models[17],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(models[18],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(models[19],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(models[20],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(models[21],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(models[22],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(models[23],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(models[24],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(models[25],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(models[26],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(models[27],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(models[28],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(models[29],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(models[30],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(models[31],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatDoublefloatE0M.AssertModel(models[0],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(models[1],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(models[2],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(models[3],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(models[4],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(models[5],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(models[6],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(models[7],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 92;
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
                 ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[21],_testData[34], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        DoublefloatE0M.AssertModel(models[0],_testData[18], false);
                        DoublefloatE0M.AssertModel(models[1],_testData[19], false);
                        DoublefloatE0M.AssertModel(models[2],_testData[20], false);
                        DoublefloatE0M.AssertModel(models[3],_testData[21], false);
                        DoublefloatE0M.AssertModel(models[4],_testData[22], false);
                        DoublefloatE0M.AssertModel(models[5],_testData[23], false);
                        DoublefloatE0M.AssertModel(models[6],_testData[24], false);
                        DoublefloatE0M.AssertModel(models[7],_testData[25], false);
                        DoublefloatE0M.AssertModel(models[8],_testData[26], false);
                        DoublefloatE0M.AssertModel(models[9],_testData[27], false);
                        DoublefloatE0M.AssertModel(models[10],_testData[28], false);
                        DoublefloatE0M.AssertModel(models[11],_testData[29], false);
                        DoublefloatE0M.AssertModel(models[12],_testData[30], false);
                        DoublefloatE0M.AssertModel(models[13],_testData[31], false);
                        DoublefloatE0M.AssertModel(models[14],_testData[32], false);
                        DoublefloatE0M.AssertModel(models[15],_testData[33], false);
                        DoublefloatE0M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        DoublefloatE0M.AssertModel(models[0],_testData[25], false);
                        DoublefloatE0M.AssertModel(models[1],_testData[26], false);
                        DoublefloatE0M.AssertModel(models[2],_testData[27], false);
                        DoublefloatE0M.AssertModel(models[3],_testData[28], false);
                        DoublefloatE0M.AssertModel(models[4],_testData[29], false);
                        DoublefloatE0M.AssertModel(models[5],_testData[30], false);
                        DoublefloatE0M.AssertModel(models[6],_testData[31], false);
                        DoublefloatE0M.AssertModel(models[7],_testData[32], false);
                        DoublefloatE0M.AssertModel(models[8],_testData[33], false);
                        DoublefloatE0M.AssertModel(models[9],_testData[34], false);
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
                await ((IDoubleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 102, query1, 84, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                await ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 95, query1, 105, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[10],_testData[34], false);
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
                 ((IDoubleSingleTypefloat)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 76, query1, 68, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[22],_testData[34], false);
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
                 ((IDoubleSingleTypefloat)this).DbConnectionMMDynQuerySelectModelBatch(connection, 38, query1, 79, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[20],_testData[34], false);
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
                foreach(var batchResult in await ((IDoubleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 17, query1, 102, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatDoublefloatE0M.AssertModel(models[0],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(models[1],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(models[2],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(models[3],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(models[4],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(models[5],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(models[6],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(models[7],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(models[8],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(models[9],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(models[10],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(models[11],_testData[34], false);
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
                await ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 120, query1, 139, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[3],_testData[34], false);
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
                foreach(var batchResult in  ((IDoubleSingleTypefloat)this).DbConnectionSTDynQuerySelectModelBatch(connection, 139, query1, 100, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDoublefloatE0M.AssertModel(models[0],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(models[1],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(models[2],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatDoublefloatE0M.AssertModel(models[0],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(models[1],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(models[2],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(models[3],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(models[4],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(models[5],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(models[6],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(models[7],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(models[8],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(models[9],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(models[10],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(models[11],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(models[12],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(models[13],_testData[34], false);
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
                 ((IDoubleSingleTypefloat)this).DbConnectionDynQuerySelectModelBatch(connection, 59, query1, 59, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatDoublefloatE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatDoublefloatE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatDoublefloatE0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatDoublefloatE0M.AssertModel(secondItems2[23],_testData[34], false);
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
                foreach(var batchResult in await ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelBatchAsync(connection, 148, 24))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        DoublefloatE0M.AssertModel(models[0],_testData[32], false);
                        DoublefloatE0M.AssertModel(models[1],_testData[33], false);
                        DoublefloatE0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        DoublefloatE0M.AssertModel(models[0],_testData[4], false);
                        DoublefloatE0M.AssertModel(models[1],_testData[5], false);
                        DoublefloatE0M.AssertModel(models[2],_testData[6], false);
                        DoublefloatE0M.AssertModel(models[3],_testData[7], false);
                        DoublefloatE0M.AssertModel(models[4],_testData[8], false);
                        DoublefloatE0M.AssertModel(models[5],_testData[9], false);
                        DoublefloatE0M.AssertModel(models[6],_testData[10], false);
                        DoublefloatE0M.AssertModel(models[7],_testData[11], false);
                        DoublefloatE0M.AssertModel(models[8],_testData[12], false);
                        DoublefloatE0M.AssertModel(models[9],_testData[13], false);
                        DoublefloatE0M.AssertModel(models[10],_testData[14], false);
                        DoublefloatE0M.AssertModel(models[11],_testData[15], false);
                        DoublefloatE0M.AssertModel(models[12],_testData[16], false);
                        DoublefloatE0M.AssertModel(models[13],_testData[17], false);
                        DoublefloatE0M.AssertModel(models[14],_testData[18], false);
                        DoublefloatE0M.AssertModel(models[15],_testData[19], false);
                        DoublefloatE0M.AssertModel(models[16],_testData[20], false);
                        DoublefloatE0M.AssertModel(models[17],_testData[21], false);
                        DoublefloatE0M.AssertModel(models[18],_testData[22], false);
                        DoublefloatE0M.AssertModel(models[19],_testData[23], false);
                        DoublefloatE0M.AssertModel(models[20],_testData[24], false);
                        DoublefloatE0M.AssertModel(models[21],_testData[25], false);
                        DoublefloatE0M.AssertModel(models[22],_testData[26], false);
                        DoublefloatE0M.AssertModel(models[23],_testData[27], false);
                        DoublefloatE0M.AssertModel(models[24],_testData[28], false);
                        DoublefloatE0M.AssertModel(models[25],_testData[29], false);
                        DoublefloatE0M.AssertModel(models[26],_testData[30], false);
                        DoublefloatE0M.AssertModel(models[27],_testData[31], false);
                        DoublefloatE0M.AssertModel(models[28],_testData[32], false);
                        DoublefloatE0M.AssertModel(models[29],_testData[33], false);
                        DoublefloatE0M.AssertModel(models[30],_testData[34], false);
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
                foreach(var batchResult in  ((IDoubleSingleTypefloat)this).DbConnectionSTSelectModelBatch(connection, 76, 115))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        DoublefloatE0M.AssertModel(models[0],_testData[13], false);
                        DoublefloatE0M.AssertModel(models[1],_testData[14], false);
                        DoublefloatE0M.AssertModel(models[2],_testData[15], false);
                        DoublefloatE0M.AssertModel(models[3],_testData[16], false);
                        DoublefloatE0M.AssertModel(models[4],_testData[17], false);
                        DoublefloatE0M.AssertModel(models[5],_testData[18], false);
                        DoublefloatE0M.AssertModel(models[6],_testData[19], false);
                        DoublefloatE0M.AssertModel(models[7],_testData[20], false);
                        DoublefloatE0M.AssertModel(models[8],_testData[21], false);
                        DoublefloatE0M.AssertModel(models[9],_testData[22], false);
                        DoublefloatE0M.AssertModel(models[10],_testData[23], false);
                        DoublefloatE0M.AssertModel(models[11],_testData[24], false);
                        DoublefloatE0M.AssertModel(models[12],_testData[25], false);
                        DoublefloatE0M.AssertModel(models[13],_testData[26], false);
                        DoublefloatE0M.AssertModel(models[14],_testData[27], false);
                        DoublefloatE0M.AssertModel(models[15],_testData[28], false);
                        DoublefloatE0M.AssertModel(models[16],_testData[29], false);
                        DoublefloatE0M.AssertModel(models[17],_testData[30], false);
                        DoublefloatE0M.AssertModel(models[18],_testData[31], false);
                        DoublefloatE0M.AssertModel(models[19],_testData[32], false);
                        DoublefloatE0M.AssertModel(models[20],_testData[33], false);
                        DoublefloatE0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        DoublefloatE0M.AssertModel(models[0],_testData[26], false);
                        DoublefloatE0M.AssertModel(models[1],_testData[27], false);
                        DoublefloatE0M.AssertModel(models[2],_testData[28], false);
                        DoublefloatE0M.AssertModel(models[3],_testData[29], false);
                        DoublefloatE0M.AssertModel(models[4],_testData[30], false);
                        DoublefloatE0M.AssertModel(models[5],_testData[31], false);
                        DoublefloatE0M.AssertModel(models[6],_testData[32], false);
                        DoublefloatE0M.AssertModel(models[7],_testData[33], false);
                        DoublefloatE0M.AssertModel(models[8],_testData[34], false);
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
                ((IDoubleSingleTypefloat)this).SetDbConnectionSelectModelParametrs(cmd, 47);
                var models = await ((IDoubleSingleTypefloat)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                DoublefloatE0M.AssertModel(models[0],_testData[8], false);
                DoublefloatE0M.AssertModel(models[1],_testData[9], false);
                DoublefloatE0M.AssertModel(models[2],_testData[10], false);
                DoublefloatE0M.AssertModel(models[3],_testData[11], false);
                DoublefloatE0M.AssertModel(models[4],_testData[12], false);
                DoublefloatE0M.AssertModel(models[5],_testData[13], false);
                DoublefloatE0M.AssertModel(models[6],_testData[14], false);
                DoublefloatE0M.AssertModel(models[7],_testData[15], false);
                DoublefloatE0M.AssertModel(models[8],_testData[16], false);
                DoublefloatE0M.AssertModel(models[9],_testData[17], false);
                DoublefloatE0M.AssertModel(models[10],_testData[18], false);
                DoublefloatE0M.AssertModel(models[11],_testData[19], false);
                DoublefloatE0M.AssertModel(models[12],_testData[20], false);
                DoublefloatE0M.AssertModel(models[13],_testData[21], false);
                DoublefloatE0M.AssertModel(models[14],_testData[22], false);
                DoublefloatE0M.AssertModel(models[15],_testData[23], false);
                DoublefloatE0M.AssertModel(models[16],_testData[24], false);
                DoublefloatE0M.AssertModel(models[17],_testData[25], false);
                DoublefloatE0M.AssertModel(models[18],_testData[26], false);
                DoublefloatE0M.AssertModel(models[19],_testData[27], false);
                DoublefloatE0M.AssertModel(models[20],_testData[28], false);
                DoublefloatE0M.AssertModel(models[21],_testData[29], false);
                DoublefloatE0M.AssertModel(models[22],_testData[30], false);
                DoublefloatE0M.AssertModel(models[23],_testData[31], false);
                DoublefloatE0M.AssertModel(models[24],_testData[32], false);
                DoublefloatE0M.AssertModel(models[25],_testData[33], false);
                DoublefloatE0M.AssertModel(models[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleSingleTypefloat)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleSingleTypefloat)this).SetDbConnectionSelectModelParametrs(cmd, 9);
                var models =  ((IDoubleSingleTypefloat)this).ExecuteDbConnectionSelectModelCommand(cmd);

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
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7955696369298852d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.04294807809084322d)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.17965533853058258d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7675066026950557d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.0192621032800373d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.32624711725980426d)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.680322971354499d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9146816301079538d)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6751994496658122d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4719459934814716d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.15960353297044982d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3802262243630493d)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.15815316627094234d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7426369222016302d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5542258264090845d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.22530246399097953d)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7402440826743512d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5400957666002771d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.035215923457613485d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.9384995943077363d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.39304519714834296d)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6184982681063492d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.005547358116870904d)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.670025279678871d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9811759596992109d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.34425973791612063d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8295038725626892d)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7128409346872652d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.1690853187940401d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.33644289203269984d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5064661010054698d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.08926258736882864d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9660686762746973d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.058618912979671034d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4871779194077228d)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5733680808260481d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8682468419069032d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7489219982823887d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6764747910812743d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.31256878560689794d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8243991007598489d)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.886641274468366d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.42731670267153d)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.17307853237375315d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3742462438721107d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.37398622181530883d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6733843987827399d)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8585097666545968d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5140394580498386d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.2133385304601071d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.265392294942256d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7180049727076319d)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9069909725014202d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.13156080638054368d)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.05929746407999281d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.745876979798983d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.6066274270816725d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7532393411347746d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.23148653459204027d)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.36627416050644457d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9726475798450294d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.3932978890142439d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3031388382815805d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.33707093322528203d)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8202595104477076d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.12093705036449398d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.21870822299016957d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.19317950867706457d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.20433864123334922d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3439375748024246d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.6236037406802062d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.41362796474998187d)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4327713951220482d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7017061582480816d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5724159172129106d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.76315420486481d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9601001480357906d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5141718528670015d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.6927703382914394d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.35098054376184484d)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.1446749416202433d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.47597718926727983d)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.028994999638270236d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9063659139108964d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7471531211032252d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.1883734208419946d)));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7955696369298852d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.04294807809084322d)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.17965533853058258d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7675066026950557d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.0192621032800373d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.32624711725980426d)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.680322971354499d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9146816301079538d)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6751994496658122d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4719459934814716d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.15960353297044982d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3802262243630493d)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.15815316627094234d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7426369222016302d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5542258264090845d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.22530246399097953d)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7402440826743512d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5400957666002771d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.035215923457613485d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.9384995943077363d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.39304519714834296d)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6184982681063492d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.005547358116870904d)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.670025279678871d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9811759596992109d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.34425973791612063d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8295038725626892d)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7128409346872652d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.1690853187940401d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.33644289203269984d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5064661010054698d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.08926258736882864d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9660686762746973d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.058618912979671034d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4871779194077228d)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5733680808260481d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8682468419069032d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7489219982823887d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6764747910812743d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.31256878560689794d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8243991007598489d)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.886641274468366d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.42731670267153d)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.17307853237375315d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3742462438721107d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.37398622181530883d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6733843987827399d)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8585097666545968d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5140394580498386d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.2133385304601071d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.265392294942256d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7180049727076319d)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9069909725014202d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.13156080638054368d)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.05929746407999281d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.745876979798983d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.6066274270816725d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7532393411347746d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.23148653459204027d)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.36627416050644457d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9726475798450294d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.3932978890142439d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3031388382815805d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.33707093322528203d)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8202595104477076d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.12093705036449398d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.21870822299016957d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.19317950867706457d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.20433864123334922d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3439375748024246d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.6236037406802062d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.41362796474998187d)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4327713951220482d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7017061582480816d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5724159172129106d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.76315420486481d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9601001480357906d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5141718528670015d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.6927703382914394d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.35098054376184484d)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.1446749416202433d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.47597718926727983d)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.028994999638270236d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9063659139108964d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7471531211032252d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.1883734208419946d)));

            }
        }

#endregion

    }
}

