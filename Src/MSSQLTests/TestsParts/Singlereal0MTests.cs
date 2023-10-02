

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
    internal partial interface ISingleSingleTypereal
    {
    }
    
    internal partial class SingleSingleTypereal : ISingleSingleTypereal
    {


#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.singlereal0mi(
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
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)
            ), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                sqlDbType: (System.Data.SqlDbType)(8)
                ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Single),
                parametrName: "value",
                methodParametrName: "value",
                sqlDbType: (System.Data.SqlDbType)(13)
                ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Single?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                sqlDbType: (System.Data.SqlDbType)(13)
                )
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

                changedRows =  ((ISingleSingleTypereal)this).InsertModelInner(connection, 1222078610, 0.5122503f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISingleSingleTypereal)this).InsertModelInner(connection, 1621999226, 0.9394005f, null);
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

                changedRows = await ((ISingleSingleTypereal)this).InsertModelInnerAsync(connection, 1110223961, 0.61099935f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).InsertModelInnerAsync(connection, 959122184, 0.061249197f, 0.14856839f);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.singlereal0mi(
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
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)11
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Single), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)15
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Single?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)15, 
                nullable: true
                )
            ]
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

                changedRows =  ((ISingleSingleTypereal)this).DbConnectionInsertInnerModel(connection, 110682953, 0.20199686f, null);
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

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertInnerModelAsync(connection, 1110552438, 0.97162056f, 0.33146095f);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertInnerModelAsync(connection, 94149538, 0.83021516f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertInnerModelAsync(connection, 254283125, 0.4988315f, 0.3787042f);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertInnerModelAsync(connection, 1471248427, 0.9531262f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertInnerModelAsync(connection, 1427102934, 0.4472562f, 0.46563762f);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertInnerModelAsync(connection, 970691797, 0.0013529658f, 0.9116536f);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertInnerModelAsync(connection, 963343866, 0.84496224f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertInnerModelAsync(connection, 1471842944, 0.8544306f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertInnerModelAsync(connection, 1251150815, 0.06841171f, 0.78313524f);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertInnerModelAsync(connection, 865156662, 0.38800478f, 0.45676464f);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.singlereal0m(
	id,
    value,
    nullablevalue,
    singlereal0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @singlereal0mi_id
)
",
            methodName:"InsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)
            ), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id",
                sqlDbType: (System.Data.SqlDbType)(8)
            ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Single), 
                parametrName: "value", 
                methodParametrName: "value", 
                sqlDbType: (System.Data.SqlDbType)(13)
            ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Single?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                sqlDbType: (System.Data.SqlDbType)(13),
                nullable: true
            ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "singlereal0mi_id", 
                methodParametrName: "singlereal0mi_id", 
                sqlDbType: (System.Data.SqlDbType)(8),
                nullable: true
            )
            ]
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

                changedRows =  ((ISingleSingleTypereal)this).InsertModel(connection, 904062065, 0.42887658f, 0.10874325f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISingleSingleTypereal)this).InsertModel(connection, 1353581118, 0.91710377f, null, 1222078610);
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

                changedRows = await ((ISingleSingleTypereal)this).InsertModelAsync(connection, 467512809, 0.46451813f, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).InsertModelAsync(connection, 1676389638, 0.9098626f, 0.95366585f, 1621999226);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.singlereal0m(
	id,
    value,
    nullablevalue,
    singlereal0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @singlereal0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Single), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)15),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Single?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)15,
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "singlereal0mi_id", 
                methodParametrName: "singlereal0mi_id", 
                dbType: (System.Data.DbType)11,
                nullable: true
            )
            ]
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

                changedRows =  ((ISingleSingleTypereal)this).DbConnectionInsertModel(connection, 2061918962, 0.78270584f, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISingleSingleTypereal)this).DbConnectionInsertModel(connection, 1969893585, 0.6666484f, 0.68112713f, 1110223961);
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

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, 1420060417, 0.3802203f, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, 314488072, 0.8879047f, 0.780153f, 959122184);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, 1858923306, 0.4785769f, 0.9008525f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, 1535907550, 0.99696416f, 0.51875156f, 110682953);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, 1158812902, 0.89628136f, 0.31899232f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, 527875661, 0.8852808f, null, 1110552438);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, 981956216, 0.29641008f, 0.5293845f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, 1294408828, 0.32464713f, 0.38320452f, 94149538);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, 951027900, 0.36972338f, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, 702564668, 0.63805884f, 0.82929885f, 254283125);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, 2064343828, 0.30704612f, 0.014019489f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, 1781766317, 0.89524734f, null, 1471248427);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, 1201809360, 0.685431f, 0.41278863f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, 287873598, 0.7339539f, 0.03245288f, 1427102934);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, 788494822, 0.91572565f, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, 220545758, 0.056392193f, null, 970691797);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, 1788468879, 0.026727855f, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, 1952228392, 0.4721732f, null, 963343866);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, 854198727, 0.252343f, 0.032711208f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, 608800480, 0.9282769f, 0.6845887f, 1471842944);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, 464464083, 0.5594876f, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, 1190181523, 0.9896014f, null, 1251150815);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, 1469219428, 0.17123693f, 0.5577145f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, 1565952736, 0.54171884f, null, 865156662);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region Select Models

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
FROM dbo.singlereal0m m
LEFT JOIN dbo.singlereal0mi mi ON mi.id = m.singlereal0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(Singlereal0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)
            ),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            sqlDbType: (System.Data.SqlDbType)(8)
            )
            ]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ISingleSingleTypereal)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(220545758));
                Assert.That(model.Value, Is.EqualTo(0.056392193f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(970691797));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.0013529658f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.9116536f));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(287873598));
                Assert.That(model.Value, Is.EqualTo(0.7339539f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.03245288f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1427102934));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.4472562f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.46563762f));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(314488072));
                Assert.That(model.Value, Is.EqualTo(0.8879047f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.780153f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(959122184));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.061249197f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.14856839f));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(464464083));
                Assert.That(model.Value, Is.EqualTo(0.5594876f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(467512809));
                Assert.That(model.Value, Is.EqualTo(0.46451813f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(527875661));
                Assert.That(model.Value, Is.EqualTo(0.8852808f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1110552438));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.97162056f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.33146095f));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(608800480));
                Assert.That(model.Value, Is.EqualTo(0.9282769f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.6845887f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1471842944));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8544306f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(702564668));
                Assert.That(model.Value, Is.EqualTo(0.63805884f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.82929885f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(254283125));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.4988315f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.3787042f));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(788494822));
                Assert.That(model.Value, Is.EqualTo(0.91572565f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(854198727));
                Assert.That(model.Value, Is.EqualTo(0.252343f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.032711208f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(904062065));
                Assert.That(model.Value, Is.EqualTo(0.42887658f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.10874325f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(951027900));
                Assert.That(model.Value, Is.EqualTo(0.36972338f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(981956216));
                Assert.That(model.Value, Is.EqualTo(0.29641008f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5293845f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1158812902));
                Assert.That(model.Value, Is.EqualTo(0.89628136f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.31899232f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1190181523));
                Assert.That(model.Value, Is.EqualTo(0.9896014f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1251150815));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.06841171f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.78313524f));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1201809360));
                Assert.That(model.Value, Is.EqualTo(0.685431f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.41278863f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1294408828));
                Assert.That(model.Value, Is.EqualTo(0.32464713f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.38320452f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(94149538));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.83021516f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1353581118));
                Assert.That(model.Value, Is.EqualTo(0.91710377f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1222078610));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.5122503f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1420060417));
                Assert.That(model.Value, Is.EqualTo(0.3802203f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1469219428));
                Assert.That(model.Value, Is.EqualTo(0.17123693f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5577145f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1535907550));
                Assert.That(model.Value, Is.EqualTo(0.99696416f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.51875156f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(110682953));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.20199686f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1565952736));
                Assert.That(model.Value, Is.EqualTo(0.54171884f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(865156662));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.38800478f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.45676464f));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1676389638));
                Assert.That(model.Value, Is.EqualTo(0.9098626f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.95366585f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1621999226));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9394005f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1781766317));
                Assert.That(model.Value, Is.EqualTo(0.89524734f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1471248427));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9531262f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1788468879));
                Assert.That(model.Value, Is.EqualTo(0.026727855f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1858923306));
                Assert.That(model.Value, Is.EqualTo(0.4785769f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.9008525f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1952228392));
                Assert.That(model.Value, Is.EqualTo(0.4721732f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(963343866));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.84496224f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1969893585));
                Assert.That(model.Value, Is.EqualTo(0.6666484f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.68112713f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1110223961));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.61099935f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2061918962));
                Assert.That(model.Value, Is.EqualTo(0.78270584f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2064343828));
                Assert.That(model.Value, Is.EqualTo(0.30704612f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.014019489f));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISingleSingleTypereal)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(220545758));
                Assert.That(model.Value, Is.EqualTo(0.056392193f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(970691797));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.0013529658f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.9116536f));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(287873598));
                Assert.That(model.Value, Is.EqualTo(0.7339539f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.03245288f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1427102934));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.4472562f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.46563762f));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(314488072));
                Assert.That(model.Value, Is.EqualTo(0.8879047f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.780153f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(959122184));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.061249197f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.14856839f));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(464464083));
                Assert.That(model.Value, Is.EqualTo(0.5594876f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(467512809));
                Assert.That(model.Value, Is.EqualTo(0.46451813f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(527875661));
                Assert.That(model.Value, Is.EqualTo(0.8852808f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1110552438));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.97162056f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.33146095f));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(608800480));
                Assert.That(model.Value, Is.EqualTo(0.9282769f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.6845887f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1471842944));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8544306f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(702564668));
                Assert.That(model.Value, Is.EqualTo(0.63805884f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.82929885f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(254283125));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.4988315f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.3787042f));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(788494822));
                Assert.That(model.Value, Is.EqualTo(0.91572565f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(854198727));
                Assert.That(model.Value, Is.EqualTo(0.252343f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.032711208f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(904062065));
                Assert.That(model.Value, Is.EqualTo(0.42887658f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.10874325f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(951027900));
                Assert.That(model.Value, Is.EqualTo(0.36972338f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(981956216));
                Assert.That(model.Value, Is.EqualTo(0.29641008f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5293845f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1158812902));
                Assert.That(model.Value, Is.EqualTo(0.89628136f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.31899232f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1190181523));
                Assert.That(model.Value, Is.EqualTo(0.9896014f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1251150815));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.06841171f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.78313524f));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1201809360));
                Assert.That(model.Value, Is.EqualTo(0.685431f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.41278863f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1294408828));
                Assert.That(model.Value, Is.EqualTo(0.32464713f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.38320452f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(94149538));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.83021516f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1353581118));
                Assert.That(model.Value, Is.EqualTo(0.91710377f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1222078610));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.5122503f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1420060417));
                Assert.That(model.Value, Is.EqualTo(0.3802203f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1469219428));
                Assert.That(model.Value, Is.EqualTo(0.17123693f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5577145f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1535907550));
                Assert.That(model.Value, Is.EqualTo(0.99696416f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.51875156f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(110682953));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.20199686f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1565952736));
                Assert.That(model.Value, Is.EqualTo(0.54171884f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(865156662));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.38800478f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.45676464f));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1676389638));
                Assert.That(model.Value, Is.EqualTo(0.9098626f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.95366585f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1621999226));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9394005f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1781766317));
                Assert.That(model.Value, Is.EqualTo(0.89524734f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1471248427));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9531262f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1788468879));
                Assert.That(model.Value, Is.EqualTo(0.026727855f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1858923306));
                Assert.That(model.Value, Is.EqualTo(0.4785769f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.9008525f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1952228392));
                Assert.That(model.Value, Is.EqualTo(0.4721732f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(963343866));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.84496224f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1969893585));
                Assert.That(model.Value, Is.EqualTo(0.6666484f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.68112713f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1110223961));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.61099935f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2061918962));
                Assert.That(model.Value, Is.EqualTo(0.78270584f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2064343828));
                Assert.That(model.Value, Is.EqualTo(0.30704612f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.014019489f));

                Assert.That(model.ModelInner, Is.Null);

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
FROM dbo.singlereal0m m
LEFT JOIN dbo.singlereal0mi mi ON mi.id = m.singlereal0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(Singlereal0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)
            ),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)11
                )
            ]
        private void DbConnectionSelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((ISingleSingleTypereal)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(220545758));
                Assert.That(model.Value, Is.EqualTo(0.056392193f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(970691797));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.0013529658f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.9116536f));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(287873598));
                Assert.That(model.Value, Is.EqualTo(0.7339539f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.03245288f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1427102934));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.4472562f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.46563762f));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(314488072));
                Assert.That(model.Value, Is.EqualTo(0.8879047f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.780153f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(959122184));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.061249197f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.14856839f));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(464464083));
                Assert.That(model.Value, Is.EqualTo(0.5594876f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(467512809));
                Assert.That(model.Value, Is.EqualTo(0.46451813f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(527875661));
                Assert.That(model.Value, Is.EqualTo(0.8852808f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1110552438));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.97162056f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.33146095f));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(608800480));
                Assert.That(model.Value, Is.EqualTo(0.9282769f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.6845887f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1471842944));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8544306f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(702564668));
                Assert.That(model.Value, Is.EqualTo(0.63805884f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.82929885f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(254283125));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.4988315f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.3787042f));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(788494822));
                Assert.That(model.Value, Is.EqualTo(0.91572565f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(854198727));
                Assert.That(model.Value, Is.EqualTo(0.252343f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.032711208f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(904062065));
                Assert.That(model.Value, Is.EqualTo(0.42887658f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.10874325f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(951027900));
                Assert.That(model.Value, Is.EqualTo(0.36972338f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(981956216));
                Assert.That(model.Value, Is.EqualTo(0.29641008f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5293845f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1158812902));
                Assert.That(model.Value, Is.EqualTo(0.89628136f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.31899232f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1190181523));
                Assert.That(model.Value, Is.EqualTo(0.9896014f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1251150815));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.06841171f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.78313524f));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1201809360));
                Assert.That(model.Value, Is.EqualTo(0.685431f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.41278863f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1294408828));
                Assert.That(model.Value, Is.EqualTo(0.32464713f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.38320452f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(94149538));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.83021516f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1353581118));
                Assert.That(model.Value, Is.EqualTo(0.91710377f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1222078610));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.5122503f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1420060417));
                Assert.That(model.Value, Is.EqualTo(0.3802203f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1469219428));
                Assert.That(model.Value, Is.EqualTo(0.17123693f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5577145f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1535907550));
                Assert.That(model.Value, Is.EqualTo(0.99696416f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.51875156f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(110682953));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.20199686f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1565952736));
                Assert.That(model.Value, Is.EqualTo(0.54171884f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(865156662));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.38800478f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.45676464f));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1676389638));
                Assert.That(model.Value, Is.EqualTo(0.9098626f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.95366585f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1621999226));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9394005f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1781766317));
                Assert.That(model.Value, Is.EqualTo(0.89524734f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1471248427));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9531262f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1788468879));
                Assert.That(model.Value, Is.EqualTo(0.026727855f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1858923306));
                Assert.That(model.Value, Is.EqualTo(0.4785769f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.9008525f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1952228392));
                Assert.That(model.Value, Is.EqualTo(0.4721732f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(963343866));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.84496224f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1969893585));
                Assert.That(model.Value, Is.EqualTo(0.6666484f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.68112713f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1110223961));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.61099935f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2061918962));
                Assert.That(model.Value, Is.EqualTo(0.78270584f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2064343828));
                Assert.That(model.Value, Is.EqualTo(0.30704612f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.014019489f));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISingleSingleTypereal)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(220545758));
                Assert.That(model.Value, Is.EqualTo(0.056392193f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(970691797));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.0013529658f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.9116536f));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(287873598));
                Assert.That(model.Value, Is.EqualTo(0.7339539f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.03245288f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1427102934));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.4472562f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.46563762f));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(314488072));
                Assert.That(model.Value, Is.EqualTo(0.8879047f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.780153f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(959122184));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.061249197f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.14856839f));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(464464083));
                Assert.That(model.Value, Is.EqualTo(0.5594876f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(467512809));
                Assert.That(model.Value, Is.EqualTo(0.46451813f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(527875661));
                Assert.That(model.Value, Is.EqualTo(0.8852808f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1110552438));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.97162056f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.33146095f));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(608800480));
                Assert.That(model.Value, Is.EqualTo(0.9282769f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.6845887f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1471842944));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8544306f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(702564668));
                Assert.That(model.Value, Is.EqualTo(0.63805884f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.82929885f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(254283125));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.4988315f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.3787042f));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(788494822));
                Assert.That(model.Value, Is.EqualTo(0.91572565f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(854198727));
                Assert.That(model.Value, Is.EqualTo(0.252343f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.032711208f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(904062065));
                Assert.That(model.Value, Is.EqualTo(0.42887658f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.10874325f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(951027900));
                Assert.That(model.Value, Is.EqualTo(0.36972338f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(981956216));
                Assert.That(model.Value, Is.EqualTo(0.29641008f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5293845f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1158812902));
                Assert.That(model.Value, Is.EqualTo(0.89628136f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.31899232f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1190181523));
                Assert.That(model.Value, Is.EqualTo(0.9896014f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1251150815));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.06841171f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.78313524f));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1201809360));
                Assert.That(model.Value, Is.EqualTo(0.685431f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.41278863f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1294408828));
                Assert.That(model.Value, Is.EqualTo(0.32464713f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.38320452f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(94149538));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.83021516f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1353581118));
                Assert.That(model.Value, Is.EqualTo(0.91710377f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1222078610));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.5122503f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1420060417));
                Assert.That(model.Value, Is.EqualTo(0.3802203f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1469219428));
                Assert.That(model.Value, Is.EqualTo(0.17123693f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5577145f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1535907550));
                Assert.That(model.Value, Is.EqualTo(0.99696416f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.51875156f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(110682953));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.20199686f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1565952736));
                Assert.That(model.Value, Is.EqualTo(0.54171884f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(865156662));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.38800478f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.45676464f));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1676389638));
                Assert.That(model.Value, Is.EqualTo(0.9098626f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.95366585f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1621999226));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9394005f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1781766317));
                Assert.That(model.Value, Is.EqualTo(0.89524734f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1471248427));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9531262f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1788468879));
                Assert.That(model.Value, Is.EqualTo(0.026727855f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1858923306));
                Assert.That(model.Value, Is.EqualTo(0.4785769f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.9008525f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1952228392));
                Assert.That(model.Value, Is.EqualTo(0.4721732f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(963343866));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.84496224f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1969893585));
                Assert.That(model.Value, Is.EqualTo(0.6666484f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.68112713f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1110223961));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.61099935f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2061918962));
                Assert.That(model.Value, Is.EqualTo(0.78270584f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2064343828));
                Assert.That(model.Value, Is.EqualTo(0.30704612f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.014019489f));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleSingleTypereal)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleSingleTypereal)this).SetDbConnectionSelectModelParametrs(cmd, 1858923306);
                var models =  ((ISingleSingleTypereal)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(4));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1952228392));
                Assert.That(model.Value, Is.EqualTo(0.4721732f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(963343866));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.84496224f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1969893585));
                Assert.That(model.Value, Is.EqualTo(0.6666484f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.68112713f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1110223961));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.61099935f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2061918962));
                Assert.That(model.Value, Is.EqualTo(0.78270584f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2064343828));
                Assert.That(model.Value, Is.EqualTo(0.30704612f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.014019489f));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((ISingleSingleTypereal)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ISingleSingleTypereal)this).SetDbConnectionSelectModelParametrs(cmd, 702564668);
                var models = await ((ISingleSingleTypereal)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(22));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(788494822));
                Assert.That(model.Value, Is.EqualTo(0.91572565f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(854198727));
                Assert.That(model.Value, Is.EqualTo(0.252343f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.032711208f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(904062065));
                Assert.That(model.Value, Is.EqualTo(0.42887658f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.10874325f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(951027900));
                Assert.That(model.Value, Is.EqualTo(0.36972338f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(981956216));
                Assert.That(model.Value, Is.EqualTo(0.29641008f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5293845f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1158812902));
                Assert.That(model.Value, Is.EqualTo(0.89628136f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.31899232f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1190181523));
                Assert.That(model.Value, Is.EqualTo(0.9896014f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1251150815));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.06841171f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.78313524f));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1201809360));
                Assert.That(model.Value, Is.EqualTo(0.685431f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.41278863f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1294408828));
                Assert.That(model.Value, Is.EqualTo(0.32464713f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.38320452f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(94149538));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.83021516f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1353581118));
                Assert.That(model.Value, Is.EqualTo(0.91710377f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1222078610));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.5122503f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1420060417));
                Assert.That(model.Value, Is.EqualTo(0.3802203f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1469219428));
                Assert.That(model.Value, Is.EqualTo(0.17123693f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5577145f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1535907550));
                Assert.That(model.Value, Is.EqualTo(0.99696416f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.51875156f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(110682953));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.20199686f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1565952736));
                Assert.That(model.Value, Is.EqualTo(0.54171884f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(865156662));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.38800478f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.45676464f));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1676389638));
                Assert.That(model.Value, Is.EqualTo(0.9098626f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.95366585f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1621999226));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9394005f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1781766317));
                Assert.That(model.Value, Is.EqualTo(0.89524734f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1471248427));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9531262f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1788468879));
                Assert.That(model.Value, Is.EqualTo(0.026727855f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1858923306));
                Assert.That(model.Value, Is.EqualTo(0.4785769f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.9008525f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1952228392));
                Assert.That(model.Value, Is.EqualTo(0.4721732f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(963343866));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.84496224f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1969893585));
                Assert.That(model.Value, Is.EqualTo(0.6666484f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.68112713f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1110223961));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.61099935f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2061918962));
                Assert.That(model.Value, Is.EqualTo(0.78270584f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2064343828));
                Assert.That(model.Value, Is.EqualTo(0.30704612f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.014019489f));

                Assert.That(model.ModelInner, Is.Null);

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
FROM dbo.singlereal0m m
LEFT JOIN dbo.singlereal0mi mi ON mi.id = m.singlereal0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelToObjArr",
            queryMapType: typeof(object[]),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)
            )
            ]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((ISingleSingleTypereal)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((220545758)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.056392193f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((970691797)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.0013529658f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.9116536f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((287873598)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7339539f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1427102934)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.4472562f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.46563762f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.03245288f)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((314488072)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8879047f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((959122184)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.061249197f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.14856839f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.780153f)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((464464083)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5594876f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((467512809)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.46451813f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((527875661)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8852808f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1110552438)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.97162056f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.33146095f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((608800480)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9282769f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1471842944)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.8544306f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.6845887f)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((702564668)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.63805884f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((254283125)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.4988315f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.3787042f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.82929885f)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((788494822)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.91572565f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((854198727)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.252343f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.032711208f)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((904062065)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.42887658f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.10874325f)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((951027900)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.36972338f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((981956216)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.29641008f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5293845f)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1158812902)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.89628136f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.31899232f)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1190181523)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9896014f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1251150815)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.06841171f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.78313524f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1201809360)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.685431f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.41278863f)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1294408828)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.32464713f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((94149538)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.83021516f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.38320452f)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1353581118)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.91710377f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1222078610)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.5122503f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1420060417)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.3802203f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1469219428)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.17123693f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5577145f)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1535907550)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.99696416f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((110682953)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.20199686f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.51875156f)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1565952736)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.54171884f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((865156662)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.38800478f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.45676464f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1676389638)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9098626f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1621999226)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.9394005f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.95366585f)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1781766317)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.89524734f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1471248427)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.9531262f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1788468879)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.026727855f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1858923306)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4785769f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.9008525f)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1952228392)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4721732f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((963343866)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.84496224f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1969893585)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6666484f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1110223961)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.61099935f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.68112713f)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2061918962)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.78270584f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2064343828)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.30704612f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.014019489f)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISingleSingleTypereal)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((220545758)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.056392193f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((970691797)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.0013529658f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.9116536f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((287873598)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7339539f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1427102934)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.4472562f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.46563762f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.03245288f)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((314488072)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8879047f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((959122184)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.061249197f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.14856839f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.780153f)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((464464083)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5594876f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((467512809)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.46451813f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((527875661)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8852808f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1110552438)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.97162056f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.33146095f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((608800480)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9282769f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1471842944)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.8544306f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.6845887f)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((702564668)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.63805884f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((254283125)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.4988315f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.3787042f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.82929885f)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((788494822)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.91572565f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((854198727)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.252343f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.032711208f)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((904062065)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.42887658f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.10874325f)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((951027900)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.36972338f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((981956216)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.29641008f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5293845f)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1158812902)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.89628136f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.31899232f)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1190181523)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9896014f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1251150815)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.06841171f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.78313524f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1201809360)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.685431f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.41278863f)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1294408828)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.32464713f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((94149538)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.83021516f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.38320452f)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1353581118)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.91710377f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1222078610)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.5122503f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1420060417)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.3802203f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1469219428)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.17123693f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5577145f)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1535907550)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.99696416f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((110682953)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.20199686f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.51875156f)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1565952736)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.54171884f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((865156662)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.38800478f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.45676464f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1676389638)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9098626f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1621999226)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.9394005f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.95366585f)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1781766317)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.89524734f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1471248427)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.9531262f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1788468879)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.026727855f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1858923306)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4785769f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.9008525f)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1952228392)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4721732f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((963343866)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.84496224f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1969893585)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6666484f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1110223961)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.61099935f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.68112713f)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2061918962)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.78270584f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2064343828)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.30704612f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.014019489f)));

            }
        }

        #endregion

    }
}

