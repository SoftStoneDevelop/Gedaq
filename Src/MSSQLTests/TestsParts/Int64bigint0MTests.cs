

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
    Id = 6,
    Value = 4347319338114373729L,
    ModelInner = null,
    NullableValue = 3061027846439355650L,
},
            new Int64bigint0M
{
    Id = 11,
    Value = 8477817954110312837L,
    ModelInner = new Int64bigint0MI
{
    Id = 8,
    Value = 1487147135040701664L,
    NullableValue = 1030041924985958747L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 15,
    Value = 376423369969103097L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 16,
    Value = 8970636247361515434L,
    ModelInner = new Int64bigint0MI
{
    Id = 11,
    Value = 6745850062542036505L,
    NullableValue = null,
},
    NullableValue = 5628946382997886486L,
},
            new Int64bigint0M
{
    Id = 22,
    Value = 1790438883817239333L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 29,
    Value = 4239639950446617478L,
    ModelInner = new Int64bigint0MI
{
    Id = 12,
    Value = 7562450189815035239L,
    NullableValue = null,
},
    NullableValue = 4692514735973812168L,
},
            new Int64bigint0M
{
    Id = 31,
    Value = 3347414409531118977L,
    ModelInner = null,
    NullableValue = 2551857846779447326L,
},
            new Int64bigint0M
{
    Id = 35,
    Value = 926656210587686258L,
    ModelInner = new Int64bigint0MI
{
    Id = 18,
    Value = 6228556394639008484L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 41,
    Value = 2156496656834382782L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 44,
    Value = 8554115066175459510L,
    ModelInner = new Int64bigint0MI
{
    Id = 19,
    Value = 5740615098253539323L,
    NullableValue = 468803563825068999L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 47,
    Value = 4728417013651344912L,
    ModelInner = null,
    NullableValue = 4930598591293244299L,
},
            new Int64bigint0M
{
    Id = 56,
    Value = 3106933352544395639L,
    ModelInner = new Int64bigint0MI
{
    Id = 21,
    Value = 7378236211429680215L,
    NullableValue = null,
},
    NullableValue = 3214215225610181423L,
},
            new Int64bigint0M
{
    Id = 65,
    Value = 4550885294435863944L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 73,
    Value = 1482897671933191019L,
    ModelInner = new Int64bigint0MI
{
    Id = 23,
    Value = 1661242938315075700L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 76,
    Value = 8286612292242675808L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 80,
    Value = 6870060565741330708L,
    ModelInner = new Int64bigint0MI
{
    Id = 24,
    Value = 8795126267225777040L,
    NullableValue = 6652386161474630244L,
},
    NullableValue = 1986192718276588750L,
},
            new Int64bigint0M
{
    Id = 81,
    Value = 2570387370145235858L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 90,
    Value = 6896185940738028020L,
    ModelInner = new Int64bigint0MI
{
    Id = 26,
    Value = 5066137366418541262L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 94,
    Value = 1758112654268070056L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 96,
    Value = 6019282107846827009L,
    ModelInner = new Int64bigint0MI
{
    Id = 32,
    Value = 2875256654950031535L,
    NullableValue = null,
},
    NullableValue = 7862890326248177665L,
},
            new Int64bigint0M
{
    Id = 105,
    Value = 5459852841158489142L,
    ModelInner = null,
    NullableValue = 451024824830023222L,
},
            new Int64bigint0M
{
    Id = 109,
    Value = 3461332971131748965L,
    ModelInner = new Int64bigint0MI
{
    Id = 41,
    Value = 415015374991424582L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 118,
    Value = 5240970391244330489L,
    ModelInner = null,
    NullableValue = 5566422217179530674L,
},
            new Int64bigint0M
{
    Id = 121,
    Value = 4783919285253281500L,
    ModelInner = new Int64bigint0MI
{
    Id = 47,
    Value = 8826534272622372325L,
    NullableValue = null,
},
    NullableValue = 5750367523858786440L,
},
            new Int64bigint0M
{
    Id = 124,
    Value = 3534767722475806723L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 127,
    Value = 3877231025455799417L,
    ModelInner = new Int64bigint0MI
{
    Id = 56,
    Value = 6650122878839190235L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 133,
    Value = 7379161172917178846L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 135,
    Value = 7084562404636780533L,
    ModelInner = new Int64bigint0MI
{
    Id = 57,
    Value = 3097690193956402142L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 137,
    Value = 3149771722740114660L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 146,
    Value = 5887465844214221431L,
    ModelInner = new Int64bigint0MI
{
    Id = 61,
    Value = 7039699959912270185L,
    NullableValue = null,
},
    NullableValue = 7177351035581048549L,
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
                sqlDbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int64),
                parametrName: "value",
                methodParametrName: "value",
                sqlDbType: (System.Data.SqlDbType)(0)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                sqlDbType: (System.Data.SqlDbType)(0))
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
                sqlDbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int64), 
                parametrName: "value", 
                methodParametrName: "value", 
                sqlDbType: (System.Data.SqlDbType)(0)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                sqlDbType: (System.Data.SqlDbType)(0),
                nullable: true),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int64bigint0mi_id", 
                methodParametrName: "int64bigint0mi_id", 
                sqlDbType: (System.Data.SqlDbType)(8),
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
            sqlDbType: (System.Data.SqlDbType)(8))]
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
            sqlDbType: (System.Data.SqlDbType)(8))]
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
            sqlDbType: (System.Data.SqlDbType)(8))]
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[30], false);
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[30], false);
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
                parametr1.Value = 15;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
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
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[29], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[30], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
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
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[17],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[18],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[19],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[20],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[21],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[22],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[23],_testData[29], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[23],_testData[30], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Int64bigint0M.AssertModel(models[0],_testData[25], false);
                        Int64bigint0M.AssertModel(models[1],_testData[26], false);
                        Int64bigint0M.AssertModel(models[2],_testData[27], false);
                        Int64bigint0M.AssertModel(models[3],_testData[28], false);
                        Int64bigint0M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Int64bigint0M.AssertModel(models[0],_testData[23], false);
                        Int64bigint0M.AssertModel(models[1],_testData[24], false);
                        Int64bigint0M.AssertModel(models[2],_testData[25], false);
                        Int64bigint0M.AssertModel(models[3],_testData[26], false);
                        Int64bigint0M.AssertModel(models[4],_testData[27], false);
                        Int64bigint0M.AssertModel(models[5],_testData[28], false);
                        Int64bigint0M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Int64bigint0M.AssertModel(models[0],_testData[19], false);
                        Int64bigint0M.AssertModel(models[1],_testData[20], false);
                        Int64bigint0M.AssertModel(models[2],_testData[21], false);
                        Int64bigint0M.AssertModel(models[3],_testData[22], false);
                        Int64bigint0M.AssertModel(models[4],_testData[23], false);
                        Int64bigint0M.AssertModel(models[5],_testData[24], false);
                        Int64bigint0M.AssertModel(models[6],_testData[25], false);
                        Int64bigint0M.AssertModel(models[7],_testData[26], false);
                        Int64bigint0M.AssertModel(models[8],_testData[27], false);
                        Int64bigint0M.AssertModel(models[9],_testData[28], false);
                        Int64bigint0M.AssertModel(models[10],_testData[29], false);
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
                int resultIndex = 0;
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
                await ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 127, query1, 109, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[30], false);
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
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 16, query1, 133, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[29], false);
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
                int resultIndex = 0;
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
                 ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 35, query1, 65, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[30], false);
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
                 ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 76, query1, 44, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[29], false);
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
                int resultIndex = 0;
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
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 121, query1, 44, query2))
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
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[17],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[18],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[19],_testData[29], false);
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
                await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 56, query1, 118, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[30], false);
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
                int resultIndex = 0;
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
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 73, query1, 127, query2))
                {
                    if(++resultIndex == 1)
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
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatch(connection, 81, query1, 121, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[30], false);
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
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatchAsync(connection, 6, 96))
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
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatch(connection, 47, 76))
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
                        Assert.That(models, Has.Count.EqualTo(15));

                        Int64bigint0M.AssertModel(models[0],_testData[15], false);
                        Int64bigint0M.AssertModel(models[1],_testData[16], false);
                        Int64bigint0M.AssertModel(models[2],_testData[17], false);
                        Int64bigint0M.AssertModel(models[3],_testData[18], false);
                        Int64bigint0M.AssertModel(models[4],_testData[19], false);
                        Int64bigint0M.AssertModel(models[5],_testData[20], false);
                        Int64bigint0M.AssertModel(models[6],_testData[21], false);
                        Int64bigint0M.AssertModel(models[7],_testData[22], false);
                        Int64bigint0M.AssertModel(models[8],_testData[23], false);
                        Int64bigint0M.AssertModel(models[9],_testData[24], false);
                        Int64bigint0M.AssertModel(models[10],_testData[25], false);
                        Int64bigint0M.AssertModel(models[11],_testData[26], false);
                        Int64bigint0M.AssertModel(models[12],_testData[27], false);
                        Int64bigint0M.AssertModel(models[13],_testData[28], false);
                        Int64bigint0M.AssertModel(models[14],_testData[29], false);
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
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 11);
                var models = await ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
Int64bigint0M.AssertModel(models[0],_testData[2], false);Int64bigint0M.AssertModel(models[1],_testData[3], false);Int64bigint0M.AssertModel(models[2],_testData[4], false);Int64bigint0M.AssertModel(models[3],_testData[5], false);Int64bigint0M.AssertModel(models[4],_testData[6], false);Int64bigint0M.AssertModel(models[5],_testData[7], false);Int64bigint0M.AssertModel(models[6],_testData[8], false);Int64bigint0M.AssertModel(models[7],_testData[9], false);Int64bigint0M.AssertModel(models[8],_testData[10], false);Int64bigint0M.AssertModel(models[9],_testData[11], false);Int64bigint0M.AssertModel(models[10],_testData[12], false);Int64bigint0M.AssertModel(models[11],_testData[13], false);Int64bigint0M.AssertModel(models[12],_testData[14], false);Int64bigint0M.AssertModel(models[13],_testData[15], false);Int64bigint0M.AssertModel(models[14],_testData[16], false);Int64bigint0M.AssertModel(models[15],_testData[17], false);Int64bigint0M.AssertModel(models[16],_testData[18], false);Int64bigint0M.AssertModel(models[17],_testData[19], false);Int64bigint0M.AssertModel(models[18],_testData[20], false);Int64bigint0M.AssertModel(models[19],_testData[21], false);Int64bigint0M.AssertModel(models[20],_testData[22], false);Int64bigint0M.AssertModel(models[21],_testData[23], false);Int64bigint0M.AssertModel(models[22],_testData[24], false);Int64bigint0M.AssertModel(models[23],_testData[25], false);Int64bigint0M.AssertModel(models[24],_testData[26], false);Int64bigint0M.AssertModel(models[25],_testData[27], false);Int64bigint0M.AssertModel(models[26],_testData[28], false);Int64bigint0M.AssertModel(models[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64SingleTypebigint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 31);
                var models =  ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
Int64bigint0M.AssertModel(models[0],_testData[7], false);Int64bigint0M.AssertModel(models[1],_testData[8], false);Int64bigint0M.AssertModel(models[2],_testData[9], false);Int64bigint0M.AssertModel(models[3],_testData[10], false);Int64bigint0M.AssertModel(models[4],_testData[11], false);Int64bigint0M.AssertModel(models[5],_testData[12], false);Int64bigint0M.AssertModel(models[6],_testData[13], false);Int64bigint0M.AssertModel(models[7],_testData[14], false);Int64bigint0M.AssertModel(models[8],_testData[15], false);Int64bigint0M.AssertModel(models[9],_testData[16], false);Int64bigint0M.AssertModel(models[10],_testData[17], false);Int64bigint0M.AssertModel(models[11],_testData[18], false);Int64bigint0M.AssertModel(models[12],_testData[19], false);Int64bigint0M.AssertModel(models[13],_testData[20], false);Int64bigint0M.AssertModel(models[14],_testData[21], false);Int64bigint0M.AssertModel(models[15],_testData[22], false);Int64bigint0M.AssertModel(models[16],_testData[23], false);Int64bigint0M.AssertModel(models[17],_testData[24], false);Int64bigint0M.AssertModel(models[18],_testData[25], false);Int64bigint0M.AssertModel(models[19],_testData[26], false);Int64bigint0M.AssertModel(models[20],_testData[27], false);Int64bigint0M.AssertModel(models[21],_testData[28], false);Int64bigint0M.AssertModel(models[22],_testData[29], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4347319338114373729L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3061027846439355650L)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8477817954110312837L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1487147135040701664L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((1030041924985958747L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((376423369969103097L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8970636247361515434L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6745850062542036505L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((5628946382997886486L)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1790438883817239333L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4239639950446617478L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7562450189815035239L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((4692514735973812168L)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3347414409531118977L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2551857846779447326L)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((926656210587686258L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6228556394639008484L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2156496656834382782L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8554115066175459510L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5740615098253539323L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((468803563825068999L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4728417013651344912L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4930598591293244299L)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3106933352544395639L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7378236211429680215L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((3214215225610181423L)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4550885294435863944L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1482897671933191019L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1661242938315075700L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8286612292242675808L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6870060565741330708L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8795126267225777040L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6652386161474630244L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1986192718276588750L)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2570387370145235858L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6896185940738028020L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5066137366418541262L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1758112654268070056L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6019282107846827009L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2875256654950031535L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((7862890326248177665L)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5459852841158489142L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((451024824830023222L)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3461332971131748965L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((415015374991424582L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5240970391244330489L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5566422217179530674L)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4783919285253281500L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8826534272622372325L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((5750367523858786440L)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3534767722475806723L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3877231025455799417L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6650122878839190235L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7379161172917178846L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7084562404636780533L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3097690193956402142L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3149771722740114660L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5887465844214221431L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7039699959912270185L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((7177351035581048549L)));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4347319338114373729L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3061027846439355650L)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8477817954110312837L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1487147135040701664L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((1030041924985958747L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((376423369969103097L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8970636247361515434L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6745850062542036505L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((5628946382997886486L)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1790438883817239333L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4239639950446617478L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7562450189815035239L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((4692514735973812168L)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3347414409531118977L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2551857846779447326L)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((926656210587686258L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6228556394639008484L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2156496656834382782L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8554115066175459510L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5740615098253539323L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((468803563825068999L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4728417013651344912L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4930598591293244299L)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3106933352544395639L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7378236211429680215L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((3214215225610181423L)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4550885294435863944L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1482897671933191019L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1661242938315075700L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8286612292242675808L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6870060565741330708L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8795126267225777040L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6652386161474630244L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1986192718276588750L)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2570387370145235858L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6896185940738028020L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5066137366418541262L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1758112654268070056L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6019282107846827009L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2875256654950031535L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((7862890326248177665L)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5459852841158489142L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((451024824830023222L)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3461332971131748965L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((415015374991424582L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5240970391244330489L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5566422217179530674L)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4783919285253281500L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8826534272622372325L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((5750367523858786440L)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3534767722475806723L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3877231025455799417L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6650122878839190235L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7379161172917178846L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7084562404636780533L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3097690193956402142L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3149771722740114660L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5887465844214221431L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7039699959912270185L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((7177351035581048549L)));

            }
        }

#endregion

    }
}

