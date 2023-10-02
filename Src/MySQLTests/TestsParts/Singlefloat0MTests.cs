

using MySqlConnector;
using System;
using Gedaq.Common.Enums;
using Gedaq.MySqlConnector.Attributes;
using Gedaq.MySqlConnector.Enums;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface ISingleSingleTypefloat
    {
    }
    
    internal partial class SingleSingleTypefloat : ISingleSingleTypefloat
    {


#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.singlefloat0mi(
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
            sourceType: SourceType.MySqlConnection,
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypefloat)
            ), 
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)
                ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Single),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (MySqlConnector.MySqlDbType)(4)
                ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Single?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (MySqlConnector.MySqlDbType)(4)
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

                changedRows =  ((ISingleSingleTypefloat)this).InsertModelInner(connection, 18277433, 0.76872545f, 0.5599673f);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISingleSingleTypefloat)this).InsertModelInner(connection, 1970168053, 0.82029176f, 0.3198495f);
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

                changedRows = await ((ISingleSingleTypefloat)this).InsertModelInnerAsync(connection, 2084165394, 0.08895272f, 0.22467983f);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).InsertModelInnerAsync(connection, 717272267, 0.45653778f, 0.60086536f);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.singlefloat0mi(
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
            asPartInterface: typeof(ISingleSingleTypefloat)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Single), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(15)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Single?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(15), 
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

                changedRows =  ((ISingleSingleTypefloat)this).DbConnectionInsertInnerModel(connection, 567662818, 0.08889812f, 0.56401855f);
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

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, 1860927612, 0.35319936f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, 1457850350, 0.91278774f, 0.12912863f);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, 1460211824, 0.043859243f, 0.6145832f);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, 1710646902, 0.069545865f, 0.3308617f);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, 802363669, 0.6469401f, 0.8756944f);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, 1987528501, 0.42850208f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, 811410767, 0.12008548f, 0.02772963f);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, 567062694, 0.20810467f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, 1738074369, 0.010444045f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, 1549158581, 0.8954303f, null);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.singlefloat0m(
	id,
    value,
    nullablevalue,
    singlefloat0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @singlefloat0mi_id
)
",
            methodName:"InsertModel",
            sourceType: SourceType.MySqlConnection,
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypefloat)
            ), 
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)
            ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Single), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (MySqlConnector.MySqlDbType)(4)
            ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Single?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (MySqlConnector.MySqlDbType)(4),
                nullable: true
            ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "singlefloat0mi_id", 
                methodParametrName: "singlefloat0mi_id", 
                dbType: (MySqlConnector.MySqlDbType)(3),
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

                changedRows =  ((ISingleSingleTypefloat)this).InsertModel(connection, 83598929, 0.12311053f, 0.7117326f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISingleSingleTypefloat)this).InsertModel(connection, 553193543, 0.4889586f, 0.8767247f, 18277433);
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

                changedRows = await ((ISingleSingleTypefloat)this).InsertModelAsync(connection, 1324391498, 0.38201272f, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).InsertModelAsync(connection, 1985538787, 0.3266375f, null, 1970168053);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.singlefloat0m(
	id,
    value,
    nullablevalue,
    singlefloat0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @singlefloat0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypefloat)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Single), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(15)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Single?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(15),
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "singlefloat0mi_id", 
                methodParametrName: "singlefloat0mi_id", 
                dbType: (System.Data.DbType)(11),
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

                changedRows =  ((ISingleSingleTypefloat)this).DbConnectionInsertModel(connection, 696678979, 0.74120486f, 0.36481798f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISingleSingleTypefloat)this).DbConnectionInsertModel(connection, 2142537834, 0.02044326f, null, 2084165394);
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

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 1517217188, 0.8640744f, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 547377260, 0.5655503f, null, 717272267);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 228096881, 0.13814944f, 0.33770996f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 143551845, 0.8176923f, 0.47292697f, 567662818);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 439335577, 0.15697163f, 0.94774723f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 1735114643, 0.7944935f, 0.494344f, 1860927612);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 1098318582, 0.54642874f, 0.03796792f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 633908708, 0.64114237f, null, 1457850350);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 1896191035, 0.06907338f, 0.44135565f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 319124564, 0.46687317f, null, 1460211824);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 898490349, 0.80793035f, 0.38595492f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 659004551, 0.23456842f, 0.05472225f, 1710646902);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 50682615, 0.18381494f, 0.23766565f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 103040787, 0.59107786f, 0.24858868f, 802363669);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 1065344188, 0.4555487f, 0.25926095f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 320659097, 0.8501284f, null, 1987528501);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 1989549070, 0.6915906f, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 1787858649, 0.49275833f, 0.98865694f, 811410767);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 1378166183, 0.73554033f, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 1488069543, 0.92399526f, 0.76338756f, 567062694);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 1407566957, 0.4646783f, 0.23041195f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 826970253, 0.72499883f, 0.5185071f, 1738074369);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 819452542, 0.50321245f, 0.1304909f, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 1588591356, 0.37491345f, 0.86672115f, 1549158581);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region Select Models

[Gedaq.MySqlConnector.Attributes.Query(
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
FROM gedaqtests.singlefloat0m m
LEFT JOIN gedaqtests.singlefloat0mi mi ON mi.id = m.singlefloat0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapType: typeof(Singlefloat0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypefloat)
            ),
Gedaq.MySqlConnector.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (MySqlConnector.MySqlDbType)(3)
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
                var models =  ((ISingleSingleTypefloat)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(50682615));
                Assert.That(model.Value, Is.EqualTo(0.18381494f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.23766565f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(83598929));
                Assert.That(model.Value, Is.EqualTo(0.12311053f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.7117326f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(103040787));
                Assert.That(model.Value, Is.EqualTo(0.59107786f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.24858868f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(802363669));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.6469401f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.8756944f));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(143551845));
                Assert.That(model.Value, Is.EqualTo(0.8176923f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.47292697f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(567662818));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.08889812f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.56401855f));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(228096881));
                Assert.That(model.Value, Is.EqualTo(0.13814944f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.33770996f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(319124564));
                Assert.That(model.Value, Is.EqualTo(0.46687317f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1460211824));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.043859243f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.6145832f));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(320659097));
                Assert.That(model.Value, Is.EqualTo(0.8501284f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1987528501));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.42850208f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(439335577));
                Assert.That(model.Value, Is.EqualTo(0.15697163f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.94774723f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(547377260));
                Assert.That(model.Value, Is.EqualTo(0.5655503f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(717272267));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.45653778f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.60086536f));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(553193543));
                Assert.That(model.Value, Is.EqualTo(0.4889586f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8767247f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(18277433));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.76872545f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.5599673f));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(633908708));
                Assert.That(model.Value, Is.EqualTo(0.64114237f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1457850350));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.91278774f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.12912863f));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(659004551));
                Assert.That(model.Value, Is.EqualTo(0.23456842f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.05472225f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1710646902));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.069545865f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.3308617f));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(696678979));
                Assert.That(model.Value, Is.EqualTo(0.74120486f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.36481798f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(819452542));
                Assert.That(model.Value, Is.EqualTo(0.50321245f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.1304909f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(826970253));
                Assert.That(model.Value, Is.EqualTo(0.72499883f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5185071f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1738074369));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.010444045f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(898490349));
                Assert.That(model.Value, Is.EqualTo(0.80793035f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.38595492f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1065344188));
                Assert.That(model.Value, Is.EqualTo(0.4555487f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.25926095f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1098318582));
                Assert.That(model.Value, Is.EqualTo(0.54642874f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.03796792f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1324391498));
                Assert.That(model.Value, Is.EqualTo(0.38201272f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1378166183));
                Assert.That(model.Value, Is.EqualTo(0.73554033f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1407566957));
                Assert.That(model.Value, Is.EqualTo(0.4646783f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.23041195f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1488069543));
                Assert.That(model.Value, Is.EqualTo(0.92399526f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.76338756f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(567062694));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.20810467f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1517217188));
                Assert.That(model.Value, Is.EqualTo(0.8640744f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1588591356));
                Assert.That(model.Value, Is.EqualTo(0.37491345f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.86672115f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1549158581));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8954303f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735114643));
                Assert.That(model.Value, Is.EqualTo(0.7944935f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.494344f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1860927612));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.35319936f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1787858649));
                Assert.That(model.Value, Is.EqualTo(0.49275833f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.98865694f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(811410767));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.12008548f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.02772963f));

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1896191035));
                Assert.That(model.Value, Is.EqualTo(0.06907338f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.44135565f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985538787));
                Assert.That(model.Value, Is.EqualTo(0.3266375f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1970168053));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.82029176f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.3198495f));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1989549070));
                Assert.That(model.Value, Is.EqualTo(0.6915906f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2142537834));
                Assert.That(model.Value, Is.EqualTo(0.02044326f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2084165394));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.08895272f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.22467983f));

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISingleSingleTypefloat)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(50682615));
                Assert.That(model.Value, Is.EqualTo(0.18381494f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.23766565f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(83598929));
                Assert.That(model.Value, Is.EqualTo(0.12311053f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.7117326f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(103040787));
                Assert.That(model.Value, Is.EqualTo(0.59107786f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.24858868f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(802363669));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.6469401f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.8756944f));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(143551845));
                Assert.That(model.Value, Is.EqualTo(0.8176923f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.47292697f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(567662818));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.08889812f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.56401855f));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(228096881));
                Assert.That(model.Value, Is.EqualTo(0.13814944f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.33770996f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(319124564));
                Assert.That(model.Value, Is.EqualTo(0.46687317f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1460211824));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.043859243f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.6145832f));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(320659097));
                Assert.That(model.Value, Is.EqualTo(0.8501284f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1987528501));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.42850208f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(439335577));
                Assert.That(model.Value, Is.EqualTo(0.15697163f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.94774723f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(547377260));
                Assert.That(model.Value, Is.EqualTo(0.5655503f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(717272267));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.45653778f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.60086536f));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(553193543));
                Assert.That(model.Value, Is.EqualTo(0.4889586f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8767247f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(18277433));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.76872545f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.5599673f));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(633908708));
                Assert.That(model.Value, Is.EqualTo(0.64114237f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1457850350));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.91278774f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.12912863f));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(659004551));
                Assert.That(model.Value, Is.EqualTo(0.23456842f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.05472225f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1710646902));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.069545865f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.3308617f));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(696678979));
                Assert.That(model.Value, Is.EqualTo(0.74120486f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.36481798f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(819452542));
                Assert.That(model.Value, Is.EqualTo(0.50321245f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.1304909f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(826970253));
                Assert.That(model.Value, Is.EqualTo(0.72499883f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5185071f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1738074369));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.010444045f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(898490349));
                Assert.That(model.Value, Is.EqualTo(0.80793035f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.38595492f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1065344188));
                Assert.That(model.Value, Is.EqualTo(0.4555487f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.25926095f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1098318582));
                Assert.That(model.Value, Is.EqualTo(0.54642874f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.03796792f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1324391498));
                Assert.That(model.Value, Is.EqualTo(0.38201272f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1378166183));
                Assert.That(model.Value, Is.EqualTo(0.73554033f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1407566957));
                Assert.That(model.Value, Is.EqualTo(0.4646783f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.23041195f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1488069543));
                Assert.That(model.Value, Is.EqualTo(0.92399526f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.76338756f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(567062694));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.20810467f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1517217188));
                Assert.That(model.Value, Is.EqualTo(0.8640744f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1588591356));
                Assert.That(model.Value, Is.EqualTo(0.37491345f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.86672115f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1549158581));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8954303f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735114643));
                Assert.That(model.Value, Is.EqualTo(0.7944935f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.494344f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1860927612));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.35319936f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1787858649));
                Assert.That(model.Value, Is.EqualTo(0.49275833f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.98865694f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(811410767));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.12008548f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.02772963f));

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1896191035));
                Assert.That(model.Value, Is.EqualTo(0.06907338f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.44135565f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985538787));
                Assert.That(model.Value, Is.EqualTo(0.3266375f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1970168053));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.82029176f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.3198495f));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1989549070));
                Assert.That(model.Value, Is.EqualTo(0.6915906f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2142537834));
                Assert.That(model.Value, Is.EqualTo(0.02044326f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2084165394));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.08895272f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.22467983f));

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
FROM gedaqtests.singlefloat0m m
LEFT JOIN gedaqtests.singlefloat0mi mi ON mi.id = m.singlefloat0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(Singlefloat0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypefloat)
            ),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11)
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
                var models =  ((ISingleSingleTypefloat)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(50682615));
                Assert.That(model.Value, Is.EqualTo(0.18381494f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.23766565f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(83598929));
                Assert.That(model.Value, Is.EqualTo(0.12311053f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.7117326f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(103040787));
                Assert.That(model.Value, Is.EqualTo(0.59107786f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.24858868f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(802363669));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.6469401f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.8756944f));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(143551845));
                Assert.That(model.Value, Is.EqualTo(0.8176923f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.47292697f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(567662818));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.08889812f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.56401855f));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(228096881));
                Assert.That(model.Value, Is.EqualTo(0.13814944f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.33770996f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(319124564));
                Assert.That(model.Value, Is.EqualTo(0.46687317f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1460211824));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.043859243f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.6145832f));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(320659097));
                Assert.That(model.Value, Is.EqualTo(0.8501284f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1987528501));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.42850208f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(439335577));
                Assert.That(model.Value, Is.EqualTo(0.15697163f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.94774723f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(547377260));
                Assert.That(model.Value, Is.EqualTo(0.5655503f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(717272267));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.45653778f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.60086536f));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(553193543));
                Assert.That(model.Value, Is.EqualTo(0.4889586f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8767247f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(18277433));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.76872545f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.5599673f));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(633908708));
                Assert.That(model.Value, Is.EqualTo(0.64114237f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1457850350));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.91278774f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.12912863f));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(659004551));
                Assert.That(model.Value, Is.EqualTo(0.23456842f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.05472225f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1710646902));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.069545865f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.3308617f));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(696678979));
                Assert.That(model.Value, Is.EqualTo(0.74120486f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.36481798f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(819452542));
                Assert.That(model.Value, Is.EqualTo(0.50321245f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.1304909f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(826970253));
                Assert.That(model.Value, Is.EqualTo(0.72499883f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5185071f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1738074369));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.010444045f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(898490349));
                Assert.That(model.Value, Is.EqualTo(0.80793035f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.38595492f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1065344188));
                Assert.That(model.Value, Is.EqualTo(0.4555487f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.25926095f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1098318582));
                Assert.That(model.Value, Is.EqualTo(0.54642874f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.03796792f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1324391498));
                Assert.That(model.Value, Is.EqualTo(0.38201272f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1378166183));
                Assert.That(model.Value, Is.EqualTo(0.73554033f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1407566957));
                Assert.That(model.Value, Is.EqualTo(0.4646783f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.23041195f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1488069543));
                Assert.That(model.Value, Is.EqualTo(0.92399526f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.76338756f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(567062694));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.20810467f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1517217188));
                Assert.That(model.Value, Is.EqualTo(0.8640744f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1588591356));
                Assert.That(model.Value, Is.EqualTo(0.37491345f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.86672115f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1549158581));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8954303f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735114643));
                Assert.That(model.Value, Is.EqualTo(0.7944935f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.494344f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1860927612));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.35319936f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1787858649));
                Assert.That(model.Value, Is.EqualTo(0.49275833f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.98865694f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(811410767));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.12008548f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.02772963f));

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1896191035));
                Assert.That(model.Value, Is.EqualTo(0.06907338f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.44135565f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985538787));
                Assert.That(model.Value, Is.EqualTo(0.3266375f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1970168053));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.82029176f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.3198495f));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1989549070));
                Assert.That(model.Value, Is.EqualTo(0.6915906f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2142537834));
                Assert.That(model.Value, Is.EqualTo(0.02044326f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2084165394));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.08895272f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.22467983f));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISingleSingleTypefloat)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(50682615));
                Assert.That(model.Value, Is.EqualTo(0.18381494f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.23766565f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(83598929));
                Assert.That(model.Value, Is.EqualTo(0.12311053f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.7117326f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(103040787));
                Assert.That(model.Value, Is.EqualTo(0.59107786f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.24858868f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(802363669));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.6469401f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.8756944f));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(143551845));
                Assert.That(model.Value, Is.EqualTo(0.8176923f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.47292697f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(567662818));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.08889812f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.56401855f));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(228096881));
                Assert.That(model.Value, Is.EqualTo(0.13814944f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.33770996f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(319124564));
                Assert.That(model.Value, Is.EqualTo(0.46687317f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1460211824));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.043859243f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.6145832f));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(320659097));
                Assert.That(model.Value, Is.EqualTo(0.8501284f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1987528501));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.42850208f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(439335577));
                Assert.That(model.Value, Is.EqualTo(0.15697163f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.94774723f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(547377260));
                Assert.That(model.Value, Is.EqualTo(0.5655503f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(717272267));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.45653778f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.60086536f));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(553193543));
                Assert.That(model.Value, Is.EqualTo(0.4889586f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8767247f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(18277433));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.76872545f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.5599673f));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(633908708));
                Assert.That(model.Value, Is.EqualTo(0.64114237f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1457850350));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.91278774f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.12912863f));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(659004551));
                Assert.That(model.Value, Is.EqualTo(0.23456842f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.05472225f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1710646902));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.069545865f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.3308617f));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(696678979));
                Assert.That(model.Value, Is.EqualTo(0.74120486f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.36481798f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(819452542));
                Assert.That(model.Value, Is.EqualTo(0.50321245f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.1304909f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(826970253));
                Assert.That(model.Value, Is.EqualTo(0.72499883f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5185071f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1738074369));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.010444045f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(898490349));
                Assert.That(model.Value, Is.EqualTo(0.80793035f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.38595492f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1065344188));
                Assert.That(model.Value, Is.EqualTo(0.4555487f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.25926095f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1098318582));
                Assert.That(model.Value, Is.EqualTo(0.54642874f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.03796792f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1324391498));
                Assert.That(model.Value, Is.EqualTo(0.38201272f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1378166183));
                Assert.That(model.Value, Is.EqualTo(0.73554033f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1407566957));
                Assert.That(model.Value, Is.EqualTo(0.4646783f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.23041195f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1488069543));
                Assert.That(model.Value, Is.EqualTo(0.92399526f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.76338756f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(567062694));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.20810467f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1517217188));
                Assert.That(model.Value, Is.EqualTo(0.8640744f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1588591356));
                Assert.That(model.Value, Is.EqualTo(0.37491345f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.86672115f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1549158581));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8954303f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735114643));
                Assert.That(model.Value, Is.EqualTo(0.7944935f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.494344f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1860927612));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.35319936f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1787858649));
                Assert.That(model.Value, Is.EqualTo(0.49275833f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.98865694f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(811410767));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.12008548f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.02772963f));

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1896191035));
                Assert.That(model.Value, Is.EqualTo(0.06907338f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.44135565f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985538787));
                Assert.That(model.Value, Is.EqualTo(0.3266375f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1970168053));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.82029176f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.3198495f));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1989549070));
                Assert.That(model.Value, Is.EqualTo(0.6915906f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2142537834));
                Assert.That(model.Value, Is.EqualTo(0.02044326f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2084165394));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.08895272f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.22467983f));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleSingleTypefloat)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleSingleTypefloat)this).SetDbConnectionSelectModelParametrs(cmd, 1324391498);
                var models =  ((ISingleSingleTypefloat)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(11));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1378166183));
                Assert.That(model.Value, Is.EqualTo(0.73554033f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1407566957));
                Assert.That(model.Value, Is.EqualTo(0.4646783f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.23041195f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1488069543));
                Assert.That(model.Value, Is.EqualTo(0.92399526f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.76338756f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(567062694));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.20810467f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1517217188));
                Assert.That(model.Value, Is.EqualTo(0.8640744f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1588591356));
                Assert.That(model.Value, Is.EqualTo(0.37491345f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.86672115f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1549158581));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8954303f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735114643));
                Assert.That(model.Value, Is.EqualTo(0.7944935f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.494344f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1860927612));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.35319936f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1787858649));
                Assert.That(model.Value, Is.EqualTo(0.49275833f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.98865694f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(811410767));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.12008548f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.02772963f));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1896191035));
                Assert.That(model.Value, Is.EqualTo(0.06907338f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.44135565f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985538787));
                Assert.That(model.Value, Is.EqualTo(0.3266375f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1970168053));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.82029176f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.3198495f));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1989549070));
                Assert.That(model.Value, Is.EqualTo(0.6915906f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2142537834));
                Assert.That(model.Value, Is.EqualTo(0.02044326f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2084165394));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.08895272f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.22467983f));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((ISingleSingleTypefloat)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ISingleSingleTypefloat)this).SetDbConnectionSelectModelParametrs(cmd, 1098318582);
                var models = await ((ISingleSingleTypefloat)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(12));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1324391498));
                Assert.That(model.Value, Is.EqualTo(0.38201272f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1378166183));
                Assert.That(model.Value, Is.EqualTo(0.73554033f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1407566957));
                Assert.That(model.Value, Is.EqualTo(0.4646783f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.23041195f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1488069543));
                Assert.That(model.Value, Is.EqualTo(0.92399526f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.76338756f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(567062694));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.20810467f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1517217188));
                Assert.That(model.Value, Is.EqualTo(0.8640744f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1588591356));
                Assert.That(model.Value, Is.EqualTo(0.37491345f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.86672115f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1549158581));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8954303f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735114643));
                Assert.That(model.Value, Is.EqualTo(0.7944935f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.494344f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1860927612));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.35319936f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1787858649));
                Assert.That(model.Value, Is.EqualTo(0.49275833f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.98865694f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(811410767));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.12008548f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.02772963f));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1896191035));
                Assert.That(model.Value, Is.EqualTo(0.06907338f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.44135565f));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985538787));
                Assert.That(model.Value, Is.EqualTo(0.3266375f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1970168053));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.82029176f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.3198495f));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1989549070));
                Assert.That(model.Value, Is.EqualTo(0.6915906f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2142537834));
                Assert.That(model.Value, Is.EqualTo(0.02044326f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2084165394));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.08895272f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.22467983f));

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypefloat)
            ),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1
            ),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2
            )
            ]
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                 foreach(var batchResult in ((ISingleSingleTypefloat)this).DbConnectionSelectModelBatch(connection, 143551845, 1985538787))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(26));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(228096881));
                Assert.That(model.Value, Is.EqualTo(0.13814944f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.33770996f));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(319124564));
                Assert.That(model.Value, Is.EqualTo(0.46687317f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1460211824));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.043859243f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.6145832f));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(320659097));
                Assert.That(model.Value, Is.EqualTo(0.8501284f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1987528501));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.42850208f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(439335577));
                Assert.That(model.Value, Is.EqualTo(0.15697163f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.94774723f));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(547377260));
                Assert.That(model.Value, Is.EqualTo(0.5655503f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(717272267));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.45653778f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.60086536f));

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(553193543));
                Assert.That(model.Value, Is.EqualTo(0.4889586f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8767247f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(18277433));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.76872545f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.5599673f));

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(633908708));
                Assert.That(model.Value, Is.EqualTo(0.64114237f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1457850350));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.91278774f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.12912863f));

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(659004551));
                Assert.That(model.Value, Is.EqualTo(0.23456842f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.05472225f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1710646902));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.069545865f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.3308617f));

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(696678979));
                Assert.That(model.Value, Is.EqualTo(0.74120486f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.36481798f));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(819452542));
                Assert.That(model.Value, Is.EqualTo(0.50321245f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.1304909f));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(826970253));
                Assert.That(model.Value, Is.EqualTo(0.72499883f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5185071f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1738074369));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.010444045f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(898490349));
                Assert.That(model.Value, Is.EqualTo(0.80793035f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.38595492f));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1065344188));
                Assert.That(model.Value, Is.EqualTo(0.4555487f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.25926095f));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1098318582));
                Assert.That(model.Value, Is.EqualTo(0.54642874f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.03796792f));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1324391498));
                Assert.That(model.Value, Is.EqualTo(0.38201272f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1378166183));
                Assert.That(model.Value, Is.EqualTo(0.73554033f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1407566957));
                Assert.That(model.Value, Is.EqualTo(0.4646783f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.23041195f));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1488069543));
                Assert.That(model.Value, Is.EqualTo(0.92399526f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.76338756f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(567062694));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.20810467f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1517217188));
                Assert.That(model.Value, Is.EqualTo(0.8640744f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1588591356));
                Assert.That(model.Value, Is.EqualTo(0.37491345f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.86672115f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1549158581));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8954303f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735114643));
                Assert.That(model.Value, Is.EqualTo(0.7944935f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.494344f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1860927612));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.35319936f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1787858649));
                Assert.That(model.Value, Is.EqualTo(0.49275833f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.98865694f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(811410767));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.12008548f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.02772963f));

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1896191035));
                Assert.That(model.Value, Is.EqualTo(0.06907338f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.44135565f));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[23];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985538787));
                Assert.That(model.Value, Is.EqualTo(0.3266375f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1970168053));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.82029176f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.3198495f));

                        model = models[24];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1989549070));
                Assert.That(model.Value, Is.EqualTo(0.6915906f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[25];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2142537834));
                Assert.That(model.Value, Is.EqualTo(0.02044326f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2084165394));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.08895272f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.22467983f));

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(2));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1989549070));
                Assert.That(model.Value, Is.EqualTo(0.6915906f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2142537834));
                Assert.That(model.Value, Is.EqualTo(0.02044326f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2084165394));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.08895272f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.22467983f));

                        continue;
                    }
                    
                    //todo return false
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                await foreach(var batchResult in ((ISingleSingleTypefloat)this).DbConnectionSelectModelBatchAsync(connection, 1517217188, 83598929))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(7));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1588591356));
                Assert.That(model.Value, Is.EqualTo(0.37491345f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.86672115f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1549158581));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8954303f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735114643));
                Assert.That(model.Value, Is.EqualTo(0.7944935f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.494344f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1860927612));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.35319936f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1787858649));
                Assert.That(model.Value, Is.EqualTo(0.49275833f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.98865694f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(811410767));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.12008548f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.02772963f));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1896191035));
                Assert.That(model.Value, Is.EqualTo(0.06907338f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.44135565f));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985538787));
                Assert.That(model.Value, Is.EqualTo(0.3266375f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1970168053));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.82029176f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.3198495f));

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1989549070));
                Assert.That(model.Value, Is.EqualTo(0.6915906f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2142537834));
                Assert.That(model.Value, Is.EqualTo(0.02044326f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2084165394));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.08895272f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.22467983f));

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(28));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(103040787));
                Assert.That(model.Value, Is.EqualTo(0.59107786f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.24858868f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(802363669));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.6469401f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.8756944f));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(143551845));
                Assert.That(model.Value, Is.EqualTo(0.8176923f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.47292697f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(567662818));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.08889812f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.56401855f));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(228096881));
                Assert.That(model.Value, Is.EqualTo(0.13814944f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.33770996f));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(319124564));
                Assert.That(model.Value, Is.EqualTo(0.46687317f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1460211824));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.043859243f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.6145832f));

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(320659097));
                Assert.That(model.Value, Is.EqualTo(0.8501284f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1987528501));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.42850208f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(439335577));
                Assert.That(model.Value, Is.EqualTo(0.15697163f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.94774723f));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(547377260));
                Assert.That(model.Value, Is.EqualTo(0.5655503f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(717272267));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.45653778f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.60086536f));

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(553193543));
                Assert.That(model.Value, Is.EqualTo(0.4889586f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.8767247f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(18277433));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.76872545f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.5599673f));

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(633908708));
                Assert.That(model.Value, Is.EqualTo(0.64114237f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1457850350));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.91278774f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.12912863f));

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(659004551));
                Assert.That(model.Value, Is.EqualTo(0.23456842f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.05472225f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1710646902));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.069545865f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.3308617f));

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(696678979));
                Assert.That(model.Value, Is.EqualTo(0.74120486f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.36481798f));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(819452542));
                Assert.That(model.Value, Is.EqualTo(0.50321245f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.1304909f));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(826970253));
                Assert.That(model.Value, Is.EqualTo(0.72499883f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5185071f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1738074369));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.010444045f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(898490349));
                Assert.That(model.Value, Is.EqualTo(0.80793035f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.38595492f));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1065344188));
                Assert.That(model.Value, Is.EqualTo(0.4555487f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.25926095f));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1098318582));
                Assert.That(model.Value, Is.EqualTo(0.54642874f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.03796792f));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1324391498));
                Assert.That(model.Value, Is.EqualTo(0.38201272f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1378166183));
                Assert.That(model.Value, Is.EqualTo(0.73554033f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1407566957));
                Assert.That(model.Value, Is.EqualTo(0.4646783f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.23041195f));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1488069543));
                Assert.That(model.Value, Is.EqualTo(0.92399526f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.76338756f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(567062694));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.20810467f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1517217188));
                Assert.That(model.Value, Is.EqualTo(0.8640744f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1588591356));
                Assert.That(model.Value, Is.EqualTo(0.37491345f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.86672115f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1549158581));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8954303f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1735114643));
                Assert.That(model.Value, Is.EqualTo(0.7944935f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.494344f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1860927612));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.35319936f));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[23];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1787858649));
                Assert.That(model.Value, Is.EqualTo(0.49275833f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.98865694f));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(811410767));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.12008548f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.02772963f));

                        model = models[24];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1896191035));
                Assert.That(model.Value, Is.EqualTo(0.06907338f));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.44135565f));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[25];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985538787));
                Assert.That(model.Value, Is.EqualTo(0.3266375f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1970168053));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.82029176f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.3198495f));

                        model = models[26];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1989549070));
                Assert.That(model.Value, Is.EqualTo(0.6915906f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[27];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2142537834));
                Assert.That(model.Value, Is.EqualTo(0.02044326f));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2084165394));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.08895272f));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.22467983f));

                        continue;
                    }
                    
                    //todo return false
                }
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
FROM gedaqtests.singlefloat0m m
LEFT JOIN gedaqtests.singlefloat0mi mi ON mi.id = m.singlefloat0mi_id
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
            asPartInterface: typeof(ISingleSingleTypefloat)
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
                var models =  ((ISingleSingleTypefloat)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50682615)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.18381494f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.23766565f)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83598929)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.12311053f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.7117326f)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103040787)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.59107786f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((802363669)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.6469401f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.8756944f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.24858868f)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143551845)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8176923f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((567662818)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.08889812f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.56401855f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.47292697f)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((228096881)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.13814944f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.33770996f)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((319124564)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.46687317f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1460211824)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.043859243f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.6145832f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((320659097)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8501284f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1987528501)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.42850208f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((439335577)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.15697163f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.94774723f)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((547377260)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5655503f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((717272267)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.45653778f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.60086536f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((553193543)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4889586f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18277433)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.76872545f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.5599673f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.8767247f)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((633908708)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.64114237f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1457850350)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.91278774f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.12912863f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((659004551)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.23456842f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1710646902)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.069545865f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.3308617f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.05472225f)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((696678979)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.74120486f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.36481798f)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((819452542)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.50321245f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.1304909f)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((826970253)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.72499883f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1738074369)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.010444045f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5185071f)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((898490349)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.80793035f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.38595492f)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1065344188)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4555487f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.25926095f)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1098318582)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.54642874f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.03796792f)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1324391498)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.38201272f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1378166183)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.73554033f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1407566957)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4646783f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.23041195f)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1488069543)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.92399526f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((567062694)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.20810467f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.76338756f)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1517217188)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8640744f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1588591356)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.37491345f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1549158581)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.8954303f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.86672115f)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1735114643)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7944935f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1860927612)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.35319936f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.494344f)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1787858649)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.49275833f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((811410767)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.12008548f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.02772963f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.98865694f)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1896191035)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.06907338f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.44135565f)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1985538787)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.3266375f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1970168053)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.82029176f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.3198495f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1989549070)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6915906f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2142537834)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.02044326f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2084165394)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.08895272f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.22467983f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISingleSingleTypefloat)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50682615)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.18381494f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.23766565f)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83598929)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.12311053f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.7117326f)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103040787)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.59107786f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((802363669)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.6469401f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.8756944f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.24858868f)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143551845)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8176923f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((567662818)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.08889812f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.56401855f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.47292697f)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((228096881)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.13814944f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.33770996f)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((319124564)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.46687317f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1460211824)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.043859243f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.6145832f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((320659097)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8501284f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1987528501)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.42850208f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((439335577)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.15697163f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.94774723f)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((547377260)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5655503f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((717272267)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.45653778f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.60086536f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((553193543)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4889586f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18277433)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.76872545f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.5599673f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.8767247f)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((633908708)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.64114237f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1457850350)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.91278774f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.12912863f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((659004551)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.23456842f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1710646902)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.069545865f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.3308617f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.05472225f)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((696678979)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.74120486f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.36481798f)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((819452542)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.50321245f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.1304909f)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((826970253)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.72499883f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1738074369)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.010444045f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5185071f)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((898490349)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.80793035f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.38595492f)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1065344188)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4555487f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.25926095f)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1098318582)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.54642874f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.03796792f)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1324391498)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.38201272f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1378166183)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.73554033f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1407566957)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4646783f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.23041195f)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1488069543)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.92399526f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((567062694)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.20810467f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.76338756f)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1517217188)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8640744f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1588591356)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.37491345f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1549158581)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.8954303f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.86672115f)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1735114643)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7944935f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1860927612)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.35319936f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.494344f)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1787858649)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.49275833f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((811410767)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.12008548f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.02772963f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.98865694f)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1896191035)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.06907338f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.44135565f)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1985538787)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.3266375f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1970168053)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.82029176f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.3198495f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1989549070)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6915906f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2142537834)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.02044326f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2084165394)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.08895272f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.22467983f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        #endregion

    }
}

