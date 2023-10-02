

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
    internal partial interface IInt32SingleTypeint
    {
    }
    
    internal partial class Int32SingleTypeint : IInt32SingleTypeint
    {


#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int32int0mi(
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
            asPartInterface: typeof(IInt32SingleTypeint)
            ), 
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)
                ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (MySqlConnector.MySqlDbType)(3)
                ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (MySqlConnector.MySqlDbType)(3)
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

                changedRows =  ((IInt32SingleTypeint)this).InsertModelInner(connection, 1740058563, 586083756, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt32SingleTypeint)this).InsertModelInner(connection, 820326032, 465804602, 194135691);
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

                changedRows = await ((IInt32SingleTypeint)this).InsertModelInnerAsync(connection, 1606689878, 74439911, 492516260);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).InsertModelInnerAsync(connection, 1052359036, 2010708022, null);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int32int0mi(
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
            asPartInterface: typeof(IInt32SingleTypeint)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(11)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(11), 
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

                changedRows =  ((IInt32SingleTypeint)this).DbConnectionInsertInnerModel(connection, 387436912, 744819855, null);
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

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, 1056156475, 2065060019, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, 1762229129, 67639814, 691217647);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, 1492825485, 476515763, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, 593935053, 975591364, 726603318);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, 163955125, 1089250931, 2077522905);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, 519545898, 1656856433, 1894598940);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, 1587591378, 774662410, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, 279334757, 709383221, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, 1894451883, 835489407, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, 1537519019, 1475453706, null);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int32int0m(
	id,
    value,
    nullablevalue,
    int32int0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int32int0mi_id
)
",
            methodName:"InsertModel",
            sourceType: SourceType.MySqlConnection,
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)
            ), 
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)
            ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (MySqlConnector.MySqlDbType)(3)
            ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (MySqlConnector.MySqlDbType)(3),
                nullable: true
            ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int32int0mi_id", 
                methodParametrName: "int32int0mi_id", 
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

                changedRows =  ((IInt32SingleTypeint)this).InsertModel(connection, 70257282, 1659443785, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt32SingleTypeint)this).InsertModel(connection, 1154224892, 1484850154, null, 1740058563);
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

                changedRows = await ((IInt32SingleTypeint)this).InsertModelAsync(connection, 1957715961, 1439852000, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).InsertModelAsync(connection, 1196733011, 643103462, 712728105, 820326032);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int32int0m(
	id,
    value,
    nullablevalue,
    int32int0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int32int0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(11),
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int32int0mi_id", 
                methodParametrName: "int32int0mi_id", 
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

                changedRows =  ((IInt32SingleTypeint)this).DbConnectionInsertModel(connection, 1588978310, 1767680455, 1263339959, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt32SingleTypeint)this).DbConnectionInsertModel(connection, 57537566, 1121506148, null, 1606689878);
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

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 778982372, 1536722186, 2082375491, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 1782213419, 128186402, 1152041431, 1052359036);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 2097742364, 1619539449, 772148004, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 450282542, 1946427216, null, 387436912);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 1948847728, 2005939014, 333137506, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 1657963789, 850239673, null, 1056156475);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 1084107413, 516177153, 4206956, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 1970406666, 1018209414, null, 1762229129);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 185448934, 405694002, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 1652048155, 1117618902, null, 1492825485);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 1992896861, 413865579, 2031917069, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 2035239286, 1962082811, 192725514, 593935053);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 2097707965, 468950198, 2080032176, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 381425317, 2055958548, 1130666863, 163955125);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 1613328142, 1623074317, 519541461, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 1580982536, 1616377517, 958403169, 519545898);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 1255500287, 863598879, 5160093, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 862686080, 627545552, 1965179125, 1587591378);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 1927722123, 811643804, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 1429672403, 1921686944, null, 279334757);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 338758550, 913989440, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 1070454301, 988164950, null, 1894451883);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 1982848614, 1271489996, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, 1528972782, 18306667, 1309235683, 1537519019);
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
FROM gedaqtests.int32int0m m
LEFT JOIN gedaqtests.int32int0mi mi ON mi.id = m.int32int0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapType: typeof(Int32int0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)
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
                var models =  ((IInt32SingleTypeint)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(57537566));
                Assert.That(model.Value, Is.EqualTo(1121506148));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1606689878));

                Assert.That(model.ModelInner.Value, Is.EqualTo(74439911));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(492516260));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(70257282));
                Assert.That(model.Value, Is.EqualTo(1659443785));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(185448934));
                Assert.That(model.Value, Is.EqualTo(405694002));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(338758550));
                Assert.That(model.Value, Is.EqualTo(913989440));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(381425317));
                Assert.That(model.Value, Is.EqualTo(2055958548));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1130666863));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(163955125));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1089250931));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(2077522905));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(450282542));
                Assert.That(model.Value, Is.EqualTo(1946427216));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(387436912));

                Assert.That(model.ModelInner.Value, Is.EqualTo(744819855));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(778982372));
                Assert.That(model.Value, Is.EqualTo(1536722186));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2082375491));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(862686080));
                Assert.That(model.Value, Is.EqualTo(627545552));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1965179125));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1587591378));

                Assert.That(model.ModelInner.Value, Is.EqualTo(774662410));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1070454301));
                Assert.That(model.Value, Is.EqualTo(988164950));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1894451883));

                Assert.That(model.ModelInner.Value, Is.EqualTo(835489407));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1084107413));
                Assert.That(model.Value, Is.EqualTo(516177153));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(4206956));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1154224892));
                Assert.That(model.Value, Is.EqualTo(1484850154));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1740058563));

                Assert.That(model.ModelInner.Value, Is.EqualTo(586083756));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1196733011));
                Assert.That(model.Value, Is.EqualTo(643103462));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(712728105));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(820326032));

                Assert.That(model.ModelInner.Value, Is.EqualTo(465804602));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(194135691));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1255500287));
                Assert.That(model.Value, Is.EqualTo(863598879));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5160093));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1429672403));
                Assert.That(model.Value, Is.EqualTo(1921686944));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(279334757));

                Assert.That(model.ModelInner.Value, Is.EqualTo(709383221));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1528972782));
                Assert.That(model.Value, Is.EqualTo(18306667));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1309235683));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1537519019));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1475453706));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1580982536));
                Assert.That(model.Value, Is.EqualTo(1616377517));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(958403169));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(519545898));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1656856433));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1894598940));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1588978310));
                Assert.That(model.Value, Is.EqualTo(1767680455));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1263339959));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1613328142));
                Assert.That(model.Value, Is.EqualTo(1623074317));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(519541461));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1652048155));
                Assert.That(model.Value, Is.EqualTo(1117618902));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1492825485));

                Assert.That(model.ModelInner.Value, Is.EqualTo(476515763));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1657963789));
                Assert.That(model.Value, Is.EqualTo(850239673));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1056156475));

                Assert.That(model.ModelInner.Value, Is.EqualTo(2065060019));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1782213419));
                Assert.That(model.Value, Is.EqualTo(128186402));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1152041431));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1052359036));

                Assert.That(model.ModelInner.Value, Is.EqualTo(2010708022));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1927722123));
                Assert.That(model.Value, Is.EqualTo(811643804));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1948847728));
                Assert.That(model.Value, Is.EqualTo(2005939014));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(333137506));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1957715961));
                Assert.That(model.Value, Is.EqualTo(1439852000));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1970406666));
                Assert.That(model.Value, Is.EqualTo(1018209414));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1762229129));

                Assert.That(model.ModelInner.Value, Is.EqualTo(67639814));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(691217647));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1982848614));
                Assert.That(model.Value, Is.EqualTo(1271489996));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1992896861));
                Assert.That(model.Value, Is.EqualTo(413865579));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2031917069));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2035239286));
                Assert.That(model.Value, Is.EqualTo(1962082811));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(192725514));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(593935053));

                Assert.That(model.ModelInner.Value, Is.EqualTo(975591364));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(726603318));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2097707965));
                Assert.That(model.Value, Is.EqualTo(468950198));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2080032176));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2097742364));
                Assert.That(model.Value, Is.EqualTo(1619539449));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(772148004));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt32SingleTypeint)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(57537566));
                Assert.That(model.Value, Is.EqualTo(1121506148));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1606689878));

                Assert.That(model.ModelInner.Value, Is.EqualTo(74439911));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(492516260));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(70257282));
                Assert.That(model.Value, Is.EqualTo(1659443785));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(185448934));
                Assert.That(model.Value, Is.EqualTo(405694002));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(338758550));
                Assert.That(model.Value, Is.EqualTo(913989440));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(381425317));
                Assert.That(model.Value, Is.EqualTo(2055958548));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1130666863));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(163955125));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1089250931));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(2077522905));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(450282542));
                Assert.That(model.Value, Is.EqualTo(1946427216));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(387436912));

                Assert.That(model.ModelInner.Value, Is.EqualTo(744819855));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(778982372));
                Assert.That(model.Value, Is.EqualTo(1536722186));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2082375491));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(862686080));
                Assert.That(model.Value, Is.EqualTo(627545552));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1965179125));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1587591378));

                Assert.That(model.ModelInner.Value, Is.EqualTo(774662410));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1070454301));
                Assert.That(model.Value, Is.EqualTo(988164950));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1894451883));

                Assert.That(model.ModelInner.Value, Is.EqualTo(835489407));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1084107413));
                Assert.That(model.Value, Is.EqualTo(516177153));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(4206956));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1154224892));
                Assert.That(model.Value, Is.EqualTo(1484850154));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1740058563));

                Assert.That(model.ModelInner.Value, Is.EqualTo(586083756));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1196733011));
                Assert.That(model.Value, Is.EqualTo(643103462));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(712728105));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(820326032));

                Assert.That(model.ModelInner.Value, Is.EqualTo(465804602));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(194135691));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1255500287));
                Assert.That(model.Value, Is.EqualTo(863598879));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5160093));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1429672403));
                Assert.That(model.Value, Is.EqualTo(1921686944));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(279334757));

                Assert.That(model.ModelInner.Value, Is.EqualTo(709383221));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1528972782));
                Assert.That(model.Value, Is.EqualTo(18306667));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1309235683));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1537519019));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1475453706));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1580982536));
                Assert.That(model.Value, Is.EqualTo(1616377517));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(958403169));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(519545898));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1656856433));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1894598940));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1588978310));
                Assert.That(model.Value, Is.EqualTo(1767680455));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1263339959));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1613328142));
                Assert.That(model.Value, Is.EqualTo(1623074317));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(519541461));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1652048155));
                Assert.That(model.Value, Is.EqualTo(1117618902));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1492825485));

                Assert.That(model.ModelInner.Value, Is.EqualTo(476515763));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1657963789));
                Assert.That(model.Value, Is.EqualTo(850239673));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1056156475));

                Assert.That(model.ModelInner.Value, Is.EqualTo(2065060019));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1782213419));
                Assert.That(model.Value, Is.EqualTo(128186402));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1152041431));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1052359036));

                Assert.That(model.ModelInner.Value, Is.EqualTo(2010708022));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1927722123));
                Assert.That(model.Value, Is.EqualTo(811643804));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1948847728));
                Assert.That(model.Value, Is.EqualTo(2005939014));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(333137506));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1957715961));
                Assert.That(model.Value, Is.EqualTo(1439852000));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1970406666));
                Assert.That(model.Value, Is.EqualTo(1018209414));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1762229129));

                Assert.That(model.ModelInner.Value, Is.EqualTo(67639814));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(691217647));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1982848614));
                Assert.That(model.Value, Is.EqualTo(1271489996));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1992896861));
                Assert.That(model.Value, Is.EqualTo(413865579));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2031917069));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2035239286));
                Assert.That(model.Value, Is.EqualTo(1962082811));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(192725514));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(593935053));

                Assert.That(model.ModelInner.Value, Is.EqualTo(975591364));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(726603318));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2097707965));
                Assert.That(model.Value, Is.EqualTo(468950198));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2080032176));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2097742364));
                Assert.That(model.Value, Is.EqualTo(1619539449));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(772148004));

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
FROM gedaqtests.int32int0m m
LEFT JOIN gedaqtests.int32int0mi mi ON mi.id = m.int32int0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(Int32int0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)
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
                var models =  ((IInt32SingleTypeint)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(57537566));
                Assert.That(model.Value, Is.EqualTo(1121506148));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1606689878));

                Assert.That(model.ModelInner.Value, Is.EqualTo(74439911));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(492516260));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(70257282));
                Assert.That(model.Value, Is.EqualTo(1659443785));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(185448934));
                Assert.That(model.Value, Is.EqualTo(405694002));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(338758550));
                Assert.That(model.Value, Is.EqualTo(913989440));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(381425317));
                Assert.That(model.Value, Is.EqualTo(2055958548));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1130666863));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(163955125));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1089250931));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(2077522905));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(450282542));
                Assert.That(model.Value, Is.EqualTo(1946427216));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(387436912));

                Assert.That(model.ModelInner.Value, Is.EqualTo(744819855));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(778982372));
                Assert.That(model.Value, Is.EqualTo(1536722186));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2082375491));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(862686080));
                Assert.That(model.Value, Is.EqualTo(627545552));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1965179125));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1587591378));

                Assert.That(model.ModelInner.Value, Is.EqualTo(774662410));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1070454301));
                Assert.That(model.Value, Is.EqualTo(988164950));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1894451883));

                Assert.That(model.ModelInner.Value, Is.EqualTo(835489407));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1084107413));
                Assert.That(model.Value, Is.EqualTo(516177153));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(4206956));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1154224892));
                Assert.That(model.Value, Is.EqualTo(1484850154));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1740058563));

                Assert.That(model.ModelInner.Value, Is.EqualTo(586083756));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1196733011));
                Assert.That(model.Value, Is.EqualTo(643103462));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(712728105));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(820326032));

                Assert.That(model.ModelInner.Value, Is.EqualTo(465804602));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(194135691));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1255500287));
                Assert.That(model.Value, Is.EqualTo(863598879));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5160093));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1429672403));
                Assert.That(model.Value, Is.EqualTo(1921686944));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(279334757));

                Assert.That(model.ModelInner.Value, Is.EqualTo(709383221));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1528972782));
                Assert.That(model.Value, Is.EqualTo(18306667));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1309235683));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1537519019));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1475453706));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1580982536));
                Assert.That(model.Value, Is.EqualTo(1616377517));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(958403169));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(519545898));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1656856433));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1894598940));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1588978310));
                Assert.That(model.Value, Is.EqualTo(1767680455));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1263339959));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1613328142));
                Assert.That(model.Value, Is.EqualTo(1623074317));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(519541461));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1652048155));
                Assert.That(model.Value, Is.EqualTo(1117618902));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1492825485));

                Assert.That(model.ModelInner.Value, Is.EqualTo(476515763));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1657963789));
                Assert.That(model.Value, Is.EqualTo(850239673));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1056156475));

                Assert.That(model.ModelInner.Value, Is.EqualTo(2065060019));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1782213419));
                Assert.That(model.Value, Is.EqualTo(128186402));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1152041431));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1052359036));

                Assert.That(model.ModelInner.Value, Is.EqualTo(2010708022));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1927722123));
                Assert.That(model.Value, Is.EqualTo(811643804));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1948847728));
                Assert.That(model.Value, Is.EqualTo(2005939014));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(333137506));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1957715961));
                Assert.That(model.Value, Is.EqualTo(1439852000));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1970406666));
                Assert.That(model.Value, Is.EqualTo(1018209414));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1762229129));

                Assert.That(model.ModelInner.Value, Is.EqualTo(67639814));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(691217647));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1982848614));
                Assert.That(model.Value, Is.EqualTo(1271489996));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1992896861));
                Assert.That(model.Value, Is.EqualTo(413865579));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2031917069));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2035239286));
                Assert.That(model.Value, Is.EqualTo(1962082811));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(192725514));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(593935053));

                Assert.That(model.ModelInner.Value, Is.EqualTo(975591364));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(726603318));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2097707965));
                Assert.That(model.Value, Is.EqualTo(468950198));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2080032176));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2097742364));
                Assert.That(model.Value, Is.EqualTo(1619539449));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(772148004));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt32SingleTypeint)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(57537566));
                Assert.That(model.Value, Is.EqualTo(1121506148));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1606689878));

                Assert.That(model.ModelInner.Value, Is.EqualTo(74439911));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(492516260));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(70257282));
                Assert.That(model.Value, Is.EqualTo(1659443785));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(185448934));
                Assert.That(model.Value, Is.EqualTo(405694002));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(338758550));
                Assert.That(model.Value, Is.EqualTo(913989440));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(381425317));
                Assert.That(model.Value, Is.EqualTo(2055958548));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1130666863));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(163955125));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1089250931));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(2077522905));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(450282542));
                Assert.That(model.Value, Is.EqualTo(1946427216));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(387436912));

                Assert.That(model.ModelInner.Value, Is.EqualTo(744819855));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(778982372));
                Assert.That(model.Value, Is.EqualTo(1536722186));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2082375491));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(862686080));
                Assert.That(model.Value, Is.EqualTo(627545552));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1965179125));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1587591378));

                Assert.That(model.ModelInner.Value, Is.EqualTo(774662410));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1070454301));
                Assert.That(model.Value, Is.EqualTo(988164950));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1894451883));

                Assert.That(model.ModelInner.Value, Is.EqualTo(835489407));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1084107413));
                Assert.That(model.Value, Is.EqualTo(516177153));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(4206956));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1154224892));
                Assert.That(model.Value, Is.EqualTo(1484850154));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1740058563));

                Assert.That(model.ModelInner.Value, Is.EqualTo(586083756));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1196733011));
                Assert.That(model.Value, Is.EqualTo(643103462));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(712728105));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(820326032));

                Assert.That(model.ModelInner.Value, Is.EqualTo(465804602));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(194135691));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1255500287));
                Assert.That(model.Value, Is.EqualTo(863598879));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5160093));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1429672403));
                Assert.That(model.Value, Is.EqualTo(1921686944));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(279334757));

                Assert.That(model.ModelInner.Value, Is.EqualTo(709383221));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1528972782));
                Assert.That(model.Value, Is.EqualTo(18306667));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1309235683));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1537519019));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1475453706));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1580982536));
                Assert.That(model.Value, Is.EqualTo(1616377517));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(958403169));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(519545898));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1656856433));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1894598940));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1588978310));
                Assert.That(model.Value, Is.EqualTo(1767680455));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1263339959));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1613328142));
                Assert.That(model.Value, Is.EqualTo(1623074317));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(519541461));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1652048155));
                Assert.That(model.Value, Is.EqualTo(1117618902));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1492825485));

                Assert.That(model.ModelInner.Value, Is.EqualTo(476515763));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1657963789));
                Assert.That(model.Value, Is.EqualTo(850239673));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1056156475));

                Assert.That(model.ModelInner.Value, Is.EqualTo(2065060019));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1782213419));
                Assert.That(model.Value, Is.EqualTo(128186402));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1152041431));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1052359036));

                Assert.That(model.ModelInner.Value, Is.EqualTo(2010708022));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1927722123));
                Assert.That(model.Value, Is.EqualTo(811643804));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1948847728));
                Assert.That(model.Value, Is.EqualTo(2005939014));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(333137506));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1957715961));
                Assert.That(model.Value, Is.EqualTo(1439852000));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1970406666));
                Assert.That(model.Value, Is.EqualTo(1018209414));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1762229129));

                Assert.That(model.ModelInner.Value, Is.EqualTo(67639814));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(691217647));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1982848614));
                Assert.That(model.Value, Is.EqualTo(1271489996));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1992896861));
                Assert.That(model.Value, Is.EqualTo(413865579));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2031917069));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2035239286));
                Assert.That(model.Value, Is.EqualTo(1962082811));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(192725514));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(593935053));

                Assert.That(model.ModelInner.Value, Is.EqualTo(975591364));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(726603318));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2097707965));
                Assert.That(model.Value, Is.EqualTo(468950198));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2080032176));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2097742364));
                Assert.That(model.Value, Is.EqualTo(1619539449));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(772148004));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32SingleTypeint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32SingleTypeint)this).SetDbConnectionSelectModelParametrs(cmd, 381425317);
                var models =  ((IInt32SingleTypeint)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(25));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(450282542));
                Assert.That(model.Value, Is.EqualTo(1946427216));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(387436912));

                Assert.That(model.ModelInner.Value, Is.EqualTo(744819855));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(778982372));
                Assert.That(model.Value, Is.EqualTo(1536722186));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2082375491));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(862686080));
                Assert.That(model.Value, Is.EqualTo(627545552));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1965179125));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1587591378));

                Assert.That(model.ModelInner.Value, Is.EqualTo(774662410));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1070454301));
                Assert.That(model.Value, Is.EqualTo(988164950));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1894451883));

                Assert.That(model.ModelInner.Value, Is.EqualTo(835489407));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1084107413));
                Assert.That(model.Value, Is.EqualTo(516177153));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(4206956));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1154224892));
                Assert.That(model.Value, Is.EqualTo(1484850154));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1740058563));

                Assert.That(model.ModelInner.Value, Is.EqualTo(586083756));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1196733011));
                Assert.That(model.Value, Is.EqualTo(643103462));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(712728105));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(820326032));

                Assert.That(model.ModelInner.Value, Is.EqualTo(465804602));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(194135691));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1255500287));
                Assert.That(model.Value, Is.EqualTo(863598879));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5160093));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1429672403));
                Assert.That(model.Value, Is.EqualTo(1921686944));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(279334757));

                Assert.That(model.ModelInner.Value, Is.EqualTo(709383221));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1528972782));
                Assert.That(model.Value, Is.EqualTo(18306667));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1309235683));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1537519019));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1475453706));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1580982536));
                Assert.That(model.Value, Is.EqualTo(1616377517));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(958403169));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(519545898));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1656856433));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1894598940));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1588978310));
                Assert.That(model.Value, Is.EqualTo(1767680455));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1263339959));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1613328142));
                Assert.That(model.Value, Is.EqualTo(1623074317));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(519541461));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1652048155));
                Assert.That(model.Value, Is.EqualTo(1117618902));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1492825485));

                Assert.That(model.ModelInner.Value, Is.EqualTo(476515763));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1657963789));
                Assert.That(model.Value, Is.EqualTo(850239673));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1056156475));

                Assert.That(model.ModelInner.Value, Is.EqualTo(2065060019));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1782213419));
                Assert.That(model.Value, Is.EqualTo(128186402));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1152041431));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1052359036));

                Assert.That(model.ModelInner.Value, Is.EqualTo(2010708022));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1927722123));
                Assert.That(model.Value, Is.EqualTo(811643804));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1948847728));
                Assert.That(model.Value, Is.EqualTo(2005939014));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(333137506));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1957715961));
                Assert.That(model.Value, Is.EqualTo(1439852000));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1970406666));
                Assert.That(model.Value, Is.EqualTo(1018209414));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1762229129));

                Assert.That(model.ModelInner.Value, Is.EqualTo(67639814));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(691217647));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1982848614));
                Assert.That(model.Value, Is.EqualTo(1271489996));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1992896861));
                Assert.That(model.Value, Is.EqualTo(413865579));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2031917069));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2035239286));
                Assert.That(model.Value, Is.EqualTo(1962082811));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(192725514));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(593935053));

                Assert.That(model.ModelInner.Value, Is.EqualTo(975591364));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(726603318));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2097707965));
                Assert.That(model.Value, Is.EqualTo(468950198));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2080032176));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2097742364));
                Assert.That(model.Value, Is.EqualTo(1619539449));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(772148004));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IInt32SingleTypeint)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt32SingleTypeint)this).SetDbConnectionSelectModelParametrs(cmd, 1970406666);
                var models = await ((IInt32SingleTypeint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(5));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1982848614));
                Assert.That(model.Value, Is.EqualTo(1271489996));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1992896861));
                Assert.That(model.Value, Is.EqualTo(413865579));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2031917069));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2035239286));
                Assert.That(model.Value, Is.EqualTo(1962082811));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(192725514));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(593935053));

                Assert.That(model.ModelInner.Value, Is.EqualTo(975591364));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(726603318));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2097707965));
                Assert.That(model.Value, Is.EqualTo(468950198));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2080032176));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2097742364));
                Assert.That(model.Value, Is.EqualTo(1619539449));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(772148004));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)
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
                 foreach(var batchResult in ((IInt32SingleTypeint)this).DbConnectionSelectModelBatch(connection, 1613328142, 1154224892))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(12));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1652048155));
                Assert.That(model.Value, Is.EqualTo(1117618902));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1492825485));

                Assert.That(model.ModelInner.Value, Is.EqualTo(476515763));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1657963789));
                Assert.That(model.Value, Is.EqualTo(850239673));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1056156475));

                Assert.That(model.ModelInner.Value, Is.EqualTo(2065060019));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1782213419));
                Assert.That(model.Value, Is.EqualTo(128186402));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1152041431));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1052359036));

                Assert.That(model.ModelInner.Value, Is.EqualTo(2010708022));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1927722123));
                Assert.That(model.Value, Is.EqualTo(811643804));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1948847728));
                Assert.That(model.Value, Is.EqualTo(2005939014));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(333137506));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1957715961));
                Assert.That(model.Value, Is.EqualTo(1439852000));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1970406666));
                Assert.That(model.Value, Is.EqualTo(1018209414));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1762229129));

                Assert.That(model.ModelInner.Value, Is.EqualTo(67639814));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(691217647));

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1982848614));
                Assert.That(model.Value, Is.EqualTo(1271489996));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1992896861));
                Assert.That(model.Value, Is.EqualTo(413865579));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2031917069));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2035239286));
                Assert.That(model.Value, Is.EqualTo(1962082811));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(192725514));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(593935053));

                Assert.That(model.ModelInner.Value, Is.EqualTo(975591364));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(726603318));

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2097707965));
                Assert.That(model.Value, Is.EqualTo(468950198));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2080032176));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2097742364));
                Assert.That(model.Value, Is.EqualTo(1619539449));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(772148004));

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(19));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1196733011));
                Assert.That(model.Value, Is.EqualTo(643103462));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(712728105));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(820326032));

                Assert.That(model.ModelInner.Value, Is.EqualTo(465804602));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(194135691));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1255500287));
                Assert.That(model.Value, Is.EqualTo(863598879));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5160093));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1429672403));
                Assert.That(model.Value, Is.EqualTo(1921686944));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(279334757));

                Assert.That(model.ModelInner.Value, Is.EqualTo(709383221));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1528972782));
                Assert.That(model.Value, Is.EqualTo(18306667));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1309235683));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1537519019));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1475453706));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1580982536));
                Assert.That(model.Value, Is.EqualTo(1616377517));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(958403169));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(519545898));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1656856433));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1894598940));

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1588978310));
                Assert.That(model.Value, Is.EqualTo(1767680455));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1263339959));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1613328142));
                Assert.That(model.Value, Is.EqualTo(1623074317));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(519541461));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1652048155));
                Assert.That(model.Value, Is.EqualTo(1117618902));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1492825485));

                Assert.That(model.ModelInner.Value, Is.EqualTo(476515763));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1657963789));
                Assert.That(model.Value, Is.EqualTo(850239673));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1056156475));

                Assert.That(model.ModelInner.Value, Is.EqualTo(2065060019));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1782213419));
                Assert.That(model.Value, Is.EqualTo(128186402));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1152041431));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1052359036));

                Assert.That(model.ModelInner.Value, Is.EqualTo(2010708022));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1927722123));
                Assert.That(model.Value, Is.EqualTo(811643804));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1948847728));
                Assert.That(model.Value, Is.EqualTo(2005939014));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(333137506));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1957715961));
                Assert.That(model.Value, Is.EqualTo(1439852000));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1970406666));
                Assert.That(model.Value, Is.EqualTo(1018209414));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1762229129));

                Assert.That(model.ModelInner.Value, Is.EqualTo(67639814));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(691217647));

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1982848614));
                Assert.That(model.Value, Is.EqualTo(1271489996));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1992896861));
                Assert.That(model.Value, Is.EqualTo(413865579));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2031917069));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2035239286));
                Assert.That(model.Value, Is.EqualTo(1962082811));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(192725514));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(593935053));

                Assert.That(model.ModelInner.Value, Is.EqualTo(975591364));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(726603318));

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2097707965));
                Assert.That(model.Value, Is.EqualTo(468950198));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2080032176));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2097742364));
                Assert.That(model.Value, Is.EqualTo(1619539449));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(772148004));

                Assert.That(model.ModelInner, Is.Null);

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
                await foreach(var batchResult in ((IInt32SingleTypeint)this).DbConnectionSelectModelBatchAsync(connection, 1084107413, 1782213419))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(20));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1154224892));
                Assert.That(model.Value, Is.EqualTo(1484850154));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1740058563));

                Assert.That(model.ModelInner.Value, Is.EqualTo(586083756));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1196733011));
                Assert.That(model.Value, Is.EqualTo(643103462));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(712728105));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(820326032));

                Assert.That(model.ModelInner.Value, Is.EqualTo(465804602));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(194135691));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1255500287));
                Assert.That(model.Value, Is.EqualTo(863598879));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(5160093));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1429672403));
                Assert.That(model.Value, Is.EqualTo(1921686944));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(279334757));

                Assert.That(model.ModelInner.Value, Is.EqualTo(709383221));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1528972782));
                Assert.That(model.Value, Is.EqualTo(18306667));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1309235683));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1537519019));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1475453706));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1580982536));
                Assert.That(model.Value, Is.EqualTo(1616377517));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(958403169));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(519545898));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1656856433));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1894598940));

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1588978310));
                Assert.That(model.Value, Is.EqualTo(1767680455));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1263339959));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1613328142));
                Assert.That(model.Value, Is.EqualTo(1623074317));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(519541461));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1652048155));
                Assert.That(model.Value, Is.EqualTo(1117618902));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1492825485));

                Assert.That(model.ModelInner.Value, Is.EqualTo(476515763));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1657963789));
                Assert.That(model.Value, Is.EqualTo(850239673));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1056156475));

                Assert.That(model.ModelInner.Value, Is.EqualTo(2065060019));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1782213419));
                Assert.That(model.Value, Is.EqualTo(128186402));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1152041431));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1052359036));

                Assert.That(model.ModelInner.Value, Is.EqualTo(2010708022));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1927722123));
                Assert.That(model.Value, Is.EqualTo(811643804));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1948847728));
                Assert.That(model.Value, Is.EqualTo(2005939014));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(333137506));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1957715961));
                Assert.That(model.Value, Is.EqualTo(1439852000));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1970406666));
                Assert.That(model.Value, Is.EqualTo(1018209414));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1762229129));

                Assert.That(model.ModelInner.Value, Is.EqualTo(67639814));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(691217647));

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1982848614));
                Assert.That(model.Value, Is.EqualTo(1271489996));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1992896861));
                Assert.That(model.Value, Is.EqualTo(413865579));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2031917069));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2035239286));
                Assert.That(model.Value, Is.EqualTo(1962082811));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(192725514));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(593935053));

                Assert.That(model.ModelInner.Value, Is.EqualTo(975591364));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(726603318));

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2097707965));
                Assert.That(model.Value, Is.EqualTo(468950198));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2080032176));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2097742364));
                Assert.That(model.Value, Is.EqualTo(1619539449));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(772148004));

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(9));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1927722123));
                Assert.That(model.Value, Is.EqualTo(811643804));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1948847728));
                Assert.That(model.Value, Is.EqualTo(2005939014));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(333137506));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1957715961));
                Assert.That(model.Value, Is.EqualTo(1439852000));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1970406666));
                Assert.That(model.Value, Is.EqualTo(1018209414));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1762229129));

                Assert.That(model.ModelInner.Value, Is.EqualTo(67639814));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(691217647));

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1982848614));
                Assert.That(model.Value, Is.EqualTo(1271489996));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1992896861));
                Assert.That(model.Value, Is.EqualTo(413865579));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2031917069));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2035239286));
                Assert.That(model.Value, Is.EqualTo(1962082811));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(192725514));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(593935053));

                Assert.That(model.ModelInner.Value, Is.EqualTo(975591364));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(726603318));

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2097707965));
                Assert.That(model.Value, Is.EqualTo(468950198));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2080032176));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2097742364));
                Assert.That(model.Value, Is.EqualTo(1619539449));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(772148004));

                Assert.That(model.ModelInner, Is.Null);

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
FROM gedaqtests.int32int0m m
LEFT JOIN gedaqtests.int32int0mi mi ON mi.id = m.int32int0mi_id
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
            asPartInterface: typeof(IInt32SingleTypeint)
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
                var models =  ((IInt32SingleTypeint)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57537566)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1121506148)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1606689878)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((74439911)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((492516260)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70257282)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1659443785)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((185448934)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((405694002)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((338758550)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((913989440)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((381425317)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2055958548)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((163955125)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1089250931)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((2077522905)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1130666863)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((450282542)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1946427216)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((387436912)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((744819855)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((778982372)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1536722186)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2082375491)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((862686080)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((627545552)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1587591378)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((774662410)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1965179125)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1070454301)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((988164950)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1894451883)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((835489407)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1084107413)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((516177153)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((4206956)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1154224892)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1484850154)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1740058563)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((586083756)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1196733011)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((643103462)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((820326032)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((465804602)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((194135691)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((712728105)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1255500287)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((863598879)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((5160093)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1429672403)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1921686944)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((279334757)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((709383221)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1528972782)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((18306667)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1537519019)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1475453706)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1309235683)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1580982536)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1616377517)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((519545898)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1656856433)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1894598940)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((958403169)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1588978310)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1767680455)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1263339959)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1613328142)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1623074317)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((519541461)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1652048155)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1117618902)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1492825485)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((476515763)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1657963789)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((850239673)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1056156475)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2065060019)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1782213419)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((128186402)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1052359036)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2010708022)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1152041431)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1927722123)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((811643804)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1948847728)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2005939014)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((333137506)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1957715961)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1439852000)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1970406666)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1018209414)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1762229129)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((67639814)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((691217647)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1982848614)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1271489996)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1992896861)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((413865579)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2031917069)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2035239286)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1962082811)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((593935053)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((975591364)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((726603318)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((192725514)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2097707965)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((468950198)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2080032176)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2097742364)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1619539449)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((772148004)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt32SingleTypeint)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57537566)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1121506148)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1606689878)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((74439911)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((492516260)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70257282)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1659443785)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((185448934)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((405694002)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((338758550)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((913989440)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((381425317)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2055958548)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((163955125)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1089250931)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((2077522905)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1130666863)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((450282542)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1946427216)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((387436912)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((744819855)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((778982372)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1536722186)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2082375491)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((862686080)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((627545552)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1587591378)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((774662410)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1965179125)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1070454301)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((988164950)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1894451883)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((835489407)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1084107413)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((516177153)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((4206956)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1154224892)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1484850154)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1740058563)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((586083756)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1196733011)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((643103462)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((820326032)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((465804602)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((194135691)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((712728105)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1255500287)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((863598879)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((5160093)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1429672403)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1921686944)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((279334757)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((709383221)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1528972782)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((18306667)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1537519019)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1475453706)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1309235683)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1580982536)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1616377517)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((519545898)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1656856433)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1894598940)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((958403169)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1588978310)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1767680455)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1263339959)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1613328142)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1623074317)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((519541461)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1652048155)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1117618902)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1492825485)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((476515763)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1657963789)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((850239673)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1056156475)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2065060019)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1782213419)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((128186402)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1052359036)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2010708022)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1152041431)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1927722123)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((811643804)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1948847728)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2005939014)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((333137506)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1957715961)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1439852000)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1970406666)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1018209414)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1762229129)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((67639814)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((691217647)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1982848614)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1271489996)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1992896861)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((413865579)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2031917069)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2035239286)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1962082811)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((593935053)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((975591364)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((726603318)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((192725514)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2097707965)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((468950198)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2080032176)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2097742364)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1619539449)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((772148004)));

            }
        }

        #endregion

    }
}

