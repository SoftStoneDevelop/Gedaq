

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
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)
            ), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                sqlDbType: (System.Data.SqlDbType)(8)
                ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Double),
                parametrName: "value",
                methodParametrName: "value",
                sqlDbType: (System.Data.SqlDbType)(6)
                ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                sqlDbType: (System.Data.SqlDbType)(6)
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

                changedRows =  ((IDoubleSingleTypefloat)this).InsertModelInner(connection, 1724414469, 0.08620292550592146d, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleSingleTypefloat)this).InsertModelInner(connection, 1500503511, 0.1664477985101167d, null);
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

                changedRows = await ((IDoubleSingleTypefloat)this).InsertModelInnerAsync(connection, 264307735, 0.37526914988834437d, 0.565556569955871d);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).InsertModelInnerAsync(connection, 1032440072, 0.9526668900518162d, null);
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
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)11
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Double), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)8
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)8, 
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

                changedRows =  ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModel(connection, 996142883, 0.8829560159107395d, 0.5151521405665934d);
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

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, 1842091306, 0.9519741801683319d, 0.8933906617111562d);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, 746988435, 0.5204718092114882d, 0.42460126918983676d);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, 23129470, 0.11494436014911802d, 0.3677008921093845d);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, 1220008836, 0.8765445610942524d, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, 693616831, 0.5725860771796515d, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, 953069133, 0.47063270003354485d, 0.2480099014412236d);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, 836430761, 0.19851524519273345d, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, 1709851153, 0.16831138165412263d, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, 362056279, 0.9825683760860673d, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertInnerModelAsync(connection, 297336043, 0.16235055714525104d, null);
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
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)
            ), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id",
                sqlDbType: (System.Data.SqlDbType)(8)
            ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Double), 
                parametrName: "value", 
                methodParametrName: "value", 
                sqlDbType: (System.Data.SqlDbType)(6)
            ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                sqlDbType: (System.Data.SqlDbType)(6),
                nullable: true
            ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "doublefloat0mi_id", 
                methodParametrName: "doublefloat0mi_id", 
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

                changedRows =  ((IDoubleSingleTypefloat)this).InsertModel(connection, 1440321374, 0.7026694155237307d, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleSingleTypefloat)this).InsertModel(connection, 146697333, 0.7299368951081839d, 0.3221085434587596d, 1724414469);
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

                changedRows = await ((IDoubleSingleTypefloat)this).InsertModelAsync(connection, 134843365, 0.4581159405382814d, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).InsertModelAsync(connection, 1391625637, 0.07660834570844788d, null, 1500503511);
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
            queryMapType: null,
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
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "doublefloat0mi_id", 
                methodParametrName: "doublefloat0mi_id", 
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

                changedRows =  ((IDoubleSingleTypefloat)this).DbConnectionInsertModel(connection, 1323449323, 0.9594903963395698d, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleSingleTypefloat)this).DbConnectionInsertModel(connection, 1907600198, 0.5218268260885728d, null, 264307735);
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

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 1524106376, 0.6770907051152949d, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 1186124350, 0.8111864878467939d, null, 1032440072);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 1045044835, 0.13303298090310633d, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 2135691691, 0.46737541242412495d, 0.42811874386080695d, 996142883);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 1076299992, 0.2351462307564679d, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 1763001104, 0.3439357659289185d, 0.2793863618278283d, 1842091306);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 1814474735, 0.7007700083804963d, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 1357158391, 0.8850258349084217d, 0.2565714292430957d, 746988435);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 1783193114, 0.43520410321492964d, 0.9815980319348899d, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 1013123441, 0.7184794879155846d, null, 23129470);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 317013874, 0.24053660023988999d, 0.3601737061617687d, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 2097775410, 0.5171832389682101d, null, 1220008836);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 1649297179, 0.29232566047041153d, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 286511207, 0.9113787123281261d, 0.7443920716514391d, 693616831);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 1023814221, 0.1380138556747229d, 0.03916640474642796d, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 932955551, 0.6118714910519649d, 0.23302948674122137d, 953069133);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 875846602, 0.36319431392641965d, 0.1556487346631812d, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 594523193, 0.4469526036525824d, null, 836430761);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 2108338010, 0.4547428567266538d, 0.024108551570875658d, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 1207116517, 0.08869017466151197d, 0.15630114414784735d, 1709851153);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 2095860407, 0.7229261632854652d, 0.5602087756656768d, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 1923866108, 0.5894459016482458d, null, 362056279);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 1007058762, 0.45778655213531705d, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypefloat)this).DbConnectionInsertModelAsync(connection, 321629014, 0.6270640472241508d, 0.36886513555107125d, 297336043);
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
FROM dbo.doublefloat0m m
LEFT JOIN dbo.doublefloat0mi mi ON mi.id = m.doublefloat0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(Doublefloat0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)
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
                var models =  ((IDoubleSingleTypefloat)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(134843365));
                Assert.That(model.Value, Is.EqualTo(0.4581159405382814d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(146697333));
                Assert.That(model.Value, Is.EqualTo(0.7299368951081839d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.3221085434587596d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1724414469));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.08620292550592146d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(286511207));
                Assert.That(model.Value, Is.EqualTo(0.9113787123281261d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.7443920716514391d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(693616831));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.5725860771796515d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(317013874));
                Assert.That(model.Value, Is.EqualTo(0.24053660023988999d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.3601737061617687d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(321629014));
                Assert.That(model.Value, Is.EqualTo(0.6270640472241508d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.36886513555107125d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(297336043));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.16235055714525104d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(594523193));
                Assert.That(model.Value, Is.EqualTo(0.4469526036525824d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(836430761));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.19851524519273345d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(875846602));
                Assert.That(model.Value, Is.EqualTo(0.36319431392641965d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.1556487346631812d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(932955551));
                Assert.That(model.Value, Is.EqualTo(0.6118714910519649d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.23302948674122137d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(953069133));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.47063270003354485d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.2480099014412236d));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1007058762));
                Assert.That(model.Value, Is.EqualTo(0.45778655213531705d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1013123441));
                Assert.That(model.Value, Is.EqualTo(0.7184794879155846d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(23129470));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.11494436014911802d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.3677008921093845d));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1023814221));
                Assert.That(model.Value, Is.EqualTo(0.1380138556747229d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.03916640474642796d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045044835));
                Assert.That(model.Value, Is.EqualTo(0.13303298090310633d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1076299992));
                Assert.That(model.Value, Is.EqualTo(0.2351462307564679d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1186124350));
                Assert.That(model.Value, Is.EqualTo(0.8111864878467939d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1032440072));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9526668900518162d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1207116517));
                Assert.That(model.Value, Is.EqualTo(0.08869017466151197d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.15630114414784735d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1709851153));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.16831138165412263d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1323449323));
                Assert.That(model.Value, Is.EqualTo(0.9594903963395698d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1357158391));
                Assert.That(model.Value, Is.EqualTo(0.8850258349084217d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.2565714292430957d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(746988435));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.5204718092114882d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.42460126918983676d));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1391625637));
                Assert.That(model.Value, Is.EqualTo(0.07660834570844788d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1500503511));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.1664477985101167d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1440321374));
                Assert.That(model.Value, Is.EqualTo(0.7026694155237307d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1524106376));
                Assert.That(model.Value, Is.EqualTo(0.6770907051152949d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1649297179));
                Assert.That(model.Value, Is.EqualTo(0.29232566047041153d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1763001104));
                Assert.That(model.Value, Is.EqualTo(0.3439357659289185d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.2793863618278283d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1842091306));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9519741801683319d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.8933906617111562d));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1783193114));
                Assert.That(model.Value, Is.EqualTo(0.43520410321492964d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.9815980319348899d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1814474735));
                Assert.That(model.Value, Is.EqualTo(0.7007700083804963d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1907600198));
                Assert.That(model.Value, Is.EqualTo(0.5218268260885728d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(264307735));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.37526914988834437d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.565556569955871d));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1923866108));
                Assert.That(model.Value, Is.EqualTo(0.5894459016482458d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(362056279));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9825683760860673d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2095860407));
                Assert.That(model.Value, Is.EqualTo(0.7229261632854652d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5602087756656768d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2097775410));
                Assert.That(model.Value, Is.EqualTo(0.5171832389682101d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1220008836));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8765445610942524d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2108338010));
                Assert.That(model.Value, Is.EqualTo(0.4547428567266538d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.024108551570875658d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2135691691));
                Assert.That(model.Value, Is.EqualTo(0.46737541242412495d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.42811874386080695d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(996142883));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8829560159107395d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.5151521405665934d));

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleSingleTypefloat)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(134843365));
                Assert.That(model.Value, Is.EqualTo(0.4581159405382814d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(146697333));
                Assert.That(model.Value, Is.EqualTo(0.7299368951081839d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.3221085434587596d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1724414469));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.08620292550592146d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(286511207));
                Assert.That(model.Value, Is.EqualTo(0.9113787123281261d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.7443920716514391d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(693616831));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.5725860771796515d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(317013874));
                Assert.That(model.Value, Is.EqualTo(0.24053660023988999d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.3601737061617687d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(321629014));
                Assert.That(model.Value, Is.EqualTo(0.6270640472241508d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.36886513555107125d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(297336043));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.16235055714525104d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(594523193));
                Assert.That(model.Value, Is.EqualTo(0.4469526036525824d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(836430761));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.19851524519273345d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(875846602));
                Assert.That(model.Value, Is.EqualTo(0.36319431392641965d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.1556487346631812d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(932955551));
                Assert.That(model.Value, Is.EqualTo(0.6118714910519649d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.23302948674122137d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(953069133));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.47063270003354485d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.2480099014412236d));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1007058762));
                Assert.That(model.Value, Is.EqualTo(0.45778655213531705d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1013123441));
                Assert.That(model.Value, Is.EqualTo(0.7184794879155846d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(23129470));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.11494436014911802d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.3677008921093845d));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1023814221));
                Assert.That(model.Value, Is.EqualTo(0.1380138556747229d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.03916640474642796d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045044835));
                Assert.That(model.Value, Is.EqualTo(0.13303298090310633d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1076299992));
                Assert.That(model.Value, Is.EqualTo(0.2351462307564679d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1186124350));
                Assert.That(model.Value, Is.EqualTo(0.8111864878467939d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1032440072));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9526668900518162d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1207116517));
                Assert.That(model.Value, Is.EqualTo(0.08869017466151197d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.15630114414784735d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1709851153));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.16831138165412263d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1323449323));
                Assert.That(model.Value, Is.EqualTo(0.9594903963395698d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1357158391));
                Assert.That(model.Value, Is.EqualTo(0.8850258349084217d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.2565714292430957d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(746988435));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.5204718092114882d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.42460126918983676d));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1391625637));
                Assert.That(model.Value, Is.EqualTo(0.07660834570844788d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1500503511));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.1664477985101167d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1440321374));
                Assert.That(model.Value, Is.EqualTo(0.7026694155237307d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1524106376));
                Assert.That(model.Value, Is.EqualTo(0.6770907051152949d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1649297179));
                Assert.That(model.Value, Is.EqualTo(0.29232566047041153d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1763001104));
                Assert.That(model.Value, Is.EqualTo(0.3439357659289185d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.2793863618278283d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1842091306));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9519741801683319d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.8933906617111562d));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1783193114));
                Assert.That(model.Value, Is.EqualTo(0.43520410321492964d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.9815980319348899d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1814474735));
                Assert.That(model.Value, Is.EqualTo(0.7007700083804963d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1907600198));
                Assert.That(model.Value, Is.EqualTo(0.5218268260885728d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(264307735));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.37526914988834437d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.565556569955871d));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1923866108));
                Assert.That(model.Value, Is.EqualTo(0.5894459016482458d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(362056279));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9825683760860673d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2095860407));
                Assert.That(model.Value, Is.EqualTo(0.7229261632854652d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5602087756656768d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2097775410));
                Assert.That(model.Value, Is.EqualTo(0.5171832389682101d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1220008836));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8765445610942524d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2108338010));
                Assert.That(model.Value, Is.EqualTo(0.4547428567266538d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.024108551570875658d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2135691691));
                Assert.That(model.Value, Is.EqualTo(0.46737541242412495d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.42811874386080695d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(996142883));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8829560159107395d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.5151521405665934d));

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
            queryMapType: typeof(Doublefloat0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)
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
                var models =  ((IDoubleSingleTypefloat)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(134843365));
                Assert.That(model.Value, Is.EqualTo(0.4581159405382814d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(146697333));
                Assert.That(model.Value, Is.EqualTo(0.7299368951081839d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.3221085434587596d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1724414469));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.08620292550592146d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(286511207));
                Assert.That(model.Value, Is.EqualTo(0.9113787123281261d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.7443920716514391d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(693616831));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.5725860771796515d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(317013874));
                Assert.That(model.Value, Is.EqualTo(0.24053660023988999d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.3601737061617687d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(321629014));
                Assert.That(model.Value, Is.EqualTo(0.6270640472241508d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.36886513555107125d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(297336043));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.16235055714525104d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(594523193));
                Assert.That(model.Value, Is.EqualTo(0.4469526036525824d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(836430761));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.19851524519273345d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(875846602));
                Assert.That(model.Value, Is.EqualTo(0.36319431392641965d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.1556487346631812d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(932955551));
                Assert.That(model.Value, Is.EqualTo(0.6118714910519649d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.23302948674122137d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(953069133));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.47063270003354485d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.2480099014412236d));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1007058762));
                Assert.That(model.Value, Is.EqualTo(0.45778655213531705d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1013123441));
                Assert.That(model.Value, Is.EqualTo(0.7184794879155846d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(23129470));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.11494436014911802d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.3677008921093845d));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1023814221));
                Assert.That(model.Value, Is.EqualTo(0.1380138556747229d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.03916640474642796d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045044835));
                Assert.That(model.Value, Is.EqualTo(0.13303298090310633d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1076299992));
                Assert.That(model.Value, Is.EqualTo(0.2351462307564679d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1186124350));
                Assert.That(model.Value, Is.EqualTo(0.8111864878467939d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1032440072));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9526668900518162d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1207116517));
                Assert.That(model.Value, Is.EqualTo(0.08869017466151197d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.15630114414784735d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1709851153));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.16831138165412263d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1323449323));
                Assert.That(model.Value, Is.EqualTo(0.9594903963395698d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1357158391));
                Assert.That(model.Value, Is.EqualTo(0.8850258349084217d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.2565714292430957d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(746988435));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.5204718092114882d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.42460126918983676d));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1391625637));
                Assert.That(model.Value, Is.EqualTo(0.07660834570844788d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1500503511));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.1664477985101167d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1440321374));
                Assert.That(model.Value, Is.EqualTo(0.7026694155237307d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1524106376));
                Assert.That(model.Value, Is.EqualTo(0.6770907051152949d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1649297179));
                Assert.That(model.Value, Is.EqualTo(0.29232566047041153d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1763001104));
                Assert.That(model.Value, Is.EqualTo(0.3439357659289185d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.2793863618278283d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1842091306));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9519741801683319d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.8933906617111562d));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1783193114));
                Assert.That(model.Value, Is.EqualTo(0.43520410321492964d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.9815980319348899d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1814474735));
                Assert.That(model.Value, Is.EqualTo(0.7007700083804963d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1907600198));
                Assert.That(model.Value, Is.EqualTo(0.5218268260885728d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(264307735));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.37526914988834437d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.565556569955871d));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1923866108));
                Assert.That(model.Value, Is.EqualTo(0.5894459016482458d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(362056279));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9825683760860673d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2095860407));
                Assert.That(model.Value, Is.EqualTo(0.7229261632854652d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5602087756656768d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2097775410));
                Assert.That(model.Value, Is.EqualTo(0.5171832389682101d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1220008836));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8765445610942524d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2108338010));
                Assert.That(model.Value, Is.EqualTo(0.4547428567266538d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.024108551570875658d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2135691691));
                Assert.That(model.Value, Is.EqualTo(0.46737541242412495d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.42811874386080695d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(996142883));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8829560159107395d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.5151521405665934d));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleSingleTypefloat)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(134843365));
                Assert.That(model.Value, Is.EqualTo(0.4581159405382814d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(146697333));
                Assert.That(model.Value, Is.EqualTo(0.7299368951081839d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.3221085434587596d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1724414469));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.08620292550592146d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(286511207));
                Assert.That(model.Value, Is.EqualTo(0.9113787123281261d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.7443920716514391d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(693616831));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.5725860771796515d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(317013874));
                Assert.That(model.Value, Is.EqualTo(0.24053660023988999d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.3601737061617687d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(321629014));
                Assert.That(model.Value, Is.EqualTo(0.6270640472241508d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.36886513555107125d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(297336043));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.16235055714525104d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(594523193));
                Assert.That(model.Value, Is.EqualTo(0.4469526036525824d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(836430761));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.19851524519273345d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(875846602));
                Assert.That(model.Value, Is.EqualTo(0.36319431392641965d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.1556487346631812d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(932955551));
                Assert.That(model.Value, Is.EqualTo(0.6118714910519649d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.23302948674122137d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(953069133));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.47063270003354485d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.2480099014412236d));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1007058762));
                Assert.That(model.Value, Is.EqualTo(0.45778655213531705d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1013123441));
                Assert.That(model.Value, Is.EqualTo(0.7184794879155846d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(23129470));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.11494436014911802d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.3677008921093845d));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1023814221));
                Assert.That(model.Value, Is.EqualTo(0.1380138556747229d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.03916640474642796d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045044835));
                Assert.That(model.Value, Is.EqualTo(0.13303298090310633d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1076299992));
                Assert.That(model.Value, Is.EqualTo(0.2351462307564679d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1186124350));
                Assert.That(model.Value, Is.EqualTo(0.8111864878467939d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1032440072));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9526668900518162d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1207116517));
                Assert.That(model.Value, Is.EqualTo(0.08869017466151197d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.15630114414784735d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1709851153));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.16831138165412263d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1323449323));
                Assert.That(model.Value, Is.EqualTo(0.9594903963395698d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1357158391));
                Assert.That(model.Value, Is.EqualTo(0.8850258349084217d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.2565714292430957d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(746988435));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.5204718092114882d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.42460126918983676d));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1391625637));
                Assert.That(model.Value, Is.EqualTo(0.07660834570844788d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1500503511));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.1664477985101167d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1440321374));
                Assert.That(model.Value, Is.EqualTo(0.7026694155237307d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1524106376));
                Assert.That(model.Value, Is.EqualTo(0.6770907051152949d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1649297179));
                Assert.That(model.Value, Is.EqualTo(0.29232566047041153d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1763001104));
                Assert.That(model.Value, Is.EqualTo(0.3439357659289185d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.2793863618278283d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1842091306));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9519741801683319d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.8933906617111562d));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1783193114));
                Assert.That(model.Value, Is.EqualTo(0.43520410321492964d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.9815980319348899d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1814474735));
                Assert.That(model.Value, Is.EqualTo(0.7007700083804963d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1907600198));
                Assert.That(model.Value, Is.EqualTo(0.5218268260885728d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(264307735));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.37526914988834437d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.565556569955871d));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1923866108));
                Assert.That(model.Value, Is.EqualTo(0.5894459016482458d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(362056279));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9825683760860673d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2095860407));
                Assert.That(model.Value, Is.EqualTo(0.7229261632854652d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5602087756656768d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2097775410));
                Assert.That(model.Value, Is.EqualTo(0.5171832389682101d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1220008836));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8765445610942524d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2108338010));
                Assert.That(model.Value, Is.EqualTo(0.4547428567266538d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.024108551570875658d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2135691691));
                Assert.That(model.Value, Is.EqualTo(0.46737541242412495d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.42811874386080695d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(996142883));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8829560159107395d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.5151521405665934d));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleSingleTypefloat)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleSingleTypefloat)this).SetDbConnectionSelectModelParametrs(cmd, 1357158391);
                var models =  ((IDoubleSingleTypefloat)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(13));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1391625637));
                Assert.That(model.Value, Is.EqualTo(0.07660834570844788d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1500503511));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.1664477985101167d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1440321374));
                Assert.That(model.Value, Is.EqualTo(0.7026694155237307d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1524106376));
                Assert.That(model.Value, Is.EqualTo(0.6770907051152949d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1649297179));
                Assert.That(model.Value, Is.EqualTo(0.29232566047041153d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1763001104));
                Assert.That(model.Value, Is.EqualTo(0.3439357659289185d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.2793863618278283d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1842091306));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9519741801683319d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.8933906617111562d));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1783193114));
                Assert.That(model.Value, Is.EqualTo(0.43520410321492964d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.9815980319348899d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1814474735));
                Assert.That(model.Value, Is.EqualTo(0.7007700083804963d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1907600198));
                Assert.That(model.Value, Is.EqualTo(0.5218268260885728d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(264307735));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.37526914988834437d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.565556569955871d));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1923866108));
                Assert.That(model.Value, Is.EqualTo(0.5894459016482458d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(362056279));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9825683760860673d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2095860407));
                Assert.That(model.Value, Is.EqualTo(0.7229261632854652d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5602087756656768d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2097775410));
                Assert.That(model.Value, Is.EqualTo(0.5171832389682101d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1220008836));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8765445610942524d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2108338010));
                Assert.That(model.Value, Is.EqualTo(0.4547428567266538d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.024108551570875658d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2135691691));
                Assert.That(model.Value, Is.EqualTo(0.46737541242412495d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.42811874386080695d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(996142883));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8829560159107395d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.5151521405665934d));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IDoubleSingleTypefloat)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleSingleTypefloat)this).SetDbConnectionSelectModelParametrs(cmd, 1524106376);
                var models = await ((IDoubleSingleTypefloat)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(10));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1649297179));
                Assert.That(model.Value, Is.EqualTo(0.29232566047041153d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1763001104));
                Assert.That(model.Value, Is.EqualTo(0.3439357659289185d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.2793863618278283d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1842091306));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9519741801683319d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.8933906617111562d));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1783193114));
                Assert.That(model.Value, Is.EqualTo(0.43520410321492964d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.9815980319348899d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1814474735));
                Assert.That(model.Value, Is.EqualTo(0.7007700083804963d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1907600198));
                Assert.That(model.Value, Is.EqualTo(0.5218268260885728d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(264307735));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.37526914988834437d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.565556569955871d));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1923866108));
                Assert.That(model.Value, Is.EqualTo(0.5894459016482458d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(362056279));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.9825683760860673d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2095860407));
                Assert.That(model.Value, Is.EqualTo(0.7229261632854652d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.5602087756656768d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2097775410));
                Assert.That(model.Value, Is.EqualTo(0.5171832389682101d));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1220008836));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8765445610942524d));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2108338010));
                Assert.That(model.Value, Is.EqualTo(0.4547428567266538d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.024108551570875658d));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2135691691));
                Assert.That(model.Value, Is.EqualTo(0.46737541242412495d));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.42811874386080695d));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(996142883));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.8829560159107395d));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.5151521405665934d));

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
            queryMapType: typeof(object[]),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypefloat)
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
                var models =  ((IDoubleSingleTypefloat)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134843365)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4581159405382814d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146697333)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7299368951081839d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1724414469)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.08620292550592146d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3221085434587596d)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((286511207)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9113787123281261d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((693616831)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5725860771796515d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7443920716514391d)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((317013874)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.24053660023988999d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3601737061617687d)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((321629014)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6270640472241508d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((297336043)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.16235055714525104d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.36886513555107125d)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((594523193)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4469526036525824d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((836430761)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.19851524519273345d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((875846602)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.36319431392641965d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.1556487346631812d)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((932955551)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6118714910519649d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((953069133)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.47063270003354485d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.2480099014412236d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.23302948674122137d)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1007058762)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.45778655213531705d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1013123441)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7184794879155846d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23129470)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.11494436014911802d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.3677008921093845d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1023814221)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.1380138556747229d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.03916640474642796d)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1045044835)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.13303298090310633d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1076299992)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2351462307564679d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1186124350)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8111864878467939d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1032440072)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9526668900518162d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1207116517)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.08869017466151197d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1709851153)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.16831138165412263d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.15630114414784735d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1323449323)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9594903963395698d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1357158391)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8850258349084217d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((746988435)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5204718092114882d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.42460126918983676d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.2565714292430957d)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1391625637)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.07660834570844788d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1500503511)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.1664477985101167d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1440321374)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7026694155237307d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1524106376)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6770907051152949d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1649297179)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.29232566047041153d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1763001104)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3439357659289185d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1842091306)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9519741801683319d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.8933906617111562d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.2793863618278283d)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1783193114)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.43520410321492964d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9815980319348899d)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1814474735)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7007700083804963d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1907600198)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5218268260885728d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((264307735)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.37526914988834437d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.565556569955871d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1923866108)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5894459016482458d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((362056279)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9825683760860673d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2095860407)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7229261632854652d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5602087756656768d)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2097775410)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5171832389682101d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1220008836)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8765445610942524d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2108338010)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4547428567266538d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.024108551570875658d)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2135691691)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.46737541242412495d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((996142883)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8829560159107395d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.5151521405665934d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.42811874386080695d)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleSingleTypefloat)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134843365)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4581159405382814d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146697333)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7299368951081839d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1724414469)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.08620292550592146d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3221085434587596d)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((286511207)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9113787123281261d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((693616831)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5725860771796515d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7443920716514391d)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((317013874)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.24053660023988999d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3601737061617687d)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((321629014)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6270640472241508d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((297336043)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.16235055714525104d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.36886513555107125d)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((594523193)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4469526036525824d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((836430761)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.19851524519273345d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((875846602)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.36319431392641965d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.1556487346631812d)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((932955551)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6118714910519649d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((953069133)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.47063270003354485d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.2480099014412236d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.23302948674122137d)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1007058762)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.45778655213531705d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1013123441)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7184794879155846d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23129470)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.11494436014911802d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.3677008921093845d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1023814221)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.1380138556747229d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.03916640474642796d)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1045044835)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.13303298090310633d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1076299992)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2351462307564679d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1186124350)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8111864878467939d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1032440072)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9526668900518162d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1207116517)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.08869017466151197d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1709851153)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.16831138165412263d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.15630114414784735d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1323449323)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9594903963395698d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1357158391)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8850258349084217d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((746988435)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5204718092114882d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.42460126918983676d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.2565714292430957d)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1391625637)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.07660834570844788d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1500503511)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.1664477985101167d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1440321374)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7026694155237307d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1524106376)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6770907051152949d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1649297179)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.29232566047041153d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1763001104)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3439357659289185d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1842091306)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9519741801683319d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.8933906617111562d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.2793863618278283d)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1783193114)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.43520410321492964d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9815980319348899d)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1814474735)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7007700083804963d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1907600198)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5218268260885728d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((264307735)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.37526914988834437d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.565556569955871d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1923866108)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5894459016482458d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((362056279)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9825683760860673d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2095860407)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7229261632854652d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5602087756656768d)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2097775410)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5171832389682101d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1220008836)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8765445610942524d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2108338010)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4547428567266538d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.024108551570875658d)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2135691691)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.46737541242412495d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((996142883)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8829560159107395d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.5151521405665934d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.42811874386080695d)));

            }
        }

        #endregion

    }
}

