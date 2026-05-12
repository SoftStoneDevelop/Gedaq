

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
    Id = 2,
    Value = 0.465425509316596m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 6,
    Value = 0.307916966108222m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 1,
    Value = 0.820643882419062m,
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 12,
    Value = 0.864848004316339m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 19,
    Value = 0.399958275558274m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 10,
    Value = 0.0221786531980296m,
    NullableValue = 0.283318981667408m,
},
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 28,
    Value = 0.132176614786636m,
    ModelInner = null,
    NullableValue = 0.0295767292280275m,
},
            new DecimaldecimalE0M
{
    Id = 31,
    Value = 0.7421765453554m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 11,
    Value = 0.283787637532918m,
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 38,
    Value = 0.396314391220163m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 39,
    Value = 0.740023453487604m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 12,
    Value = 0.604775777712875m,
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 43,
    Value = 0.409881999524696m,
    ModelInner = null,
    NullableValue = 0.766372303566022m,
},
            new DecimaldecimalE0M
{
    Id = 48,
    Value = 0.576389819774004m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 19,
    Value = 0.986541023007548m,
    NullableValue = 0.498017739701726m,
},
    NullableValue = 0.0358037872922768m,
},
            new DecimaldecimalE0M
{
    Id = 54,
    Value = 0.169265265931077m,
    ModelInner = null,
    NullableValue = 0.300908931419014m,
},
            new DecimaldecimalE0M
{
    Id = 58,
    Value = 0.9063346305013m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 26,
    Value = 0.0543757345512882m,
    NullableValue = 0.192318728632063m,
},
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 63,
    Value = 0.478706320724416m,
    ModelInner = null,
    NullableValue = 0.127552983381319m,
},
            new DecimaldecimalE0M
{
    Id = 68,
    Value = 0.801522632062962m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 27,
    Value = 0.76012300169084m,
    NullableValue = 0.262884600713122m,
},
    NullableValue = 0.039278654939532m,
},
            new DecimaldecimalE0M
{
    Id = 75,
    Value = 0.538283902498745m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 77,
    Value = 0.290378673747577m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 33,
    Value = 0.712285145509106m,
    NullableValue = 0.149399968136092m,
},
    NullableValue = 0.225497313937761m,
},
            new DecimaldecimalE0M
{
    Id = 81,
    Value = 0.779635321896655m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 85,
    Value = 0.177019707391626m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 38,
    Value = 0.834349460084677m,
    NullableValue = null,
},
    NullableValue = 0.758101257804168m,
},
            new DecimaldecimalE0M
{
    Id = 90,
    Value = 0.490867458677696m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 92,
    Value = 0.0894553908261228m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 39,
    Value = 0.142934230837711m,
    NullableValue = 0.186461386451692m,
},
    NullableValue = 0.628741565264887m,
},
            new DecimaldecimalE0M
{
    Id = 93,
    Value = 0.740917991044797m,
    ModelInner = null,
    NullableValue = 0.182857644957249m,
},
            new DecimaldecimalE0M
{
    Id = 102,
    Value = 0.475455019457286m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 46,
    Value = 0.145739257263366m,
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 106,
    Value = 0.178299207231102m,
    ModelInner = null,
    NullableValue = 0.373609026658278m,
},
            new DecimaldecimalE0M
{
    Id = 108,
    Value = 0.262783165359361m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 47,
    Value = 0.736483511489717m,
    NullableValue = 0.980071912605431m,
},
    NullableValue = 0.196099276678628m,
},
            new DecimaldecimalE0M
{
    Id = 109,
    Value = 0.137402593487665m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 118,
    Value = 0.462999581818828m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 48,
    Value = 0.827430463340991m,
    NullableValue = 0.643362854810441m,
},
    NullableValue = 0.702128912661097m,
},
            new DecimaldecimalE0M
{
    Id = 122,
    Value = 0.465052655715196m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 130,
    Value = 0.140060373328804m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 57,
    Value = 0.851633615539646m,
    NullableValue = null,
},
    NullableValue = 0.880317659630838m,
},
            new DecimaldecimalE0M
{
    Id = 133,
    Value = 0.879288572587554m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 137,
    Value = 0.36254774614004m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 63,
    Value = 0.678443173162942m,
    NullableValue = 0.395091264860391m,
},
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 143,
    Value = 0.385248124547446m,
    ModelInner = null,
    NullableValue = 0.632910049134145m,
},
            new DecimaldecimalE0M
{
    Id = 147,
    Value = 0.337951306318714m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 70,
    Value = 0.611902619165093m,
    NullableValue = null,
},
    NullableValue = 0.0197522585803183m,
},
            new DecimaldecimalE0M
{
    Id = 155,
    Value = 0.605137303379134m,
    ModelInner = null,
    NullableValue = 0.15967977930285m,
},
            new DecimaldecimalE0M
{
    Id = 160,
    Value = 0.899881392511612m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 79,
    Value = 0.834681280311441m,
    NullableValue = null,
},
    NullableValue = 0.0273908613356647m,
},
            new DecimaldecimalE0M
{
    Id = 161,
    Value = 0.023079801419534m,
    ModelInner = null,
    NullableValue = null,
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
                parametr1.Value = 19;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[15],_testData[34], false);
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
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 2;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[2],_testData[34], false);
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
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
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[34], false);
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatDecimaldecimalE0M.AssertModel(models[0],_testData[4], false);
                        FlatDecimaldecimalE0M.AssertModel(models[1],_testData[5], false);
                        FlatDecimaldecimalE0M.AssertModel(models[2],_testData[6], false);
                        FlatDecimaldecimalE0M.AssertModel(models[3],_testData[7], false);
                        FlatDecimaldecimalE0M.AssertModel(models[4],_testData[8], false);
                        FlatDecimaldecimalE0M.AssertModel(models[5],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(models[6],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(models[7],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(models[8],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(models[9],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(models[10],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(models[11],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(models[12],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(models[13],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(models[14],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(models[15],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(models[16],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(models[17],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(models[18],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(models[19],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(models[20],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(models[21],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(models[22],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(models[23],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(models[24],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(models[25],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(models[26],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(models[27],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(models[28],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(models[29],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(models[30],_testData[34], false);
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
                parametr2.Value = 6;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[19],_testData[34], false);
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
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDecimaldecimalE0M.AssertModel(models[0],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(models[1],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(models[2],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(models[3],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(models[4],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(models[5],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(models[6],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(models[7],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(models[8],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(models[9],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(models[10],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(models[11],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(models[12],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(models[13],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(models[14],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 130;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[19],_testData[34], false);
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
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        DecimaldecimalE0M.AssertModel(models[0],_testData[15], false);
                        DecimaldecimalE0M.AssertModel(models[1],_testData[16], false);
                        DecimaldecimalE0M.AssertModel(models[2],_testData[17], false);
                        DecimaldecimalE0M.AssertModel(models[3],_testData[18], false);
                        DecimaldecimalE0M.AssertModel(models[4],_testData[19], false);
                        DecimaldecimalE0M.AssertModel(models[5],_testData[20], false);
                        DecimaldecimalE0M.AssertModel(models[6],_testData[21], false);
                        DecimaldecimalE0M.AssertModel(models[7],_testData[22], false);
                        DecimaldecimalE0M.AssertModel(models[8],_testData[23], false);
                        DecimaldecimalE0M.AssertModel(models[9],_testData[24], false);
                        DecimaldecimalE0M.AssertModel(models[10],_testData[25], false);
                        DecimaldecimalE0M.AssertModel(models[11],_testData[26], false);
                        DecimaldecimalE0M.AssertModel(models[12],_testData[27], false);
                        DecimaldecimalE0M.AssertModel(models[13],_testData[28], false);
                        DecimaldecimalE0M.AssertModel(models[14],_testData[29], false);
                        DecimaldecimalE0M.AssertModel(models[15],_testData[30], false);
                        DecimaldecimalE0M.AssertModel(models[16],_testData[31], false);
                        DecimaldecimalE0M.AssertModel(models[17],_testData[32], false);
                        DecimaldecimalE0M.AssertModel(models[18],_testData[33], false);
                        DecimaldecimalE0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        DecimaldecimalE0M.AssertModel(models[0],_testData[33], false);
                        DecimaldecimalE0M.AssertModel(models[1],_testData[34], false);
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
                await ((IDecimalSingleTypedecimal)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 92, query1, 85, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[16],_testData[34], false);
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
                await ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 155, query1, 137, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[34], false);
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
                 ((IDecimalSingleTypedecimal)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 48, query1, 93, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                 ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelBatch(connection, 137, query1, 102, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[12],_testData[34], false);
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
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 85, query1, 137, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatDecimaldecimalE0M.AssertModel(models[0],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(models[1],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(models[2],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(models[3],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(models[4],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(models[5],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(models[6],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(models[7],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(models[8],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(models[9],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(models[10],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(models[11],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(models[12],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(models[13],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(models[14],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(models[15],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatDecimaldecimalE0M.AssertModel(models[0],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(models[1],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(models[2],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(models[3],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(models[4],_testData[34], false);
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
                await ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 38, query1, 108, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[10],_testData[34], false);
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
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionSTDynQuerySelectModelBatch(connection, 54, query1, 28, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatDecimaldecimalE0M.AssertModel(models[0],_testData[5], false);
                        FlatDecimaldecimalE0M.AssertModel(models[1],_testData[6], false);
                        FlatDecimaldecimalE0M.AssertModel(models[2],_testData[7], false);
                        FlatDecimaldecimalE0M.AssertModel(models[3],_testData[8], false);
                        FlatDecimaldecimalE0M.AssertModel(models[4],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(models[5],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(models[6],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(models[7],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(models[8],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(models[9],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(models[10],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(models[11],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(models[12],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(models[13],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(models[14],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(models[15],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(models[16],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(models[17],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(models[18],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(models[19],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(models[20],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(models[21],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(models[22],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(models[23],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(models[24],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(models[25],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(models[26],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(models[27],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(models[28],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(models[29],_testData[34], false);
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
                 ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelBatch(connection, 81, query1, 106, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[11],_testData[34], false);
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
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelBatchAsync(connection, 90, 48))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        DecimaldecimalE0M.AssertModel(models[0],_testData[19], false);
                        DecimaldecimalE0M.AssertModel(models[1],_testData[20], false);
                        DecimaldecimalE0M.AssertModel(models[2],_testData[21], false);
                        DecimaldecimalE0M.AssertModel(models[3],_testData[22], false);
                        DecimaldecimalE0M.AssertModel(models[4],_testData[23], false);
                        DecimaldecimalE0M.AssertModel(models[5],_testData[24], false);
                        DecimaldecimalE0M.AssertModel(models[6],_testData[25], false);
                        DecimaldecimalE0M.AssertModel(models[7],_testData[26], false);
                        DecimaldecimalE0M.AssertModel(models[8],_testData[27], false);
                        DecimaldecimalE0M.AssertModel(models[9],_testData[28], false);
                        DecimaldecimalE0M.AssertModel(models[10],_testData[29], false);
                        DecimaldecimalE0M.AssertModel(models[11],_testData[30], false);
                        DecimaldecimalE0M.AssertModel(models[12],_testData[31], false);
                        DecimaldecimalE0M.AssertModel(models[13],_testData[32], false);
                        DecimaldecimalE0M.AssertModel(models[14],_testData[33], false);
                        DecimaldecimalE0M.AssertModel(models[15],_testData[34], false);
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
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelBatch(connection, 58, 77))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        DecimaldecimalE0M.AssertModel(models[0],_testData[16], false);
                        DecimaldecimalE0M.AssertModel(models[1],_testData[17], false);
                        DecimaldecimalE0M.AssertModel(models[2],_testData[18], false);
                        DecimaldecimalE0M.AssertModel(models[3],_testData[19], false);
                        DecimaldecimalE0M.AssertModel(models[4],_testData[20], false);
                        DecimaldecimalE0M.AssertModel(models[5],_testData[21], false);
                        DecimaldecimalE0M.AssertModel(models[6],_testData[22], false);
                        DecimaldecimalE0M.AssertModel(models[7],_testData[23], false);
                        DecimaldecimalE0M.AssertModel(models[8],_testData[24], false);
                        DecimaldecimalE0M.AssertModel(models[9],_testData[25], false);
                        DecimaldecimalE0M.AssertModel(models[10],_testData[26], false);
                        DecimaldecimalE0M.AssertModel(models[11],_testData[27], false);
                        DecimaldecimalE0M.AssertModel(models[12],_testData[28], false);
                        DecimaldecimalE0M.AssertModel(models[13],_testData[29], false);
                        DecimaldecimalE0M.AssertModel(models[14],_testData[30], false);
                        DecimaldecimalE0M.AssertModel(models[15],_testData[31], false);
                        DecimaldecimalE0M.AssertModel(models[16],_testData[32], false);
                        DecimaldecimalE0M.AssertModel(models[17],_testData[33], false);
                        DecimaldecimalE0M.AssertModel(models[18],_testData[34], false);
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
                ((IDecimalSingleTypedecimal)this).SetDbConnectionSelectModelParametrs(cmd, 122);
                var models = await ((IDecimalSingleTypedecimal)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                DecimaldecimalE0M.AssertModel(models[0],_testData[27], false);
                DecimaldecimalE0M.AssertModel(models[1],_testData[28], false);
                DecimaldecimalE0M.AssertModel(models[2],_testData[29], false);
                DecimaldecimalE0M.AssertModel(models[3],_testData[30], false);
                DecimaldecimalE0M.AssertModel(models[4],_testData[31], false);
                DecimaldecimalE0M.AssertModel(models[5],_testData[32], false);
                DecimaldecimalE0M.AssertModel(models[6],_testData[33], false);
                DecimaldecimalE0M.AssertModel(models[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalSingleTypedecimal)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalSingleTypedecimal)this).SetDbConnectionSelectModelParametrs(cmd, 48);
                var models =  ((IDecimalSingleTypedecimal)this).ExecuteDbConnectionSelectModelCommand(cmd);

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
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.465425509316596m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.307916966108222m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.820643882419062m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.864848004316339m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.399958275558274m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.0221786531980296m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.283318981667408m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.132176614786636m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0295767292280275m)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.7421765453554m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.283787637532918m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.396314391220163m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.740023453487604m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.604775777712875m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.409881999524696m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.766372303566022m)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.576389819774004m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.986541023007548m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.498017739701726m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0358037872922768m)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.169265265931077m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.300908931419014m)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.9063346305013m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.0543757345512882m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.192318728632063m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.478706320724416m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.127552983381319m)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.801522632062962m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.76012300169084m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.262884600713122m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.039278654939532m)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.538283902498745m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.290378673747577m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.712285145509106m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.149399968136092m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.225497313937761m)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.779635321896655m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.177019707391626m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.834349460084677m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.758101257804168m)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.490867458677696m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0894553908261228m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.142934230837711m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.186461386451692m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.628741565264887m)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.740917991044797m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.182857644957249m)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.475455019457286m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.145739257263366m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.178299207231102m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.373609026658278m)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.262783165359361m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.736483511489717m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.980071912605431m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.196099276678628m)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.137402593487665m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.462999581818828m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.827430463340991m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.643362854810441m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.702128912661097m)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.465052655715196m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.140060373328804m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.851633615539646m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.880317659630838m)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.879288572587554m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.36254774614004m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.678443173162942m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.395091264860391m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.385248124547446m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.632910049134145m)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.337951306318714m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.611902619165093m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0197522585803183m)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.605137303379134m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.15967977930285m)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.899881392511612m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.834681280311441m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0273908613356647m)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.023079801419534m)));//Value

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
                var models =  ((IDecimalSingleTypedecimal)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.465425509316596m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.307916966108222m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.820643882419062m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.864848004316339m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.399958275558274m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.0221786531980296m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.283318981667408m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.132176614786636m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0295767292280275m)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.7421765453554m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.283787637532918m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.396314391220163m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.740023453487604m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.604775777712875m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.409881999524696m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.766372303566022m)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.576389819774004m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.986541023007548m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.498017739701726m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0358037872922768m)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.169265265931077m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.300908931419014m)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.9063346305013m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.0543757345512882m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.192318728632063m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.478706320724416m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.127552983381319m)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.801522632062962m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.76012300169084m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.262884600713122m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.039278654939532m)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.538283902498745m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.290378673747577m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.712285145509106m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.149399968136092m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.225497313937761m)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.779635321896655m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.177019707391626m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.834349460084677m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.758101257804168m)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.490867458677696m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0894553908261228m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.142934230837711m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.186461386451692m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.628741565264887m)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.740917991044797m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.182857644957249m)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.475455019457286m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.145739257263366m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.178299207231102m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.373609026658278m)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.262783165359361m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.736483511489717m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.980071912605431m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.196099276678628m)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.137402593487665m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.462999581818828m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.827430463340991m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.643362854810441m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.702128912661097m)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.465052655715196m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.140060373328804m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.851633615539646m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.880317659630838m)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.879288572587554m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.36254774614004m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.678443173162942m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.395091264860391m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.385248124547446m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.632910049134145m)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.337951306318714m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.611902619165093m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0197522585803183m)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.605137303379134m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.15967977930285m)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.899881392511612m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.834681280311441m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0273908613356647m)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.023079801419534m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

