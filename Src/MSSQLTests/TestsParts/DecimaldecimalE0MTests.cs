

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
    Value = 0.0200914335924158m,
    ModelInner = null,
    NullableValue = 0.26241823510364m,
},
            new DecimaldecimalE0M
{
    Id = 11,
    Value = 0.805088003988143m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 8,
    Value = 0.042237482464314m,
    NullableValue = null,
},
    NullableValue = 0.68649909036098m,
},
            new DecimaldecimalE0M
{
    Id = 15,
    Value = 0.673651978420319m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 18,
    Value = 0.0404796945025888m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 16,
    Value = 0.103806927095699m,
    NullableValue = 0.79730304756604m,
},
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 20,
    Value = 0.671846025969662m,
    ModelInner = null,
    NullableValue = 0.328961089830949m,
},
            new DecimaldecimalE0M
{
    Id = 27,
    Value = 0.155267737877217m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 19,
    Value = 0.482803966413863m,
    NullableValue = 0.21478475873535m,
},
    NullableValue = 0.324125877545762m,
},
            new DecimaldecimalE0M
{
    Id = 34,
    Value = 0.848633898442541m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 36,
    Value = 0.882130468022671m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 27,
    Value = 0.816401312875434m,
    NullableValue = null,
},
    NullableValue = 0.12689186308745m,
},
            new DecimaldecimalE0M
{
    Id = 43,
    Value = 0.477787651074083m,
    ModelInner = null,
    NullableValue = 0.131769716544119m,
},
            new DecimaldecimalE0M
{
    Id = 45,
    Value = 0.589839316313295m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 31,
    Value = 0.948489015402016m,
    NullableValue = null,
},
    NullableValue = 0.428144336340807m,
},
            new DecimaldecimalE0M
{
    Id = 47,
    Value = 0.0983341844167157m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 49,
    Value = 0.274989561905782m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 32,
    Value = 0.188254759912151m,
    NullableValue = 0.823585500689724m,
},
    NullableValue = 0.697820688974503m,
},
            new DecimaldecimalE0M
{
    Id = 58,
    Value = 0.24957980225523m,
    ModelInner = null,
    NullableValue = 0.165361140985049m,
},
            new DecimaldecimalE0M
{
    Id = 59,
    Value = 0.0280611179934892m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 38,
    Value = 0.483332458550925m,
    NullableValue = 0.0332840392972956m,
},
    NullableValue = 0.475343280517445m,
},
            new DecimaldecimalE0M
{
    Id = 65,
    Value = 0.943350361327857m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 70,
    Value = 0.18069001138014m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 41,
    Value = 0.637979108170777m,
    NullableValue = 0.0926426699618731m,
},
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 73,
    Value = 0.875402324853586m,
    ModelInner = null,
    NullableValue = 0.144977140720277m,
},
            new DecimaldecimalE0M
{
    Id = 81,
    Value = 0.70251530312831m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 44,
    Value = 0.481010176682729m,
    NullableValue = null,
},
    NullableValue = 0.873825764857532m,
},
            new DecimaldecimalE0M
{
    Id = 86,
    Value = 0.369883831415771m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 88,
    Value = 0.105156324996541m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 51,
    Value = 0.807343783251867m,
    NullableValue = 0.826354524694276m,
},
    NullableValue = 0.534932601197198m,
},
            new DecimaldecimalE0M
{
    Id = 91,
    Value = 0.0433468817196634m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 93,
    Value = 0.359838639744915m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 53,
    Value = 0.85199365334006m,
    NullableValue = null,
},
    NullableValue = 0.995814357744696m,
},
            new DecimaldecimalE0M
{
    Id = 96,
    Value = 0.780746049868758m,
    ModelInner = null,
    NullableValue = 0.486744094915726m,
},
            new DecimaldecimalE0M
{
    Id = 101,
    Value = 0.453039719648967m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 61,
    Value = 0.933348457228255m,
    NullableValue = null,
},
    NullableValue = 0.299412007054989m,
},
            new DecimaldecimalE0M
{
    Id = 104,
    Value = 0.472289836150657m,
    ModelInner = null,
    NullableValue = 0.255223720946927m,
},
            new DecimaldecimalE0M
{
    Id = 113,
    Value = 0.134480956715379m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 62,
    Value = 0.743468949701552m,
    NullableValue = null,
},
    NullableValue = 0.041536745808264m,
},
            new DecimaldecimalE0M
{
    Id = 118,
    Value = 0.166052262885461m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 119,
    Value = 0.452434422975209m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 71,
    Value = 0.715545803188946m,
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 127,
    Value = 0.580988977934042m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 135,
    Value = 0.966888485397715m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 74,
    Value = 0.880687571048219m,
    NullableValue = null,
},
    NullableValue = 0.409531108466784m,
},
            new DecimaldecimalE0M
{
    Id = 138,
    Value = 0.913673348718629m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 143,
    Value = 0.0820770157567282m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 75,
    Value = 0.207189786814136m,
    NullableValue = null,
},
    NullableValue = 0.0798112375382764m,
},
            new DecimaldecimalE0M
{
    Id = 150,
    Value = 0.883223538885273m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 157,
    Value = 0.715699024118679m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 84,
    Value = 0.204215657376255m,
    NullableValue = 0.772972607716479m,
},
    NullableValue = 0.168461023905558m,
},
            new DecimaldecimalE0M
{
    Id = 160,
    Value = 0.474908183696323m,
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[25],_testData[34], false);
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[34], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 143;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[17],_testData[34], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
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
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDecimaldecimalE0M.AssertModel(models[0],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(models[1],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(models[2],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(models[3],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(models[4],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(models[5],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(models[6],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(models[7],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(models[8],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(models[9],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[28],_testData[34], false);
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
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatDecimaldecimalE0M.AssertModel(models[0],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(models[1],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatDecimaldecimalE0M.AssertModel(models[0],_testData[6], false);
                        FlatDecimaldecimalE0M.AssertModel(models[1],_testData[7], false);
                        FlatDecimaldecimalE0M.AssertModel(models[2],_testData[8], false);
                        FlatDecimaldecimalE0M.AssertModel(models[3],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(models[4],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(models[5],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(models[6],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(models[7],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(models[8],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(models[9],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(models[10],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(models[11],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(models[12],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(models[13],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(models[14],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(models[15],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(models[16],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(models[17],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(models[18],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(models[19],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(models[20],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(models[21],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(models[22],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(models[23],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(models[24],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(models[25],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(models[26],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(models[27],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[18],_testData[34], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        DecimaldecimalE0M.AssertModel(models[0],_testData[9], false);
                        DecimaldecimalE0M.AssertModel(models[1],_testData[10], false);
                        DecimaldecimalE0M.AssertModel(models[2],_testData[11], false);
                        DecimaldecimalE0M.AssertModel(models[3],_testData[12], false);
                        DecimaldecimalE0M.AssertModel(models[4],_testData[13], false);
                        DecimaldecimalE0M.AssertModel(models[5],_testData[14], false);
                        DecimaldecimalE0M.AssertModel(models[6],_testData[15], false);
                        DecimaldecimalE0M.AssertModel(models[7],_testData[16], false);
                        DecimaldecimalE0M.AssertModel(models[8],_testData[17], false);
                        DecimaldecimalE0M.AssertModel(models[9],_testData[18], false);
                        DecimaldecimalE0M.AssertModel(models[10],_testData[19], false);
                        DecimaldecimalE0M.AssertModel(models[11],_testData[20], false);
                        DecimaldecimalE0M.AssertModel(models[12],_testData[21], false);
                        DecimaldecimalE0M.AssertModel(models[13],_testData[22], false);
                        DecimaldecimalE0M.AssertModel(models[14],_testData[23], false);
                        DecimaldecimalE0M.AssertModel(models[15],_testData[24], false);
                        DecimaldecimalE0M.AssertModel(models[16],_testData[25], false);
                        DecimaldecimalE0M.AssertModel(models[17],_testData[26], false);
                        DecimaldecimalE0M.AssertModel(models[18],_testData[27], false);
                        DecimaldecimalE0M.AssertModel(models[19],_testData[28], false);
                        DecimaldecimalE0M.AssertModel(models[20],_testData[29], false);
                        DecimaldecimalE0M.AssertModel(models[21],_testData[30], false);
                        DecimaldecimalE0M.AssertModel(models[22],_testData[31], false);
                        DecimaldecimalE0M.AssertModel(models[23],_testData[32], false);
                        DecimaldecimalE0M.AssertModel(models[24],_testData[33], false);
                        DecimaldecimalE0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        DecimaldecimalE0M.AssertModel(models[0],_testData[18], false);
                        DecimaldecimalE0M.AssertModel(models[1],_testData[19], false);
                        DecimaldecimalE0M.AssertModel(models[2],_testData[20], false);
                        DecimaldecimalE0M.AssertModel(models[3],_testData[21], false);
                        DecimaldecimalE0M.AssertModel(models[4],_testData[22], false);
                        DecimaldecimalE0M.AssertModel(models[5],_testData[23], false);
                        DecimaldecimalE0M.AssertModel(models[6],_testData[24], false);
                        DecimaldecimalE0M.AssertModel(models[7],_testData[25], false);
                        DecimaldecimalE0M.AssertModel(models[8],_testData[26], false);
                        DecimaldecimalE0M.AssertModel(models[9],_testData[27], false);
                        DecimaldecimalE0M.AssertModel(models[10],_testData[28], false);
                        DecimaldecimalE0M.AssertModel(models[11],_testData[29], false);
                        DecimaldecimalE0M.AssertModel(models[12],_testData[30], false);
                        DecimaldecimalE0M.AssertModel(models[13],_testData[31], false);
                        DecimaldecimalE0M.AssertModel(models[14],_testData[32], false);
                        DecimaldecimalE0M.AssertModel(models[15],_testData[33], false);
                        DecimaldecimalE0M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        DecimaldecimalE0M.AssertModel(models[0],_testData[28], false);
                        DecimaldecimalE0M.AssertModel(models[1],_testData[29], false);
                        DecimaldecimalE0M.AssertModel(models[2],_testData[30], false);
                        DecimaldecimalE0M.AssertModel(models[3],_testData[31], false);
                        DecimaldecimalE0M.AssertModel(models[4],_testData[32], false);
                        DecimaldecimalE0M.AssertModel(models[5],_testData[33], false);
                        DecimaldecimalE0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        DecimaldecimalE0M.AssertModel(models[0],_testData[28], false);
                        DecimaldecimalE0M.AssertModel(models[1],_testData[29], false);
                        DecimaldecimalE0M.AssertModel(models[2],_testData[30], false);
                        DecimaldecimalE0M.AssertModel(models[3],_testData[31], false);
                        DecimaldecimalE0M.AssertModel(models[4],_testData[32], false);
                        DecimaldecimalE0M.AssertModel(models[5],_testData[33], false);
                        DecimaldecimalE0M.AssertModel(models[6],_testData[34], false);
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
                await ((IDecimalSingleTypedecimal)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 118, query1, 93, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[12],_testData[34], false);
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
                await ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 113, query1, 86, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[15],_testData[34], false);
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
                 ((IDecimalSingleTypedecimal)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 127, query1, 59, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[20],_testData[34], false);
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
                 ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelBatch(connection, 45, query1, 11, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[32],_testData[34], false);
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
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 47, query1, 138, query2))
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
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDecimaldecimalE0M.AssertModel(models[0],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(models[1],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(models[2],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(models[3],_testData[34], false);
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
                await ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 36, query1, 93, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[12],_testData[34], false);
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
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionSTDynQuerySelectModelBatch(connection, 43, query1, 81, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatDecimaldecimalE0M.AssertModel(models[0],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(models[1],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(models[2],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(models[3],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(models[4],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(models[5],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(models[6],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(models[7],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(models[8],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(models[9],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(models[10],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(models[11],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(models[12],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(models[13],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(models[14],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(models[15],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(models[16],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(models[17],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(models[18],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(models[19],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(models[20],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(models[21],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(models[22],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(models[23],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(models[24],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                 ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelBatch(connection, 119, query1, 86, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[15],_testData[34], false);
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
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelBatchAsync(connection, 86, 36))
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
                        Assert.That(models, Has.Count.EqualTo(27));

                        DecimaldecimalE0M.AssertModel(models[0],_testData[8], false);
                        DecimaldecimalE0M.AssertModel(models[1],_testData[9], false);
                        DecimaldecimalE0M.AssertModel(models[2],_testData[10], false);
                        DecimaldecimalE0M.AssertModel(models[3],_testData[11], false);
                        DecimaldecimalE0M.AssertModel(models[4],_testData[12], false);
                        DecimaldecimalE0M.AssertModel(models[5],_testData[13], false);
                        DecimaldecimalE0M.AssertModel(models[6],_testData[14], false);
                        DecimaldecimalE0M.AssertModel(models[7],_testData[15], false);
                        DecimaldecimalE0M.AssertModel(models[8],_testData[16], false);
                        DecimaldecimalE0M.AssertModel(models[9],_testData[17], false);
                        DecimaldecimalE0M.AssertModel(models[10],_testData[18], false);
                        DecimaldecimalE0M.AssertModel(models[11],_testData[19], false);
                        DecimaldecimalE0M.AssertModel(models[12],_testData[20], false);
                        DecimaldecimalE0M.AssertModel(models[13],_testData[21], false);
                        DecimaldecimalE0M.AssertModel(models[14],_testData[22], false);
                        DecimaldecimalE0M.AssertModel(models[15],_testData[23], false);
                        DecimaldecimalE0M.AssertModel(models[16],_testData[24], false);
                        DecimaldecimalE0M.AssertModel(models[17],_testData[25], false);
                        DecimaldecimalE0M.AssertModel(models[18],_testData[26], false);
                        DecimaldecimalE0M.AssertModel(models[19],_testData[27], false);
                        DecimaldecimalE0M.AssertModel(models[20],_testData[28], false);
                        DecimaldecimalE0M.AssertModel(models[21],_testData[29], false);
                        DecimaldecimalE0M.AssertModel(models[22],_testData[30], false);
                        DecimaldecimalE0M.AssertModel(models[23],_testData[31], false);
                        DecimaldecimalE0M.AssertModel(models[24],_testData[32], false);
                        DecimaldecimalE0M.AssertModel(models[25],_testData[33], false);
                        DecimaldecimalE0M.AssertModel(models[26],_testData[34], false);
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
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelBatch(connection, 20, 101))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        DecimaldecimalE0M.AssertModel(models[0],_testData[5], false);
                        DecimaldecimalE0M.AssertModel(models[1],_testData[6], false);
                        DecimaldecimalE0M.AssertModel(models[2],_testData[7], false);
                        DecimaldecimalE0M.AssertModel(models[3],_testData[8], false);
                        DecimaldecimalE0M.AssertModel(models[4],_testData[9], false);
                        DecimaldecimalE0M.AssertModel(models[5],_testData[10], false);
                        DecimaldecimalE0M.AssertModel(models[6],_testData[11], false);
                        DecimaldecimalE0M.AssertModel(models[7],_testData[12], false);
                        DecimaldecimalE0M.AssertModel(models[8],_testData[13], false);
                        DecimaldecimalE0M.AssertModel(models[9],_testData[14], false);
                        DecimaldecimalE0M.AssertModel(models[10],_testData[15], false);
                        DecimaldecimalE0M.AssertModel(models[11],_testData[16], false);
                        DecimaldecimalE0M.AssertModel(models[12],_testData[17], false);
                        DecimaldecimalE0M.AssertModel(models[13],_testData[18], false);
                        DecimaldecimalE0M.AssertModel(models[14],_testData[19], false);
                        DecimaldecimalE0M.AssertModel(models[15],_testData[20], false);
                        DecimaldecimalE0M.AssertModel(models[16],_testData[21], false);
                        DecimaldecimalE0M.AssertModel(models[17],_testData[22], false);
                        DecimaldecimalE0M.AssertModel(models[18],_testData[23], false);
                        DecimaldecimalE0M.AssertModel(models[19],_testData[24], false);
                        DecimaldecimalE0M.AssertModel(models[20],_testData[25], false);
                        DecimaldecimalE0M.AssertModel(models[21],_testData[26], false);
                        DecimaldecimalE0M.AssertModel(models[22],_testData[27], false);
                        DecimaldecimalE0M.AssertModel(models[23],_testData[28], false);
                        DecimaldecimalE0M.AssertModel(models[24],_testData[29], false);
                        DecimaldecimalE0M.AssertModel(models[25],_testData[30], false);
                        DecimaldecimalE0M.AssertModel(models[26],_testData[31], false);
                        DecimaldecimalE0M.AssertModel(models[27],_testData[32], false);
                        DecimaldecimalE0M.AssertModel(models[28],_testData[33], false);
                        DecimaldecimalE0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        DecimaldecimalE0M.AssertModel(models[0],_testData[24], false);
                        DecimaldecimalE0M.AssertModel(models[1],_testData[25], false);
                        DecimaldecimalE0M.AssertModel(models[2],_testData[26], false);
                        DecimaldecimalE0M.AssertModel(models[3],_testData[27], false);
                        DecimaldecimalE0M.AssertModel(models[4],_testData[28], false);
                        DecimaldecimalE0M.AssertModel(models[5],_testData[29], false);
                        DecimaldecimalE0M.AssertModel(models[6],_testData[30], false);
                        DecimaldecimalE0M.AssertModel(models[7],_testData[31], false);
                        DecimaldecimalE0M.AssertModel(models[8],_testData[32], false);
                        DecimaldecimalE0M.AssertModel(models[9],_testData[33], false);
                        DecimaldecimalE0M.AssertModel(models[10],_testData[34], false);
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
                ((IDecimalSingleTypedecimal)this).SetDbConnectionSelectModelParametrs(cmd, 119);
                var models = await ((IDecimalSingleTypedecimal)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                DecimaldecimalE0M.AssertModel(models[0],_testData[28], false);
                DecimaldecimalE0M.AssertModel(models[1],_testData[29], false);
                DecimaldecimalE0M.AssertModel(models[2],_testData[30], false);
                DecimaldecimalE0M.AssertModel(models[3],_testData[31], false);
                DecimaldecimalE0M.AssertModel(models[4],_testData[32], false);
                DecimaldecimalE0M.AssertModel(models[5],_testData[33], false);
                DecimaldecimalE0M.AssertModel(models[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalSingleTypedecimal)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalSingleTypedecimal)this).SetDbConnectionSelectModelParametrs(cmd, 45);
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
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0200914335924158m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.26241823510364m)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.805088003988143m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.042237482464314m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.68649909036098m)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.673651978420319m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0404796945025888m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.103806927095699m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.79730304756604m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.671846025969662m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.328961089830949m)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.155267737877217m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.482803966413863m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.21478475873535m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.324125877545762m)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.848633898442541m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.882130468022671m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.816401312875434m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.12689186308745m)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.477787651074083m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.131769716544119m)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.589839316313295m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.948489015402016m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.428144336340807m)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0983341844167157m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.274989561905782m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.188254759912151m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.823585500689724m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.697820688974503m)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.24957980225523m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.165361140985049m)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0280611179934892m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.483332458550925m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.0332840392972956m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.475343280517445m)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.943350361327857m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.18069001138014m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.637979108170777m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.0926426699618731m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.875402324853586m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.144977140720277m)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.70251530312831m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.481010176682729m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.873825764857532m)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.369883831415771m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.105156324996541m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.807343783251867m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.826354524694276m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.534932601197198m)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0433468817196634m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.359838639744915m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.85199365334006m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.995814357744696m)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.780746049868758m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.486744094915726m)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.453039719648967m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.933348457228255m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.299412007054989m)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.472289836150657m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.255223720946927m)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.134480956715379m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.743468949701552m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.041536745808264m)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.166052262885461m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.452434422975209m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.715545803188946m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.580988977934042m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.966888485397715m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.880687571048219m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.409531108466784m)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.913673348718629m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0820770157567282m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.207189786814136m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0798112375382764m)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.883223538885273m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.715699024118679m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.204215657376255m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.772972607716479m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.168461023905558m)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.474908183696323m)));//Value

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
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0200914335924158m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.26241823510364m)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.805088003988143m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.042237482464314m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.68649909036098m)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.673651978420319m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0404796945025888m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.103806927095699m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.79730304756604m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.671846025969662m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.328961089830949m)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.155267737877217m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.482803966413863m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.21478475873535m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.324125877545762m)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.848633898442541m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.882130468022671m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.816401312875434m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.12689186308745m)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.477787651074083m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.131769716544119m)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.589839316313295m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.948489015402016m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.428144336340807m)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0983341844167157m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.274989561905782m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.188254759912151m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.823585500689724m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.697820688974503m)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.24957980225523m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.165361140985049m)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0280611179934892m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.483332458550925m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.0332840392972956m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.475343280517445m)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.943350361327857m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.18069001138014m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.637979108170777m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.0926426699618731m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.875402324853586m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.144977140720277m)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.70251530312831m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.481010176682729m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.873825764857532m)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.369883831415771m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.105156324996541m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.807343783251867m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.826354524694276m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.534932601197198m)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0433468817196634m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.359838639744915m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.85199365334006m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.995814357744696m)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.780746049868758m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.486744094915726m)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.453039719648967m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.933348457228255m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.299412007054989m)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.472289836150657m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.255223720946927m)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.134480956715379m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.743468949701552m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.041536745808264m)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.166052262885461m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.452434422975209m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.715545803188946m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.580988977934042m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.966888485397715m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.880687571048219m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.409531108466784m)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.913673348718629m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0820770157567282m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.207189786814136m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0798112375382764m)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.883223538885273m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.715699024118679m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.204215657376255m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.772972607716479m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.168461023905558m)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.474908183696323m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

